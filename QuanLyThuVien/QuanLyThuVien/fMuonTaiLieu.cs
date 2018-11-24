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
using linQ_View;

namespace QuanLyThuVien
{
    public partial class fMuonTaiLieu : DevExpress.XtraEditors.XtraForm
    {
        Connection1 conn = new Connection1();
        Conection con = new Conection();
        View_Linq view = new View_Linq();

        CreatePrimaryKey pk = new CreatePrimaryKey();
        string ma, ten, maNV;
        int index;
        public fMuonTaiLieu()
        {
            InitializeComponent();
            //dtgvDS.DataSource = connloadSach();
            this.maNV = "NV001";
        }
        public fMuonTaiLieu(string maNV)
        {
            InitializeComponent();
            dtgvDS.DataSource = view.loadSach();
            dtgvDS.Columns["KHOA"].Visible = false;
            dtgvDS.Columns["THANGNHAP"].Visible = false;
            this.maNV = maNV;
        }
        private void fMuonTaiLieu_Load(object sender, EventArgs e)
        {
            LoadMaSinhVien();
            loadDataGrid_DS();
            btnMuon.Enabled = false;
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
            cboMaSV.DataSource = con.loadSinhVien();
            
            cboMaSV.ValueMember = "MADG";
            cboMaSV.DisplayMember = "MADG";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ma != null)
            {
                for (int i = 0; i < dtgvMuon.Rows.Count; i++)
                {
                    if (ma == dtgvMuon.Rows[i].Cells[0].Value.ToString())
                    {
                        MessageBox.Show("Sách này đã được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                dtgvMuon.Rows.Add(new object[] { ma, ten });
                btnMuon.Enabled = true;
            }
            else
                MessageBox.Show("Chưa chọn sách ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private List<string> loadMa()
        {
            List<string> masach = new List<string>();
            for (int i = 0; i < dtgvMuon.RowCount; i++)
                masach.Add(dtgvDS["MASACH", i].Value.ToString());
            return masach;

        }
        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (dtgvDS["SOLUONG", index].Value.ToString() == "0")
            {
                MessageBox.Show("Sách bạn chọn hiện không có sẵn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ma = pk.createKeyMuonSach();
            int kt = conn.addPhieuMuon(ma, maNV, cboMaSV.SelectedValue.ToString(), dtgvMuon.RowCount,loadMa());
            if (kt == 1)
            {
                MessageBox.Show("Thêm thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGrid_DS();
                dtgvMuon.Rows.Clear();
                //frmPhieuMuon phieuMuon = new frmPhieuMuon(ma.ToString(), maNV);
                //phieuMuon.Show();
            }
            else if (kt == 2)
                MessageBox.Show("Sinh viên chưa đóng phạt ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (kt == 3)
                MessageBox.Show("Sinh viên chưa trả sách ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Thêm không thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void dtgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgvDS.RowCount != 0)
                {
                    index = e.RowIndex;
                    ma = dtgvDS["MASACH", index].Value.ToString();
                    ten = dtgvDS["TENSACH", index].Value.ToString();
                    if (dtgvDS["SOLUONG", index].Value.ToString() == "0")
                    {
                        MessageBox.Show("Sách bạn chọn hiện không có sẵn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
            }
            catch
            {
                return;
            }       
        }
    }
}