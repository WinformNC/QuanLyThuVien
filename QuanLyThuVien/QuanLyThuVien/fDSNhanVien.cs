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
    public partial class fDSNhanVien : DevExpress.XtraEditors.XtraForm
    {
        CHUCNANG chucnang;
        ChucVuBLL chucvu = new ChucVuBLL();
        NhanVienBLL nhanvien = new NhanVienBLL();
        TaiKhoanBLL taikhoan = new TaiKhoanBLL();

        public fDSNhanVien()
        {
            InitializeComponent();
        }

        private void fDSNhanVien_Load(object sender, EventArgs e)
        {
            LoadcboChucVu();
            LoadNhanVien();
            setBoolField(false);
        }

        private void setBoolField(bool b)
        {
            btnHuy.Enabled = btnLuu.Enabled = txtMa.Enabled = txtTen.Enabled = cboChucVu.Enabled = txtNgaySinh.Enabled = txtDiaChi.Enabled = txtDT.Enabled = txtEmail.Enabled = txtCMND.Enabled = b;
        }

        private void setNameCol()
        {
            dtgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dtgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dtgvNhanVien.Columns[2].HeaderText = "Tên đăng nhập";
            dtgvNhanVien.Columns[3].HeaderText = "Chức vụ";
            dtgvNhanVien.Columns[4].HeaderText = "Ngày sinh";
            dtgvNhanVien.Columns[5].HeaderText = "CMND";
            dtgvNhanVien.Columns[6].HeaderText = "Địa chỉ";
            dtgvNhanVien.Columns[7].HeaderText = "Điện thoại";
            dtgvNhanVien.Columns[8].HeaderText = "Email";
        }

        private void LoadNhanVien()
        {
            dtgvNhanVien.DataSource = nhanvien.LoadNhanVien();
            dtgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            setNameCol();
        }

        private void LoadcboChucVu()
        {
            cboChucVu.DataSource = chucvu.LoadChucVu();
            cboChucVu.DisplayMember = "TENCHUCVU";
            cboChucVu.ValueMember = "MACHUCVU";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboChucVu.Enabled = txtMa.Enabled = txtTen.Enabled = txtNgaySinh.Enabled = txtCMND.Enabled = txtDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = true;
            txtMa.Text = txtTen.Text = txtCMND.Text = txtDT.Text = txtDiaChi.Text = txtEmail.Text = string.Empty;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnHuy.Enabled = btnLuu.Enabled = true;
            txtMa.Focus();
            chucnang = CHUCNANG.THEM;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvNhanVien.Rows.Count == 0)
            {
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn xóa nhân viên: " + dtgvNhanVien.CurrentRow.Cells[1].Value.ToString(),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {

                LoadNhanVien();
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvNhanVien.Rows.Count == 0)
            {
                return;
            }
            cboChucVu.Enabled = txtTen.Enabled = txtNgaySinh.Enabled = txtCMND.Enabled = txtDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = btnHuy.Enabled = btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            dtgvNhanVien_Click(sender, e);
            txtTen.Focus();
            chucnang = CHUCNANG.SUA;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cboChucVu.Enabled = txtTen.Enabled = txtNgaySinh.Enabled = txtCMND.Enabled = txtDT.Enabled = txtDiaChi.Enabled = txtEmail.Enabled = btnHuy.Enabled = btnLuu.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim().Length != 0)
                if (chucnang == CHUCNANG.THEM)
                {
                    if (taikhoan.CheckPrimary(txtEmail.Text))
                    {
                        MessageBox.Show("Email đã tồn tại. Không thể lập tài khoản.", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    if (nhanvien.CheckPrimary(txtMa.Text))
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại. Không thể lập tài khoản.", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }

                    int result = nhanvien.Insert(txtMa.Text, cboChucVu.SelectedValue.ToString(), txtEmail.Text, txtTen.Text, txtNgaySinh.Text, txtCMND.Text, txtDiaChi.Text, txtDT.Text, txtEmail.Text);
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
                    int result = nhanvien.Update(txtMa.Text, cboChucVu.SelectedValue.ToString(), txtTen.Text, txtNgaySinh.Text, txtCMND.Text, txtDiaChi.Text, txtDT.Text, txtEmail.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            LoadNhanVien();
            btnHuy_Click(sender, e);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void dtgvNhanVien_Click(object sender, EventArgs e)
        {
            if (dtgvNhanVien.Rows.Count != 0)
            {
                txtMa.Text = dtgvNhanVien.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dtgvNhanVien.SelectedRows[0].Cells[1].Value.ToString();
                cboChucVu.Text = dtgvNhanVien.SelectedRows[0].Cells[3].Value.ToString();
                txtNgaySinh.Text = dtgvNhanVien.SelectedRows[0].Cells[4].Value.ToString();
                txtCMND.Text = dtgvNhanVien.SelectedRows[0].Cells[5].Value.ToString();
                txtDiaChi.Text = dtgvNhanVien.SelectedRows[0].Cells[6].Value.ToString();
                txtDT.Text = dtgvNhanVien.SelectedRows[0].Cells[7].Value.ToString();
                txtEmail.Text = dtgvNhanVien.SelectedRows[0].Cells[8].Value.ToString();
            }
        }
        
    }
}