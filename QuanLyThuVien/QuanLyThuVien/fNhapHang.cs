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
using linQ_View;

namespace QuanLyThuVien
{
    public partial class fNhapHang : DevExpress.XtraEditors.XtraForm
    {
        Connection1 conn = new Connection1();
        View_Linq view = new View_Linq();

        string maNXB;

        public fNhapHang()
        {
            InitializeComponent();
        }

        private void loadNXB()
        {
            dtgv_NXB.DataSource = conn.loadNXB();
            //dtgv_NXB.Columns[1].Visible = false;
            for (int i = 2; i < dtgv_NXB.Columns.Count; i++)
            {
                dtgv_NXB.Columns[i].Visible = false;
            }
        }

        private void fNhapHang_Load(object sender, EventArgs e)
        {
            loadNXB();
        }

        private void dtgv_NXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                maNXB = dtgv_NXB["MANXB", index].Value.ToString();

                List<CHITIETDONDATHANG> lst = view.loadChiTietDDHChuaNhap(dtgv_NXB["MANXB", index].Value.ToString());
                pnlDSTaiLieu.Controls.Clear();
                for (int i = 0; i < lst.Count; i++)
                {
                    string maDDH = lst[i].MADDH.ToString();
                    string maSach = lst[i].MASACH.ToString();
                    string tenSach = lst[i].SACH.TENSACH.ToString();
                    string hinhanh = lst[i].SACH.HINHANHSACH.ToString();
                    string soluong = lst[i].SOLUONGNHAP.Value.ToString();
                    string dongia = lst[i].DONGIANHAP.Value.ToString();

                    SachNhapNXB_Item item = new SachNhapNXB_Item(maDDH, maSach, tenSach, hinhanh, soluong, dongia);
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
    }
}