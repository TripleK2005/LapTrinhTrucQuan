using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestConnectDatabase
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtID.Visible = false;
            //LoadUser();
        }

        private void LoadUser()
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                dgwUser.DataSource = dbHelper.GetAllUsers();

                if (dgwUser.Columns.Contains("Id"))
                {
                    dgwUser.Columns["Id"].Visible = false;
                }

                dgwUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgwUser.Columns["Name"].FillWeight = 35;
                dgwUser.Columns["Email"].FillWeight = 65;

                dgwUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                AdjustGridHeight();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load user: " + ex.Message);
            }
        }

        private void AdjustGridHeight()
        {
            if (dgwUser.Rows.Count > 0)
            {
                int totalHeight = dgwUser.Rows.GetRowsHeight(DataGridViewElementStates.Visible)
                                  + dgwUser.ColumnHeadersHeight - 20;

                dgwUser.Height = totalHeight;
            }
        }


        private void dgwUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = dgwUser.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtEmail.Text = dgwUser.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtID.Text = dgwUser.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            }
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                string email = txtEmail.Text;

                DatabaseHelper dbHelper = new DatabaseHelper();
                dbHelper.UpdateUser(id, name, email);

                MessageBox.Show("Cập nhật thành công!");
                LoadUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa user: " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);

                DatabaseHelper dbHelper = new DatabaseHelper();
                dbHelper.RemoveUser(id);

                MessageBox.Show("Xóa thành công!");
                LoadUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa user: " + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadUser();
        }
    }
}
