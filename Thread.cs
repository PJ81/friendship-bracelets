using System.Drawing;
using System.IO;

namespace bracelets {

    class Thread {
        private readonly Pen pen;
        private Pen clrPen;
        private Color clr;

        internal Color Color {
            get { return clr; }
            set { clr = value; clrPen = new Pen(value, 7); }
        }

        internal Direction Dir { get; set; }

        internal Thread(Color c, Direction d) {
            Color = c; Dir = d;
            pen = new Pen(Color.Black, 11);
        }

        internal void Draw(Graphics gr, Point[] pts) {
            gr.DrawLines(pen, pts);
            gr.DrawLines(clrPen, pts);
        }

        internal Thread Clone() {
            return new Thread(Color, Dir);
        }

        internal void save(StreamWriter writer) {
            writer.WriteLine(clr.ToArgb());
            writer.WriteLine(Dir);
        }
    }
}
