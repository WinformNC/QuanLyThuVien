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

enum CHUCNANG
{
    THEM, XOA, SUA
};
namespace QuanLyThuVien
{
    public partial class fDSTaiLieu : DevExpress.XtraEditors.XtraForm
    {
        CHUCNANG chucnang;

        Conection conn = new Conection();
        Connection1 con = new Connection1();
        View_Linq view = new View_Linq();
        CreatePrimaryKey pk = new CreatePrimaryKey();
        string PathImg = "";

        public fDSTaiLieu()
        {
            InitializeComponent();
            dtgvSach.DataSource = view.loadSach();
            dtgvSach.Columns["KHOA"].Visible = false;
            dtgvSach.Columns["THANGNHAP"].Visible = false;
            //.DataSource = conn.loadSach();
            setBtn(false);
        }

        private void loadCombobox()
        {
            cboNXB.DataSource = con.loadNXB();
            cboNXB.ValueMember = "MANXB";
            cboNXB.DisplayMember = "TENNXB";

            cboTacGia.DataSource = con.loadTacGia();
            cboTacGia.ValueMember = "MATACGIA";
            cboTacGia.DisplayMember = "TENTACGIA";

            cboTheLoai.DataSource = con.loadTheLoai();
            cboTheLoai.ValueMember = "MATHELOAI";
            cboTheLoai.DisplayMember = "TENTHELOAI";

            cboViTri.DataSource = con.loadViTri();
            cboViTri.ValueMember = "MAVT";
            cboViTri.DisplayMember = "TENVITRI";
        }

        private void loadDataGrid()
        {
            for (int i = 0; i < dtgvSach.Rows.Count; i++)
            {
                try
                {
                    string s = dtgvSach.Rows[i].Cells[17].Value.ToString();
                    dtgvSach.Rows[i].Cells[0].Value = Image.FromFile(dtgvSach["HINHANHSACH", i].Value.ToString());
                }
                catch
                {
                    dtgvSach.Rows[i].Cells[0].Value = Properties.Resources.Book_96px;
                }
            }
            //dtgvSach.Columns[1].SortMode = dtgvSach.Columns[2].SortMode = dtgvSach.Columns[3].SortMode = dtgvSach.Columns[4].SortMode = dtgvSach.Columns[5].SortMode = dtgvSach.Columns[6].SortMode = dtgvSach.Columns[7].SortMode = dtgvSach.Columns[8].SortMode = dtgvSach.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;

            //dtgvSach.Columns[9].Visible = false;
        }

        private void fDSTaiLieu_Load(object sender, EventArgs e)
        {
            setBoolField(false);
            loadDataGrid();
            loadCombobox();
        }

        private void setBoolField(bool b)
        {
            txtSoLuong.Enabled = btnLoadImage.Enabled = btnHuy.Enabled = btnLuu.Enabled = txtTen.Enabled = txtMoTa.Enabled = txtNamXB.Enabled = cboViTri.Enabled = cboTheLoai.Enabled = cboTacGia.Enabled = cboNXB.Enabled = txt_gia.Enabled = b;
        }
        private void setBtn(bool b)
        {
            btnXoa.Enabled = btnSua.Enabled = b;
            
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

      
      
        private void btnThem_Click(object sender, EventArgs e)
        {
            setBoolField(true);
            txtMa.Focus();
            chucnang = CHUCNANG.THEM;
            clearTextBox();
            setBoolField(true);
            setBtn(false);
            txtMa.Text = pk.createKeySach();
            picbxAnh.Image = Properties.Resources.Book_96px;
            btnThem.Enabled = false;
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvSach.Rows.Count == 0)
            {
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có muốn xóa sách: " + txtTen.Text,
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                xoa();
                dtgvSach.DataSource = view.loadSach();
                loadDataGrid();
                btnSua.Enabled = btnXoa.Enabled = false;
            }
            btnTaiLai.PerformClick();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgvSach.Rows.Count == 0)
            {
                return;
            }
            //DialogResult r = MessageBox.Show("Bạn có muốn sửa sách: " + dtgvSach.CurrentRow.Cells[2].Value.ToString(),
            //    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (r == DialogResult.Yes)
            //{
                chucnang = CHUCNANG.SUA;
                
