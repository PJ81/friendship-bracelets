﻿
namespace bracelets {
    partial class Create {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.clrDlg = new System.Windows.Forms.ColorDialog();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAddThread = new System.Windows.Forms.Button();
            this.btnSubThread = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnSubRow = new System.Windows.Forms.Button();
            this.btnMake = new System.Windows.Forms.Button();
            this.btnHorizontal = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxImage = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxBraceletBook = new System.Windows.Forms.ToolStripMenuItem();
            this.clrOne = new System.Windows.Forms.Label();
            this.clrTwo = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.ctxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(4, 3);
            this.picBox.Margin = new System.Windows.Forms.Padding(0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(960, 534);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox.TabIndex = 12;
            this.picBox.TabStop = false;
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            // 
            // saveDlg
            // 
            this.saveDlg.Filter = "Bracelets|*.bra";
            // 
            // openDlg
            // 
            this.openDlg.Filter = "Bracelet|*bra";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(365, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnSave, "Save to file");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(293, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(69, 26);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnLoad, "Load from file");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAddThread
            // 
            this.btnAddThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddThread.Image = ((System.Drawing.Image)(resources.GetObject("btnAddThread.Image")));
            this.btnAddThread.Location = new System.Drawing.Point(5, 5);
            this.btnAddThread.Name = "btnAddThread";
            this.btnAddThread.Size = new System.Drawing.Size(69, 26);
            this.btnAddThread.TabIndex = 1;
            this.btnAddThread.Text = "Thread";
            this.btnAddThread.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnAddThread, "Add new thread");
            this.btnAddThread.UseVisualStyleBackColor = true;
            this.btnAddThread.Click += new System.EventHandler(this.btnAddThread_Click);
            // 
            // btnSubThread
            // 
            this.btnSubThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSubThread.Image = ((System.Drawing.Image)(resources.GetObject("btnSubThread.Image")));
            this.btnSubThread.Location = new System.Drawing.Point(77, 5);
            this.btnSubThread.Name = "btnSubThread";
            this.btnSubThread.Size = new System.Drawing.Size(69, 26);
            this.btnSubThread.TabIndex = 2;
            this.btnSubThread.Text = "Thread";
            this.btnSubThread.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnSubThread, "Remove last thread");
            this.btnSubThread.UseVisualStyleBackColor = true;
            this.btnSubThread.Click += new System.EventHandler(this.btnSubThread_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddRow.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRow.Image")));
            this.btnAddRow.Location = new System.Drawing.Point(149, 5);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(69, 26);
            this.btnAddRow.TabIndex = 3;
            this.btnAddRow.Text = "Row";
            this.btnAddRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnAddRow, "Add new row of knots");
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnSubRow
            // 
            this.btnSubRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSubRow.Image = ((System.Drawing.Image)(resources.GetObject("btnSubRow.Image")));
            this.btnSubRow.Location = new System.Drawing.Point(221, 5);
            this.btnSubRow.Name = "btnSubRow";
            this.btnSubRow.Size = new System.Drawing.Size(69, 26);
            this.btnSubRow.TabIndex = 4;
            this.btnSubRow.Text = "Row";
            this.btnSubRow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnSubRow, "Remove last row of knots");
            this.btnSubRow.UseVisualStyleBackColor = true;
            this.btnSubRow.Click += new System.EventHandler(this.btnSubRow_Click);
            // 
            // btnMake
            // 
            this.btnMake.Image = ((System.Drawing.Image)(resources.GetObject("btnMake.Image")));
            this.btnMake.Location = new System.Drawing.Point(582, 5);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(69, 26);
            this.btnMake.TabIndex = 7;
            this.btnMake.Text = "Make";
            this.btnMake.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnMake, "Save to file");
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Image = ((System.Drawing.Image)(resources.GetObject("btnHorizontal.Image")));
            this.btnHorizontal.Location = new System.Drawing.Point(509, 5);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(69, 26);
            this.btnHorizontal.TabIndex = 10;
            this.btnHorizontal.Text = "Horiz";
            this.btnHorizontal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnHorizontal, "Save to file");
            this.btnHorizontal.UseVisualStyleBackColor = true;
            this.btnHorizontal.Click += new System.EventHandler(this.btnHorizontal_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(437, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(69, 26);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnExport, "Save to file");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExport_MouseClick);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 541);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btnChange);
            this.panel2.Controls.Add(this.clrTwo);
            this.panel2.Controls.Add(this.clrOne);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnHorizontal);
            this.panel2.Controls.Add(this.btnMake);
            this.panel2.Controls.Add(this.btnSubRow);
            this.panel2.Controls.Add(this.btnSubThread);
            this.panel2.Controls.Add(this.btnAddRow);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.btnAddThread);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 34);
            this.panel2.TabIndex = 21;
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(4, 3);
            this.picBox2.Margin = new System.Windows.Forms.Padding(0);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(960, 89);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox2.TabIndex = 21;
            this.picBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.picBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(968, 95);
            this.panel3.TabIndex = 23;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxImage,
            this.ctxBraceletBook});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(144, 48);
            // 
            // ctxImage
            // 
            this.ctxImage.Name = "ctxImage";
            this.ctxImage.Size = new System.Drawing.Size(143, 22);
            this.ctxImage.Text = "Image";
            this.ctxImage.Click += new System.EventHandler(this.ctxImage_Click);
            // 
            // ctxBraceletBook
            // 
            this.ctxBraceletBook.Name = "ctxBraceletBook";
            this.ctxBraceletBook.Size = new System.Drawing.Size(143, 22);
            this.ctxBraceletBook.Text = "BraceletBook";
            this.ctxBraceletBook.Click += new System.EventHandler(this.ctxBraceletBook_Click);
            // 
            // clrOne
            // 
            this.clrOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clrOne.BackColor = System.Drawing.Color.Black;
            this.clrOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clrOne.Location = new System.Drawing.Point(870, 5);
            this.clrOne.Name = "clrOne";
            this.clrOne.Size = new System.Drawing.Size(28, 26);
            this.clrOne.TabIndex = 13;
            this.clrOne.Click += new System.EventHandler(this.clrOne_Click);
            // 
            // clrTwo
            // 
            this.clrTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clrTwo.BackColor = System.Drawing.Color.DimGray;
            this.clrTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clrTwo.Location = new System.Drawing.Point(933, 5);
            this.clrTwo.Name = "clrTwo";
            this.clrTwo.Size = new System.Drawing.Size(28, 26);
            this.clrTwo.TabIndex = 14;
            this.clrTwo.Click += new System.EventHandler(this.clrOne_Click);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.Image = ((System.Drawing.Image)(resources.GetObject("btnChange.Image")));
            this.btnChange.Location = new System.Drawing.Point(901, 5);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(28, 26);
            this.btnChange.TabIndex = 15;
            this.btnChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.btnChange, "Save to file");
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Create";
            this.Text = "Bracelets";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ctxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog clrDlg;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.SaveFileDialog saveDlg;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAddThread;
        private System.Windows.Forms.Button btnSubThread;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnSubRow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Button btnHorizontal;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem ctxImage;
        private System.Windows.Forms.ToolStripMenuItem ctxBraceletBook;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label clrTwo;
        private System.Windows.Forms.Label clrOne;
    }
}

