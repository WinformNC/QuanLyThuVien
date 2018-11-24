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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgv_DocGia = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MADG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.pnlDSTaiLieu = new System.Windows.Forms.FlowLayoutPanel();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DocGia)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.dtgv_DocGia, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDSTaiLieu, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 702);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtgv_DocGia
            // 
            this.dtgv_DocGia.AllowUserToAddRows = false;
            this.dtgv_DocGia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgv_DocGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_DocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_DocGia.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgv_DocGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_DocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_DocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_DocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MADG,
            this.TENDG});
            this.dtgv_DocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_DocGia.DoubleBuffered = true;
            this.dtgv_DocGia.EnableHeadersVisualStyles = false;
            this.dtgv_DocGia.HeaderBgColor = System.Drawing.Color.White;
            this.dtgv_DocGia.HeaderForeColor = System.Drawing.Color.Black;
            this.dtgv_DocGia.Location = new System.Drawing.Point(3, 72);
            this.dtgv_DocGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgv_DocGia.Name = "dtgv_DocGia";
            this.dtgv_DocGia.ReadOnly = true;
            this.dtgv_DocGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_DocGia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_DocGia.RowTemplate.Height = 24;
            this.dtgv_DocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_DocGia.Size = new System.Drawing.Size(289, 628);
            this.dtgv_DocGia.TabIndex = 36;
            this.dtgv_DocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_DocGia_CellClick);
            // 
            // MADG
            // 
            this.MADG.DataPropertyName = "MADG";
            this.MADG.HeaderText = "Mã độc giả";
            this.MADG.Name = "MADG";
            this.MADG.ReadOnly = true;
            // 
            // TENDG
            // 
            this.TENDG.DataPropertyName = "TENDG";
            this.TENDG.HeaderText = "Tên độc giả";
            this.TENDG.Name = "TENDG";
            this.TENDG.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(289, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách độc giả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(298, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 64);
            this.panel1.TabIndex = 35;
            // 
            // txtTimKiem
            // 
            this.behaviorManager1.SetBehaviors(this.txtTimKiem, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.FileIconBehavior.Create(typeof(DevExpress.XtraEditors.Behaviors.FileIconBehaviorSourceForTextEdit), DevExpress.Utils.Behaviors.Common.FileIconSize.Small, global::QuanLyThuVien.Properties.Resources.icons8_Search_16, null)))});
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTimKiem.EditValue = "";
            this.txtTimKiem.Location = new System.Drawing.Point(434, 0);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 22);
            this.txtTimKiem.TabIndex = 25;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // pnlDSTaiLieu
            // 
            this.pnlDSTaiLieu.AutoScroll = true;
            this.pnlDSTaiLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDSTaiLieu.Location = new System.Drawing.Point(298, 73);
            this.pnlDSTaiLieu.Name = "pnlDSTaiLieu";
            this.pnlDSTaiLieu.Size = new System.Drawing.Size(684, 626);
            this.pnlDSTaiLieu.TabIndex = 37;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DocGia)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgv_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MADG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENDG;
        private System.Windows.Forms.FlowLayoutPanel pnlDSTaiLieu;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;


    }
}