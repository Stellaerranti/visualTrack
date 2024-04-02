using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualTrack.Properties;

namespace VisualTrack
{
    public partial class options : Form
    {
        private readonly Form1 _form1;
        public options(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void options_Load(object sender, EventArgs e)
        {
            standartDimBox.SelectedIndex = 0;
        }

        private void options_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }

        private void SettingsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           standartDimBox.SelectedIndex = 0;

           switch (SettingsBox.SelectedIndex)
            {
                case 0: dimTextBox.Text = Settings.Default.U_dimension.ToString(); break;
                case 1: dimTextBox.Text = Settings.Default.Ca_dimension.ToString(); break;
                case 2: dimTextBox.Text = Settings.Default.S.ToString(); break;
                case 3: dimTextBox.Text = Settings.Default.Tracks.ToString(); break;
            }
        }

        private void standartDimBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(standartDimBox.SelectedIndex) 
            {
                case 1: dimTextBox.Text = (1000000).ToString(); break;
                case 2: dimTextBox.Text = (2000).ToString(); break;
            }
        }

        private void saveOptionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (SettingsBox.SelectedIndex)
                {
                    case 0: Settings.Default.U_dimension = Double.Parse(dimTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture); break;
                    case 1: Settings.Default.Ca_dimension = Double.Parse(dimTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture); break;
                    case 2: Settings.Default.S = Double.Parse(dimTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture); break;
                    case 3: Settings.Default.Tracks = Double.Parse(dimTextBox.Text, NumberStyles.Any, CultureInfo.InvariantCulture); break;
                }

                Settings.Default.Save();
                this._form1.optionsChanged();
            }
            catch { }
        }

       
    }
}
