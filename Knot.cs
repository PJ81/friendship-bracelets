using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bracelets {
    class Knot {

        public KnotType type {
            get; set;
        }

        private Point pos;
        private SolidBrush black, clr;
        private Pen penB = new Pen(Color.Black, 1);
        private Pen penW = new Pen(Color.White, 1);
        private Rectangle rect;

        public Rectangle Rect {
            get { return rect; }
        }

        public SolidBrush threadClr {
            get { return clr; }
        }

        public void setColor(Color c) {
            clr = new SolidBrush(c);
        }

        public void setPos(int x, int y) {
            pos.X = x;
            pos.Y = y;

            rect = new Rectangle(pos.X - 14, pos.Y - 14, 28, 28);
        }

        public void draw(Graphics gr) {
            gr.FillEllipse(black, rect);
            gr.FillEllipse(clr, pos.X - 12, pos.Y - 12, 24, 24);
            drawArrow(gr);
        }

        public Knot(KnotType t) {
            type = t;
            pos = new Point();
            black = new SolidBrush(Color.Black);
            clr = new SolidBrush(Color.Red);
        }

        public void nextKnot() {
            switch(type) {
                case KnotType.F: type = KnotType.FB; break;
                case KnotType.FB: type = KnotType.B; break;
                case KnotType.B: type = KnotType.BF; break; 
                case KnotType.BF: type = KnotType.F; break;
            }
        }

        private Color getForeColor(Color c) {
            float br2 = 0.3f * c.R + 0.59f * c.G + 0.11f * c.B;
            if (br2 > 127.0) return Color.Black;
            return Color.White;
        }

        private void drawArrow(Graphics gr) {
            float scale = .7f, tail = .7f, r = 11f;

            Pen pen = getForeColor(clr.Color) == Color.Black ? penB : penW;

            if (type == KnotType.F) {
                float px = (float)(-r * Math.Sin(Math.PI / 4) * scale + pos.X);
                float py = (float)(-r * Math.Cos(Math.PI / 4) * scale + pos.Y);
                float qx = (float)(r * Math.Sin(Math.PI / 4) * scale + pos.X);
                float qy = (float)(r * Math.Cos(Math.PI / 4) * scale + pos.Y);
                gr.DrawLine(pen, px, py, qx, qy);
                gr.DrawLine(pen, qx, qy, qx, qy - r * tail);
                gr.DrawLine(pen, qx, qy, qx - r * tail, qy);
            }
            else if (type == KnotType.B) {
                float px = (float)(r * Math.Sin(Math.PI / 4) * scale + pos.X);
                float py = (float)(-r * Math.Cos(Math.PI / 4) * scale + pos.Y);
                float qx = (float)(-r * Math.Sin(Math.PI / 4) * scale + pos.X);
                float qy = (float)(r * Math.Cos(Math.PI / 4) * scale + pos.Y);
                gr.DrawLine(pen, px, py, qx, qy);
                gr.DrawLine(pen, qx, qy, qx, qy - r * tail);
                gr.DrawLine(pen, qx, qy, qx + r * tail, qy);
            }
            else if (type == KnotType.FB) {
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
            else if (type == KnotType.BF) {
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
    }
}
