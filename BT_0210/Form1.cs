using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BT_0210.Classes;

namespace BT_0210
{
    public partial class frmMatHang : Form
    {
        // Khai báo đối tượng toàn cục
        DataBaseProcess dtbase = new DataBaseProcess();

        public frmMatHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            dgvKetQua.DataSource = dtbase.ExecuteQuery("SELECT * FROM tblMatHang");

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            HienChiTiet(false);

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
          
        }
        private void XoaTrangChiTiet()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            dtpNgaySX.Value = DateTime.Today;
            dtpNgayHH.Value = DateTime.Today;
            txtDonVi.Text = "";
            txtDonGia.Text = "";
            txtGhiChu.Text = "";
        }

        private void HienChiTiet(bool hien)
        {
            txtMaSP.Enabled = hien;
            txtTenSP.Enabled = hien;
            dtpNgaySX.Enabled = hien;
            dtpNgayHH.Enabled = hien;
            txtDonVi.Enabled = hien;
            txtDonGia.Enabled = hien;
            txtGhiChu.Enabled = hien;

            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lbltittle.Text = "TÌM KIẾM MẶT HÀNG";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            string sql = "SELECT * FROM tblMatHang WHERE 1=1";
            if (txtTKMaSP.Text.Trim() != "")
                sql += " AND MaSP LIKE @MaSP";
            if (txtTKTenSP.Text.Trim() != "")
                sql += " AND TenSP LIKE @TenSP";

            var paramList = new System.Collections.Generic.List<SqlParameter>();
            if (txtTKMaSP.Text.Trim() != "")
                paramList.Add(new SqlParameter("@MaSP", "%" + txtTKMaSP.Text + "%"));
            if (txtTKTenSP.Text.Trim() != "")
                paramList.Add(new SqlParameter("@TenSP", "%" + txtTKTenSP.Text + "%"));

            dgvKetQua.DataSource = dtbase.ExecuteQuery(sql, paramList.ToArray());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lbltittle.Text = "THÊM MẶT HÀNG";
            XoaTrangChiTiet();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            HienChiTiet(true);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "CẬP NHẬT MẶT HÀNG";

            btnThem.Enabled = false;
            btnXoa.Enabled = false;

            HienChiTiet(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa mã mặt hàng " + txtMaSP.Text + " không?",
                "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sql = "DELETE FROM tblMatHang WHERE MaSP=@MaSP";
                dtbase.ExecuteNonQuery(sql, new SqlParameter("@MaSP", txtMaSP.Text));

                dgvKetQua.DataSource = dtbase.ExecuteQuery("SELECT * FROM tblMatHang");
                XoaTrangChiTiet();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDonGia.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "";
            var paramList = new System.Collections.Generic.List<SqlParameter>
            {
                new SqlParameter("@MaSP", txtMaSP.Text),
                new SqlParameter("@TenSP", txtTenSP.Text),
                new SqlParameter("@NgaySX", dtpNgaySX.Value),
                new SqlParameter("@NgayHH", dtpNgayHH.Value),
                new SqlParameter("@DonVi", txtDonVi.Text),
                new SqlParameter("@DonGia", decimal.Parse(txtDonGia.Text)),
                new SqlParameter("@GhiChu", txtGhiChu.Text)
            };

            if (btnThem.Enabled == true) // thêm mới
            {
                sql = @"INSERT INTO tblMatHang(MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu)
                        VALUES (@MaSP, @TenSP, @NgaySX, @NgayHH, @DonVi, @DonGia, @GhiChu)";
            }
            else if (btnSua.Enabled == true) // cập nhật
            {
                sql = @"UPDATE tblMatHang SET TenSP=@TenSP, NgaySX=@NgaySX, NgayHH=@NgayHH,
                        DonVi=@DonVi, DonGia=@DonGia, GhiChu=@GhiChu WHERE MaSP=@MaSP";
            }

            dtbase.ExecuteNonQuery(sql, paramList.ToArray());

            dgvKetQua.DataSource = dtbase.ExecuteQuery("SELECT * FROM tblMatHang");
            HienChiTiet(false);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = true;

            XoaTrangChiTiet();
            HienChiTiet(false);
        }

        private void dgvKetQua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;

            try
            {
                txtMaSP.Text = dgvKetQua.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvKetQua.CurrentRow.Cells[1].Value.ToString();
                dtpNgaySX.Value = (DateTime)dgvKetQua.CurrentRow.Cells[2].Value;
                dtpNgayHH.Value = (DateTime)dgvKetQua.CurrentRow.Cells[3].Value;
                txtDonVi.Text = dgvKetQua.CurrentRow.Cells[4].Value.ToString();
                txtDonGia.Text = dgvKetQua.CurrentRow.Cells[5].Value.ToString();
                txtGhiChu.Text = dgvKetQua.CurrentRow.Cells[6].Value.ToString();
            }
            catch { }
        }
        string strConnect = @"Data Source=TRIPLEK\SQLEXPRESS;
                              Initial Catalog=BanHang;
                              Integrated Security=True;
                              TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
