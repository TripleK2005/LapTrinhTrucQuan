namespace BT1809_BAI2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTInh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTongSoTC = new System.Windows.Forms.TextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoTC);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMonHoc);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm sinh viên";
            // 
            // txtSoTC
            // 
            this.txtSoTC.Location = new System.Drawing.Point(150, 150);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.ReadOnly = true;
            this.txtSoTC.Size = new System.Drawing.Size(100, 22);
            this.txtSoTC.TabIndex = 9;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(150, 226);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 22);
            this.txtDiem.TabIndex = 8;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnThem.Location = new System.Drawing.Point(98, 358);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(105, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm DS";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điểm môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số tín chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên môn học";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(50, 91);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(203, 24);
            this.cbMonHoc.TabIndex = 0;
            this.cbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbMonHoc_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(376, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn học";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 16;
            this.lstDanhSach.Location = new System.Drawing.Point(21, 22);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(532, 228);
            this.lstDanhSach.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng số tín chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(723, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng số điểm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(404, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Điểm trung bình";
            // 
            // btnTInh
            // 
            this.btnTInh.BackColor = System.Drawing.SystemColors.Control;
            this.btnTInh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTInh.Location = new System.Drawing.Point(471, 463);
            this.btnTInh.Name = "btnTInh";
            this.btnTInh.Size = new System.Drawing.Size(75, 38);
            this.btnTInh.TabIndex = 5;
            this.btnTInh.Text = "Tính";
            this.btnTInh.UseVisualStyleBackColor = false;
            this.btnTInh.Click += new System.EventHandler(this.btnTInh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(726, 463);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 38);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTongSoTC
            // 
            this.txtTongSoTC.Location = new System.Drawing.Point(540, 318);
            this.txtTongSoTC.Multiline = true;
            this.txtTongSoTC.Name = "txtTongSoTC";
            this.txtTongSoTC.Size = new System.Drawing.Size(113, 30);
            this.txtTongSoTC.TabIndex = 7;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(583, 383);
            this.txtDiemTB.Multiline = true;
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(190, 30);
            this.txtDiemTB.TabIndex = 8;
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(829, 318);
            this.txtTongDiem.Multiline = true;
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(100, 30);
            this.txtTongDiem.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 554);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.txtDiemTB);
            this.Controls.Add(this.txtTongSoTC);
            this.Controls.Add(this.btnTInh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTInh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTongSoTC;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.ListBox lstDanhSach;
    }
}

