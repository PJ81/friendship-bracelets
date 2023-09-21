
using System.Drawing;


namespace bracelets {

    class Thread {

        private Pen pen, clrPen;

        public Color color {
            get; set;
        }
        public Direction dir {
            get; set;
        }

        public Thread(Color c, Direction d) {
            color = c; dir = d;
            pen = new Pen(Color.Black, 11);
            clrPen = new Pen(c, 7);
        }

        public void draw(Graphics gr, Point[] pts) {
            gr.DrawLines(pen, pts);
            gr.DrawLines(clrPen, pts);
        }
    }
}
