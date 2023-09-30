using System;
using System.Drawing;
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
    }
}