                loadDataGrid();
                setBtn(false);
                setBoolField(true);
                btnTaiLai.Enabled = false;
                btnLuu.Enabled = true;
            //}
                
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
            loadCombobox();
            setBtn(false);
            clearTextBox();
            loadDataGrid();
            setBoolField(false);
            btnThem.Enabled = true;
            picbxAnh.Image = Properties.Resources.Book_96px;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chucnang == CHUCNANG.THEM)
                them();
            else if (chucnang == CHUCNANG.SUA)
                sua();
            conn.saveSach();
             

            
            dtgvSach.DataSource = view.loadSach();
            dtgvSach.Columns["KHOA"].Visible = false;
            dtgvSach.Columns["THANGNHAP"].Visible = false;
            setBtn(false);
            setBoolField(false);
            loadDataGrid();
            btnThem.Enabled = true;
            btnTaiLai.Enabled = true;
        }
        // Chuc nang
        private void clearTextBox()
        {
            txtSoLuong.Text = txtMa.Text = txtMoTa.Text = txtNamXB.Text = txtTen.Text= txt_gia.Text = null;
            cboNXB.SelectedIndex = cboTacGia.SelectedIndex = cboTheLoai.SelectedIndex = cboViTri.SelectedIndex = 0;
        }
        private void them()
        {
            if (conn.addSach(txtMa.Text, cboNXB.SelectedValue.ToString(), cboTheLoai.SelectedValue.ToString(), cboTacGia.SelectedValue.ToString(), cboViTri.SelectedValue.ToString(), txtTen.Text, txtNamXB.Text, PathImg, txtMoTa.Text, txtSoLuong.Text,txt_gia.Text) == 1)
                MessageBox.Show("Nhập thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Nhập không thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void sua()
        {
            if (conn.upSach(txtMa.Text, cboNXB.SelectedValue.ToString(), cboTheLoai.SelectedValue.ToString(), cboTacGia.SelectedValue.ToString(), cboViTri.SelectedValue.ToString(), txtTen.Text, txtNamXB.Text, PathImg, txtMoTa.Text, txtSoLuong.Text,txt_gia.Text) == 1)
            {
                MessageBox.Show("Sửa thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Sửa không thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void xoa()
        {
            if (conn.delSach(txtMa.Text) == 1)
            {
                MessageBox.Show("Xóa thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Xóa không thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            loadDataGrid();
            loadCombobox();
            setBtn(false);
            btnThem.Enabled = true;
        }

     

        private void dtgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            try
            {
                PathImg = dtgvSach["HINHANHSACH", index].Value.ToString();
                picbxAnh.Load(PathImg);
            }
            catch
            {
                picbxAnh.Image = Properties.Resources.Book_96px;
            }
            txtMa.Text = dtgvSach["MASACH", index].Value.ToString();
            txtTen.Text = dtgvSach["TENSACH", index].Value.ToString();
            cboTacGia.SelectedValue = dtgvSach["MATACGIA", index].Value.ToString();
            cboTheLoai.SelectedValue = dtgvSach["MATHELOAI", index].Value.ToString();
            cboNXB.SelectedValue = dtgvSach["MANXB", index].Value.ToString();
            cboViTri.SelectedValue = dtgvSach["MAVT", index].Value.ToString();
            txtMoTa.Text = dtgvSach["MOTA", index].Value.ToString();
            txtNamXB.Text = dtgvSach["NAMXB", index].Value.ToString();
            txtSoLuong.Text = dtgvSach["SOLUONG", index].Value.ToString();
            try
            {
                txt_gia.Text = dtgvSach["GIA", index].Value.ToString();
            }
            catch {
                txt_gia.Text = 100000+"";
            }
            setBtn(true);
            btnThem.Enabled =false;
            setBoolField(false);
            
        }

   
        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtgvSach.DataSource = view.loadSach(textEdit1.Text);
                dtgvSach.Columns["KHOA"].Visible = false;
                dtgvSach.Columns["THANGNHAP"].Visible = false;
                loadDataGrid();
            }
        }

      
    }
}