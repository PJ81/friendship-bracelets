using System;
using System.Drawing;
using System.IO;

namespace bracelets {

    class Knot {

        private Point pos;
        private readonly SolidBrush black;
        private readonly Pen penB = new Pen(Color.Black, 1);
        private readonly Pen penW = new Pen(Color.White, 1);

        public KnotType Type { get; set; }

        public Rectangle Rect { get; private set; }

        public SolidBrush threadClr { get; private set; }

        public void setColor(Color c) {
            threadClr = new SolidBrush(c);
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
            float scale = .7f, tail = .7f, r = 11f;

            Pen pen = Program.getForeColor(threadClr.Color) == Color.Black ? penB : penW;

            if (Type == KnotType.F) {
                float px = (float)(-r * Math.Sin(Math.PI / 4) * scale + pos.X);
                float py = (float)(-r * Math.Cos(Math.PI / 4) * scale + pos.Y);
                float qx = (float)(r * Math.Sin(Math.PI / 4) * scale + pos.X);
                float qy = (float)(r * Math.Cos(Math.PI / 4) * scale + pos.Y);
                gr.DrawLine(pen, px, py, qx, qy);
                gr.DrawLine(pen, qx, qy, qx, qy - r * tail);
                gr.DrawLine(pen, qx, qy, qx - r * tail, qy);
            }
            else if (Type == KnotType.B) {
                float px = (float)(r * Math.Sin(Math.PI / 4) * scale + pos.X);
                float py = (float)(-r * Math.Cos(Math.PI / 4) * scale + pos.Y);
                float qx = (float)(-r * Math.Sin(Math.PI / 4) * scale + pos.X);
                float qy = (float)(r * Math.Cos(Math.PI / 4) * scale + pos.Y);
                gr.DrawLine(pen, px, py, qx, qy);
                gr.DrawLine(pen, qx, qy, qx, qy - r * tail);
                gr.DrawLine(pen, qx, qy, qx + r * tail, qy);
            }
            else if (Type == KnotType.FB) {
                float px = (float)(-r * Math.Sin(Math.PI / 4) * scale * 0.5 + pos.X);
                float py = (float)(-r * Math.Cos(Math.PI / 4) * scale + pos.Y);
                float qx = (float)(r * Math.Sin(Math.PI / 4) * scale * 0.5 + pos.X);
                float qy = pos.Y;
                float rx = px;
                float ry =(float)( r * Math.Cos(Math.PI / 4) * scale + pos.Y);
                gr.DrawLine(pen, px, py, qx, qy);
                gr.DrawLine(pen, qx, qy, rx, ry);
                gr.DrawLine(pen, rx, ry+1, rx, ry - r * tail * 0.6f+1);
                gr.DrawLine(pen, rx, ry+1, rx + r * tail * 0.6f, ry+1);
            }
            else if (Type == KnotType.BF) {
                float px = (float)(r * Math.Sin(Math.PI / 4) * scale * 0.5 + pos.X);
                float py = (float)(-r * Math.Cos(Math.PI / 4) * scale + pos.Y);
                float qx = (float)(-r * Math.Sin(Math.PI / 4) * scale * 0.5 + pos.X);
                float qy = 0 + pos.Y;
                float rx = px;
                float ry = (float)(r * Math.Cos(Math.PI / 4) * scale + pos.Y);
                gr.DrawLine(pen, px, py, qx, qy);
                gr.DrawLine(pen, qx, qy, rx, ry);
                gr.DrawLine(pen, rx, ry+1, rx, ry - r * tail * 0.6f+1);
                gr.DrawLine(pen, rx, ry+1, rx - r * tail * 0.6f, ry+1);
            }
        }

        public void save(StreamWriter writer) {
            writer.WriteLine(Type);
        }
    }
}
