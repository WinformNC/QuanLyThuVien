namespace QuanLyThuVien
{
    partial class fDanhSachSV
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
            this.dtgvSinhVien = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvSinhVien
            // 
            this.dtgvSinhVien.AllowUserToAddRows = false;
            this.dtgvSinhVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvSinhVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSinhVien.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSinhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSinhVien.DoubleBuffered = true;
            this.dtgvSinhVien.EnableHeadersVisualStyles = false;
            this.dtgvSinhVien.HeaderBgColor = System.Drawing.Color.White;
            this.dtgvSinhVien.HeaderForeColor = System.Drawing.Color.Black;
            this.dtgvSinhVien.Location = new System.Drawing.Point(0, 0);
            this.dtgvSinhVien.MultiSelect = false;
            this.dtgvSinhVien.Name = "dtgvSinhVien";
            this.dtgvSinhVien.ReadOnly = true;
            this.dtgvSinhVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSinhVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvSinhVien.RowTemplate.Height = 40;
            this.dtgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSinhVien.Size = new System.Drawing.Size(941, 685);
            this.dtgvSinhVien.TabIndex = 31;
            // 
            // fDanhSachSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 685);
            this.Controls.Add(this.dtgvSinhVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fDanhSachSV";
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.fDanhSachSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgvSinhVien;
    }
}