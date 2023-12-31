﻿using System.Drawing;

namespace bracelets {

    class ColorHandle {

        private readonly SolidBrush black;
        private Point pos;

        internal SolidBrush threadClr { get; private set; }

        internal Rectangle Rect { get; private set; }

        internal int Index { get; set; }

        internal ColorHandle(Point p, Color c, int idx) {
            black = new SolidBrush(Color.Black);

            threadClr = new SolidBrush(c);

            pos.X = p.X;
            pos.Y = p.Y;

            Index = idx;

            Rect = new Rectangle(pos.X - 12, pos.Y - 12, 24, 24);
        }

        internal void draw(Graphics gr) {
            gr.FillEllipse(black, Rect);
            gr.FillEllipse(threadClr, pos.X - 10, pos.Y - 10, 20, 20);
        }
    }
}
