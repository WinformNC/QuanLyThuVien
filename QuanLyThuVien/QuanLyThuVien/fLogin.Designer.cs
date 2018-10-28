namespace QuanLyThuVien
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.loginFrom1 = new Login.LoginFrom();
            this.SuspendLayout();
            // 
            // loginFrom1
            // 
            this.loginFrom1.BackgroundImage = global::QuanLyThuVien.Properties.Resources.bg3;
            this.loginFrom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginFrom1.Location = new System.Drawing.Point(5, 4);
            this.loginFrom1.Name = "loginFrom1";
            this.loginFrom1.Size = new System.Drawing.Size(713, 386);
            this.loginFrom1.TabIndex = 0;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::QuanLyThuVien.Properties.Resources.bg3;
            this.ClientSize = new System.Drawing.Size(713, 386);
            this.Controls.Add(this.loginFrom1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Login.LoginFrom loginFrom1;




    }
}