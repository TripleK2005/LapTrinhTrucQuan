using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_MAU_1709
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AddComboBox()
        {
            cbThoiGianGui.Items.Add("1");
            cbThoiGianGui.Items.Add("3");
            cbThoiGianGui.Items.Add("6");
            cbThoiGianGui.Items.Add("12");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddComboBox();

            this.KeyPreview = true;

        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtMaKH.Text = "";
            txtSoTienGui.Text = "";
            txtNgayGui.Text = "";
            txtTenKH.Text = "";
            cbThoiGianGui.Text = "";
            cbThoiGianGui.SelectedIndex = -1;
            rdoThuong.Checked = false;
            rdoPhatLoc.Checked = false;
            txtMaKH.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int kt = 1;
            if (txtMaKH.TextLength < 6)
            {
                MessageBox.Show("Nhập lại vì mã < 6");
                kt = 0;
            }
            if (txtDiaChi.TextLength == 0 || txtTenKH.TextLength == 0)
            {
                MessageBox.Show("Nhập lại vì tên hoặc địa chỉ rỗng");
                kt = 0;
            }
            if(txtNgayGui.TextLength == 0)
            {
                MessageBox.Show("Nhập lại vì ngày gửi rỗng");
                kt = 0;
            }
            else
            {
                try
                {
                    DateTime ngay = Convert.ToDateTime(txtNgayGui.Text);
                }
                catch
                {
                    MessageBox.Show("Nhập lại vì ngày gửi sai định dạng");
                    kt = 0;
                }
            }


            double tienlai = 0;
            if (kt == 1)
            {
                if (rdoThuong.Checked == true)
                {

                    string thang = cbThoiGianGui.SelectedItem.ToString();
                    double soTienGui = Convert.ToDouble(txtSoTienGui.Text);
                    if(thang == "1")
                    {
                        tienlai = soTienGui * 0.06;
                    }
                    if (thang == "3")
                    {
                        tienlai = soTienGui * 0.07;
                    }
                    if (thang == "6")
                    {
                        tienlai = soTienGui * 0.08;
                    }
                    if (thang == "12")
                    {
                        tienlai = soTienGui * 0.09;
                    }
                }
                else if (rdoPhatLoc.Checked == true)
                {
                    string thang = cbThoiGianGui.SelectedItem.ToString();
                    double soTienGui = Convert.ToDouble(txtSoTienGui.Text);
                    if (thang == "1")
                    {
                        tienlai = soTienGui * 0.07;
                    }
                    if (thang == "3")
                    {
                        tienlai = soTienGui * 0.08;
                    }
                    if (thang == "6")
                    {
                        tienlai = soTienGui * 0.09;
                    }
                    if (thang == "12")
                    {
                        tienlai = soTienGui * 0.10;
                    }
                }

                lstDanhSach.Items.Add(
                    txtMaKH.Text + " | " + 
                    txtTenKH.Text + " | " +
                    txtDiaChi.Text+ " | " + 
                    txtNgayGui.Text + " | " + 
                    txtSoTienGui.Text + " | "+ 
                    cbThoiGianGui.Text + " tháng | " + 
                    tienlai);
                

                StaticData._Nguoigui.Add(new NguoiGui(
                    Convert.ToInt32(txtMaKH.Text),
                    txtTenKH.Text, 
                    txtDiaChi.Text, 
                    Convert.ToInt32(txtSoTienGui.Text),
                    Convert.ToDateTime(txtNgayGui.Text), 
                    cbThoiGianGui.Text, 
                    tienlai
                  ));
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }

}


