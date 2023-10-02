using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace bracelets {

    public partial class Create : Form {

        private Bracelet bracelet;

        public Create() {
            InitializeComponent();

            bracelet = new Bracelet();
            create();
        }

        private void create() {
            var t = bracelet.create();
            picBox.Image = t.Item1;
            picBox2.Image = t.Item2;
            panel3.Size = new Size(picBox2.Width, t.Item2.Height + 10);
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e) {
            Point pt = new Point(e.X, e.Y);

            if (bracelet.searchKnot(pt)) {
                create();
                return;
            }

            int r = bracelet.searchColorHandles(pt);
            if (r > -1) {
                changeColor(r);
                create();
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            saveDlg.Filter = "Bracelet | *.bra";
            saveDlg.FileName = "";

            if (saveDlg.ShowDialog() == DialogResult.OK) {
                FileStream strm = new FileStream(saveDlg.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(strm);
                writer.BaseStream.Seek(0, SeekOrigin.End);

                bracelet.save(writer);

                writer.Flush();
                writer.Close();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            if (openDlg.ShowDialog() == DialogResult.OK) {
                Text = "Bracelets - [" + openDlg.FileName + "]";

                FileStream strm = new FileStream(openDlg.FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(strm);

                bracelet.load(reader);

                reader.Close();

                create();
            }
        }

        private void changeColor(int idx) {
            if (clrDlg.ShowDialog() == DialogResult.OK) {
                Color c = clrDlg.Color;
                bracelet.setThreadColor(idx, c);
            }
        }

        private void btnAddThread_Click(object sender, EventArgs e) {
            bracelet.addThread();
            bracelet.updateKnots(true);
            create();
        }

        private void btnSubThread_Click(object sender, EventArgs e) {
            if (bracelet.subThread())
                bracelet.updateKnots(false);
            create();
        }

        private void btnAddRow_Click(object sender, EventArgs e) {
            bracelet.addRow();
            create();
        }

        private void btnSubRow_Click(object sender, EventArgs e) {
            bracelet.subRow();
            create();
        }

        private void btnMake_Click(object sender, EventArgs e) {
            Make mk = new Make((Bitmap)picBox.Image);
            mk.ShowDialog(this);
        }

        private void btnHorizontal_Click(object sender, EventArgs e) {
            bracelet.horizontal();
            create();
        }

        private void btnVertical_Click(object sender, EventArgs e) {
            bracelet.vertical();
            create();
        }

        private void btnExport_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ctxMenu.Show(btnExport, e.Location);
            }
        }

        private void ctxImage_Click(object sender, EventArgs e) {
            int w = 10 + Math.Max(picBox.Image.Width, picBox2.Image.Width),
                h = picBox.Image.Height + picBox2.Image.Height + 40;
            Bitmap nb = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(nb);

            g.Clear(Color.White);
            g.DrawImage(picBox2.Image, 5, 10);
            g.DrawImage(picBox.Image, 5, 10 + picBox2.Image.Height + 20);

            saveDlg.Filter = "Image | *.png";
            saveDlg.FileName = "";

            if (saveDlg.ShowDialog() == DialogResult.OK) {
                nb.Save(saveDlg.FileName, ImageFormat.Png);
            }
        }

        private void ctxBraceletBook_Click(object sender, EventArgs e) {
            (string, string, string) txt = bracelet.getExport();

            saveDlg.Filter = "BraceletBook | *.bbk";
            saveDlg.FileName = "";

            if (saveDlg.ShowDialog() == DialogResult.OK) {
                FileStream strm = new FileStream(saveDlg.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(strm);
                writer.BaseStream.Seek(0, SeekOrigin.End);

                writer.WriteLine(txt.Item1);
                writer.WriteLine(txt.Item2);
                writer.WriteLine(txt.Item3);

                writer.Flush();
                writer.Close();
            }
        }

        private void btnChange_Click(object sender, EventArgs e) {
            bracelet.changeColors(clrOne.BackColor, clrTwo.BackColor);
            create();
        }

        private void clrOne_Click(object sender, EventArgs e) {
            if(clrDlg.ShowDialog() == DialogResult.OK) {
                ((Label)sender).BackColor = clrDlg.Color;
            }
        }
    }
}