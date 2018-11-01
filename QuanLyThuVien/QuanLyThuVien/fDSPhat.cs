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
using linQ;
namespace QuanLyThuVien
{
    public partial class fDSPhat : DevExpress.XtraEditors.XtraForm
    {
        Conection conn = new Conection();
        public fDSPhat()
        {
            InitializeComponent();
            loadDgv();
        }
        
        public void loadDgv()
        {
            dtgvDSPhat.DataSource = conn.loadPhat();
        }

        private void btnDongPhat_Click(object sender, EventArgs e)
        {
            if (maphat != null)
            {
                if (conn.delPhat(maphat) == 1)
                    MessageBox.Show("Đóng thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Đóng không thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadDgv();
            }
            else
                MessageBox.Show("Chưa chọn phiếu phạt ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        string maphat;
        private void dtgvDSPhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(dtgvDSPhat.RowCount != 0)
                maphat = dtgvDSPhat["Column1", index].Value.ToString();

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExcelExport export = new ExcelExport();
            export.export2ExcelSpecial(dtgvDSPhat, @"C:\Users\Dell7559\Desktop\", "DataPhat");
        }
      
    }
}