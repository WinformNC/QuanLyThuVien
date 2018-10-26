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
enum CHUCNANG
{
    THEM, XOA, SUA
};
namespace QuanLyThuVien
{
    public partial class fDSTaiLieu : DevExpress.XtraEditors.XtraForm
    {
        CHUCNANG chucnang;
        SachBLL sachBLL = new SachBLL();
        TheLoaiBLL theloaiBLL = new TheLoaiBLL();
        ViTriBLL vitriBLL = new ViTriBLL();
        TacGiaBLL tacgiaBLL = new TacGiaBLL();
        NXBBLL nxbBLL = new NXBBLL();

        string PathImg = "";

        public fDSTaiLieu()
        {
            InitializeComponent();
            dtgvSach.DataSource = sachBLL.LoadSach();
        }

        private void loadCombobox()
        {
            cboNXB.DataSource = nxbBLL.LoadNXB();
            cboNXB.DisplayMember = "MANXB";
            cboNXB.ValueMember = "TENNXB";

            cboTacGia.DataSource = tacgiaBLL.LoadTacGia();
            cboTacGia.DisplayMember = "MATACGIA";
            cboTacGia.ValueMember = "TENTACGIA";

            cboTheLoai.DataSource = theloaiBLL.LoadTheLoai();
            cboTheLoai.DisplayMember = "MATHELOAI";
            cboTheLoai.ValueMember = "TENTHELOAI";

            cboViTri.DataSource = vitriBLL.LoadViTri();
            cboViTri.DisplayMember = "MAVITRI";
            cboViTri.ValueMember = "VITRI";
        }

        private void loadDataGrid()
        {
            for (int i = 0; i < dtgvSach.Rows.Count; i++)
            {
                try
                {
                    dtgvSach.Rows[i].Cells[0].Value = Image.FromFile(dtgvSach.Rows[i].Cells[9].Value.ToString());
                }
                catch
                {
                    dtgvSach.Rows[i].Cells[0].Value = Properties.Resources.Book_96px;
                }
            }
            dtgvSach.Columns[1].SortMode = dtgvSach.Columns[2].SortMode = dtgvSach.Columns[3].SortMode = dtgvSach.Columns[4].SortMode = dtgvSach.Columns[5].SortMode = dtgvSach.Columns[6].SortMode = dtgvSach.Columns[7].SortMode = dtgvSach.Columns[8].SortMode = dtgvSach.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;

            dtgvSach.Columns[9].Visible = false;
        }

        private void fDSTaiLieu_Load(object sender, EventArgs e)
        {
            setBoolField(false);
            loadDataGrid();
            loadCombobox();
        }

        private void setBoolField(bool b)
        {
            btnLoadImage.Enabled = btnHuy.Enabled = btnLuu.Enabled = txtMa.Enabled = txtTen.Enabled = txtMoTa.Enabled = txtNamXB.Enabled = cboViTri.Enabled = cboTheLoai.Enabled = cboTacGia.Enabled = cboNXB.Enabled = b;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "JPEG|*.jpg|PNG|*.png";
            openfile.ShowDialog();
            if (openfile.FileName.Length != 0)
            {
                PathImg = openfile.FileName;
                picbxAnh.Image = Image.FromFile(PathImg);
            }
        }

        private void dtgvSach_Click(object sender, EventArgs e)
        {
            if (dtgvSach.Rows.Count != 0)
            {
                try
                {
                    picbxAnh.Load(dtgvSach.CurrentRow.Cells[9].Value.ToString());
                }
                catch
                {
                    picbxAnh.Image = Properties.Resources.Book_96px;
                }
                txtMa.Text = dtgvSach.CurrentRow.Cells[1].Value.ToString();
                txtTen.Text = dtgvSach.CurrentRow.Cells[2].Value.ToString();
                cboTacGia.Text = dtgvSach.CurrentRow.Cells[3].Value.ToString();
                cboNXB.Text = dtgvSach.CurrentRow.Cells[4].Value.ToString();
                cboTheLoai.Text = dtgvSach.CurrentRow.Cells[5].Value.ToString();
                txtNamXB.Text = dtgvSach.CurrentRow.Cells[6].Value.ToString();
                txtMoTa.Text = dtgvSach.CurrentRow.Cells[7].Value.ToString();
                cboViTri.Text = dtgvSach.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            setBoolField(true);
            txtMa.Focus();
            chucnang = CHUCNANG.THEM;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvSach.Rows.Count == 0)
            {
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn xóa sách: " + dtgvSach.CurrentRow.Cells[2].Value.ToString(),
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                //sachBLL.Delete(txtMa.Text);
                dtgvSach.DataSource = sachBLL.LoadSach();
                loadDataGrid();
                btnSua.Enabled = btnXoa.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {

        }
    }
}