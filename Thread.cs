
using System.Drawing;


namespace bracelets {

    class Thread {
        private readonly Pen pen;
        private readonly Pen clrPen;

        public Color Color { get; set; }

        public Direction Dir { get; set; }

        public Thread(Color c, Direction d) {
            Color = c; Dir = d;
            pen = new Pen(Color.Black, 11);
            clrPen = new Pen(c, 7);
        }

        public void Draw(Graphics gr, Point[] pts) {
            gr.DrawLines(pen, pts);
            gr.DrawLines(clrPen, pts);
        }
    }
}
