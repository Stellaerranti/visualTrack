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
        private Form1 MainFormInstance;

        public StandardWindow(Form1 mainForm)
        {
            InitializeComponent();
            MainFormInstance = mainForm;
        }

        private void StandardWindow_Load(object sender, EventArgs e)
        {
            LoadComboBoxItems();
        }

        private void SaveStandards()
        {
            // Clear the current items in the StringCollection
            Properties.Settings.Default.StandartBoxItems.Clear();

            // Add each full standard (name, age, error) to the StringCollection
            foreach (var standard in standardMapping.Values)
            {
                Properties.Settings.Default.StandartBoxItems.Add(standard);
            }

            // Save the changes
            Properties.Settings.Default.Save();
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

        private void ClearInputs()
        {
            StandardName.Clear();
            StandardAge.Clear();
            StandardErr.Clear();
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
            string name = StandardName.Text;
            string ageText = StandardAge.Text;
            string errText = StandardErr.Text;

            // Validate inputs
            if (string.IsNullOrWhiteSpace(name) || !double.TryParse(ageText, out double age) || !double.TryParse(errText, out double err))
            {
                MessageBox.Show("Please enter valid values for Name, Age, and Error.");
                return;
            }

            // Add to dictionary and ListBox
            if (!standardMapping.ContainsKey(name)) // Avoid duplicate names
            {
                string fullData = $"{name},{age},{err}";
                standardMapping[name] = fullData;
                StandardListBox.Items.Add(name);  // Display only the name in the ListBox
            }
            else
            {
                MessageBox.Show("A standard with this name already exists.");
            }

            // Save to settings
            SaveStandards();
            ClearInputs();
            MainFormInstance.LoadComboBoxItems();
        }

        //Delete standard
        private void DeleteStandardbutton_Click(object sender, EventArgs e)
        {
            if (StandardListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a standard to delete.");
                return;
            }

            string selectedName = StandardListBox.SelectedItem.ToString();

            // Remove from dictionary and ListBox
            if (standardMapping.ContainsKey(selectedName))
            {
                standardMapping.Remove(selectedName);
                StandardListBox.Items.Remove(selectedName);
            }

            // Save to settings
            SaveStandards();
            MainFormInstance.LoadComboBoxItems();
        }

        private void ModifyStandardbutton_Click(object sender, EventArgs e)
        {
            if (StandardListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a standard to modify.");
                return;
            }

            string selectedName = StandardListBox.SelectedItem.ToString();

            // Validate input (similar to Add button)
            string ageText = StandardAge.Text;
            string errText = StandardErr.Text;

            if (string.IsNullOrWhiteSpace(selectedName) || !double.TryParse(ageText, out double age) || !double.TryParse(errText, out double err))
            {
                MessageBox.Show("Please enter valid values for Age and Error.");
                return;
            }

            // Update the dictionary with the modified data
            string modifiedStandard = $"{selectedName},{age},{err}";

            if (standardMapping.ContainsKey(selectedName))
            {
                // Replace the existing standard data with the modified one
                standardMapping[selectedName] = modifiedStandard;
            }

            // Update the ListBox to reflect the changes
            int selectedIndex = StandardListBox.SelectedIndex;
            StandardListBox.Items[selectedIndex] = selectedName; // Update the displayed name in ListBox

            // Save the updated data
            SaveStandards();
            ClearInputs();
            MainFormInstance.LoadComboBoxItems();
        }
    }   

    
}
