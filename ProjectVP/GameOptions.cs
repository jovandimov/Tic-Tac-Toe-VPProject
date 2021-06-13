using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVP
{
    public partial class GameOptions : Form
    {
        public static string p1Name { get; set; }
        public static string p2Name { get; set; }
        public static Color c1;
        public static Color c2;
        public static int ptsWin;
        

        public GameOptions()
        {
            InitializeComponent();
            this.Icon = ProjectVP.Properties.Resources.tic_tac_toe_39453;
            color1.Text = "Black";
            color2.Text = "Black";
            c1 = Color.Black;
            c2 = Color.Black;

        }
      
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                p1Name = player1.Text;
                p2Name = player2.Text;
                ptsWin = (int)pointsWin.Value;
                MultiDimensional multiDimensional = new MultiDimensional(int.Parse(textBox1.Text));
                multiDimensional.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter a board size!");

               
            }
            
          
        }
        //validacija za ime na prv igrac
        private void player1_Validating(object sender, CancelEventArgs e)
        {
            if (player1.Text == "")
            {
                errorProvider1.SetError(player1, "The name is required!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(player1, null);
                e.Cancel = false;
            }
        }
        //validacija za ime na vtor igrac
        private void player2_Validating(object sender, CancelEventArgs e)
        {
            if (player2.Text == "")
            {
                errorProvider1.SetError(player2, "The name is required!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(player2, null);
                e.Cancel = false;
            }
        }
       
         
        //izbor na boja za prv igrac
        private void color1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (color1.SelectedIndex != -1)
            {
                switch (color1.SelectedIndex)
                {
                    case 0:
                        c1 = Color.Black;
                        break;

                    case 1:
                        c1 = Color.Red;
                        break;

                    case 2:
                        c1 = Color.Yellow;
                        break;

                    case 3:
                        c1 = Color.Green;
                        break;

                    case 4:
                        c1 = Color.Blue;
                        break;
                }
            }
        }

        //izbor na boja za vtor igrac
        private void color2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (color2.SelectedIndex != -1)
            {
                switch (color2.SelectedIndex)
                {
                    case 0:
                        c2 = Color.Black;
                        break;

                    case 1:
                        c2 = Color.Red;
                        break;

                    case 2:
                        c2 = Color.Yellow;
                        break;

                    case 3:
                        c2 = Color.Green;
                        break;

                    case 4:
                        c2 = Color.Blue;
                        break;
                }
            }
        }

     
    }
}

