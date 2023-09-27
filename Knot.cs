﻿using System;
using System.Drawing;
using System.IO;

namespace bracelets {

    class Knot {

        private Point pos;
        private readonly SolidBrush black;
        private readonly Pen penB = new Pen(Color.Black);
        private readonly Pen penW = new Pen(Color.White);

        public KnotType Type { get; set; }

        public Rectangle Rect { get; private set; }

        public SolidBrush threadClr { get; private set; }

        public void setColor(Color c) {
            threadClr = new SolidBrush(c);
        }

        public Point getPos() {
            return pos;
        }

        public void setPos(int x, int y) {
            pos.X = x;
            pos.Y = y;

            Rect = new Rectangle(pos.X - 14, pos.Y - 14, 28, 28);
        }

        public void draw(Graphics gr) {
            gr.FillEllipse(black, Rect);
            gr.FillEllipse(threadClr, pos.X - 12, pos.Y - 12, 24, 24);
            drawArrow(gr);
        }

        public Knot(KnotType t) {
            Type = t;
            pos = new Point();
            black = new SolidBrush(Color.Black);
            threadClr = new SolidBrush(Color.Red);
        }

        public void NextKnot() {
            switch(Type) {
                case KnotType.F: Type = KnotType.FB; break;
                case KnotType.FB: Type = KnotType.B; break;
                case KnotType.B: Type = KnotType.BF; break; 
                case KnotType.BF: Type = KnotType.F; break;
            }
        }

        private void drawArrow(Graphics gr) {
            float sc = .7f, t = .7f, r = 11f;
            PointF a = new PointF(), b = new PointF(), c = new PointF();
            double cos = Math.Cos(Math.PI / 4), sin = Math.Sin(Math.PI / 4);

            Pen pen = Program.getForeColor(threadClr.Color) == Color.Black ? penB : penW;

            if (Type == KnotType.F || Type == KnotType.B) {
                a.X = (float)((Type == KnotType.F ? -r : r) * sin * sc + pos.X);
                a.Y = (float)(-r * cos * sc + pos.Y);
                b.X = (float)((Type == KnotType.B ? -r : r) * sin * sc + pos.X);
                b.Y = (float)(r * cos * sc + pos.Y);
                gr.DrawLine(pen, a, b);
                gr.DrawLine(pen, b.X, b.Y, b.X, b.Y - r * t);
                gr.DrawLine(pen, b.X, b.Y, b.X + (Type == KnotType.F ? -r : r) * t, b.Y);
            }
            else {
                a.X = (float)((Type == KnotType.FB ? -r : r) * sin * sc * 0.5 + pos.X);
                a.Y = (float)(-r * cos * sc + pos.Y);
                b.X = (float)((Type == KnotType.BF ? -r : r) * sin * sc * 0.5 + pos.X);
                b.Y = pos.Y;
                c.X = a.X;
                c.Y = (float)(r * cos * sc + pos.Y);
                gr.DrawLine(pen, a, b);
                gr.DrawLine(pen, b, c);
                gr.DrawLine(pen, c.X, c.Y + 1, c.X, c.Y - r * t * 0.6f + 1);
                gr.DrawLine(pen, c.X, c.Y + 1, c.X + (Type == KnotType.BF ? -r : r) * t * 0.6f, c.Y + 1);
            }
        }

        public void save(StreamWriter writer) {
            writer.WriteLine(Type);
        }
    }
}
