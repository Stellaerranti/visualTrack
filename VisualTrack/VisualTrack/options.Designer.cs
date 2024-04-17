namespace VisualTrack
{
    partial class options
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.standartDimBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dimTextBox = new System.Windows.Forms.TextBox();
            this.saveOptionsButton = new System.Windows.Forms.Button();
            this.SettingsBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SettingsBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 106);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.standartDimBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dimTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.saveOptionsButton, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(73, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(186, 96);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // standartDimBox
            // 
            this.standartDimBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standartDimBox.Items.AddRange(new object[] {
            "-",
            "ppm",
            "n"});
            this.standartDimBox.Location = new System.Drawing.Point(97, 5);
            this.standartDimBox.Name = "standartDimBox";
            this.standartDimBox.Size = new System.Drawing.Size(84, 21);
            this.standartDimBox.TabIndex = 3;
            this.standartDimBox.SelectedIndexChanged += new System.EventHandler(this.standartDimBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Standart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Manual";
            // 
            // dimTextBox
            // 
            this.dimTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dimTextBox.Location = new System.Drawing.Point(97, 36);
            this.dimTextBox.Name = "dimTextBox";
            this.dimTextBox.Size = new System.Drawing.Size(84, 20);
            this.dimTextBox.TabIndex = 4;
            // 
            // saveOptionsButton
            // 
            this.saveOptionsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveOptionsButton.Location = new System.Drawing.Point(97, 67);
            this.saveOptionsButton.Name = "saveOptionsButton";
            this.saveOptionsButton.Size = new System.Drawing.Size(84, 24);
            this.saveOptionsButton.TabIndex = 5;
            this.saveOptionsButton.Text = "Save";
            this.saveOptionsButton.UseVisualStyleBackColor = true;
            this.saveOptionsButton.Click += new System.EventHandler(this.saveOptionsButton_Click);
            // 
            // SettingsBox
            // 
            this.SettingsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsBox.FormattingEnabled = true;
            this.SettingsBox.Items.AddRange(new object[] {
            "U",
            "Ca",
            "S",
            "Tracks"});
            this.SettingsBox.Location = new System.Drawing.Point(5, 5);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(60, 96);
            this.SettingsBox.TabIndex = 2;
            this.SettingsBox.SelectedIndexChanged += new System.EventHandler(this.SettingsBox_SelectedIndexChanged);
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 106);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "options";
            this.Text = "options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.options_FormClosing);
            this.Load += new System.EventHandler(this.options_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox SettingsBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox standartDimBox;
        private System.Windows.Forms.TextBox dimTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveOptionsButton;
    }
}