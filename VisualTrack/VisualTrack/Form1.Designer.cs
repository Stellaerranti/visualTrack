namespace VisualTrack
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Zeta = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.zetaTable = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_std = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ca_std = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCastd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCaFlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCaFlatStd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zeta_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zeta_col_std = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ImportZeta = new System.Windows.Forms.OpenFileDialog();
            this.fileLabel = new System.Windows.Forms.Label();
            this.DurangoAgeText = new System.Windows.Forms.TextBox();
            this.DurangoErrText = new System.Windows.Forms.TextBox();
            this.yr1Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SlopeLabel = new System.Windows.Forms.Label();
            this.InterseptLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Zeta.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zetaTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UCaChart)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Zeta);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1445, 861);
            this.tabControl1.TabIndex = 0;
            // 
            // Zeta
            // 
            this.Zeta.Controls.Add(this.tableLayoutPanel1);
            this.Zeta.Location = new System.Drawing.Point(4, 22);
            this.Zeta.Name = "Zeta";
            this.Zeta.Padding = new System.Windows.Forms.Padding(3);
            this.Zeta.Size = new System.Drawing.Size(1437, 835);
            this.Zeta.TabIndex = 0;
            this.Zeta.Text = "Zeta";
            this.Zeta.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1431, 829);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.zetaTable, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.UCaChart, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1210, 823);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // zetaTable
            // 
            this.zetaTable.AllowUserToAddRows = false;
            this.zetaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zetaTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.U,
            this.U_std,
            this.Ca,
            this.Ca_std,
            this.Trs,
            this.S,
            this.UCa,
            this.UCastd,
            this.UCaFlat,
            this.UCaFlatStd,
            this.Zeta_Col,
            this.Zeta_col_std});
            this.zetaTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zetaTable.Location = new System.Drawing.Point(3, 414);
            this.zetaTable.Name = "zetaTable";
            this.zetaTable.RowHeadersVisible = false;
            this.zetaTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.zetaTable.Size = new System.Drawing.Size(1204, 406);
            this.zetaTable.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // U
            // 
            this.U.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.U.HeaderText = "U";
            this.U.Name = "U";
            // 
            // U_std
            // 
            this.U_std.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.U_std.HeaderText = "U std";
            this.U_std.Name = "U_std";
            // 
            // Ca
            // 
            this.Ca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ca.HeaderText = "Ca";
            this.Ca.Name = "Ca";
            // 
            // Ca_std
            // 
            this.Ca_std.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ca_std.HeaderText = "Ca std";
            this.Ca_std.Name = "Ca_std";
            // 
            // Trs
            // 
            this.Trs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trs.HeaderText = "Trs";
            this.Trs.Name = "Trs";
            // 
            // S
            // 
            this.S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.S.HeaderText = "S";
            this.S.Name = "S";
            // 
            // UCa
            // 
            this.UCa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UCa.HeaderText = "U/Ca";
            this.UCa.Name = "UCa";
            // 
            // UCastd
            // 
            this.UCastd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UCastd.HeaderText = "U/Ca std";
            this.UCastd.Name = "UCastd";
            // 
            // UCaFlat
            // 
            this.UCaFlat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UCaFlat.HeaderText = "U/Ca Flat";
            this.UCaFlat.Name = "UCaFlat";
            // 
            // UCaFlatStd
            // 
            this.UCaFlatStd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UCaFlatStd.HeaderText = "U/Ca Flat std";
            this.UCaFlatStd.Name = "UCaFlatStd";
            // 
            // Zeta_Col
            // 
            this.Zeta_Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Zeta_Col.HeaderText = "Zeta";
            this.Zeta_Col.Name = "Zeta_Col";
            // 
            // Zeta_col_std
            // 
            this.Zeta_col_std.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Zeta_col_std.HeaderText = "Zeta std";
            this.Zeta_col_std.Name = "Zeta_col_std";
            // 
            // UCaChart
            // 
            chartArea1.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position;
            chartArea1.AlignWithChartArea = "ChartArea2";
            chartArea1.Name = "ChartArea1";
            chartArea2.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position;
            chartArea2.BorderColor = System.Drawing.Color.Bisque;
            chartArea2.Name = "ChartArea2";
            this.UCaChart.ChartAreas.Add(chartArea1);
            this.UCaChart.ChartAreas.Add(chartArea2);
            this.UCaChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.UCaChart.Legends.Add(legend1);
            this.UCaChart.Location = new System.Drawing.Point(3, 3);
            this.UCaChart.Name = "UCaChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "UCaSeries";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
            series2.Legend = "Legend1";
            series2.Name = "UCaError";
            series2.YValuesPerPoint = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "FittingLine";
            series4.ChartArea = "ChartArea2";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.Name = "UCaFlat";
            series5.ChartArea = "ChartArea2";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
            series5.Legend = "Legend1";
            series5.Name = "UCaFlatError";
            series5.YValuesPerPoint = 3;
            this.UCaChart.Series.Add(series1);
            this.UCaChart.Series.Add(series2);
            this.UCaChart.Series.Add(series3);
            this.UCaChart.Series.Add(series4);
            this.UCaChart.Series.Add(series5);
            this.UCaChart.Size = new System.Drawing.Size(1204, 405);
            this.UCaChart.TabIndex = 1;
            this.UCaChart.Text = "chart1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.fileLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.DurangoAgeText, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.DurangoErrText, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.yr1Text, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.SlopeLabel, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.InterseptLabel, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1219, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.09082F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.09082F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.09082F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.09082F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.09082F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.09082F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.09082F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.09082F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.09082F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.182644F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(209, 355);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1576, 835);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(109, 3);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(10, 13);
            this.fileLabel.TabIndex = 3;
            this.fileLabel.Text = "-";
            // 
            // DurangoAgeText
            // 
            this.DurangoAgeText.Location = new System.Drawing.Point(6, 41);
            this.DurangoAgeText.Name = "DurangoAgeText";
            this.DurangoAgeText.Size = new System.Drawing.Size(94, 20);
            this.DurangoAgeText.TabIndex = 4;
            this.DurangoAgeText.Text = "0";
            // 
            // DurangoErrText
            // 
            this.DurangoErrText.Location = new System.Drawing.Point(6, 76);
            this.DurangoErrText.Name = "DurangoErrText";
            this.DurangoErrText.Size = new System.Drawing.Size(94, 20);
            this.DurangoErrText.TabIndex = 5;
            this.DurangoErrText.Text = "0";
            // 
            // yr1Text
            // 
            this.yr1Text.Location = new System.Drawing.Point(6, 111);
            this.yr1Text.Name = "yr1Text";
            this.yr1Text.Size = new System.Drawing.Size(94, 20);
            this.yr1Text.TabIndex = 6;
            this.yr1Text.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Durango age Ma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Durango Err";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "yr-1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Flattering";
            // 
            // SlopeLabel
            // 
            this.SlopeLabel.AutoSize = true;
            this.SlopeLabel.Location = new System.Drawing.Point(6, 178);
            this.SlopeLabel.Name = "SlopeLabel";
            this.SlopeLabel.Size = new System.Drawing.Size(10, 13);
            this.SlopeLabel.TabIndex = 11;
            this.SlopeLabel.Text = "-";
            // 
            // InterseptLabel
            // 
            this.InterseptLabel.AutoSize = true;
            this.InterseptLabel.Location = new System.Drawing.Point(6, 213);
            this.InterseptLabel.Name = "InterseptLabel";
            this.InterseptLabel.Size = new System.Drawing.Size(10, 13);
            this.InterseptLabel.TabIndex = 12;
            this.InterseptLabel.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Slope";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Intersept";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 861);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = " VisualTrack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Zeta.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zetaTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UCaChart)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Zeta;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog ImportZeta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart UCaChart;
        private System.Windows.Forms.DataGridView zetaTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn U;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_std;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ca_std;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trs;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCastd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCaFlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCaFlatStd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeta_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zeta_col_std;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TextBox DurangoAgeText;
        private System.Windows.Forms.TextBox DurangoErrText;
        private System.Windows.Forms.TextBox yr1Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SlopeLabel;
        private System.Windows.Forms.Label InterseptLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

