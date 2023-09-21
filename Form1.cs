using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace bracelets {

    public enum Direction {
        RIGHT, LEFT
    };

    public enum KnotType {
        F, FB, B, BF
    };

    public partial class Form1 : Form {

        private Bracelet bracelet;

        public Form1() {
            InitializeComponent();

            bracelet = new Bracelet();
        }

        private void btnAddClr_Click(object sender, EventArgs e) {
            if(clrDlg.ShowDialog() == DialogResult.OK) {
                Color c = clrDlg.Color;

                ListViewItem li = new ListViewItem();
                li.Tag = bracelet.clrLst.Count;
                li.BackColor = c;
                li.ForeColor = bracelet.getForeColor(c);
                li.Text = ((Char)(65+clrList.Items.Count)) + " #" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2") + " ";
                clrList.Items.Add(li);

                bracelet.clrLst.Add(c);
            }
        }

        private void btnFor_Click(object sender, EventArgs e) {
            if (lstKnot.Text.Length > 0) lstKnot.Text += ", ";

            switch (((Button)sender).Name) {
                case "btnFor":
                    lstKnot.Text = lstKnot.Text + "f";
                    break;
                case "btnBack":
                    lstKnot.Text = lstKnot.Text + "b";
                    break;
                case "btnForBack":
                    lstKnot.Text = lstKnot.Text + "fb";
                    break;
                case "btnBackFor":
                    lstKnot.Text = lstKnot.Text + "bf";
                    break;
                case "btnNull":
                    lstKnot.Text = lstKnot.Text + "0";
                    break;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            if (lstColors.Text.Length == 0 || lstKnot.Text.Length == 0) return;

            Bitmap bmp = new Bitmap(picBox.Width, picBox.Height);
            Graphics gr = Graphics.FromImage(bmp);

            bracelet.create(gr, lstKnot.Text, lstColors.Text);

            picBox.Image = bmp;
        }

        private void picBox_MouseDown(object sender, MouseEventArgs e) {
            Point pt = new Point(e.X, e.Y);
            if (bracelet.searchKnot(pt)) btnCreate.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if(saveDlg.ShowDialog() == DialogResult.OK) {
                FileStream strm = new FileStream(saveDlg.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(strm);
                writer.BaseStream.Seek(0, SeekOrigin.End);

                writer.WriteLine(bracelet.clrLst.Count);
                foreach (Color c in bracelet.clrLst)
                    writer.WriteLine(c.ToArgb());

                writer.WriteLine(lstColors.Text);
                writer.WriteLine(lstKnot.Text);

                writer.Flush();
                writer.Close();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            if (openDlg.ShowDialog() == DialogResult.OK) {
                FileStream strm = new FileStream(openDlg.FileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(strm);

                int c = Convert.ToInt32(reader.ReadLine());

                bracelet.clrLst.Clear();
                clrList.Items.Clear();

                for (int i = 0; i < c; i++) {
                    int l = Convert.ToInt32(reader.ReadLine());
                    Color o = Color.FromArgb(l);

                    ListViewItem li = new ListViewItem();
                    li.Tag = bracelet.clrLst.Count;
                    li.BackColor = o;
                    li.ForeColor = bracelet.getForeColor(o);
                    li.Text = ((Char)(65 + clrList.Items.Count)) + " #" + o.R.ToString("X2") + o.G.ToString("X2") + o.B.ToString("X2") + " ";
                    clrList.Items.Add(li);

                    bracelet.clrLst.Add(o);

                }

                lstColors.Text = reader.ReadLine();

                string str = "";
                while(!reader.EndOfStream) {
                    str += reader.ReadLine() + "\r\n";
                }

                lstKnot.Text = str;

                reader.Close();

                btnCreate.PerformClick();
            }
        }

        private void clrList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (!e.IsSelected) return;

            if (clrDlg.ShowDialog() == DialogResult.OK) {
                Color c = clrDlg.Color;

                ListViewItem li = e.Item;
                li.BackColor = c;
                li.ForeColor = bracelet.getForeColor(c);
                li.Text = ((Char)(65 + clrList.Items.Count)) + " #" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2") + " ";
                bracelet.clrLst[(int)li.Tag] = c;

            }
        }
    }
}
