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
    public partial class fDatHang : DevExpress.XtraEditors.XtraForm
    {
        Connection1 conn = new Connection1();
        View_Linq view = new View_Linq();
        CreatePrimaryKey key = new CreatePrimaryKey();

        string maNV;
        string maNXB;
        public fDatHang(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private void fDatHang_Load(object sender, EventArgs e)
        {
            loadNXB();
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

        private void dtgv_NXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnDatHang.Visible = true;
                int index = e.RowIndex;
                maNXB = dtgv_NXB["MANXB", index].Value.ToString();

                List<linQ_View.SACH> lst = view.loadSach_NXB(dtgv_NXB["MANXB", index].Value.ToString());
                pnlDSTaiLieu.Controls.Clear();
                for (int i = 0; i < lst.Count; i++)
                {
                    string maSach = lst[i].MASACH.ToString();
                    string tenSach = lst[i].TENSACH.ToString();
                    string hinhanh = lst[i].HINHANHSACH.ToString();
                    float dongia = lst[i].GIA.Value;

                    SachDatNXB_Item item = new SachDatNXB_Item(maSach, tenSach, hinhanh, dongia);
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

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            bool kt = false;
            foreach (Control ctr in pnlDSTaiLieu.Controls)
            {
                if (ctr is SachDatNXB_Item)
                {
                    if (((SachDatNXB_Item)ctr).ktChon)
                    {
                        kt = true;
                        break;
                    }  
                }
            }
            if (!kt)
                return;

            string maDDH = key.createKeyDatHang();

            int result = view.addDonDatHang(maDDH, maNV, maNXB);

            foreach (Control ctr in pnlDSTaiLieu.Controls)
            {
                if (ctr is SachDatNXB_Item)
                {
                    if (((SachDatNXB_Item)ctr).ktChon)
                    {
                        string maSach = ((SachDatNXB_Item)ctr).maSach;
                        int soluong = ((SachDatNXB_Item)ctr).soluong;
                        float dongia = ((SachDatNXB_Item)ctr).tongtien;

                        view.addCTDonHang(maDDH, maSach, soluong, dongia);
                    }
                }
            }

            if (result == 1)
            {
                MessageBox.Show("Đặt hàng thành công", "Thông báo", MessageBoxButtons.OK);
                pnlDSTaiLieu.Controls.Clear();
                btnDatHang.Visible = false;
            }
            else
            {
                MessageBox.Show("Đặt hàng thất bại", "Thông báo", MessageBoxButtons.OK);
            }
            
        }
    }
}