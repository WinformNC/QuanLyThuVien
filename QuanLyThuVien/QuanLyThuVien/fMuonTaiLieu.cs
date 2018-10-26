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
    public partial class fMuonTaiLieu : DevExpress.XtraEditors.XtraForm
    {
        SinhVienBLL sinhvien = new SinhVienBLL();
        SachBLL sach = new SachBLL();

        public fMuonTaiLieu()
        {
            InitializeComponent();
            dtgvDS.DataSource = sach.LoadSach();
        }

        private void fMuonTaiLieu_Load(object sender, EventArgs e)
        {
            LoadMaSinhVien();
            loadDataGrid_DS();
            btnMuon.Enabled = false;
        }

        private void setNameCol_DS()
        {
            dtgvDS.Columns[1].HeaderText = "Mã tài liệu";
            dtgvDS.Columns[2].HeaderText = "Tựa";
            dtgvDS.Columns[3].HeaderText = "Tác giả";
            dtgvDS.Columns[4].HeaderText = "Nhà xuất bản";
            dtgvDS.Columns[5].HeaderText = "Thể loại";
            dtgvDS.Columns[6].HeaderText = "Năm xuất bản";
            dtgvDS.Columns[7].HeaderText = "Mô tả";
            dtgvDS.Columns[8].HeaderText = "Vị trí";
        }

        private void loadDataGrid_DS()
        {
            for (int i = 0; i < dtgvDS.Rows.Count; i++)
            {
                try
                {
                    dtgvDS.Rows[i].Cells[0].Value = Image.FromFile(dtgvDS.Rows[i].Cells[9].Value.ToString());
                }
                catch
                {
                    dtgvDS.Rows[i].Cells[0].Value = Properties.Resources.Book_96px;
                }
            }
            dtgvDS.Columns[1].SortMode = dtgvDS.Columns[2].SortMode = dtgvDS.Columns[3].SortMode = dtgvDS.Columns[4].SortMode = dtgvDS.Columns[5].SortMode = dtgvDS.Columns[6].SortMode = dtgvDS.Columns[7].SortMode = dtgvDS.Columns[8].SortMode = dtgvDS.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;

            dtgvDS.Columns[9].Visible = false;
            setNameCol_DS();
        }

        private void LoadMaSinhVien()
        {
            cboMaSV.DataSource = sinhvien.LoadMaSinhVien();
            cboMaSV.DisplayMember = "MASINHVIEN";
            cboMaSV.ValueMember = "MASINHVIEN";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dtgvMuon.Rows.Count != 0)
            {
                string ma = dtgvMuon.CurrentRow.Cells[1].Value.ToString();
                //if (dtgvMuon.CurrentRow.Cells[8].Value.ToString() == "0")
                //{
                //    MessageBox.Show("Sách bạn chọn hiện không có sẵn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
                for (int i = 0; i < dtgvMuon.Rows.Count; i++)
                {
                    if (ma == dtgvMuon.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Sách này đã được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                dtgvMuon.Rows.Add(new object[] { dtgvDS.CurrentRow.Cells[1].Value, dtgvDS.CurrentRow.Cells[2].Value });
                btnMuon.Enabled = true;
            } 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvMuon.SelectedRows.Count != 0)
                dtgvMuon.Rows.Remove(dtgvMuon.CurrentRow);
            if (dtgvMuon.Rows.Count == 0)
            {
                btnMuon.Enabled = false;
            }
        }
    }
}