using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        const int WIDTH = 20;
        const int HEIGHT = 20;
        const int DISTANCE = 30;

        GamePlay game = new GamePlay();

        private List<List<Button>> arr;

        public List<List<Button>> Arr
        {
            get { return arr; }
            set { arr = value; }
        }


        char ChessMan = 'O';

        public Form1()
        {
            InitializeComponent();

            initMap();
        }

        void initMap()
        {
            Arr = new List<List<Button>>();

            for (int i = 0; i < HEIGHT; i++)
            {
                Arr.Add(new List<Button>());
                for (int j = 0; j < WIDTH; j++)
                {
                    Button b = new Button();
                    b.Size = new Size(30, 30);
                    b.Location = new Point(j * DISTANCE, i * DISTANCE);
                    b.Font = new Font(SystemFonts.DefaultFont, FontStyle.Bold);
                    b.Click += b_Click;
                    this.Controls.Add(b);
                    Arr[i].Add(b);
                    b.Tag = i.ToString();
                }
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            

            if (((Button)sender).Text == "")
            {
                ((Button)sender).Text = ChessMan.ToString();
                if (game.isEndGame(arr, (Button)sender, Width, HEIGHT))
                {
                    MessageBox.Show(ChessMan + " Win !!!", "End Game !!!");
                }
                if (ChessMan == 'O')
                {
                    ChessMan = 'X';
                    ((Button)sender).ForeColor = Color.Green;
                }
                else
                {
                    ChessMan = 'O';
                    ((Button)sender).ForeColor = Color.Red;
                }
                
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    arr[i][j].Text = "";
                }
            }
        }

    }
}
