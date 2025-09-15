using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                this.Close();
            }

        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng.", "Lỗi");
                txtName.Focus();
                return;
            }

            string item = txtName.Text + " | ";

            if (rdoFullDay.Checked)
            {
                item += "Cả Ngày";
            }
            else
            {
                item += "Nửa Ngày";
            }

            item += " | " + txtPrice.Text + "$";

            if (cboDrink.SelectedIndex != -1)
            {
                item += " | Đồ Uống: " + txtMoney.Text + "$";
            }
            else
            {
                item += " | Đồ Uống: 0$";
            }

            double giaDuThuyen = Convert.ToDouble(txtPrice.Text);
            double tienDoUong = 0;
            if (!string.IsNullOrWhiteSpace(txtMoney.Text))
            {
                tienDoUong = Convert.ToDouble(txtMoney.Text);
            }
            double tongTien = giaDuThuyen + tienDoUong;
            item += " | Tổng: " + tongTien + "$";

            lstCustommer.Items.Add(item);

            btnAdd_Click_1(sender, e);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtMoney.Text = "";

            rdoFullDay.Checked = true;
            rdoHalfOfDay.Checked = false;

            cboDrink.SelectedIndex = -1;
            cboAmount.SelectedIndex = -1;

            txtName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPrice.ReadOnly = true;
            txtMoney.ReadOnly = true;

            rdoFullDay.Checked = true;
            txtPrice.Text = "200";
        }

        private void rdoFullDay_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "200";
        }

        private void rdoHalfOfDay_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Text = "100";
        }

        private void TinhTienDoUong()
        {
            if (cboDrink.SelectedIndex != -1 && cboAmount.SelectedIndex != -1)
            {
                double donGia = 0;
                int soLuong = Convert.ToInt32(cboAmount.SelectedItem);

                if (cboDrink.Text == "Coca Cola")
                {
                    donGia = 0.5;
                }
                if (cboDrink.Text == "Pepsi")
                {
                    donGia = 0.8;
                }
                if (cboDrink.Text == "7Up")
                {
                    donGia = 1;
                }

                double tongTien = donGia * soLuong;
                txtMoney.Text = tongTien.ToString();
            }
        }

        private void cboDrink_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTienDoUong();
        }

        private void cboAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTienDoUong();
        }
    }
}
