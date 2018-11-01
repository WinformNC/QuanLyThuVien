namespace QuanLyThuVien
{
    partial class fMuonTaiLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgvDS = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dtgvMuon = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMuon = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new Bunifu.Framework.UI.BunifuImageButton();
            this.cboMaSV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageSach = new System.Windows.Forms.DataGridViewImageColumn();
            this.MASACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTHELOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VITRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTACGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATHELOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATACGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAVITRI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TACGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHAXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THELOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHANHSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMuon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtgvDS, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtgvMuon, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(833, 609);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtgvDS
            // 
            this.dtgvDS.AllowUserToAddRows = false;
            this.dtgvDS.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvDS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDS.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvDS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageSach,
            this.MASACH,
            this.TENSACH,
            this.TENTHELOAI,
            this.VITRI,
            this.TENTACGIA,
            this.TenNXB,
            this.NAMXB,
            this.MOTA,
            this.SOLUONG,
            this.Gia,
            this.MANXB,
            this.MATHELOAI,
            this.MATACGIA,
            this.MAVITRI,
            this.VT,
            this.TACGIA,
            this.NHAXB,
            this.THELOAI,
            this.HINHANHSACH});
            this.dtgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDS.DoubleBuffered = true;
            this.dtgvDS.EnableHeadersVisualStyles = false;
            this.dtgvDS.HeaderBgColor = System.Drawing.Color.White;
            this.dtgvDS.HeaderForeColor = System.Drawing.Color.Black;
            this.dtgvDS.Location = new System.Drawing.Point(3, 83);
            this.dtgvDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvDS.MultiSelect = false;
            this.dtgvDS.Name = "dtgvDS";
            this.dtgvDS.ReadOnly = true;
            this.dtgvDS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDS.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDS.RowTemplate.Height = 100;
            this.dtgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDS.Size = new System.Drawing.Size(827, 278);
            this.dtgvDS.TabIndex = 36;
            this.dtgvDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDS_CellClick);
            // 
            // dtgvMuon
            // 
            this.dtgvMuon.AllowUserToAddRows = false;
            this.dtgvMuon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvMuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMuon.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen});
            this.dtgvMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMuon.DoubleBuffered = true;
            this.dtgvMuon.EnableHeadersVisualStyles = false;
            this.dtgvMuon.HeaderBgColor = System.Drawing.Color.White;
            this.dtgvMuon.HeaderForeColor = System.Drawing.Color.Black;
            this.dtgvMuon.Location = new System.Drawing.Point(3, 422);
            this.dtgvMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvMuon.MultiSelect = false;
            this.dtgvMuon.Name = "dtgvMuon";
            this.dtgvMuon.ReadOnly = true;
            this.dtgvMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMuon.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvMuon.RowTemplate.Height = 24;
            this.dtgvMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMuon.Size = new System.Drawing.Size(827, 185);
            this.dtgvMuon.TabIndex = 32;
            // 
            // colMa
            // 
            this.colMa.HeaderText = "Mã tài liệu";
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tựa đề";
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMuon);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 365);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 53);
            this.panel1.TabIndex = 34;
            // 
            // btnMuon
            // 
            this.btnMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMuon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnMuon.Location = new System.Drawing.Point(675, 18);
            this.btnMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(144, 28);
            this.btnMuon.TabIndex = 34;
            this.btnMuon.Text = "Lập phiếu mượn";
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Image = global::QuanLyThuVien.Properties.Resources.Trash_Can_48px;
            this.btnXoa.ImageActive = null;
            this.btnXoa.Location = new System.Drawing.Point(9, 18);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(9, 24, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(34, 32);
            this.btnXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnXoa.TabIndex = 33;
            this.btnXoa.TabStop = false;
            this.btnXoa.Zoom = 10;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.cboMaSV);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 77);
            this.panel2.TabIndex = 35;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Image = global::QuanLyThuVien.Properties.Resources.icons8_Plus_Math_32;
            this.btnThem.ImageActive = null;
            this.btnThem.Location = new System.Drawing.Point(14, 42);
            this.btnThem.Margin = new System.Windows.Forms.Padding(9, 24, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(34, 32);
            this.btnThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThem.TabIndex = 34;
            this.btnThem.TabStop = false;
            this.btnThem.Zoom = 10;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboMaSV
            // 
            this.cboMaSV.FormattingEnabled = true;
            this.cboMaSV.Location = new System.Drawing.Point(87, 7);
            this.cboMaSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaSV.Name = "cboMaSV";
            this.cboMaSV.Size = new System.Drawing.Size(151, 21);
            this.cboMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sinh viên";
            // 
            // ImageSach
            // 
            this.ImageSach.HeaderText = "Ảnh";
            this.ImageSach.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImageSach.Name = "ImageSach";
            this.ImageSach.ReadOnly = true;
            this.ImageSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MASACH
            // 
            this.MASACH.DataPropertyName = "MASACH";
            this.MASACH.HeaderText = "Mã Sách";
            this.MASACH.Name = "MASACH";
            this.MASACH.ReadOnly = true;
            // 
            // TENSACH
            // 
            this.TENSACH.DataPropertyName = "TENSACH";
            this.TENSACH.HeaderText = "Tên Sách";
            this.TENSACH.Name = "TENSACH";
            this.TENSACH.ReadOnly = true;
            // 
            // TENTHELOAI
            // 
            this.TENTHELOAI.DataPropertyName = "TENTHELOAI";
            this.TENTHELOAI.HeaderText = "Tên thể loại";
            this.TENTHELOAI.Name = "TENTHELOAI";
            this.TENTHELOAI.ReadOnly = true;
            // 
            // VITRI
            // 
            this.VITRI.DataPropertyName = "MAVITRI";
            this.VITRI.HeaderText = "Vị Trí";
            this.VITRI.Name = "VITRI";
            this.VITRI.ReadOnly = true;
            // 
            // TENTACGIA
            // 
            this.TENTACGIA.DataPropertyName = "TENTACGIA";
            this.TENTACGIA.HeaderText = "Tên tác giả";
            this.TENTACGIA.Name = "TENTACGIA";
            this.TENTACGIA.ReadOnly = true;
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "TENNXB";
            this.TenNXB.HeaderText = "Tên nhà xuất bản";
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            // 
            // NAMXB
            // 
            this.NAMXB.DataPropertyName = "NAMXB";
            this.NAMXB.HeaderText = "Năm xuất bản";
            this.NAMXB.Name = "NAMXB";
            this.NAMXB.ReadOnly = true;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "Mô tả";
            this.MOTA.Name = "MOTA";
            this.MOTA.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số Lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // MANXB
            // 
            this.MANXB.DataPropertyName = "MANXB";
            this.MANXB.HeaderText = "Column1";
            this.MANXB.Name = "MANXB";
            this.MANXB.ReadOnly = true;
            this.MANXB.Visible = false;
            // 
            // MATHELOAI
            // 
            this.MATHELOAI.DataPropertyName = "MATHELOAI";
            this.MATHELOAI.HeaderText = "Column1";
            this.MATHELOAI.Name = "MATHELOAI";
            this.MATHELOAI.ReadOnly = true;
            this.MATHELOAI.Visible = false;
            // 
            // MATACGIA
            // 
            this.MATACGIA.DataPropertyName = "MATACGIA";
            this.MATACGIA.HeaderText = "Column1";
            this.MATACGIA.Name = "MATACGIA";
            this.MATACGIA.ReadOnly = true;
            this.MATACGIA.Visible = false;
            // 
            // MAVITRI
            // 
            this.MAVITRI.DataPropertyName = "MAVITRI";
            this.MAVITRI.HeaderText = "Column1";
            this.MAVITRI.Name = "MAVITRI";
            this.MAVITRI.ReadOnly = true;
            this.MAVITRI.Visible = false;
            // 
            // VT
            // 
            this.VT.HeaderText = "Column1";
            this.VT.Name = "VT";
            this.VT.ReadOnly = true;
            this.VT.Visible = false;
            // 
            // TACGIA
            // 
            this.TACGIA.HeaderText = "Column1";
            this.TACGIA.Name = "TACGIA";
            this.TACGIA.ReadOnly = true;
            this.TACGIA.Visible = false;
            // 
            // NHAXB
            // 
            this.NHAXB.HeaderText = "Column1";
            this.NHAXB.Name = "NHAXB";
            this.NHAXB.ReadOnly = true;
            this.NHAXB.Visible = false;
            // 
            // THELOAI
            // 
            this.THELOAI.HeaderText = "Column1";
            this.THELOAI.Name = "THELOAI";
            this.THELOAI.ReadOnly = true;
            this.THELOAI.Visible = false;
            // 
            // HINHANHSACH
            // 
            this.HINHANHSACH.DataPropertyName = "HINHANHSACH";
            this.HINHANHSACH.HeaderText = "Column1";
            this.HINHANHSACH.Name = "HINHANHSACH";
            this.HINHANHSACH.ReadOnly = true;
            this.HINHANHSACH.Visible = false;
            // 
            // fMuonTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fMuonTaiLieu";
            this.Text = "Mượn tài liệu";
            this.Load += new System.EventHandler(this.fMuonTaiLieu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMuon)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnMuon;
        private Bunifu.Framework.UI.BunifuImageButton btnXoa;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnThem;
        private System.Windows.Forms.ComboBox cboMaSV;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvDS;
        private System.Windows.Forms.DataGridViewImageColumn ImageSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTHELOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn VITRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATHELOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAVITRI;
        private System.Windows.Forms.DataGridViewTextBoxColumn VT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TACGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHAXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn THELOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHANHSACH;

    }
}