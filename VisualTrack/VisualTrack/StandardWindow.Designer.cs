namespace VisualTrack
{
    partial class StandardWindow
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
            this.StandardListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StandardName = new System.Windows.Forms.TextBox();
            this.StandardAge = new System.Windows.Forms.TextBox();
            this.StandardErr = new System.Windows.Forms.TextBox();
            this.AddStandardbutton = new System.Windows.Forms.Button();
            this.DeleteStandardbutton = new System.Windows.Forms.Button();
            this.ModifyStandardbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.StandardListBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(472, 179);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StandardListBox
            // 
            this.StandardListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StandardListBox.FormattingEnabled = true;
            this.StandardListBox.Location = new System.Drawing.Point(3, 3);
            this.StandardListBox.Name = "StandardListBox";
            this.StandardListBox.Size = new System.Drawing.Size(135, 173);
            this.StandardListBox.TabIndex = 0;
            this.StandardListBox.SelectedIndexChanged += new System.EventHandler(this.StandardListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(144, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(325, 173);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.AddStandardbutton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DeleteStandardbutton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ModifyStandardbutton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 132);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(319, 38);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.StandardName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.StandardAge, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.StandardErr, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(319, 123);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age Err";
            // 
            // StandardName
            // 
            this.StandardName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StandardName.Location = new System.Drawing.Point(102, 6);
            this.StandardName.Name = "StandardName";
            this.StandardName.Size = new System.Drawing.Size(211, 20);
            this.StandardName.TabIndex = 3;
            // 
            // StandardAge
            // 
            this.StandardAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StandardAge.Location = new System.Drawing.Point(102, 45);
            this.StandardAge.Name = "StandardAge";
            this.StandardAge.Size = new System.Drawing.Size(211, 20);
            this.StandardAge.TabIndex = 4;
            // 
            // StandardErr
            // 
            this.StandardErr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StandardErr.Location = new System.Drawing.Point(102, 84);
            this.StandardErr.Name = "StandardErr";
            this.StandardErr.Size = new System.Drawing.Size(211, 20);
            this.StandardErr.TabIndex = 5;
            // 
            // AddStandardbutton
            // 
            this.AddStandardbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddStandardbutton.Location = new System.Drawing.Point(6, 6);
            this.AddStandardbutton.Name = "AddStandardbutton";
            this.AddStandardbutton.Size = new System.Drawing.Size(96, 26);
            this.AddStandardbutton.TabIndex = 0;
            this.AddStandardbutton.Text = "Add";
            this.AddStandardbutton.UseVisualStyleBackColor = true;
            this.AddStandardbutton.Click += new System.EventHandler(this.AddStandardbutton_Click);
            // 
            // DeleteStandardbutton
            // 
            this.DeleteStandardbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteStandardbutton.Location = new System.Drawing.Point(111, 6);
            this.DeleteStandardbutton.Name = "DeleteStandardbutton";
            this.DeleteStandardbutton.Size = new System.Drawing.Size(96, 26);
            this.DeleteStandardbutton.TabIndex = 1;
            this.DeleteStandardbutton.Text = "Delete";
            this.DeleteStandardbutton.UseVisualStyleBackColor = true;
            this.DeleteStandardbutton.Click += new System.EventHandler(this.DeleteStandardbutton_Click);
            // 
            // ModifyStandardbutton
            // 
            this.ModifyStandardbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModifyStandardbutton.Location = new System.Drawing.Point(216, 6);
            this.ModifyStandardbutton.Name = "ModifyStandardbutton";
            this.ModifyStandardbutton.Size = new System.Drawing.Size(97, 26);
            this.ModifyStandardbutton.TabIndex = 2;
            this.ModifyStandardbutton.Text = "Modify";
            this.ModifyStandardbutton.UseVisualStyleBackColor = true;
            // 
            // StandardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 179);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StandardWindow";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.StandardWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox StandardListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddStandardbutton;
        private System.Windows.Forms.Button DeleteStandardbutton;
        private System.Windows.Forms.Button ModifyStandardbutton;
        private System.Windows.Forms.TextBox StandardName;
        private System.Windows.Forms.TextBox StandardAge;
        private System.Windows.Forms.TextBox StandardErr;
    }
}