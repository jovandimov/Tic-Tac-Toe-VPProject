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
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
            this.BackgroundImage = ProjectVP.Properties.Resources.picture;
            this.Icon = ProjectVP.Properties.Resources.tic_tac_toe_39453;           
            
        }

       

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            GameOptions form = new GameOptions();
            form.ShowDialog();
            this.Close();
        }

        
    }
}
