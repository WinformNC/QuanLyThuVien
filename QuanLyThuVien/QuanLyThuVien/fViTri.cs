using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;

namespace QuanLyThuVien
{
    public partial class fViTri : DevExpress.XtraEditors.XtraForm
    {
        CHUCNANG chucnang;
        ViTriBLL vitri = new ViTriBLL();
        Connection1 con = new Connection1();

        public fViTri()
        {
            InitializeComponent();
        }

        private void fViTri_Load(object sender, EventArgs e)
        {
            LoadViTri();
            setBoolField(false);
        }

        private void setBoolField(bool b)
        {
            txtMa.Enabled = txtTen.Enabled = b;
        }

        private void LoadViTri()
        {
            dtgvVT.DataSource = con.loadViTri();
            dtgvVT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            setNameCol();
        }

        private void setNameCol()
        {
            dtgvVT.Columns[0].HeaderText = "Mã vị trí";
            dtgvVT.Columns[1].HeaderText = "Tên vị trí";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTen.Enabled = txtMa.Enabled= btnHuy.Enabled = btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            txtTen.Text = txtMa.Text = string.Empty;
            txtMa.Focus();
            chucnang = CHUCNANG.THEM;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvVT.Rows.Count == 0)
            {
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn xóa vị trí: " + dtgvVT.CurrentRow.Cells[1].Value.ToString(),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                con.delViTri(txtMa.Text);
                LoadViTri();
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvVT.Rows.Count == 0)
            {
                return;
            }
            txtTen.Enabled = btnHuy.Enabled = btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            dtgvVT_Click(sender, e);
            txtMa.Focus();
            chucnang = CHUCNANG.SUA;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTen.Enabled = txtMa.Enabled = btnHuy.Enabled = btnLuu.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Length != 0)
                if (chucnang == CHUCNANG.THEM)
                {
                    int result = con.addViTri(txtMa.Text, txtTen.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else if (chucnang == CHUCNANG.SUA)
                {
                    int result = con.upViTri(txtMa.Text, txtTen.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            LoadViTri();
            btnHuy_Click(sender, e);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {

        }

        private void dtgvVT_Click(object sender, EventArgs e)
        {
            if (dtgvVT.Rows.Count != 0)
            {
                txtMa.Text = dtgvVT.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dtgvVT.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}