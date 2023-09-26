using System;
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
            create();
        }

        private void create() {
            var t = bracelet.create();
            picBox.Image = t.Item1;
            picBox2.Image = t.Item2;
            picBox2.Size = new Size(picBox2.Width, t.Item2.Height);
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
            if(saveDlg.ShowDialog() == DialogResult.OK) {
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
            bracelet.addRow(true);
            create();
        }

        private void btnSubThread_Click(object sender, EventArgs e) {
            bracelet.subThread();
            bracelet.addRow(true);
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
    }
}

/*private void btnAddClr_Click(object sender, EventArgs e) {
    if(clrDlg.ShowDialog() == DialogResult.OK) {
        Color c = clrDlg.Color;

        ListViewItem li = new ListViewItem();
        li.Tag = bracelet.clrLst.Count;
        li.BackColor = c;
        li.ForeColor = Program.getForeColor(c);
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

private void clrList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
if (!e.IsSelected) return;

if (clrDlg.ShowDialog() == DialogResult.OK) {
Color c = clrDlg.Color;

ListViewItem li = e.Item;
li.BackColor = c;
li.ForeColor = Program.getForeColor(c);
li.Text = ((Char)(65 + clrList.Items.Count)) + " #" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2") + " ";
bracelet.clrLst[(int)li.Tag] = c;

}
}*/
