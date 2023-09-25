﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace bracelets {

    class Bracelet {

        private const int STEP_Y = 33, STEP_X = 33, POLY = 6, POLY2 = 2 * POLY;

        private Pen blackPen;

        public int Width {get; private set;}
        public int Height {get; private set; }

        public List<Color> clrLst = new List<Color>();
        private List<Thread> threads = new List<Thread>();
        private List<Point> points = new List<Point>();
        private List<Knot[]> knots = new List<Knot[]>();
        private List<ColorHandle> clrHandles = new List<ColorHandle>();
        private Point[] poly = new Point[4];
        private readonly Point[] tmp = new Point[4];


        public bool searchKnot(Point pt) {
            foreach (Knot[] ks in knots) {
                foreach (Knot knot in ks) {
                    if (knot.Rect.Contains(pt)) {
                        knot.NextKnot();
                        return true;
                    }
                }
            }
            return false;
        }

        public Color addColor(Color c) {
            clrLst.Add(c);
            return c;
        }

        public void addThread() {
            //
        }

        public void create(Graphics gr, string knotsTxt, string colors) {

            createThreads(colors);
            createKnots(knotsTxt);
            createKnotsColors();
            createPoints();


            int s = 0, p = points.Count / threads.Count;
            Point[] pts = new Point[p];

            foreach (Thread t in threads) {
                points.CopyTo(s, pts, 0, p);
                t.Draw(gr, pts);
                s += p;
            }

            foreach (ColorHandle e in clrHandles) {
                e.draw(gr);
            }

            foreach (Knot[] knot in knots) {
                foreach (Knot k in knot) {
                    k.draw(gr);
                }
            }

            bool m;
            int x = 0, y = 10, row;
            int w = 10 + (STEP_X + STEP_X) * (knots[0].Length + 1),
                h = 1 + knots.Count / 2 * POLY2 + POLY,
                c = 1;

            while (c * h <= gr.VisibleClipBounds.Height - h) {
                c++;
            }

            for (int z = 0; z < c; z++) {
                row = 0;
                foreach (Knot[] ks in knots) {
                    m = row % 2 == 0;
                    x = w;
                    foreach (Knot knot in ks) {
                        drawLosangle(gr, m ? x : x + POLY, y, knot.threadClr);
                        x += POLY2;
                    }
                    row++;
                    y += POLY;
                }
            }

            Width = x + 42;
        }

        public Bracelet() {
            poly[0] = new Point(0, -POLY);
            poly[1] = new Point(POLY, 0);
            poly[2] = new Point(0, POLY);
            poly[3] = new Point(-POLY, 0);

            blackPen = new Pen(Color.Black, 1);
        }

        private void drawLosangle(Graphics gr, int x, int y, SolidBrush sb) {

            poly.CopyTo(tmp, 0);

            for (int z = 0; z < 4; z++) {
                tmp[z].X += x;
                tmp[z].Y += y;
            }

            gr.FillPolygon(sb, tmp);
            gr.DrawPolygon(blackPen, tmp);
        }

        public void createThreads(string colors) {
            threads.Clear();
            bool d = true;

            foreach (Char c in colors.ToLower()) {
                Color clr = clrLst[c - 97];
                Thread t = new Thread(clr, d ? Direction.LEFT : Direction.RIGHT);
                threads.Add(t);
                d = !d;
            }
        }

        public void createKnots(string knotsTxt) {
            knots.Clear();

            string[] k = knotsTxt.Replace("\r\n", "").Replace(" ", "").Split(',');
            int i = threads.Count / 2,
                z = threads.Count % 2 == 0 ? i - 1 : i,
                q = 0,
                r = 0,
                c;

            while (q < k.Length) {
                c = r % 2 == 0 ? i : z;
                Knot[] u = new Knot[c];

                for (int n = 0; n < c; n++) {
                    switch (k[q + n].ToLower()) {
                        case "f": u[n] = new Knot(KnotType.F); break;
                        case "fb": u[n] = new Knot(KnotType.FB); break;
                        case "bf": u[n] = new Knot(KnotType.BF); break;
                        case "b": u[n] = new Knot(KnotType.B); break;
                    }
                }

                knots.Add(u);

                q += c;
                r++;
            }

        }

        public int searchColorHandles(Point pt) {
            foreach (ColorHandle ch in clrHandles) {
                if (ch.Rect.Contains(pt)) {
                    return ch.Index;
                }
            }
            return -1;
        }

        public void setThreadColor(int idx, Color c) {
            threads[idx].Color = c;
        }

        public void createPoints() {
            points.Clear();
            clrHandles.Clear();

            int row, pX = 0, pY = 0, k_idx, startX = 24;
            Thread thread;
            Knot knot;
            bool lastRow;

            for (int i = 0; i < threads.Count; i++) {
                pX = startX;
                pY = 15;
                row = 0;

                startX += i % 2 == 0 ? 34 : 32;

                thread = threads[i];

                Point pt = new Point(pX, pY);
                points.Add(pt);
                clrHandles.Add(new ColorHandle(pt, thread.Color, i));

                pY += (int)(STEP_Y * .7);
                points.Add(new Point(pX, pY));


                pY += 1 + STEP_Y / 2;
                if (i % 2 == 0) {
                    pX += 1 + STEP_X / 2;
                } else {
                    pX -= 1 + STEP_X / 2;
                }

                points.Add(new Point(pX, pY));

                k_idx = i / 2;

                foreach (Knot[] k in knots) {

                    lastRow = row == knots.Count - 1;

                    pY += lastRow ? STEP_Y / 2 : STEP_Y;

                    if (k_idx < 0 || k_idx >= k.Length) {
                        if (k_idx < 0) {
                            pX += lastRow ? STEP_X / 2 : STEP_X;
                            thread.Dir = Direction.LEFT;
                            k_idx++;
                        } else {
                            pX -= lastRow ? STEP_X / 2 : STEP_X;
                            thread.Dir = Direction.RIGHT;
                            k_idx -= (threads.Count % 2 == 0 ? 0 : 1);
                        }
                    } else {
                        knot = k[k_idx];
                        knot.setPos(pX, lastRow ? pY - 16 : pY - 33);

                        if (thread.Dir == Direction.LEFT) {
                            if (knot.Type == KnotType.FB || knot.Type == KnotType.BF) {
                                pX -= lastRow ? STEP_X / 2 : STEP_X;
                                thread.Dir = Direction.RIGHT;
                                if (row % 2 == 0) k_idx--;
                            } else {
                                pX += lastRow ? STEP_X / 2 : STEP_X;
                                if (row % 2 != 0) k_idx++;
                            }

                        } else {
                            if (knot.Type == KnotType.FB || knot.Type == KnotType.BF) {
                                pX += lastRow ? STEP_X / 2 : STEP_X;
                                thread.Dir = Direction.LEFT;
                                if (row % 2 != 0) k_idx++;
                            } else {
                                pX -= lastRow ? STEP_X / 2 : STEP_X;
                                if (row % 2 == 0) k_idx--;
                            }
                        }
                    }

                    points.Add(new Point(pX, pY));
                    row++;
                }

                points.Add(new Point(pX, pY + 21));
            }

            Height = pY + 42;
        }

        public void createKnotsColors() {
            Color[] lst = new Color[threads.Count];
            int i = 0;
            foreach (Thread t in threads) lst[i++] = t.Color;

            int idx, row = 0;
            foreach (Knot[] ks in knots) {
                idx = row % 2 == 0 ? 0 : 1;
                foreach (Knot knot in ks) {
                    if (idx + 1 > threads.Count) continue;

                    switch (knot.Type) {
                        case KnotType.BF:
                            knot.setColor(lst[idx + 1]);
                            break;
                        case KnotType.FB:
                            knot.setColor(lst[idx]);
                            break;
                        case KnotType.F:
                            knot.setColor(lst[idx]);
                            (lst[idx], lst[idx + 1]) = (lst[idx + 1], lst[idx]);
                            break;
                        case KnotType.B:
                            (lst[idx], lst[idx + 1]) = (lst[idx + 1], lst[idx]);
                            knot.setColor(lst[idx]);
                            break;
                    }

                    idx += 2;
                }
                row++;
            }
        }
    }
}
