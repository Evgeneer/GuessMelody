namespace GuessMelody
{
    partial class fSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSettings));
            this.lbMusic = new System.Windows.Forms.ListBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbSubfolders = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.lblGameDuration = new System.Windows.Forms.Label();
            this.lblMusicDuration = new System.Windows.Forms.Label();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.gbSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMusic
            // 
            this.lbMusic.FormattingEnabled = true;
            this.lbMusic.Location = new System.Drawing.Point(94, 13);
            this.lbMusic.Name = "lbMusic";
            this.lbMusic.Size = new System.Drawing.Size(593, 381);
            this.lbMusic.TabIndex = 0;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(12, 36);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(75, 23);
            this.btnFolder.TabIndex = 1;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // cbSubfolders
            // 
            this.cbSubfolders.AutoSize = true;
            this.cbSubfolders.Location = new System.Drawing.Point(12, 13);
            this.cbSubfolders.Name = "cbSubfolders";
            this.cbSubfolders.Size = new System.Drawing.Size(76, 17);
            this.cbSubfolders.TabIndex = 3;
            this.cbSubfolders.Text = "Subfolders";
            this.cbSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(612, 568);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(531, 568);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.cbRandomStart);
            this.gbSettings.Controls.Add(this.cbMusicDuration);
            this.gbSettings.Controls.Add(this.cbGameDuration);
            this.gbSettings.Controls.Add(this.lblMusicDuration);
            this.gbSettings.Controls.Add(this.lblGameDuration);
            this.gbSettings.Location = new System.Drawing.Point(94, 401);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(431, 190);
            this.gbSettings.TabIndex = 6;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // lblGameDuration
            // 
            this.lblGameDuration.AutoSize = true;
            this.lblGameDuration.Location = new System.Drawing.Point(6, 36);
            this.lblGameDuration.Name = "lblGameDuration";
            this.lblGameDuration.Size = new System.Drawing.Size(76, 13);
            this.lblGameDuration.TabIndex = 0;
            this.lblGameDuration.Text = "Game duration";
            // 
            // lblMusicDuration
            // 
            this.lblMusicDuration.AutoSize = true;
            this.lblMusicDuration.Location = new System.Drawing.Point(6, 74);
            this.lblMusicDuration.Name = "lblMusicDuration";
            this.lblMusicDuration.Size = new System.Drawing.Size(82, 13);
            this.lblMusicDuration.TabIndex = 1;
            this.lblMusicDuration.Text = "Time for answer";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.cbGameDuration.Location = new System.Drawing.Point(101, 33);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(49, 21);
            this.cbGameDuration.TabIndex = 2;
            this.cbGameDuration.Text = "60";
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40"});
            this.cbMusicDuration.Location = new System.Drawing.Point(101, 71);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(49, 21);
            this.cbMusicDuration.TabIndex = 3;
            this.cbMusicDuration.Text = "20";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(9, 115);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(194, 17);
            this.cbRandomStart.TabIndex = 4;
            this.cbRandomStart.Text = "Start from random place of the song";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 603);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbSubfolders);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.lbMusic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMusic;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbSubfolders;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.Label lblMusicDuration;
        private System.Windows.Forms.Label lblGameDuration;
        private System.Windows.Forms.CheckBox cbRandomStart;
    }
}