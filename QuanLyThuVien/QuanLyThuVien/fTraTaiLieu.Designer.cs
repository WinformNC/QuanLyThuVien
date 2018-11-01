namespace QuanLyThuVien
{
    partial class fTraTaiLieu
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
            this.dtgvMuon = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaoMat = new DevExpress.XtraEditors.SimpleButton();
            this.btnTra = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMuon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvMuon
            // 
            this.dtgvMuon.AllowUserToAddRows = false;
            this.dtgvMuon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvMuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMuon.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMuon.DoubleBuffered = true;
            this.dtgvMuon.EnableHeadersVisualStyles = false;
            this.dtgvMuon.HeaderBgColor = System.Drawing.Color.White;
            this.dtgvMuon.HeaderForeColor = System.Drawing.Color.Black;
            this.dtgvMuon.Location = new System.Drawing.Point(3, 72);
            this.dtgvMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvMuon.Name = "dtgvMuon";
            this.dtgvMuon.ReadOnly = true;
            this.dtgvMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvMuon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvMuon.RowTemplate.Height = 24;
            this.dtgvMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMuon.Size = new System.Drawing.Size(979, 628);
            this.dtgvMuon.TabIndex = 34;
            this.dtgvMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMuon_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtgvMuon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 702);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBaoMat);
            this.panel1.Controls.Add(this.btnTra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 64);
            this.panel1.TabIndex = 35;
            // 
            // btnBaoMat
            // 
            this.btnBaoMat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBaoMat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnBaoMat.Location = new System.Drawing.Point(183, 28);
            this.btnBaoMat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaoMat.Name = "btnBaoMat";
            this.btnBaoMat.Size = new System.Drawing.Size(168, 34);
            this.btnBaoMat.TabIndex = 37;
            this.btnBaoMat.Text = "Báo mất";
            this.btnBaoMat.Click += new System.EventHandler(this.btnBaoMat_Click);
            // 
            // btnTra
            // 
            this.btnTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTra.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnTra.Location = new System.Drawing.Point(9, 28);
            this.btnTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(168, 34);
            this.btnTra.TabIndex = 36;
            this.btnTra.Text = "Trả tài liệu";
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // fTraTaiLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 702);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTraTaiLieu";
            this.Text = "Trả tài liệu";
            this.Load += new System.EventHandler(this.fTraTaiLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMuon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvMuon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnTra;
        private DevExpress.XtraEditors.SimpleButton btnBaoMat;


    }
}