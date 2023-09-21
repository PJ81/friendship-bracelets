
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
            this.btnAddClr = new System.Windows.Forms.Button();
            this.clrList = new System.Windows.Forms.ListView();
            this.lstColors = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstKnot = new System.Windows.Forms.TextBox();
            this.btnBackFor = new System.Windows.Forms.Button();
            this.btnForBack = new System.Windows.Forms.Button();
            this.btnNull = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.btnWork = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClr
            // 
            this.btnAddClr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddClr.Location = new System.Drawing.Point(3, 450);
            this.btnAddClr.Name = "btnAddClr";
            this.btnAddClr.Size = new System.Drawing.Size(68, 23);
            this.btnAddClr.TabIndex = 0;
            this.btnAddClr.Text = "Add Color";
            this.toolTip.SetToolTip(this.btnAddClr, "Add color");
            this.btnAddClr.UseVisualStyleBackColor = true;
            this.btnAddClr.Click += new System.EventHandler(this.btnAddClr_Click);
            // 
            // clrList
            // 
            this.clrList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clrList.Font = new System.Drawing.Font("Consolas", 12F);
            this.clrList.HideSelection = false;
            this.clrList.Location = new System.Drawing.Point(3, 22);
            this.clrList.Name = "clrList";
            this.clrList.Size = new System.Drawing.Size(138, 425);
            this.clrList.TabIndex = 1;
            this.clrList.TileSize = new System.Drawing.Size(168, 30);
            this.clrList.UseCompatibleStateImageBehavior = false;
            this.clrList.View = System.Windows.Forms.View.SmallIcon;
            this.clrList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.clrList_ItemSelectionChanged);
            // 
            // lstColors
            // 
            this.lstColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstColors.Font = new System.Drawing.Font("Consolas", 12F);
            this.lstColors.Location = new System.Drawing.Point(144, 22);
            this.lstColors.Name = "lstColors";
            this.lstColors.Size = new System.Drawing.Size(729, 26);
            this.lstColors.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Threads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Colors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Knots";
            // 
            // lstKnot
            // 
            this.lstKnot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKnot.Font = new System.Drawing.Font("Consolas", 12F);
            this.lstKnot.Location = new System.Drawing.Point(144, 69);
            this.lstKnot.Multiline = true;
            this.lstKnot.Name = "lstKnot";
            this.lstKnot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lstKnot.Size = new System.Drawing.Size(624, 67);
            this.lstKnot.TabIndex = 5;
            // 
            // btnBackFor
            // 
            this.btnBackFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackFor.Font = new System.Drawing.Font("Wingdings 3", 8F);
            this.btnBackFor.Location = new System.Drawing.Point(806, 104);
            this.btnBackFor.Name = "btnBackFor";
            this.btnBackFor.Size = new System.Drawing.Size(32, 32);
            this.btnBackFor.TabIndex = 7;
            this.btnBackFor.Text = "ßà";
            this.toolTip.SetToolTip(this.btnBackFor, "Backward/Forward");
            this.btnBackFor.UseVisualStyleBackColor = true;
            this.btnBackFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnForBack
            // 
            this.btnForBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForBack.Font = new System.Drawing.Font("Wingdings 3", 8F);
            this.btnForBack.Location = new System.Drawing.Point(771, 104);
            this.btnForBack.Name = "btnForBack";
            this.btnForBack.Size = new System.Drawing.Size(32, 32);
            this.btnForBack.TabIndex = 8;
            this.btnForBack.Text = "àß";
            this.toolTip.SetToolTip(this.btnForBack, "Forward/Backward");
            this.btnForBack.UseVisualStyleBackColor = true;
            this.btnForBack.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnNull
            // 
            this.btnNull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNull.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnNull.Location = new System.Drawing.Point(841, 69);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(32, 32);
            this.btnNull.TabIndex = 9;
            this.btnNull.Text = "z";
            this.toolTip.SetToolTip(this.btnNull, "Null");
            this.btnNull.UseVisualStyleBackColor = true;
            this.btnNull.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnFor
            // 
            this.btnFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFor.Font = new System.Drawing.Font("Wingdings 3", 12F);
            this.btnFor.Location = new System.Drawing.Point(771, 69);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(32, 32);
            this.btnFor.TabIndex = 10;
            this.btnFor.Text = "à";
            this.toolTip.SetToolTip(this.btnFor, "Forward");
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Wingdings 3", 12F);
            this.btnBack.Location = new System.Drawing.Point(806, 69);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(32, 32);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "ß";
            this.toolTip.SetToolTip(this.btnBack, "Backward");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.Location = new System.Drawing.Point(144, 139);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(729, 359);
            this.picBox.TabIndex = 12;
            this.picBox.TabStop = false;
            this.picBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseDown);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.Location = new System.Drawing.Point(74, 450);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(67, 23);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create";
            this.toolTip.SetToolTip(this.btnCreate, "Create");
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(3, 476);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.toolTip.SetToolTip(this.btnSave, "Save to file");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.Location = new System.Drawing.Point(74, 476);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(68, 23);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Load";
            this.toolTip.SetToolTip(this.btnLoad, "Load from file");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // saveDlg
            // 
            this.saveDlg.Filter = "Bracelets|*.bra";
            // 
            // openDlg
            // 
            this.openDlg.Filter = "Bracelet|*bra";
            // 
            // btnWork
            // 
            this.btnWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWork.Font = new System.Drawing.Font("Wingdings 3", 12F);
            this.btnWork.Location = new System.Drawing.Point(841, 104);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(32, 32);
            this.btnWork.TabIndex = 16;
            this.btnWork.Text = "7";
            this.toolTip.SetToolTip(this.btnWork, "Work");
            this.btnWork.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 502);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.btnForBack);
            this.Controls.Add(this.btnBackFor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstKnot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstColors);
            this.Controls.Add(this.clrList);
            this.Controls.Add(this.btnAddClr);
            this.Name = "Form1";
            this.Text = "Bracelets";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog clrDlg;
        private System.Windows.Forms.Button btnAddClr;
        private System.Windows.Forms.ListView clrList;
        private System.Windows.Forms.TextBox lstColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lstKnot;
        private System.Windows.Forms.Button btnBackFor;
        private System.Windows.Forms.Button btnForBack;
        private System.Windows.Forms.Button btnNull;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.SaveFileDialog saveDlg;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

