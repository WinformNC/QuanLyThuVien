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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgvDS = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dtgvMuon = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMuon = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new Bunifu.Framework.UI.BunifuImageButton();
            this.cboMaSV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 749);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtgvDS
            // 
            this.dtgvDS.AllowUserToAddRows = false;
            this.dtgvDS.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvDS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDS.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvDS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dtgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDS.DoubleBuffered = true;
            this.dtgvDS.EnableHeadersVisualStyles = false;
            this.dtgvDS.HeaderBgColor = System.Drawing.Color.White;
            this.dtgvDS.HeaderForeColor = System.Drawing.Color.Black;
            this.dtgvDS.Location = new System.Drawing.Point(3, 103);
            this.dtgvDS.MultiSelect = false;
            this.dtgvDS.Name = "dtgvDS";
            this.dtgvDS.ReadOnly = true;
            this.dtgvDS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDS.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgvDS.RowTemplate.Height = 24;
            this.dtgvDS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDS.Size = new System.Drawing.Size(966, 341);
            this.dtgvDS.TabIndex = 31;
            // 
            // dtgvMuon
            // 
            this.dtgvMuon.AllowUserToAddRows = false;
            this.dtgvMuon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvMuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgvMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMuon.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgvMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen});
            this.dtgvMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMuon.DoubleBuffered = true;
            this.dtgvMuon.EnableHeadersVisualStyles = false;
            this.dtgvMuon.HeaderBgColor = System.Drawing.Color.White;
            this.dtgvMuon.HeaderForeColor = System.Drawing.Color.Black;
            this.dtgvMuon.Location = new System.Drawing.Point(3, 520);
            this.dtgvMuon.MultiSelect = false;
            this.dtgvMuon.Name = "dtgvMuon";
            this.dtgvMuon.ReadOnly = true;
            this.dtgvMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMuon.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dtgvMuon.RowTemplate.Height = 24;
            this.dtgvMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMuon.Size = new System.Drawing.Size(966, 226);
            this.dtgvMuon.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMuon);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 64);
            this.panel1.TabIndex = 34;
            // 
            // btnMuon
            // 
            this.btnMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMuon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnMuon.Location = new System.Drawing.Point(789, 22);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(168, 35);
            this.btnMuon.TabIndex = 34;
            this.btnMuon.Text = "Lập phiếu mượn";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Image = global::QuanLyThuVien.Properties.Resources.Trash_Can_48px;
            this.btnXoa.ImageActive = null;
            this.btnXoa.Location = new System.Drawing.Point(16, 17);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(10, 30, 3, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(40, 40);
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
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 94);
            this.panel2.TabIndex = 35;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Image = global::QuanLyThuVien.Properties.Resources.icons8_Plus_Math_32;
            this.btnThem.ImageActive = null;
            this.btnThem.Location = new System.Drawing.Point(16, 51);
            this.btnThem.Margin = new System.Windows.Forms.Padding(10, 30, 3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(40, 40);
            this.btnThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThem.TabIndex = 34;
            this.btnThem.TabStop = false;
            this.btnThem.Zoom = 10;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboMaSV
            // 
            this.cboMaSV.FormattingEnabled = true;
            this.cboMaSV.Location = new System.Drawing.Point(101, 9);
            this.cboMaSV.Name = "cboMaSV";
            this.cboMaSV.Size = new System.Drawing.Size(176, 24);
            this.cboMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ảnh";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // fMuonTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvDS;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvMuon;
        private Bunifu.Framework.UI.BunifuImageButton btnXoa;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnMuon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaSV;
        private Bunifu.Framework.UI.BunifuImageButton btnThem;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
    }
}