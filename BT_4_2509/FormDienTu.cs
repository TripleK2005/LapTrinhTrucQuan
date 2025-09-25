using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_4_2509
{

    public partial class FormDienTu : Form
    {

        private BaiTapDienTu _bt;
        private TextBox[] _inputs;

        public FormDienTu(BaiTapDienTu bt)
        {
            InitializeComponent();
            _bt = bt;

            // map các TextBox từ Designer
            _inputs = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10 };

            // hiển thị đề bài
            txtDeBai.Text = _bt.DeBai;
            // Replace this line:
            // rtbDapAn.Show() = false;

            // With this line:
            rtbDapAn.Visible = false;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Bạn có muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int diem = 0;
            for (int i = 0; i < _inputs.Length; i++)
            {
                if (_inputs[i].Text.Trim().Equals(_bt.DapAnTungCau[i], StringComparison.OrdinalIgnoreCase))
                {
                    diem++;
                    _inputs[i].BackColor = Color.LightGreen; // tô màu xanh nếu đúng
                }
                else
                {
                    _inputs[i].BackColor = Color.LightCoral; // tô màu đỏ nếu sai
                }
            }
            MessageBox.Show($"Bạn được {diem} điểm!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            rtbDapAn.Text = _bt.DapAn;
            rtbDapAn.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            foreach (var input in _inputs)
            {
                input.Text = "";
                input.BackColor = Color.White; // reset màu nền
            }
            rtbDapAn.Visible = false;
            txtDeBai.Text = _bt.DeBai;
        }
    }
}
