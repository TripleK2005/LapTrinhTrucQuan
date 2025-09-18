using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1809_BAI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int tongSoTC = 0;
        float tongDiem = 0;
        float diemTB = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            cbMonHoc.Items.Add("Tin học đại cương");
            cbMonHoc.Items.Add("Giải tích F1");
            cbMonHoc.Items.Add("Tiếng anh A0");
            cbMonHoc.Items.Add("Triết học Mác – Lênin");
            cbMonHoc.Items.Add("Vật lý F1");
            this.KeyPreview = true;
            txtDiemTB.ReadOnly = true;
            txtTongDiem.ReadOnly = true;
            txtTongSoTC.ReadOnly = true;
        }


        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbMonHoc.SelectedIndex == -1)
            {
                txtSoTC.Clear();
                cbMonHoc.Focus();
                return;
            }
            string monhoc = cbMonHoc.SelectedItem.ToString();

            if (monhoc == "Tin học đại cương")
            {
                txtSoTC.Text = "2";
            }
            if (monhoc == "Giải tích F1")
            {
                txtSoTC.Text = "3";
            }
            if (monhoc == "Tiếng anh A0")
            {
                txtSoTC.Text = "3";
            }
            if (monhoc == "Triết học Mác – Lênin")
            {
                txtSoTC.Text = "2";
            }
            if (monhoc == "Vật lý F1")
            {
                txtSoTC.Text = "3";
            }
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if(cbMonHoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtDiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            float diem = float.Parse(txtDiem.Text);
            if(diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm không hợp lệ! Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string monhoc = cbMonHoc.SelectedItem.ToString();
            int sotc = int.Parse(txtSoTC.Text);

            bool existed = Data.listMonHoc.Any(m => m.TenMon.Equals(monhoc, StringComparison.OrdinalIgnoreCase));
            if (existed)
            {
                MessageBox.Show($"Môn học \"{monhoc}\" đã tồn tại trong danh sách!\nVui lòng chọn môn khác.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                tongSoTC += sotc;
                txtTongSoTC.Text = tongSoTC.ToString();
                tongDiem += diem;
                txtTongDiem.Text = tongDiem.ToString("0.00");
                diemTB += (diem * sotc);
            }

            if (Data.listMonHoc.Count == 0)
            {
                txtDiem.Text = null;
                txtSoTC.Text = null;
                txtDiemTB.Text = null;
            }

            lstDanhSach.Items.Add(new MonHoc(monhoc, sotc, diem).ToString());
            Data.listMonHoc.Add(new MonHoc(monhoc, sotc, diem));
            txtDiem.Clear();
            cbMonHoc.SelectedIndex = -1;

        }

        private void btnTInh_Click(object sender, EventArgs e)
        {
            txtDiemTB.Text = (diemTB / tongSoTC).ToString("0.000");
            Data.listMonHoc.Clear();
            lstDanhSach.Items.Clear();
            tongDiem = 0;
            tongSoTC = 0;
            diemTB = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
