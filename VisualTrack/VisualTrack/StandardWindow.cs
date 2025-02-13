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
        private Dictionary<string, string> standardMapping = new Dictionary<string, string>();
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
            StandardListBox.Items.Clear();
            standardMapping.Clear(); // Reset the dictionary

            var standardCollection = Properties.Settings.Default.StandartBoxItems;

            if (standardCollection != null && standardCollection.Count > 0)
            {
                // Iterate over the collection and split by semicolons
                foreach (var item in standardCollection)
                {
                    // Split by semicolon to get each standard (e.g., "Durango,31.44,0.18")
                    var items = item.ToString().Split(';');
                    foreach (var standard in items)
                    {
                        if (!string.IsNullOrWhiteSpace(standard))
                        {
                            // Split each standard by comma to separate Name, Value1, and Value2
                            string[] parts = standard.Split(',');
                            if (parts.Length == 3)
                            {
                                string name = parts[0]; // The name part
                                standardMapping[name] = standard; // Store the full standard
                                StandardListBox.Items.Add(name); // Only display the name
                            }
                        }
                    }
                }
            }
        }

        private void StandardListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StandardListBox.SelectedItem == null) return;

            string selectedName = StandardListBox.SelectedItem.ToString();
            //MessageBox.Show(selectedName);  // Display the selected name

            // Retrieve the full data from the dictionary using the name
            if (standardMapping.ContainsKey(selectedName))
            {
                string fullData = standardMapping[selectedName];  // "Durango,31.44,0.18"
                string[] parts = fullData.Split(',');

                if (parts.Length == 3)
                {
                    StandardName.Text = parts[0];  // Set name (Durango)
                    StandardAge.Text = parts[1];   // Set value1 (31.44)
                    StandardErr.Text = parts[2];   // Set value2 (0.18)
                }
            }
        }

        //Add new standard
        private void AddStandardbutton_Click(object sender, EventArgs e)
        {

        }

        //Delete standard
        private void DeleteStandardbutton_Click(object sender, EventArgs e)
        {

        }
    }   

    
}
