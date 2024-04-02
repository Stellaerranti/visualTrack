using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualTrack.Properties;

namespace VisualTrack
{
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();
        }



        private void options_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }

        private void SettingsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* switch (SettingsBox.SelectedIndex) 
            {
                case 0: label1.Text = Settings.Default.U_dimension.ToString(); break;
                case 1: label1.Text = Settings.Default.Ca_dimension.ToString(); break;
                case 2: label1.Text = Settings.Default.S.ToString(); break;
                case 3: label1.Text = Settings.Default.Tracks.ToString(); break;
            }*/


        }
    }
}
