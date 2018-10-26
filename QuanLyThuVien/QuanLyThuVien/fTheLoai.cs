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
    public partial class fTheLoai : DevExpress.XtraEditors.XtraForm
    {
        CHUCNANG chucnang;
        TheLoaiBLL theloai = new TheLoaiBLL();
        public fTheLoai()
        {
            InitializeComponent();
        }

        private void fTheLoai_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
            setBoolField(false);
        }

        private void setBoolField(bool b)
        {
            txtMa.Enabled = txtTen.Enabled = b;
        }

        private void LoadTheLoai()
        {
            dtgvTL.DataSource = theloai.LoadTheLoai();
            dtgvTL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            setNameCol();
        }

        private void setNameCol()
        {
            dtgvTL.Columns[0].HeaderText = "Mã thể loại";
            dtgvTL.Columns[1].HeaderText = "Tên thể loại";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTen.Enabled = txtMa.Enabled = btnHuy.Enabled = btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            txtTen.Text = txtMa.Text = string.Empty;
            txtMa.Focus();
            chucnang = CHUCNANG.THEM;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvTL.Rows.Count == 0)
            {
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn xóa thể loại: " + dtgvTL.CurrentRow.Cells[1].Value.ToString(),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                theloai.Delete(txtMa.Text);
                LoadTheLoai();
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvTL.Rows.Count == 0)
            {
                return;
            }
            txtTen.Enabled = btnHuy.Enabled = btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            dtgvTL_Click(sender, e);
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
                    int result = theloai.Insert(txtMa.Text, txtTen.Text);
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
                    int result = theloai.Update(txtMa.Text, txtTen.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            LoadTheLoai();
            btnHuy_Click(sender, e);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {

        }

        private void dtgvTL_Click(object sender, EventArgs e)
        {
            if (dtgvTL.Rows.Count != 0)
            {
                txtMa.Text = dtgvTL.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dtgvTL.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}