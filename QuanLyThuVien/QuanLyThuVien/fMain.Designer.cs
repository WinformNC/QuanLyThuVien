namespace QuanLyThuVien
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDSTaiLieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnMuonTaiLieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraTaiLieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSMuon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTacGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnNXB = new DevExpress.XtraBars.BarButtonItem();
            this.btnTheLoai = new DevExpress.XtraBars.BarButtonItem();
            this.btnViTri = new DevExpress.XtraBars.BarButtonItem();
            this.btnChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSPhat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDSTaiLieu,
            this.btnMuonTaiLieu,
            this.btnTraTaiLieu,
            this.btnThem1,
            this.btnSua1,
            this.btnXoa1,
            this.btnHuy1,
            this.btnLuu1,
            this.btnDSMuon,
            this.barButtonItem2,
            this.btnDSNhanVien,
            this.skinRibbonGalleryBarItem1,
            this.barButtonItem1,
            this.btnTacGia,
            this.btnNXB,
            this.btnTheLoai,
            this.btnViTri,
            this.btnChucVu,
            this.btnSV,
            this.btnDSPhat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1045, 194);
            // 
            // btnDSTaiLieu
            // 
            this.btnDSTaiLieu.Caption = "Danh sách tài liệu";
            this.btnDSTaiLieu.Id = 1;
            this.btnDSTaiLieu.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Book_Shelf_32;
            this.btnDSTaiLieu.Name = "btnDSTaiLieu";
            this.btnDSTaiLieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSTaiLieu_ItemClick);
            // 
            // btnMuonTaiLieu
            // 
            this.btnMuonTaiLieu.Caption = "Mượn tài liệu";
            this.btnMuonTaiLieu.Id = 2;
            this.btnMuonTaiLieu.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Borrow_Book_32;
            this.btnMuonTaiLieu.Name = "btnMuonTaiLieu";
            this.btnMuonTaiLieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMuonTaiLieu_ItemClick);
            // 
            // btnTraTaiLieu
            // 
            this.btnTraTaiLieu.Caption = "Trả tài liệu";
            this.btnTraTaiLieu.Id = 3;
            this.btnTraTaiLieu.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Return_Book_32;
            this.btnTraTaiLieu.Name = "btnTraTaiLieu";
            this.btnTraTaiLieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraTaiLieu_ItemClick);
            // 
            // btnThem1
            // 
            this.btnThem1.Caption = "Thêm";
            this.btnThem1.Id = 4;
            this.btnThem1.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Add_Book_32;
            this.btnThem1.Name = "btnThem1";
            // 
            // btnSua1
            // 
            this.btnSua1.Caption = "Sửa";
            this.btnSua1.Id = 5;
            this.btnSua1.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Design_32;
            this.btnSua1.Name = "btnSua1";
            // 
            // btnXoa1
            // 
            this.btnXoa1.Caption = "Xóa";
            this.btnXoa1.Id = 6;
            this.btnXoa1.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Remove_Book_32;
            this.btnXoa1.Name = "btnXoa1";
            // 
            // btnHuy1
            // 
            this.btnHuy1.Caption = "Hủy";
            this.btnHuy1.Id = 7;
            this.btnHuy1.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Delete_32;
            this.btnHuy1.Name = "btnHuy1";
            // 
            // btnLuu1
            // 
            this.btnLuu1.Caption = "Lưu";
            this.btnLuu1.Id = 8;
            this.btnLuu1.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Save_32;
            this.btnLuu1.Name = "btnLuu1";
            // 
            // btnDSMuon
            // 
            this.btnDSMuon.Caption = "Danh sách mượn";
            this.btnDSMuon.Id = 9;
            this.btnDSMuon.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Reading_321;
            this.btnDSMuon.Name = "btnDSMuon";
            this.btnDSMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSMuon_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 10;
            this.barButtonItem2.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Reading_32;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnDSNhanVien
            // 
            this.btnDSNhanVien.Caption = "Danh sách nhân viên";
            this.btnDSNhanVien.Id = 11;
            this.btnDSNhanVien.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Customer_32;
            this.btnDSNhanVien.Name = "btnDSNhanVien";
            this.btnDSNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSNhanVien_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 12;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnTacGia
            // 
            this.btnTacGia.Caption = "Danh sách tác giả";
            this.btnTacGia.Id = 14;
            this.btnTacGia.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.shakespeare;
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTacGia_ItemClick);
            // 
            // btnNXB
            // 
            this.btnNXB.Caption = "Danh sách nhà xuất bản";
            this.btnNXB.Id = 15;
            this.btnNXB.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Home_32;
            this.btnNXB.Name = "btnNXB";
            this.btnNXB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNXB_ItemClick);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Caption = "Thể loại";
            this.btnTheLoai.Id = 16;
            this.btnTheLoai.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Bookmark_32;
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTheLoai_ItemClick);
            // 
            // btnViTri
            // 
            this.btnViTri.Caption = "Vị trí";
            this.btnViTri.Id = 17;
            this.btnViTri.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Marker_32;
            this.btnViTri.Name = "btnViTri";
            this.btnViTri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViTri_ItemClick);
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức vụ";
            this.btnChucVu.Id = 18;
            this.btnChucVu.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Oppression_32;
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChucVu_ItemClick);
            // 
            // btnSV
            // 
            this.btnSV.Caption = "Danh sách sinh viên";
            this.btnSV.Id = 19;
            this.btnSV.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Student_Male_32;
            this.btnSV.Name = "btnSV";
            this.btnSV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSV_ItemClick);
            // 
            // btnDSPhat
            // 
            this.btnDSPhat.Caption = "Danh sách phạt";
            this.btnDSPhat.Id = 20;
            this.btnDSPhat.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Handcuffs_32;
            this.btnDSPhat.Name = "btnDSPhat";
            this.btnDSPhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSPhat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5,
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.ribbonPage1.Image = global::QuanLyThuVien.Properties.Resources.icons8_Books_32;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý thư viện";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDSTaiLieu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDSMuon);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDSPhat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý tài liệu";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnMuonTaiLieu);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTraTaiLieu);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTacGia);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNXB);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnTheLoai);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnViTri);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup7});
            this.ribbonPage3.Image = global::QuanLyThuVien.Properties.Resources.icons8_Staff_32;
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Quản lý nhân viên";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDSNhanVien);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnChucVu);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Image = global::QuanLyThuVien.Properties.Resources.icons8_Reading_322;
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Danh sách độc giả";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSV);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // fMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 727);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HUFI\'s Library";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnDSTaiLieu;
        private DevExpress.XtraBars.BarButtonItem btnMuonTaiLieu;
        private DevExpress.XtraBars.BarButtonItem btnTraTaiLieu;
        private DevExpress.XtraBars.BarButtonItem btnThem1;
        private DevExpress.XtraBars.BarButtonItem btnSua1;
        private DevExpress.XtraBars.BarButtonItem btnXoa1;
        private DevExpress.XtraBars.BarButtonItem btnHuy1;
        private DevExpress.XtraBars.BarButtonItem btnLuu1;
        private DevExpress.XtraBars.BarButtonItem btnDSMuon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnDSNhanVien;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnTacGia;
        private DevExpress.XtraBars.BarButtonItem btnNXB;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnTheLoai;
        private DevExpress.XtraBars.BarButtonItem btnViTri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnChucVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnSV;
        private DevExpress.XtraBars.BarButtonItem btnDSPhat;
    }
}