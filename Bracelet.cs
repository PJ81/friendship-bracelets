using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace bracelets {

    class Bracelet {

        private const int STEP_Y = 33, STEP_X = 33, POLY = 6, POLY2 = 2 * POLY;

        private Pen blackPen;
        private Pen grayPen;
        private SolidBrush gray;

        internal int Width { get; private set; }
        internal int Height { get; private set; }

        private List<Thread> threads = new List<Thread>();
        private List<Point> points = new List<Point>();
        private List<Knot[]> knots = new List<Knot[]>();
        private List<ColorHandle> clrHandles = new List<ColorHandle>();
        private Point[] poly = new Point[4];
        private readonly Point[] tmp = new Point[4];

        internal Bracelet() {
            poly[0] = new Point(0, -POLY);
            poly[1] = new Point(POLY, 0);
            poly[2] = new Point(0, POLY);
            poly[3] = new Point(-POLY, 0);

            blackPen = new Pen(Color.Black);
            grayPen = new Pen(Color.DarkGray);
            gray = new SolidBrush(Color.DarkGray);

            for (int t = 0; t < 4; t++)
                addThread();

            addRow();
        }

        internal (Bitmap, Bitmap) create() {

            createKnotsColors();
            createPoints();

            Bitmap bmp = new Bitmap(Width + 60, Height);
            Graphics gr = Graphics.FromImage(bmp);
            gr.Clear(Color.White);

            Font fnt = new Font("Consolas", 12);
            Point pt;
            int kp = 0;
            foreach (Knot[] knot in knots) {
                pt = knot[0].getPos();
                gr.DrawString((++kp).ToString(), fnt, gray, bmp.Width - 26, pt.Y - 10);
                gr.DrawLine(grayPen, bmp.Width - 30, pt.Y, 0, pt.Y);
            }

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
            int h = (1 + knots[0].Length) * POLY2 + (threads.Count % 2 == 0 ? 0 : POLY),
                c = (1 + knots.Count) * POLY;
            int x = 10, y = h - POLY2, row, pieces = 4;

            Bitmap bmpb = new Bitmap(c * pieces, h);
            Graphics grb = Graphics.FromImage(bmpb);
            grb.Clear(Color.White);

            for (int z = 0; z < pieces; z++) {
                row = 0;
                foreach (Knot[] ks in knots) {
                    m = row % 2 == 0;
                    foreach (Knot knot in ks) {
                        drawLosangle(grb, x, y, knot.threadClr);
                        y -= POLY2;
                    }
                    row++;
                    x += POLY;
                    y = h - POLY2 - (m ? POLY : 0);
                }
            }

            return (bmp, bmpb);
        }

        internal bool searchKnot(Point pt) {
            foreach (Knot[] ks in knots) {
                foreach (Knot knot in ks) {
                    if (knot.Rect.Contains(pt)) {
                        knot.nextNode();
                        return true;
                    }
                }
            }
            return false;
        }

        internal int searchColorHandles(Point pt) {
            foreach (ColorHandle ch in clrHandles) {
                if (ch.Rect.Contains(pt)) {
                    return ch.Index;
                }
            }
            return -1;
        }

        internal (string, string, string) getExport() {
            string clr = "", thr = "";
            Color c;
            List<Color> lst = new List<Color>();

            foreach (Thread t in threads) {
                c = t.Color;
                clr += c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2") + "\n";

                if (lst.IndexOf(c) < 0) lst.Add(c);
                thr += (char)(65 + lst.IndexOf(c));
            }

            string knts = "";
            foreach (Knot[] ks in knots) {
                foreach (Knot k in ks) {
                    knts += k.Type + ", ";
                }
                knts += "\n";
            }

            return (thr.ToLower(), clr, knts.Substring(0, knts.Length - 3).ToLower());
        }

        internal void setThreadColor(int idx, Color c) {
            threads[idx].Color = c;
        }

        internal bool subThread() {
            if (threads.Count <= 3) return false;
            threads.RemoveAt(threads.Count - 1);
            return true;
        }

        internal void addRow() {
            int cnt = threads.Count;
            int nn = cnt / 2, n;

            for (int r = 0; r < 2; r++) {

                n = r % 2 == 0 ? nn : cnt % 2 == 0 ? nn - 1 : nn;
                if (n < 1) return;

                Knot[] knot = new Knot[n];

                for (int c = 0; c < n; c++) {
                    knot[c] = new Knot(KnotType.F);
                }

                knots.Add(knot);
            }
        }

        internal void updateKnots(bool add) {
            List<Knot[]> kn = new List<Knot[]>();

            int n, c, o;
            bool t = threads.Count % 2 == 0;
            Knot kt = null;

            for (int r = 0; r < knots.Count; r++) {
                n = knots[r].Length;
                o = n + (add ? 1 : 0);

                o -= r % 2 == 1 ? (t ? 1 : 0) : (t ? 0 : 1);

                Knot[] knot = new Knot[o];

                for (c = 0; c < n - (add ? 0 : 1); c++) {
                    kt = knots[r][c].Clone();
                    knot[c] = kt;
                }

                while (c < knot.Length) {
                    knot[c++] = kt.Clone();
                }

                kn.Add(knot);
            }

            knots = kn;
        }

        internal void subRow() {
            if (knots.Count < 3) return;
            knots.RemoveAt(knots.Count - 1);
            knots.RemoveAt(knots.Count - 1);
        }

        internal void createPoints() {
            points.Clear();
            clrHandles.Clear();

            int row, k_idx, pX = 0, pY = 0, startX = 24, tc = threads.Count;
            bool lastRow;
            Point max = new Point(-999999, -999999);
            Thread thread;
            Knot knot;
            List<Thread> tmpThrd = threads.ConvertAll(t => t.Clone());

            for (int i = 0; i < tc; i++) {
                pX = startX;
                pY = 15;
                row = 0;

                startX += i % 2 == 0 ? 34 : 32;

                thread = tmpThrd[i];

                Point pt = new Point(pX, pY);
                points.Add(pt);
                clrHandles.Add(new ColorHandle(pt, thread.Color, i));

                pY += (int)(STEP_Y * .7);
                points.Add(new Point(pX, pY));


                pY += 1 + STEP_Y / 2;
                if (i % 2 == 0) {
                    pX += 1 + STEP_X / 2;
                }
                else {
                    pX -= 1 + STEP_X / 2;
                }

                points.Add(new Point(pX, pY));

                k_idx = i / 2;

                foreach (Knot[] k in knots) {

                    if (pX > max.X) max.X = pX;
                    if (pY > max.Y) max.Y = pY;

                    lastRow = row == knots.Count - 1;

                    pY += lastRow ? STEP_Y / 2 : STEP_Y;

                    if (k_idx < 0 || k_idx >= k.Length) {
                        if (k_idx < 0) {
                            pX += lastRow ? STEP_X / 2 : STEP_X;
                            thread.Dir = Direction.LEFT;
                            k_idx++;
                        }
                        else {
                            pX -= lastRow ? STEP_X / 2 : STEP_X;
                            thread.Dir = Direction.RIGHT;
                            k_idx -= (tc % 2 == 0 ? 0 : 1);
                        }
                    }
                    else {
                        knot = k[k_idx];
                        knot.setPos(pX, lastRow ? pY - 16 : pY - 33);

                        if (thread.Dir == Direction.LEFT) {
                            if (knot.Type == KnotType.FB || knot.Type == KnotType.BF) {
                                pX -= lastRow ? STEP_X / 2 : STEP_X;
                                thread.Dir = Direction.RIGHT;
                                if (row % 2 == 0) k_idx--;
                            }
                            else {
                                pX += lastRow ? STEP_X / 2 : STEP_X;
                                if (row % 2 != 0) k_idx++;
                            }

                        }
                        else {
                            if (knot.Type == KnotType.FB || knot.Type == KnotType.BF) {
                                pX += lastRow ? STEP_X / 2 : STEP_X;
                                thread.Dir = Direction.LEFT;
                                if (row % 2 != 0) k_idx++;
                            }
                            else {
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

            Height = max.Y + 40;
            Width = max.X + 10;
        }

        internal void createKnotsColors() {

            Color[] lst = new Color[threads.Count];
            int i = 0;
            foreach (Thread t in threads) lst[i++] = t.Color;

            int idx, row = 0;
            foreach (Knot[] ks in knots) {
                idx = row % 2 == 0 ? 0 : 1;
                foreach (Knot knot in ks) {
                    if (idx + 1 >= threads.Count) continue;

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

        internal void save(StreamWriter writer) {

            writer.WriteLine(threads.Count);
            foreach (Thread t in threads)
                t.save(writer);


            writer.WriteLine(knots.Count);
            writer.WriteLine(knots[0].Length);
            writer.WriteLine(knots[1].Length);
            foreach (Knot[] ks in knots)
                foreach (Knot k in ks)
                    k.save(writer);
        }

        internal void load(StreamReader reader) {
            int c, clr, x, y, m;

            threads.Clear();
            c = Convert.ToInt32(reader.ReadLine());
            for (int z = 0; z < c; z++) {
                clr = Convert.ToInt32(reader.ReadLine());
                threads.Add(new Thread(Color.FromArgb(clr), (Direction)Enum.Parse(typeof(Direction), reader.ReadLine())));
            }

            c = Convert.ToInt32(reader.ReadLine());
            x = Convert.ToInt32(reader.ReadLine());
            y = Convert.ToInt32(reader.ReadLine());

            knots.Clear();
            for (int z = 0; z < c; z++) {
                m = z % 2 == 0 ? x : y;
                Knot[] ks = new Knot[m];
                for (int a = 0; a < m; a++) {
                    ks[a] = new Knot((KnotType)Enum.Parse(typeof(KnotType), reader.ReadLine()));
                }

                knots.Add(ks);
            }

        }

        internal void addThread() => threads.Add(new Thread(Color.Gray, threads.Count % 2 == 0 ? Direction.LEFT : Direction.RIGHT));

        internal void horizontal() {
            List<Knot[]> tempK = new List<Knot[]>();
            Thread t;
            Knot knot = null;
            int n, u = threads.Count - 1;

            for (int i = u; i > -1; i--) {
                t = threads[i].Clone();
                t.Dir = t.Dir == Direction.LEFT ? t.Dir = Direction.RIGHT : t.Dir = Direction.LEFT;
                threads.Add(t);
            }

            int r0 = threads.Count / 2,
                r1 = r0 - (threads.Count % 2 == 0 ? 1 : 0);

            for (int k = 0; k < knots.Count; k++) {
                Knot[] kn = new Knot[k % 2 == 0 ? r0 : r1];

                for (n = 0; n < knots[k].Length; n++) {
                    kn[n] = knots[k][n];
                }

                u = n;
                for (n = knots[k].Length - 1; n > -1; n--) {
                    knot = knots[k][n].Clone();
                    knot.mirror();
                    kn[u++] = knot;
                }

                while (u < kn.Length) {
                    kn[u++] = knot.Clone();
                }

                tempK.Add(kn);
            }

            knots = tempK;
        }

        internal void vertical() {
            // not implemented
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
    }
}