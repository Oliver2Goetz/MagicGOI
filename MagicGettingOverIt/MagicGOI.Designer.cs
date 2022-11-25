namespace MagicGettingOverIt {
    partial class MagicGOI {
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
            this.pictureboxExit = new System.Windows.Forms.PictureBox();
            this.textboxSavefileName = new System.Windows.Forms.TextBox();
            this.buttonSavefileSave = new System.Windows.Forms.Button();
            this.buttonSavefileLoad = new System.Windows.Forms.Button();
            this.comboboxSaves = new System.Windows.Forms.ComboBox();
            this.buttonSavefilesRefresh = new System.Windows.Forms.Button();
            this.buttonSavefileDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSavefilemanagement = new System.Windows.Forms.Label();
            this.labelDivider = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxExit
            // 
            this.pictureboxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureboxExit.Image = global::MagicGettingOverIt.Properties.Resources.cross;
            this.pictureboxExit.Location = new System.Drawing.Point(548, 12);
            this.pictureboxExit.Name = "pictureboxExit";
            this.pictureboxExit.Size = new System.Drawing.Size(40, 40);
            this.pictureboxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxExit.TabIndex = 0;
            this.pictureboxExit.TabStop = false;
            this.pictureboxExit.Click += new System.EventHandler(this.pictureboxExit_Click);
            // 
            // textboxSavefileName
            // 
            this.textboxSavefileName.Location = new System.Drawing.Point(142, 154);
            this.textboxSavefileName.Name = "textboxSavefileName";
            this.textboxSavefileName.Size = new System.Drawing.Size(190, 23);
            this.textboxSavefileName.TabIndex = 1;
            // 
            // buttonSavefileSave
            // 
            this.buttonSavefileSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSavefileSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSavefileSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavefileSave.Location = new System.Drawing.Point(12, 150);
            this.buttonSavefileSave.Name = "buttonSavefileSave";
            this.buttonSavefileSave.Size = new System.Drawing.Size(114, 30);
            this.buttonSavefileSave.TabIndex = 2;
            this.buttonSavefileSave.TabStop = false;
            this.buttonSavefileSave.Text = "Save";
            this.buttonSavefileSave.UseVisualStyleBackColor = true;
            this.buttonSavefileSave.Click += new System.EventHandler(this.buttonSavefileSave_Click);
            // 
            // buttonSavefileLoad
            // 
            this.buttonSavefileLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSavefileLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSavefileLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavefileLoad.Location = new System.Drawing.Point(12, 114);
            this.buttonSavefileLoad.Name = "buttonSavefileLoad";
            this.buttonSavefileLoad.Size = new System.Drawing.Size(114, 30);
            this.buttonSavefileLoad.TabIndex = 3;
            this.buttonSavefileLoad.TabStop = false;
            this.buttonSavefileLoad.Text = "Load";
            this.buttonSavefileLoad.UseVisualStyleBackColor = true;
            this.buttonSavefileLoad.Click += new System.EventHandler(this.buttonSavefileLoad_Click);
            // 
            // comboboxSaves
            // 
            this.comboboxSaves.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboboxSaves.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxSaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxSaves.FormattingEnabled = true;
            this.comboboxSaves.Location = new System.Drawing.Point(142, 118);
            this.comboboxSaves.Name = "comboboxSaves";
            this.comboboxSaves.Size = new System.Drawing.Size(190, 24);
            this.comboboxSaves.TabIndex = 4;
            // 
            // buttonSavefilesRefresh
            // 
            this.buttonSavefilesRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSavefilesRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSavefilesRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavefilesRefresh.Location = new System.Drawing.Point(347, 114);
            this.buttonSavefilesRefresh.Name = "buttonSavefilesRefresh";
            this.buttonSavefilesRefresh.Size = new System.Drawing.Size(114, 30);
            this.buttonSavefilesRefresh.TabIndex = 5;
            this.buttonSavefilesRefresh.TabStop = false;
            this.buttonSavefilesRefresh.Text = "Refresh";
            this.buttonSavefilesRefresh.UseVisualStyleBackColor = true;
            this.buttonSavefilesRefresh.Click += new System.EventHandler(this.buttonSavefilesRefresh_Click);
            // 
            // buttonSavefileDelete
            // 
            this.buttonSavefileDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSavefileDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSavefileDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavefileDelete.Location = new System.Drawing.Point(474, 114);
            this.buttonSavefileDelete.Name = "buttonSavefileDelete";
            this.buttonSavefileDelete.Size = new System.Drawing.Size(114, 30);
            this.buttonSavefileDelete.TabIndex = 6;
            this.buttonSavefileDelete.TabStop = false;
            this.buttonSavefileDelete.Text = "Delete";
            this.buttonSavefileDelete.UseVisualStyleBackColor = true;
            this.buttonSavefileDelete.Click += new System.EventHandler(this.buttonSavefileDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "MagicGOI - Getting Over It";
            // 
            // labelSavefilemanagement
            // 
            this.labelSavefilemanagement.AutoSize = true;
            this.labelSavefilemanagement.Location = new System.Drawing.Point(221, 82);
            this.labelSavefilemanagement.Name = "labelSavefilemanagement";
            this.labelSavefilemanagement.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelSavefilemanagement.Size = new System.Drawing.Size(145, 17);
            this.labelSavefilemanagement.TabIndex = 9;
            this.labelSavefilemanagement.Text = "savefile management";
            // 
            // labelDivider
            // 
            this.labelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDivider.Location = new System.Drawing.Point(12, 91);
            this.labelDivider.Name = "labelDivider";
            this.labelDivider.Size = new System.Drawing.Size(576, 2);
            this.labelDivider.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 205);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(508, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Notice: Go back to the main menu and then load the save in order for it to work";
            // 
            // MagicGOI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSavefilemanagement);
            this.Controls.Add(this.labelDivider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSavefileDelete);
            this.Controls.Add(this.buttonSavefilesRefresh);
            this.Controls.Add(this.comboboxSaves);
            this.Controls.Add(this.buttonSavefileLoad);
            this.Controls.Add(this.buttonSavefileSave);
            this.Controls.Add(this.textboxSavefileName);
            this.Controls.Add(this.pictureboxExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MagicGOI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MagicGettingOverIt";
            this.Load += new System.EventHandler(this.MagicGettingOverIt_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MagicCSGO_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureboxExit;
        private System.Windows.Forms.TextBox textboxSavefileName;
        private System.Windows.Forms.Button buttonSavefileSave;
        private System.Windows.Forms.Button buttonSavefileLoad;
        private System.Windows.Forms.ComboBox comboboxSaves;
        private System.Windows.Forms.Button buttonSavefilesRefresh;
        private System.Windows.Forms.Button buttonSavefileDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSavefilemanagement;
        private System.Windows.Forms.Label labelDivider;
        private System.Windows.Forms.Label label2;
    }
}

