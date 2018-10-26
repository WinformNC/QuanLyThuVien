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

        public fDanhSachSV()
        {
            InitializeComponent();
        }

        private void LoadSinhVien()
        {
            dtgvSinhVien.DataSource = sinhvien.LoadSinhVien();
            setNameCol();
        }

        private void setNameCol()
        {
            dtgvSinhVien.Columns[0].HeaderText = "Mã sinh viên";
            dtgvSinhVien.Columns[1].HeaderText = "Tên sinh viên";
            dtgvSinhVien.Columns[2].HeaderText = "Khoa";
            dtgvSinhVien.Columns[3].HeaderText = "Ngày sinh";
            dtgvSinhVien.Columns[4].HeaderText = "CMND";
            dtgvSinhVien.Columns[5].HeaderText = "Email";
            dtgvSinhVien.Columns[6].HeaderText = "Địa chỉ";
            dtgvSinhVien.Columns[7].HeaderText = "Điện thoại";
            dtgvSinhVien.Columns[8].HeaderText = "Năm vào trường";
        }

        private void fDanhSachSV_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
        }
    }
}