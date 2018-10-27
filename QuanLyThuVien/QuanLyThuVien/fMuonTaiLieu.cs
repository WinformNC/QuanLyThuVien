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
    public partial class fMuonTaiLieu : DevExpress.XtraEditors.XtraForm
    {
    
        Conection conn = new Conection();
        string ma, ten, maNV;
        public fMuonTaiLieu()
        {
            InitializeComponent();
            dtgvDS.DataSource = conn.loadSach();
        }
        public fMuonTaiLieu(string maNV)
        {
            InitializeComponent();
            dtgvDS.DataSource = conn.loadSach();
            this.maNV = maNV;
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
                    string s = dtgvDS.Rows[i].Cells[17].Value.ToString();
                    dtgvDS.Rows[i].Cells[0].Value = Image.FromFile(dtgvDS["HINHANHSACH", i].Value.ToString());
                }
                catch
                {
                    dtgvDS.Rows[i].Cells[0].Value = Properties.Resources.Book_96px;
                }
            }
        }

        private void LoadMaSinhVien()
        {
            cboMaSV.DataSource = conn.loadSinhVien();
            
            cboMaSV.ValueMember = "MASINHVIEN";
            cboMaSV.DisplayMember = "TENSINHVIEN";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < dtgvMuon.Rows.Count; i++)
                {
                    if (ma == dtgvMuon.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Sách này đã được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                dtgvMuon.Rows.Add(new object[] { ma, ten });
                btnMuon.Enabled = true;
            
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
       
        private void btnMuon_Click(object sender, EventArgs e)
        {
            
        }
        
        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDS.RowCount != 0)
            {
                int index = e.RowIndex;
                 ma = dtgvDS["MASACH", index].Value.ToString();
                 ten = dtgvDS["TENSACH", index].Value.ToString();
                 if (dtgvDS["SOLUONG", index].Value.ToString() == "0") 
                 {
                     MessageBox.Show("Sách bạn chọn hiện không có sẵn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                 }
                 
            }
        }
    }
}