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
    public partial class fDanhSachSV : DevExpress.XtraEditors.XtraForm
    {
        SinhVienBLL sinhvien = new SinhVienBLL();
        Connection1 con = new Connection1();
        public fDanhSachSV()
        {
            InitializeComponent();
        }

        private void LoadSinhVien()
        {
            dtgvSinhVien.DataSource = con.loadDocGia();
            setNameCol();
        }

        private void setNameCol()
        {
            dtgvSinhVien.Columns[0].HeaderText = "Mã sinh viên";
            dtgvSinhVien.Columns[1].HeaderText = "Tài khoản";
            dtgvSinhVien.Columns[2].HeaderText = "Tên sinh viên";
            dtgvSinhVien.Columns[3].HeaderText = "Email";
            dtgvSinhVien.Columns[4].HeaderText = "Địa chỉ";
            dtgvSinhVien.Columns[5].HeaderText = "Điện thoại";
            dtgvSinhVien.Columns[6].HeaderText = "Giới tính";
            dtgvSinhVien.Columns[7].HeaderText = "Năm vào trường";
        }

        private void fDanhSachSV_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
        }
    }
}