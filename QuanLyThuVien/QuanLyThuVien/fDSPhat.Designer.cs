namespace QuanLyThuVien
{
    partial class fDSPhat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgvDSPhat = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SINHVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDongPhat = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPhat)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtgvDSPhat, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDongPhat, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 574);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dtgvDSPhat
            // 
            this.dtgvDSPhat.AllowUserToAddRows = false;
            this.dtgvDSPhat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvDSPhat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvDSPhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDSPhat.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvDSPhat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDSPhat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSPhat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvDSPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSPhat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.SINHVIEN});
            this.dtgvDSPhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSPhat.DoubleBuffered = true;
            this.dtgvDSPhat.EnableHeadersVisualStyles = false;
            this.dtgvDSPhat.HeaderBgColor = System.Drawing.Color.White;
            this.dtgvDSPhat.HeaderForeColor = System.Drawing.Color.Black;
            this.dtgvDSPhat.Location = new System.Drawing.Point(3, 59);
            this.dtgvDSPhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvDSPhat.Name = "dtgvDSPhat";
            this.dtgvDSPhat.ReadOnly = true;
            this.dtgvDSPhat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSPhat.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvDSPhat.RowTemplate.Height = 24;
            this.dtgvDSPhat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSPhat.Size = new System.Drawing.Size(885, 513);
            this.dtgvDSPhat.TabIndex = 34;
            this.dtgvDSPhat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSPhat_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPHAT";
            this.Column1.HeaderText = "Mã phiếu phạt";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MASINHVIEN";
            this.Column2.HeaderText = "Mã sinh viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SOTIENPHAT";
            this.Column3.HeaderText = "Số tiền phạt";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LYDO";
            this.Column4.HeaderText = "Lý do";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // SINHVIEN
            // 
            this.SINHVIEN.DataPropertyName = "SINHVIEN";
            this.SINHVIEN.HeaderText = "Column5";
            this.SINHVIEN.Name = "SINHVIEN";
            this.SINHVIEN.ReadOnly = true;
            this.SINHVIEN.Visible = false;
            // 
            // btnDongPhat
            // 
            this.btnDongPhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDongPhat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnDongPhat.Location = new System.Drawing.Point(3, 27);
            this.btnDongPhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDongPhat.Name = "btnDongPhat";
            this.btnDongPhat.Size = new System.Drawing.Size(144, 28);
            this.btnDongPhat.TabIndex = 35;
            this.btnDongPhat.Text = "Đóng phạt";
            this.btnDongPhat.Click += new System.EventHandler(this.btnDongPhat_Click);
            // 
            // fDSPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 574);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fDSPhat";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSPhat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvDSPhat;
        private DevExpress.XtraEditors.SimpleButton btnDongPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SINHVIEN;



    }
}