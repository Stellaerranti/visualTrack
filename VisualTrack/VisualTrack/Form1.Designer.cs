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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ImportZeta = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripImport = new System.Windows.Forms.ToolStripButton();
            this.optiondButton = new System.Windows.Forms.ToolStripButton();
            this.ageImport = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
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
            this.yr1Text = new System.Windows.Forms.TextBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.DurangoAgeText = new System.Windows.Forms.TextBox();
            this.DurangoErrText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SlopeLabel = new System.Windows.Forms.Label();
            this.InterseptLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.zetaLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateZeta = new System.Windows.Forms.Button();
            this.zetaErrLabel = new System.Windows.Forms.Label();
            this.deleteRow = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.TestGrid = new System.Windows.Forms.DataGridView();
            this.rawUCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCaD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeGrid = new System.Windows.Forms.DataGridView();
            this.SampleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UstdDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CastdDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCaDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCastdDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiQi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiQistd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Zeta.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zetaTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UCaChart)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.age.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripImport,
            this.optiondButton,
            this.ageImport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1445, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripImport
            // 
            this.toolStripImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripImport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripImport.Image")));
            this.toolStripImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripImport.Name = "toolStripImport";
            this.toolStripImport.Size = new System.Drawing.Size(47, 22);
            this.toolStripImport.Text = "Import";
            this.toolStripImport.Click += new System.EventHandler(this.toolStripImport_Click);
            // 
            // optiondButton
            // 
            this.optiondButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.optiondButton.Image = ((System.Drawing.Image)(resources.GetObject("optiondButton.Image")));
            this.optiondButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optiondButton.Name = "optiondButton";
            this.optiondButton.Size = new System.Drawing.Size(53, 22);
            this.optiondButton.Text = "Options";
            this.optiondButton.Visible = false;
            this.optiondButton.Click += new System.EventHandler(this.optiondButton_Click);
            // 
            // ageImport
            // 
            this.ageImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ageImport.Image = ((System.Drawing.Image)(resources.GetObject("ageImport.Image")));
            this.ageImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ageImport.Name = "ageImport";
            this.ageImport.Size = new System.Drawing.Size(72, 22);
            this.ageImport.Text = "Import age ";
            this.ageImport.Click += new System.EventHandler(this.ageImport_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1445, 836);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Zeta);
            this.tabControl1.Controls.Add(this.age);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1439, 830);
            this.tabControl1.TabIndex = 1;
            // 
            // Zeta
            // 
            this.Zeta.Controls.Add(this.tableLayoutPanel1);
            this.Zeta.Location = new System.Drawing.Point(4, 22);
            this.Zeta.Name = "Zeta";
            this.Zeta.Padding = new System.Windows.Forms.Padding(3);
            this.Zeta.Size = new System.Drawing.Size(1431, 804);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1425, 798);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1205, 792);
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
            this.zetaTable.Location = new System.Drawing.Point(3, 399);
            this.zetaTable.Name = "zetaTable";
            this.zetaTable.RowHeadersVisible = false;
            this.zetaTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.zetaTable.Size = new System.Drawing.Size(1199, 390);
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
            this.UCaChart.Size = new System.Drawing.Size(1199, 390);
            this.UCaChart.TabIndex = 1;
            this.UCaChart.Text = "chart1";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.yr1Text, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.fileLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.DurangoAgeText, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.DurangoErrText, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.SlopeLabel, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.InterseptLabel, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.zetaLabel, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.label10, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.calculateZeta, 1, 10);
            this.tableLayoutPanel3.Controls.Add(this.zetaErrLabel, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.deleteRow, 0, 10);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1214, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.10581F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.10581F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.10581F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.10581F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.10581F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.10581F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.10581F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.10581F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.10581F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.023855F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.023855F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(208, 322);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // yr1Text
            // 
            this.yr1Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yr1Text.Location = new System.Drawing.Point(6, 93);
            this.yr1Text.Name = "yr1Text";
            this.yr1Text.Size = new System.Drawing.Size(93, 20);
            this.yr1Text.TabIndex = 22;
            this.yr1Text.Text = "0";
            this.yr1Text.TextChanged += new System.EventHandler(this.yr1Text_TextChanged);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileLabel.Location = new System.Drawing.Point(108, 3);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(94, 26);
            this.fileLabel.TabIndex = 3;
            this.fileLabel.Text = "-";
            // 
            // DurangoAgeText
            // 
            this.DurangoAgeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurangoAgeText.Location = new System.Drawing.Point(6, 35);
            this.DurangoAgeText.Name = "DurangoAgeText";
            this.DurangoAgeText.Size = new System.Drawing.Size(93, 20);
            this.DurangoAgeText.TabIndex = 4;
            this.DurangoAgeText.Text = "0";
            this.DurangoAgeText.TextChanged += new System.EventHandler(this.DurangoAgeText_TextChanged);
            // 
            // DurangoErrText
            // 
            this.DurangoErrText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurangoErrText.Location = new System.Drawing.Point(6, 64);
            this.DurangoErrText.Name = "DurangoErrText";
            this.DurangoErrText.Size = new System.Drawing.Size(93, 20);
            this.DurangoErrText.TabIndex = 5;
            this.DurangoErrText.Text = "0";
            this.DurangoErrText.TextChanged += new System.EventHandler(this.DurangoErrText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Durango age Ma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Durango Err";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "yr-1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Flattering";
            // 
            // SlopeLabel
            // 
            this.SlopeLabel.AutoSize = true;
            this.SlopeLabel.Location = new System.Drawing.Point(6, 148);
            this.SlopeLabel.Name = "SlopeLabel";
            this.SlopeLabel.Size = new System.Drawing.Size(10, 13);
            this.SlopeLabel.TabIndex = 11;
            this.SlopeLabel.Text = "-";
            // 
            // InterseptLabel
            // 
            this.InterseptLabel.AutoSize = true;
            this.InterseptLabel.Location = new System.Drawing.Point(6, 177);
            this.InterseptLabel.Name = "InterseptLabel";
            this.InterseptLabel.Size = new System.Drawing.Size(10, 13);
            this.InterseptLabel.TabIndex = 12;
            this.InterseptLabel.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Slope";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Intersept";
            // 
            // zetaLabel
            // 
            this.zetaLabel.AutoSize = true;
            this.zetaLabel.Location = new System.Drawing.Point(6, 235);
            this.zetaLabel.Name = "zetaLabel";
            this.zetaLabel.Size = new System.Drawing.Size(10, 13);
            this.zetaLabel.TabIndex = 15;
            this.zetaLabel.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Zeta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(108, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Zeta std";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "File:";
            // 
            // calculateZeta
            // 
            this.calculateZeta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculateZeta.Location = new System.Drawing.Point(108, 295);
            this.calculateZeta.Name = "calculateZeta";
            this.calculateZeta.Size = new System.Drawing.Size(94, 21);
            this.calculateZeta.TabIndex = 23;
            this.calculateZeta.Text = "Get Zeta";
            this.calculateZeta.UseVisualStyleBackColor = true;
            this.calculateZeta.Click += new System.EventHandler(this.calculateZeta_Click);
            // 
            // zetaErrLabel
            // 
            this.zetaErrLabel.AutoSize = true;
            this.zetaErrLabel.Location = new System.Drawing.Point(108, 119);
            this.zetaErrLabel.Name = "zetaErrLabel";
            this.zetaErrLabel.Size = new System.Drawing.Size(10, 13);
            this.zetaErrLabel.TabIndex = 17;
            this.zetaErrLabel.Text = "-";
            // 
            // deleteRow
            // 
            this.deleteRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteRow.Location = new System.Drawing.Point(6, 295);
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Size = new System.Drawing.Size(93, 21);
            this.deleteRow.TabIndex = 24;
            this.deleteRow.Text = "Delete row";
            this.deleteRow.UseVisualStyleBackColor = true;
            this.deleteRow.Click += new System.EventHandler(this.deleteRow_Click);
            // 
            // age
            // 
            this.age.Controls.Add(this.tableLayoutPanel5);
            this.age.Location = new System.Drawing.Point(4, 22);
            this.age.Name = "age";
            this.age.Padding = new System.Windows.Forms.Padding(3);
            this.age.Size = new System.Drawing.Size(1431, 804);
            this.age.TabIndex = 1;
            this.age.Text = "Age";
            this.age.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.Controls.Add(this.AgeGrid, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.TestGrid, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1425, 798);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // TestGrid
            // 
            this.TestGrid.AllowUserToAddRows = false;
            this.TestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rawUCa,
            this.UCaD,
            this.TestDur});
            this.TestGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestGrid.Location = new System.Drawing.Point(929, 402);
            this.TestGrid.Name = "TestGrid";
            this.TestGrid.RowHeadersVisible = false;
            this.TestGrid.Size = new System.Drawing.Size(279, 393);
            this.TestGrid.TabIndex = 5;
            // 
            // rawUCa
            // 
            this.rawUCa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rawUCa.HeaderText = "raw U/Ca";
            this.rawUCa.Name = "rawUCa";
            // 
            // UCaD
            // 
            this.UCaD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UCaD.HeaderText = "U/Ca";
            this.UCaD.Name = "UCaD";
            // 
            // TestDur
            // 
            this.TestDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TestDur.HeaderText = "Test";
            this.TestDur.Name = "TestDur";
            // 
            // AgeGrid
            // 
            this.AgeGrid.AllowUserToAddRows = false;
            this.AgeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SampleName,
            this.UDur,
            this.UstdDur,
            this.CaDur,
            this.CastdDur,
            this.UCaDur,
            this.UCastdDur,
            this.PiQi,
            this.PiQistd,
            this.FT,
            this.sigma});
            this.AgeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeGrid.Location = new System.Drawing.Point(3, 402);
            this.AgeGrid.Name = "AgeGrid";
            this.AgeGrid.RowHeadersVisible = false;
            this.AgeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AgeGrid.Size = new System.Drawing.Size(920, 393);
            this.AgeGrid.TabIndex = 6;
            // 
            // SampleName
            // 
            this.SampleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SampleName.HeaderText = "Name";
            this.SampleName.Name = "SampleName";
            // 
            // UDur
            // 
            this.UDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UDur.HeaderText = "U";
            this.UDur.Name = "UDur";
            // 
            // UstdDur
            // 
            this.UstdDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UstdDur.HeaderText = "Ustd";
            this.UstdDur.Name = "UstdDur";
            // 
            // CaDur
            // 
            this.CaDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CaDur.HeaderText = "Ca";
            this.CaDur.Name = "CaDur";
            // 
            // CastdDur
            // 
            this.CastdDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CastdDur.HeaderText = "Castd";
            this.CastdDur.Name = "CastdDur";
            // 
            // UCaDur
            // 
            this.UCaDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UCaDur.HeaderText = "U/Ca";
            this.UCaDur.Name = "UCaDur";
            // 
            // UCastdDur
            // 
            this.UCastdDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UCastdDur.HeaderText = "U/Ca std";
            this.UCastdDur.Name = "UCastdDur";
            // 
            // PiQi
            // 
            this.PiQi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PiQi.HeaderText = "PiQi";
            this.PiQi.Name = "PiQi";
            // 
            // PiQistd
            // 
            this.PiQistd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PiQistd.HeaderText = "PiQi std";
            this.PiQistd.Name = "PiQistd";
            // 
            // FT
            // 
            this.FT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FT.HeaderText = "FT";
            this.FT.Name = "FT";
            // 
            // sigma
            // 
            this.sigma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sigma.HeaderText = "2 sigma";
            this.sigma.Name = "sigma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 861);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = " VisualTrack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Zeta.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zetaTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UCaChart)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.age.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ImportZeta;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripImport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Zeta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView zetaTable;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart UCaChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TextBox DurangoAgeText;
        private System.Windows.Forms.TextBox DurangoErrText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SlopeLabel;
        private System.Windows.Forms.Label InterseptLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label zetaLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label zetaErrLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage age;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton optiondButton;
        private System.Windows.Forms.TextBox yr1Text;
        private System.Windows.Forms.Button calculateZeta;
        private System.Windows.Forms.Button deleteRow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ToolStripButton ageImport;
        private System.Windows.Forms.DataGridView TestGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawUCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCaD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestDur;
        private System.Windows.Forms.DataGridView AgeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SampleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn UstdDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn CastdDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCaDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCastdDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiQi;
        private System.Windows.Forms.DataGridViewTextBoxColumn PiQistd;
        private System.Windows.Forms.DataGridViewTextBoxColumn FT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigma;
    }
}

