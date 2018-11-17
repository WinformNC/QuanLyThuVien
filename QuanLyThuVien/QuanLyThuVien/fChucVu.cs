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
using linQ;

namespace QuanLyThuVien
{
    public partial class fChucVu : DevExpress.XtraEditors.XtraForm
    {
        CHUCNANG chucnang;
        ChucVuBLL chucvu = new ChucVuBLL();

        Conection con = new Conection();
        Connection1 con1 = new Connection1();

        public fChucVu()
        {
            InitializeComponent();
        }

        private void fChucVu_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            setBoolField(false);
        }

        private void setBoolField(bool b)
        {
            txtMa.Enabled = txtTen.Enabled = b;
        }

        private void LoadChucVu()
        {
            dtgvCV.DataSource = con.loadChucVu();
            dtgvCV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            setNameCol();
        }

        private void setNameCol()
        {
            dtgvCV.Columns[0].HeaderText = "Mã chức vụ";
            dtgvCV.Columns[1].HeaderText = "Tên chức vụ";
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
            if (dtgvCV.Rows.Count == 0)
            {
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn xóa chức vụ: " + dtgvCV.CurrentRow.Cells[1].Value.ToString(),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                con.delChucVu(txtMa.Text);
                LoadChucVu();
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvCV.Rows.Count == 0)
            {
                return;
            }
            txtTen.Enabled = btnHuy.Enabled = btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            dtgvCV_Click(sender, e);
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
                    int result = con.addChucVu(txtMa.Text, txtTen.Text);
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
                    int result = con.upChucVu(txtMa.Text, txtTen.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            LoadChucVu();
            btnHuy_Click(sender, e);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {

        }

        private void dtgvCV_Click(object sender, EventArgs e)
        {
            if (dtgvCV.Rows.Count != 0)
            {
                txtMa.Text = dtgvCV.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dtgvCV.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}