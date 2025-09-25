namespace BT_MAU_2509
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDrive = new System.Windows.Forms.ComboBox();
            this.cboFolder = new System.Windows.Forms.ComboBox();
            this.rtbLyrics = new System.Windows.Forms.RichTextBox();
            this.lstSongs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWmp)).BeginInit();
            this.SuspendLayout();
            // 
            // axWmp
            // 
            this.axWmp.Enabled = true;
            this.axWmp.Location = new System.Drawing.Point(1, 175);
            this.axWmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axWmp.Name = "axWmp";
            this.axWmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWmp.OcxState")));
            this.axWmp.Size = new System.Drawing.Size(289, 223);
            this.axWmp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ổ đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thư mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tập tin";
            // 
            // cboDrive
            // 
            this.cboDrive.FormattingEnabled = true;
            this.cboDrive.Location = new System.Drawing.Point(134, 11);
            this.cboDrive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDrive.Name = "cboDrive";
            this.cboDrive.Size = new System.Drawing.Size(153, 21);
            this.cboDrive.TabIndex = 4;
            this.cboDrive.SelectedIndexChanged += new System.EventHandler(this.cboDrive_SelectedIndexChanged);
            // 
            // cboFolder
            // 
            this.cboFolder.FormattingEnabled = true;
            this.cboFolder.Location = new System.Drawing.Point(134, 45);
            this.cboFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboFolder.Name = "cboFolder";
            this.cboFolder.Size = new System.Drawing.Size(153, 21);
            this.cboFolder.TabIndex = 5;
            this.cboFolder.SelectedIndexChanged += new System.EventHandler(this.cboFolder_SelectedIndexChanged);
            // 
            // rtbLyrics
            // 
            this.rtbLyrics.Location = new System.Drawing.Point(313, 11);
            this.rtbLyrics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbLyrics.Name = "rtbLyrics";
            this.rtbLyrics.Size = new System.Drawing.Size(354, 387);
            this.rtbLyrics.TabIndex = 7;
            this.rtbLyrics.Text = "";
            // 
            // lstSongs
            // 
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.Location = new System.Drawing.Point(134, 83);
            this.lstSongs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(153, 69);
            this.lstSongs.TabIndex = 8;
            this.lstSongs.SelectedIndexChanged += new System.EventHandler(this.lstSongs_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 444);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.rtbLyrics);
            this.Controls.Add(this.cboFolder);
            this.Controls.Add(this.cboDrive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWmp);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "MusicPlay";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDrive;
        private System.Windows.Forms.ComboBox cboFolder;
        private System.Windows.Forms.RichTextBox rtbLyrics;
        private System.Windows.Forms.ListBox lstSongs;
    }
}

