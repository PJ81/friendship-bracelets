﻿
namespace bracelets {
    partial class Form1 {
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
            this.clrDlg = new System.Windows.Forms.ColorDialog();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnAddThread = new System.Windows.Forms.Button();
            this.btnSubThread = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnSubRow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.panel3.SuspendLayout();
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
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(294, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(69, 26);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.toolTip.SetToolTip(this.btnCreate, "Create");
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(438, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 26);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.toolTip.SetToolTip(this.btnSave, "Save to file");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(366, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(69, 26);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Load";
            this.toolTip.SetToolTip(this.btnLoad, "Load from file");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAddThread
            // 
            this.btnAddThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddThread.Location = new System.Drawing.Point(5, 5);
            this.btnAddThread.Name = "btnAddThread";
            this.btnAddThread.Size = new System.Drawing.Size(69, 26);
            this.btnAddThread.TabIndex = 17;
            this.btnAddThread.Text = "Add thread";
            this.toolTip.SetToolTip(this.btnAddThread, "Add new thread");
            this.btnAddThread.UseVisualStyleBackColor = true;
            this.btnAddThread.Click += new System.EventHandler(this.btnAddThread_Click);
            // 
            // btnSubThread
            // 
            this.btnSubThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSubThread.Location = new System.Drawing.Point(77, 5);
            this.btnSubThread.Name = "btnSubThread";
            this.btnSubThread.Size = new System.Drawing.Size(69, 26);
            this.btnSubThread.TabIndex = 18;
            this.btnSubThread.Text = "Sub thread";
            this.toolTip.SetToolTip(this.btnSubThread, "Remove last thread");
            this.btnSubThread.UseVisualStyleBackColor = true;
            this.btnSubThread.Click += new System.EventHandler(this.btnSubThread_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddRow.Location = new System.Drawing.Point(149, 5);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(69, 26);
            this.btnAddRow.TabIndex = 17;
            this.btnAddRow.Text = "Add row";
            this.toolTip.SetToolTip(this.btnAddRow, "Add new row of knots");
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnSubRow
            // 
            this.btnSubRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSubRow.Location = new System.Drawing.Point(222, 5);
            this.btnSubRow.Name = "btnSubRow";
            this.btnSubRow.Size = new System.Drawing.Size(69, 26);
            this.btnSubRow.TabIndex = 18;
            this.btnSubRow.Text = "Sub row";
            this.toolTip.SetToolTip(this.btnSubRow, "Remove last row of knots");
            this.btnSubRow.UseVisualStyleBackColor = true;
            this.btnSubRow.Click += new System.EventHandler(this.btnSubRow_Click);
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
            this.panel2.Controls.Add(this.btnSubRow);
            this.panel2.Controls.Add(this.btnSubThread);
            this.panel2.Controls.Add(this.btnAddRow);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.btnAddThread);
            this.panel2.Controls.Add(this.btnCreate);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Bracelets";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog clrDlg;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.SaveFileDialog saveDlg;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAddThread;
        private System.Windows.Forms.Button btnSubThread;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnSubRow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Panel panel3;
    }
}

