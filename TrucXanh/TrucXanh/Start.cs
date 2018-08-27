using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrucXanh
{
    public partial class Start : Form
    {
       
        public Start()
        {
            InitializeComponent();
        }


      
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text.Length == 0)
            {

                button1.Enabled = false;
                MessageBox.Show("Chưa nhập số cặp ảnh", "Thông báo  ", MessageBoxButtons.OK);

            }
            else
            {
                Form1 f = new Form1(int.Parse(textBox1.Text));
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
