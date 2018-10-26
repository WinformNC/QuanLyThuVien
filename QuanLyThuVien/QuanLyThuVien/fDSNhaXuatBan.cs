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
    public partial class fDSNhaXuatBan : DevExpress.XtraEditors.XtraForm
    {
        CHUCNANG chucnang;
        NXBBLL nxb = new NXBBLL();
        public fDSNhaXuatBan()
        {
            InitializeComponent();
        }

        private void fDSNhaXuatBan_Load(object sender, EventArgs e)
        {
            LoadNXB();
            setBoolField(false);
        }

        private void setBoolField(bool b)
        {
            txtMa.Enabled = txtTen.Enabled = txtDiaChi.Enabled = txtDT.Enabled = b;
        }

        private void LoadNXB()
        {
            dtgvNXB.DataSource = nxb.LoadNXB();
            dtgvNXB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            setNameCol();
        }

        private void setNameCol()
        {
            dtgvNXB.Columns[0].HeaderText = "Mã nhà xuất bản";
            dtgvNXB.Columns[1].HeaderText = "Tên nhà xuất bản";
            dtgvNXB.Columns[2].HeaderText = "Điện thoại";
            dtgvNXB.Columns[3].HeaderText = "Địa chỉ";
        }

        private void dtgvNXB_Click(object sender, EventArgs e)
        {
            if (dtgvNXB.Rows.Count != 0)
            {
                txtMa.Text = dtgvNXB.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dtgvNXB.SelectedRows[0].Cells[1].Value.ToString();
                txtDT.Text = dtgvNXB.SelectedRows[0].Cells[2].Value.ToString();
                txtDiaChi.Text = dtgvNXB.SelectedRows[0].Cells[3].Value.ToString();
            }
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
            if (dtgvNXB.Rows.Count == 0)
            {
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn xóa nhà xuất bản: " + dtgvNXB.CurrentRow.Cells[1].Value.ToString() +
                "\nĐiện thoại: " + dtgvNXB.CurrentRow.Cells[2].Value.ToString() +
                "\nĐịa chỉ: " + dtgvNXB.CurrentRow.Cells[3].Value.ToString(),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                nxb.Delete(txtMa.Text);
                LoadNXB();
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvNXB.Rows.Count == 0)
            {
                return;
            }
            txtTen.Enabled = txtDT.Enabled = txtDiaChi.Enabled = btnHuy.Enabled = btnLuu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            dtgvNXB_Click(sender, e);
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
                    int result = nxb.Insert(txtMa.Text, txtTen.Text, txtDT.Text, txtDiaChi.Text);
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
                    int result = nxb.Update(txtMa.Text, txtTen.Text, txtDT.Text, txtDiaChi.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            LoadNXB();
            btnHuy_Click(sender, e);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {

        }

        
    }
}