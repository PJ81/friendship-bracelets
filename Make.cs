using System;
using System.Drawing;
using System.Windows.Forms;

namespace bracelets {
    public partial class Make : Form {

        Bitmap bmp;
        int yPos;

        private const int STEP = 40;

        public Make(Bitmap img) {
            InitializeComponent();
            bmp = img;
            yPos = 0;
            showBitmap();
        }

        private void showBitmap() {
            Bitmap t = new Bitmap(bmp.Width, STEP);
            using (Graphics grD = Graphics.FromImage(t)) {
                grD.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, STEP), 0, yPos + 35, bmp.Width, STEP, GraphicsUnit.Pixel);
            }
            picBox.Image = t;
        }

        private void btnUp_Click(object sender, EventArgs e) {
            if (bmp == null) return;

            yPos += 33;
            if (yPos >= bmp.Height - 70) yPos = 0;
            showBitmap();
        }

        private void btnDown_Click(object sender, EventArgs e) {
            if (bmp == null) return;

            yPos -= 33;
            if (yPos < 0) yPos = 0;
            showBitmap();
        }
    }
}
