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
    public partial class fTraTaiLieu : DevExpress.XtraEditors.XtraForm
    {
        Conection con = new Conection();

        Connection1 conn = new Connection1();

        View_Linq view = new View_Linq();

        string maNV;
        public fTraTaiLieu(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private void fTraTaiLieu_Load(object sender, EventArgs e)
        {
            loadDocGia();
        }

        private void loadDocGia()
        {
            dtgv_DocGia.DataSource = conn.loadDocGia();
            dtgv_DocGia.Columns[1].Visible = false;
            for (int i = 3; i < dtgv_DocGia.Columns.Count; i++)
            {
                dtgv_DocGia.Columns[i].Visible = false;
            }
        }     

        private void dtgv_DocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                List<CTPHIEUMUONTRA> lst = conn.loadCTMuon_DocGia(dtgv_DocGia["MADG", index].Value.ToString());
                pnlDSTaiLieu.Controls.Clear();
                for (int i = 0; i < lst.Count; i++)
                {
                    string maPM = lst[i].MAPHIEUMUON.ToString();
                    string nv = lst[i].PHIEUMUONTRA.NHANVIEN.TENNV.ToString();
                    string maSach = lst[i].MASACH.ToString();
                    string tenSach = lst[i].SACH.TENSACH.ToString();
                    string hinhanh = lst[i].SACH.HINHANHSACH.ToString();
                    DateTime ngayMuon = lst[i].PHIEUMUONTRA.NGAYMUON.Value;
                    DateTime ngayTra = lst[i].NGAYDUKIENTRA.Value;
                    SachMuon_Item item = new SachMuon_Item(maPM, nv, maSach, tenSach, hinhanh, ngayMuon, ngayTra);
                    pnlDSTaiLieu.Controls.Add(item);
                    item.Dock = DockStyle.Top;
                    item.Show();
                }
            }
            catch
            {
                return;
            }     
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim().Length == 0)
            {
                loadDocGia();
                pnlDSTaiLieu.Controls.Clear();
            }
            else
            {
                searchDocGia(txtTimKiem.Text.Trim());
                pnlDSTaiLieu.Controls.Clear();
            }
        }

        private void searchDocGia(string x)
        {
            dtgv_DocGia.DataSource = conn.searchDocGia(x);
            dtgv_DocGia.Columns[1].Visible = false;
            for (int i = 3; i < dtgv_DocGia.Columns.Count; i++)
            {
                dtgv_DocGia.Columns[i].Visible = false;
            }
        }
    }

}