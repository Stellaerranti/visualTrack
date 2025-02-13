using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualTrack
{

    public partial class StandardWindow: Form
    {
        public StandardWindow()
        {
            InitializeComponent();
        }

        private void StandardWindow_Load(object sender, EventArgs e)
        {
            LoadComboBoxItems();
        }

        private void LoadComboBoxItems()
        {
            // Load the data from the settings and populate the ComboBox
            string StandardData = string.Join(";", Properties.Settings.Default.StandartBoxItems.Cast<string>());

            // Split the string by semicolons to get each patient
            var items = StandardData.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            StandardListBox.Items.Clear(); // Clear old items
            StandardListBox.Items.AddRange(items.Select(item => item.Split(',')[0]).ToArray());
        }


    }   

    
}
