namespace BT1509
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.cboAmount = new System.Windows.Forms.ComboBox();
            this.cboDrink = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoHalfOfDay = new System.Windows.Forms.RadioButton();
            this.rdoFullDay = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstCustommer = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnAddToList);
            this.groupBox1.Controls.Add(this.cboAmount);
            this.groupBox1.Controls.Add(this.cboDrink);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoHalfOfDay);
            this.groupBox1.Controls.Add(this.rdoFullDay);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Khách Hàng Đặt Tour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "$";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(230, 211);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(76, 22);
            this.txtMoney.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(173, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm Mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(20, 269);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(126, 23);
            this.btnAddToList.TabIndex = 12;
            this.btnAddToList.Text = "Thêm Vào DS";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // cboAmount
            // 
            this.cboAmount.FormattingEnabled = true;
            this.cboAmount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboAmount.Location = new System.Drawing.Point(129, 211);
            this.cboAmount.Name = "cboAmount";
            this.cboAmount.Size = new System.Drawing.Size(72, 24);
            this.cboAmount.TabIndex = 10;
            this.cboAmount.SelectedIndexChanged += new System.EventHandler(this.cboAmount_SelectedIndexChanged);
            // 
            // cboDrink
            // 
            this.cboDrink.FormattingEnabled = true;
            this.cboDrink.Items.AddRange(new object[] {
            "Coca Cola",
            "Pepsi",
            "7Up"});
            this.cboDrink.Location = new System.Drawing.Point(6, 211);
            this.cboDrink.Name = "cboDrink";
            this.cboDrink.Size = new System.Drawing.Size(107, 24);
            this.cboDrink.TabIndex = 9;
            this.cboDrink.SelectedIndexChanged += new System.EventHandler(this.cboDrink_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chọn Đồ Uống";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(129, 135);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá Du Thuyền";
            // 
            // rdoHalfOfDay
            // 
            this.rdoHalfOfDay.AutoSize = true;
            this.rdoHalfOfDay.Location = new System.Drawing.Point(150, 87);
            this.rdoHalfOfDay.Name = "rdoHalfOfDay";
            this.rdoHalfOfDay.Size = new System.Drawing.Size(89, 20);
            this.rdoHalfOfDay.TabIndex = 3;
            this.rdoHalfOfDay.TabStop = true;
            this.rdoHalfOfDay.Text = "Nửa Ngày";
            this.rdoHalfOfDay.UseVisualStyleBackColor = true;
            this.rdoHalfOfDay.CheckedChanged += new System.EventHandler(this.rdoHalfOfDay_CheckedChanged);
            // 
            // rdoFullDay
            // 
            this.rdoFullDay.AutoSize = true;
            this.rdoFullDay.Location = new System.Drawing.Point(20, 87);
            this.rdoFullDay.Name = "rdoFullDay";
            this.rdoFullDay.Size = new System.Drawing.Size(81, 20);
            this.rdoFullDay.TabIndex = 2;
            this.rdoFullDay.TabStop = true;
            this.rdoFullDay.Text = "Cả Ngày";
            this.rdoFullDay.UseVisualStyleBackColor = true;
            this.rdoFullDay.Click += new System.EventHandler(this.rdoFullDay_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCustommer);
            this.groupBox2.Location = new System.Drawing.Point(372, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khach Hàng Đặt Tour";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnExit.Location = new System.Drawing.Point(645, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstCustommer
            // 
            this.lstCustommer.FormattingEnabled = true;
            this.lstCustommer.ItemHeight = 16;
            this.lstCustommer.Location = new System.Drawing.Point(19, 38);
            this.lstCustommer.Name = "lstCustommer";
            this.lstCustommer.Size = new System.Drawing.Size(358, 260);
            this.lstCustommer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 431);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.ComboBox cboAmount;
        private System.Windows.Forms.ComboBox cboDrink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoHalfOfDay;
        private System.Windows.Forms.RadioButton rdoFullDay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstCustommer;
    }
}

