namespace QuanLyThuVien
{
    partial class fTheLoai
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgvTL = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaiLai = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.groupProp = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTL)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtgvTL, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.layoutControl1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 585);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // dtgvTL
            // 
            this.dtgvTL.AllowUserToAddRows = false;
            this.dtgvTL.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvTL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTL.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvTL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTL.DoubleBuffered = true;
            this.dtgvTL.EnableHeadersVisualStyles = false;
            this.dtgvTL.HeaderBgColor = System.Drawing.Color.White;
            this.dtgvTL.HeaderForeColor = System.Drawing.Color.Black;
            this.dtgvTL.Location = new System.Drawing.Point(3, 174);
            this.dtgvTL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvTL.MultiSelect = false;
            this.dtgvTL.Name = "dtgvTL";
            this.dtgvTL.ReadOnly = true;
            this.dtgvTL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTL.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTL.RowTemplate.Height = 24;
            this.dtgvTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTL.Size = new System.Drawing.Size(869, 409);
            this.dtgvTL.TabIndex = 18;
            this.dtgvTL.Click += new System.EventHandler(this.dtgvTL_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnLuu, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnHuy, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSua, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnXoa, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTaiLai, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtTimKiem, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(869, 45);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // btnLuu
            // 
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.Enabled = false;
            this.btnLuu.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Ok_32;
            this.btnLuu.Location = new System.Drawing.Point(367, 2);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 41);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuy.Enabled = false;
            this.btnHuy.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Cancel_32;
            this.btnHuy.Location = new System.Drawing.Point(276, 2);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 41);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Edit_32;
            this.btnSua.Location = new System.Drawing.Point(185, 2);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 41);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Minus_32;
            this.btnXoa.Location = new System.Drawing.Point(94, 2);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 41);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Plus_32;
            this.btnThem.Location = new System.Drawing.Point(3, 2);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 41);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnTaiLai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTaiLai.Enabled = false;
            this.btnTaiLai.ImageOptions.Image = global::QuanLyThuVien.Properties.Resources.icons8_Refresh_32;
            this.btnTaiLai.Location = new System.Drawing.Point(457, 2);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(85, 41);
            this.btnTaiLai.TabIndex = 22;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // txtTimKiem
            // 
            this.behaviorManager1.SetBehaviors(this.txtTimKiem, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.FileIconBehavior.Create(typeof(DevExpress.XtraEditors.Behaviors.FileIconBehaviorSourceForTextEdit), DevExpress.Utils.Behaviors.Common.FileIconSize.Small, global::QuanLyThuVien.Properties.Resources.icons8_Search_16, null)))});
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTimKiem.EditValue = "";
            this.txtTimKiem.Location = new System.Drawing.Point(652, 2);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(214, 20);
            this.txtTimKiem.TabIndex = 24;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtTen);
            this.layoutControl1.Controls.Add(this.txtMa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 51);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.groupProp;
            this.layoutControl1.Size = new System.Drawing.Size(869, 119);
            this.layoutControl1.TabIndex = 17;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtTen
            // 
            this.txtTen.EditValue = "";
            this.txtTen.Location = new System.Drawing.Point(497, 12);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(360, 20);
            this.txtTen.StyleController = this.layoutControl1;
            this.txtTen.TabIndex = 15;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(72, 12);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(361, 20);
            this.txtMa.StyleController = this.layoutControl1;
            this.txtMa.TabIndex = 14;
            // 
            // groupProp
            // 
            this.groupProp.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.groupProp.GroupBordersVisible = false;
            this.groupProp.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.groupProp.Location = new System.Drawing.Point(0, 0);
            this.groupProp.Name = "Root";
            this.groupProp.OptionsItemText.TextToControlDistance = 4;
            this.groupProp.Size = new System.Drawing.Size(869, 119);
            this.groupProp.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMa;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(425, 99);
            this.layoutControlItem1.Text = "Mã thể loại";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(56, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTen;
            this.layoutControlItem2.Location = new System.Drawing.Point(425, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(424, 99);
            this.layoutControlItem2.Text = "Tên thể loại";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(56, 13);
            // 
            // fTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTheLoai";
            this.Text = "Danh sách thể loại";
            this.Load += new System.EventHandler(this.fTheLoai_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTL)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupProp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnTaiLai;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
        private DevExpress.XtraLayout.LayoutControlGroup groupProp;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvTL;
    }
}