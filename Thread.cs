using System.Drawing;


namespace bracelets {

    class Thread {
        private readonly Pen pen;
        private  Pen clrPen;
        private Color clr;

        public Color Color {
            get { return clr; }
            set { clr = value; clrPen = new Pen(value, 7); }
        }


        public Direction Dir { get; set; }

        public Thread(Color c, Direction d) {
            Color = c; Dir = d;
            pen = new Pen(Color.Black, 11);
        }

        public void Draw(Graphics gr, Point[] pts) {
            gr.DrawLines(pen, pts);
            gr.DrawLines(clrPen, pts);
        }

        public Thread Clone() {
            return new Thread(Color, Dir);
        }
    }
}
