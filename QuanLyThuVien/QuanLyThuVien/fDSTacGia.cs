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
    public partial class fDSTacGia : DevExpress.XtraEditors.XtraForm
    {
        TacGiaBLL tacgia = new TacGiaBLL();
        CHUCNANG chucnang;

        public fDSTacGia()
        {
            InitializeComponent();
        }


        private void LoadTacGia()
        {
            dtgvTacGia.DataSource = tacgia.LoadTacGia();
            dtgvTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            setNameCol();
        }

        private void setNameCol()
        {
            dtgvTacGia.Columns[0].HeaderText = "Mã tác giả";
            dtgvTacGia.Columns[1].HeaderText = "Tên tác giả";
            dtgvTacGia.Columns[2].HeaderText = "Điện thoại";
            dtgvTacGia.Columns[3].HeaderText = "Địa chỉ";
        }

        private void fDSTacGia_Load(object sender, EventArgs e)
        {
            LoadTacGia();
            setBoolField(false);
        }

        private void setBoolField(bool b)
        {
            txtMa.Enabled = txtTen.Enabled = txtDiaChi.Enabled = txtDT.Enabled = b;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTen.Enabled = txtMa.Enabled = txtDT.Enabled = txtDiaChi.Enabled = btnHuy.Enabled = btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            txtTen.Text = txtMa.Text = txtDT.Text = txtDiaChi.Text = string.Empty;
            txtMa.Focus();
            chucnang = CHUCNANG.THEM;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvTacGia.Rows.Count == 0)
            {
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn xóa tác giả: " + dtgvTacGia.CurrentRow.Cells[1].Value.ToString() +
                "\nĐiện thoại: " + dtgvTacGia.CurrentRow.Cells[2].Value.ToString() + 
                "\nĐịa chỉ: " + dtgvTacGia.CurrentRow.Cells[3].Value.ToString(), 
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                tacgia.Delete(txtMa.Text);
                LoadTacGia();
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvTacGia.Rows.Count == 0)
            {
                return;
            }
            txtTen.Enabled = txtDT.Enabled = txtDiaChi.Enabled = btnHuy.Enabled = btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            dtgvTacGia_Click(sender, e);
            txtMa.Focus();
            chucnang = CHUCNANG.SUA;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTen.Enabled = txtMa.Enabled = txtDT.Enabled = txtDiaChi.Enabled = btnHuy.Enabled = btnLuu.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Length != 0)
                if (chucnang == CHUCNANG.THEM)
                {
                    int result = tacgia.Insert(txtMa.Text, txtTen.Text, txtDT.Text, txtDiaChi.Text);
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
                    int result = tacgia.Update(txtMa.Text, txtTen.Text, txtDT.Text, txtDiaChi.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            LoadTacGia();
            btnHuy_Click(sender, e);
        }

        private void dtgvTacGia_Click(object sender, EventArgs e)
        {
            if (dtgvTacGia.Rows.Count != 0)
            {
                txtMa.Text = dtgvTacGia.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dtgvTacGia.SelectedRows[0].Cells[1].Value.ToString();
                txtDT.Text = dtgvTacGia.SelectedRows[0].Cells[2].Value.ToString();
                txtDiaChi.Text = dtgvTacGia.SelectedRows[0].Cells[3].Value.ToString();
            }
        }


    }
}