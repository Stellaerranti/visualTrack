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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ImportZeta = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.importZetaFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTestFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSampleFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiondButton = new System.Windows.Forms.ToolStripButton();
            this.ImportZetafileButton = new System.Windows.Forms.ToolStripButton();
            this.ImportTestFileButton = new System.Windows.Forms.ToolStripButton();
            this.ImportSamplefileButton = new System.Windows.Forms.ToolStripButton();
            this.ClearButton = new System.Windows.Forms.ToolStripButton();
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
            this.deleteRow = new System.Windows.Forms.Button();
            this.zetaErrLabel = new System.Windows.Forms.Label();
            this.Zeta_test = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.TestGrid = new System.Windows.Forms.DataGridView();
            this.Ntest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawUCaTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UstdTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CastdTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCaTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCastdTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConvUCaTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.TestFileLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.RawTestLabel = new System.Windows.Forms.Label();
            this.UCaTestLabel = new System.Windows.Forms.Label();
            this.ConvFactorLabel = new System.Windows.Forms.Label();
            this.TestLabel = new System.Windows.Forms.Label();
            this.TestStdLabel = new System.Windows.Forms.Label();
            this.ConvStdLabel = new System.Windows.Forms.Label();
            this.conductTestButton = new System.Windows.Forms.Button();
            this.DeleteRowTestGrid = new System.Windows.Forms.Button();
            this.Age = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.AgeGrid = new System.Windows.Forms.DataGridView();
            this.SampleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UstdDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CastdDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCaDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UCastdDur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weighted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weightedstd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.FileSampleLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.ZetaAgeLabel = new System.Windows.Forms.Label();
            this.ZetaStdAgeLAbel = new System.Windows.Forms.Label();
            this.PWLabel = new System.Windows.Forms.Label();
            this.PWStdLabel = new System.Windows.Forms.Label();
            this.GrainsLabel = new System.Windows.Forms.Label();
            this.NsLabel = new System.Windows.Forms.Label();
            this.PooledAgeLabel = new System.Windows.Forms.Label();
            this.AgeStdLabel = new System.Windows.Forms.Label();
            this.ChiLabel = new System.Windows.Forms.Label();
            this.PLabel = new System.Windows.Forms.Label();
            this.DeleteRowAgeGrid = new System.Windows.Forms.Button();
            this.poolAgeButton = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.CentralAgeLabel = new System.Windows.Forms.Label();
            this.ImportTest = new System.Windows.Forms.OpenFileDialog();
            this.ImportSample = new System.Windows.Forms.OpenFileDialog();
            this.CentralAgeSTDLabel = new System.Windows.Forms.Label();
            this.CentralAgeDispLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Zeta.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zetaTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UCaChart)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.Zeta_test.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestGrid)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.Age.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeGrid)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.optiondButton,
            this.ImportZetafileButton,
            this.ImportTestFileButton,
            this.ImportSamplefileButton,
            this.ClearButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1445, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importZetaFileToolStripMenuItem,
            this.importTestFileToolStripMenuItem,
            this.importSampleFileToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            this.toolStripDropDownButton1.Visible = false;
            // 
            // importZetaFileToolStripMenuItem
            // 
            this.importZetaFileToolStripMenuItem.Name = "importZetaFileToolStripMenuItem";
            this.importZetaFileToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.importZetaFileToolStripMenuItem.Text = "Import Zeta file";
            this.importZetaFileToolStripMenuItem.Click += new System.EventHandler(this.importZetaFileToolStripMenuItem_Click);
            // 
            // importTestFileToolStripMenuItem
            // 
            this.importTestFileToolStripMenuItem.Name = "importTestFileToolStripMenuItem";
            this.importTestFileToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.importTestFileToolStripMenuItem.Text = "Import test file";
            this.importTestFileToolStripMenuItem.Click += new System.EventHandler(this.importTestFileToolStripMenuItem_Click);
            // 
            // importSampleFileToolStripMenuItem
            // 
            this.importSampleFileToolStripMenuItem.Name = "importSampleFileToolStripMenuItem";
            this.importSampleFileToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.importSampleFileToolStripMenuItem.Text = "Import sample file";
            this.importSampleFileToolStripMenuItem.Click += new System.EventHandler(this.importSampleFileToolStripMenuItem_Click);
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
            // ImportZetafileButton
            // 
            this.ImportZetafileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ImportZetafileButton.Image = ((System.Drawing.Image)(resources.GetObject("ImportZetafileButton.Image")));
            this.ImportZetafileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImportZetafileButton.Name = "ImportZetafileButton";
            this.ImportZetafileButton.Size = new System.Drawing.Size(92, 22);
            this.ImportZetafileButton.Text = "Import Zeta file";
            this.ImportZetafileButton.Click += new System.EventHandler(this.ImportZetafileButton_Click);
            // 
            // ImportTestFileButton
            // 
            this.ImportTestFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ImportTestFileButton.Image = ((System.Drawing.Image)(resources.GetObject("ImportTestFileButton.Image")));
            this.ImportTestFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImportTestFileButton.Name = "ImportTestFileButton";
            this.ImportTestFileButton.Size = new System.Drawing.Size(88, 22);
            this.ImportTestFileButton.Text = "Import test file";
            this.ImportTestFileButton.Click += new System.EventHandler(this.ImportTestFileButton_Click);
            // 
            // ImportSamplefileButton
            // 
            this.ImportSamplefileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ImportSamplefileButton.Image = ((System.Drawing.Image)(resources.GetObject("ImportSamplefileButton.Image")));
            this.ImportSamplefileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImportSamplefileButton.Name = "ImportSamplefileButton";
            this.ImportSamplefileButton.Size = new System.Drawing.Size(107, 22);
            this.ImportSamplefileButton.Text = "Import sample file";
            this.ImportSamplefileButton.Click += new System.EventHandler(this.ImportSamplefileButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(38, 22);
            this.ClearButton.Text = "Clear";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
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
            this.tabControl1.Controls.Add(this.Zeta_test);
            this.tabControl1.Controls.Add(this.Age);
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
            this.zetaTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.zetaTable_CellEndEdit);
            this.zetaTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.zetaTable_CellValueChanged);
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
            this.U.HeaderText = "U, ppm";
            this.U.Name = "U";
            // 
            // U_std
            // 
            this.U_std.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.U_std.HeaderText = "U SE";
            this.U_std.Name = "U_std";
            // 
            // Ca
            // 
            this.Ca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ca.HeaderText = "Ca, ppm";
            this.Ca.Name = "Ca";
            // 
            // Ca_std
            // 
            this.Ca_std.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ca_std.HeaderText = "Ca SE";
            this.Ca_std.Name = "Ca_std";
            // 
            // Trs
            // 
            this.Trs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trs.HeaderText = "Ns";
            this.Trs.Name = "Trs";
            // 
            // S
            // 
            this.S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.S.HeaderText = "S, cm^2";
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
            this.UCastd.HeaderText = "U/Ca SE";
            this.UCastd.Name = "UCastd";
            // 
            // UCaFlat
            // 
            this.UCaFlat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UCaFlat.HeaderText = "U/Ca corrected";
            this.UCaFlat.Name = "UCaFlat";
            // 
            // UCaFlatStd
            // 
            this.UCaFlatStd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UCaFlatStd.HeaderText = "U/Ca Flat corrected SE";
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
            this.Zeta_col_std.HeaderText = "Zeta SE";
            this.Zeta_col_std.Name = "Zeta_col_std";
            // 
            // UCaChart
            // 
            chartArea3.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position;
            chartArea3.AlignWithChartArea = "ChartArea2";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.Name = "ChartArea1";
            chartArea4.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position;
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.BorderColor = System.Drawing.Color.Bisque;
            chartArea4.Name = "ChartArea2";
            this.UCaChart.ChartAreas.Add(chartArea3);
            this.UCaChart.ChartAreas.Add(chartArea4);
            this.UCaChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.UCaChart.Legends.Add(legend2);
            this.UCaChart.Location = new System.Drawing.Point(3, 3);
            this.UCaChart.Name = "UCaChart";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Legend = "Legend1";
            series6.Name = "UCaSeries";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
            series7.Legend = "Legend1";
            series7.Name = "UCaError";
            series7.YValuesPerPoint = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "FittingLine";
            series9.ChartArea = "ChartArea2";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Legend = "Legend1";
            series9.Name = "UCaFlat";
            series10.ChartArea = "ChartArea2";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
            series10.Legend = "Legend1";
            series10.Name = "UCaFlatError";
            series10.YValuesPerPoint = 3;
            this.UCaChart.Series.Add(series6);
            this.UCaChart.Series.Add(series7);
            this.UCaChart.Series.Add(series8);
            this.UCaChart.Series.Add(series9);
            this.UCaChart.Series.Add(series10);
            this.UCaChart.Size = new System.Drawing.Size(1199, 390);
            this.UCaChart.TabIndex = 1;
            this.UCaChart.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "BeforeDriftTitle";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "AfterDriftTitle";
            this.UCaChart.Titles.Add(title3);
            this.UCaChart.Titles.Add(title4);
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
            this.tableLayoutPanel3.Controls.Add(this.deleteRow, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.zetaErrLabel, 0, 9);
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.yr1Text.Text = "1.55E-10";
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
            this.DurangoAgeText.Text = "31.44";
            this.DurangoAgeText.TextChanged += new System.EventHandler(this.DurangoAgeText_TextChanged);
            // 
            // DurangoErrText
            // 
            this.DurangoErrText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurangoErrText.Location = new System.Drawing.Point(6, 64);
            this.DurangoErrText.Name = "DurangoErrText";
            this.DurangoErrText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DurangoErrText.Size = new System.Drawing.Size(93, 20);
            this.DurangoErrText.TabIndex = 5;
            this.DurangoErrText.Text = "0.18";
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
            // zetaErrLabel
            // 
            this.zetaErrLabel.AutoSize = true;
            this.zetaErrLabel.Location = new System.Drawing.Point(6, 264);
            this.zetaErrLabel.Name = "zetaErrLabel";
            this.zetaErrLabel.Size = new System.Drawing.Size(10, 13);
            this.zetaErrLabel.TabIndex = 17;
            this.zetaErrLabel.Text = "-";
            // 
            // Zeta_test
            // 
            this.Zeta_test.Controls.Add(this.tableLayoutPanel8);
            this.Zeta_test.Location = new System.Drawing.Point(4, 22);
            this.Zeta_test.Name = "Zeta_test";
            this.Zeta_test.Size = new System.Drawing.Size(1431, 804);
            this.Zeta_test.TabIndex = 2;
            this.Zeta_test.Text = "Zeta test";
            this.Zeta_test.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel8.Controls.Add(this.TestGrid, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1431, 804);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // TestGrid
            // 
            this.TestGrid.AllowUserToAddRows = false;
            this.TestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ntest,
            this.rawUCaTest,
            this.UTest,
            this.UstdTest,
            this.CaTest,
            this.CastdTest,
            this.UCaTest,
            this.UCastdTest,
            this.ConvUCaTest,
            this.TestDur});
            this.TestGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestGrid.Location = new System.Drawing.Point(3, 3);
            this.TestGrid.Name = "TestGrid";
            this.TestGrid.RowHeadersVisible = false;
            this.tableLayoutPanel8.SetRowSpan(this.TestGrid, 2);
            this.TestGrid.Size = new System.Drawing.Size(1210, 798);
            this.TestGrid.TabIndex = 6;
            this.TestGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TestGrid_CellEndEdit);
            this.TestGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TestGrid_CellValueChanged);
            // 
            // Ntest
            // 
            this.Ntest.HeaderText = "N";
            this.Ntest.Name = "Ntest";
            // 
            // rawUCaTest
            // 
            this.rawUCaTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rawUCaTest.HeaderText = "raw U/Ca";
            this.rawUCaTest.Name = "rawUCaTest";
            // 
            // UTest
            // 
            this.UTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UTest.HeaderText = "U, ppm";
            this.UTest.Name = "UTest";
            // 
            // UstdTest
            // 
            this.UstdTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UstdTest.HeaderText = "U SE";
            this.UstdTest.Name = "UstdTest";
            // 
            // CaTest
            // 
            this.CaTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CaTest.HeaderText = "Ca, ppm";
            this.CaTest.Name = "CaTest";
            // 
            // CastdTest
            // 
            this.CastdTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CastdTest.HeaderText = "Ca SE";
            this.CastdTest.Name = "CastdTest";
            // 
            // UCaTest
            // 
            this.UCaTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UCaTest.HeaderText = "U/Ca";
            this.UCaTest.Name = "UCaTest";
            // 
            // UCastdTest
            // 
            this.UCastdTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UCastdTest.HeaderText = "U/Ca SE";
            this.UCastdTest.Name = "UCastdTest";
            // 
            // ConvUCaTest
            // 
            this.ConvUCaTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConvUCaTest.HeaderText = "Conv U/Ca";
            this.ConvUCaTest.Name = "ConvUCaTest";
            // 
            // TestDur
            // 
            this.TestDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TestDur.HeaderText = "Test";
            this.TestDur.Name = "TestDur";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.TestFileLabel, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.label16, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.label17, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.RawTestLabel, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.UCaTestLabel, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.ConvFactorLabel, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.TestLabel, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.TestStdLabel, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.ConvStdLabel, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.conductTestButton, 1, 7);
            this.tableLayoutPanel6.Controls.Add(this.DeleteRowTestGrid, 0, 7);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(1219, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 8;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(209, 240);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "File:";
            // 
            // TestFileLabel
            // 
            this.TestFileLabel.AutoSize = true;
            this.TestFileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestFileLabel.Location = new System.Drawing.Point(109, 3);
            this.TestFileLabel.Name = "TestFileLabel";
            this.TestFileLabel.Size = new System.Drawing.Size(94, 26);
            this.TestFileLabel.TabIndex = 1;
            this.TestFileLabel.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Raw U/Ca";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(6, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 26);
            this.label12.TabIndex = 3;
            this.label12.Text = "U/Ca";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(6, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 26);
            this.label13.TabIndex = 4;
            this.label13.Text = "Conversion factor";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(6, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 26);
            this.label14.TabIndex = 5;
            this.label14.Text = "2SD";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(6, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 26);
            this.label16.TabIndex = 7;
            this.label16.Text = "Test";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(6, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 26);
            this.label17.TabIndex = 8;
            this.label17.Text = "2SD";
            // 
            // RawTestLabel
            // 
            this.RawTestLabel.AutoSize = true;
            this.RawTestLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RawTestLabel.Location = new System.Drawing.Point(109, 32);
            this.RawTestLabel.Name = "RawTestLabel";
            this.RawTestLabel.Size = new System.Drawing.Size(94, 26);
            this.RawTestLabel.TabIndex = 9;
            this.RawTestLabel.Text = "-";
            // 
            // UCaTestLabel
            // 
            this.UCaTestLabel.AutoSize = true;
            this.UCaTestLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UCaTestLabel.Location = new System.Drawing.Point(109, 61);
            this.UCaTestLabel.Name = "UCaTestLabel";
            this.UCaTestLabel.Size = new System.Drawing.Size(94, 26);
            this.UCaTestLabel.TabIndex = 10;
            this.UCaTestLabel.Text = "-";
            // 
            // ConvFactorLabel
            // 
            this.ConvFactorLabel.AutoSize = true;
            this.ConvFactorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvFactorLabel.Location = new System.Drawing.Point(109, 90);
            this.ConvFactorLabel.Name = "ConvFactorLabel";
            this.ConvFactorLabel.Size = new System.Drawing.Size(94, 26);
            this.ConvFactorLabel.TabIndex = 11;
            this.ConvFactorLabel.Text = "-";
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestLabel.Location = new System.Drawing.Point(109, 148);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(94, 26);
            this.TestLabel.TabIndex = 12;
            this.TestLabel.Text = "-";
            // 
            // TestStdLabel
            // 
            this.TestStdLabel.AutoSize = true;
            this.TestStdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestStdLabel.Location = new System.Drawing.Point(109, 177);
            this.TestStdLabel.Name = "TestStdLabel";
            this.TestStdLabel.Size = new System.Drawing.Size(94, 26);
            this.TestStdLabel.TabIndex = 13;
            this.TestStdLabel.Text = "-";
            // 
            // ConvStdLabel
            // 
            this.ConvStdLabel.AutoSize = true;
            this.ConvStdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvStdLabel.Location = new System.Drawing.Point(109, 119);
            this.ConvStdLabel.Name = "ConvStdLabel";
            this.ConvStdLabel.Size = new System.Drawing.Size(94, 26);
            this.ConvStdLabel.TabIndex = 14;
            this.ConvStdLabel.Text = "-";
            // 
            // conductTestButton
            // 
            this.conductTestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conductTestButton.Location = new System.Drawing.Point(109, 209);
            this.conductTestButton.Name = "conductTestButton";
            this.conductTestButton.Size = new System.Drawing.Size(94, 25);
            this.conductTestButton.TabIndex = 15;
            this.conductTestButton.Text = "Test";
            this.conductTestButton.UseVisualStyleBackColor = true;
            this.conductTestButton.Click += new System.EventHandler(this.conductTestButton_Click);
            // 
            // DeleteRowTestGrid
            // 
            this.DeleteRowTestGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteRowTestGrid.Location = new System.Drawing.Point(6, 209);
            this.DeleteRowTestGrid.Name = "DeleteRowTestGrid";
            this.DeleteRowTestGrid.Size = new System.Drawing.Size(94, 25);
            this.DeleteRowTestGrid.TabIndex = 16;
            this.DeleteRowTestGrid.Text = "delete row";
            this.DeleteRowTestGrid.UseVisualStyleBackColor = true;
            this.DeleteRowTestGrid.Click += new System.EventHandler(this.DeleteRowTestGrid_Click);
            // 
            // Age
            // 
            this.Age.Controls.Add(this.tableLayoutPanel9);
            this.Age.Location = new System.Drawing.Point(4, 22);
            this.Age.Name = "Age";
            this.Age.Padding = new System.Windows.Forms.Padding(3);
            this.Age.Size = new System.Drawing.Size(1431, 804);
            this.Age.TabIndex = 3;
            this.Age.Text = "Age";
            this.Age.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel9.Controls.Add(this.AgeGrid, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1425, 798);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // AgeGrid
            // 
            this.AgeGrid.AllowUserToAddRows = false;
            this.AgeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SampleName,
            this.NAge,
            this.SAge,
            this.UDur,
            this.UstdDur,
            this.CaDur,
            this.CastdDur,
            this.UCaDur,
            this.UCastdDur,
            this.Weighted,
            this.Weightedstd,
            this.FT,
            this.sigma});
            this.AgeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeGrid.Location = new System.Drawing.Point(3, 3);
            this.AgeGrid.Name = "AgeGrid";
            this.AgeGrid.RowHeadersVisible = false;
            this.AgeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableLayoutPanel9.SetRowSpan(this.AgeGrid, 2);
            this.AgeGrid.Size = new System.Drawing.Size(1205, 792);
            this.AgeGrid.TabIndex = 11;
            this.AgeGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgeGrid_CellEndEdit);
            this.AgeGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgeGrid_CellValueChanged);
            // 
            // SampleName
            // 
            this.SampleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SampleName.HeaderText = "Name";
            this.SampleName.Name = "SampleName";
            // 
            // NAge
            // 
            this.NAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAge.HeaderText = "Ns";
            this.NAge.Name = "NAge";
            // 
            // SAge
            // 
            this.SAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SAge.HeaderText = "S, cm^2";
            this.SAge.Name = "SAge";
            // 
            // UDur
            // 
            this.UDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UDur.HeaderText = "U, ppm";
            this.UDur.Name = "UDur";
            // 
            // UstdDur
            // 
            this.UstdDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UstdDur.HeaderText = "U SE ";
            this.UstdDur.Name = "UstdDur";
            // 
            // CaDur
            // 
            this.CaDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CaDur.HeaderText = "Ca, ppm";
            this.CaDur.Name = "CaDur";
            // 
            // CastdDur
            // 
            this.CastdDur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CastdDur.HeaderText = "Ca SE";
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
            this.UCastdDur.HeaderText = "U/Ca SE";
            this.UCastdDur.Name = "UCastdDur";
            // 
            // Weighted
            // 
            this.Weighted.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Weighted.HeaderText = "Weighted U/Ca";
            this.Weighted.Name = "Weighted";
            // 
            // Weightedstd
            // 
            this.Weightedstd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Weightedstd.HeaderText = "Weighted  U/Ca SE";
            this.Weightedstd.Name = "Weightedstd";
            // 
            // FT
            // 
            this.FT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FT.HeaderText = "FT Age, Ma";
            this.FT.Name = "FT";
            // 
            // sigma
            // 
            this.sigma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sigma.HeaderText = "2 sigma, Ma";
            this.sigma.Name = "sigma";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.FileSampleLabel, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label18, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label19, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label20, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.label21, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.label22, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.label23, 0, 6);
            this.tableLayoutPanel7.Controls.Add(this.label24, 0, 7);
            this.tableLayoutPanel7.Controls.Add(this.label25, 0, 8);
            this.tableLayoutPanel7.Controls.Add(this.label26, 0, 9);
            this.tableLayoutPanel7.Controls.Add(this.label27, 0, 10);
            this.tableLayoutPanel7.Controls.Add(this.ZetaAgeLabel, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.ZetaStdAgeLAbel, 1, 6);
            this.tableLayoutPanel7.Controls.Add(this.PWLabel, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.PWStdLabel, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.GrainsLabel, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.NsLabel, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.PooledAgeLabel, 1, 9);
            this.tableLayoutPanel7.Controls.Add(this.AgeStdLabel, 1, 10);
            this.tableLayoutPanel7.Controls.Add(this.ChiLabel, 1, 7);
            this.tableLayoutPanel7.Controls.Add(this.PLabel, 1, 8);
            this.tableLayoutPanel7.Controls.Add(this.DeleteRowAgeGrid, 0, 14);
            this.tableLayoutPanel7.Controls.Add(this.poolAgeButton, 1, 14);
            this.tableLayoutPanel7.Controls.Add(this.label28, 0, 11);
            this.tableLayoutPanel7.Controls.Add(this.label29, 0, 12);
            this.tableLayoutPanel7.Controls.Add(this.label30, 0, 13);
            this.tableLayoutPanel7.Controls.Add(this.CentralAgeLabel, 1, 11);
            this.tableLayoutPanel7.Controls.Add(this.CentralAgeSTDLabel, 1, 12);
            this.tableLayoutPanel7.Controls.Add(this.CentralAgeDispLabel, 1, 13);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(1214, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 15;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667254F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667254F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667254F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667254F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667254F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667254F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667254F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667254F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667254F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667254F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667254F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666588F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.664533F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.664533F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.664533F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(208, 391);
            this.tableLayoutPanel7.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(6, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 22);
            this.label15.TabIndex = 1;
            this.label15.Text = "File:";
            // 
            // FileSampleLabel
            // 
            this.FileSampleLabel.AutoSize = true;
            this.FileSampleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileSampleLabel.Location = new System.Drawing.Point(108, 3);
            this.FileSampleLabel.Name = "FileSampleLabel";
            this.FileSampleLabel.Size = new System.Drawing.Size(94, 22);
            this.FileSampleLabel.TabIndex = 2;
            this.FileSampleLabel.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(6, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 22);
            this.label18.TabIndex = 3;
            this.label18.Text = "Grains";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(6, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 22);
            this.label19.TabIndex = 4;
            this.label19.Text = "Ns";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(6, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 22);
            this.label20.TabIndex = 5;
            this.label20.Text = "Sum PW";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(6, 103);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 22);
            this.label21.TabIndex = 6;
            this.label21.Text = "PW std";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Location = new System.Drawing.Point(6, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 22);
            this.label22.TabIndex = 7;
            this.label22.Text = "Zeta";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Location = new System.Drawing.Point(6, 153);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 22);
            this.label23.TabIndex = 8;
            this.label23.Text = "Zeta std";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Location = new System.Drawing.Point(6, 178);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(93, 22);
            this.label24.TabIndex = 9;
            this.label24.Text = "Xi sq";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Location = new System.Drawing.Point(6, 203);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 22);
            this.label25.TabIndex = 10;
            this.label25.Text = "P(Xi sq)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Location = new System.Drawing.Point(6, 228);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 22);
            this.label26.TabIndex = 11;
            this.label26.Text = "Pooled age";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Location = new System.Drawing.Point(6, 253);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 22);
            this.label27.TabIndex = 12;
            this.label27.Text = "Age std";
            // 
            // ZetaAgeLabel
            // 
            this.ZetaAgeLabel.AutoSize = true;
            this.ZetaAgeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZetaAgeLabel.Location = new System.Drawing.Point(108, 128);
            this.ZetaAgeLabel.Name = "ZetaAgeLabel";
            this.ZetaAgeLabel.Size = new System.Drawing.Size(94, 22);
            this.ZetaAgeLabel.TabIndex = 13;
            this.ZetaAgeLabel.Text = "-";
            // 
            // ZetaStdAgeLAbel
            // 
            this.ZetaStdAgeLAbel.AutoSize = true;
            this.ZetaStdAgeLAbel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZetaStdAgeLAbel.Location = new System.Drawing.Point(108, 153);
            this.ZetaStdAgeLAbel.Name = "ZetaStdAgeLAbel";
            this.ZetaStdAgeLAbel.Size = new System.Drawing.Size(94, 22);
            this.ZetaStdAgeLAbel.TabIndex = 14;
            this.ZetaStdAgeLAbel.Text = "-";
            // 
            // PWLabel
            // 
            this.PWLabel.AutoSize = true;
            this.PWLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PWLabel.Location = new System.Drawing.Point(108, 78);
            this.PWLabel.Name = "PWLabel";
            this.PWLabel.Size = new System.Drawing.Size(94, 22);
            this.PWLabel.TabIndex = 15;
            this.PWLabel.Text = "-";
            // 
            // PWStdLabel
            // 
            this.PWStdLabel.AutoSize = true;
            this.PWStdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PWStdLabel.Location = new System.Drawing.Point(108, 103);
            this.PWStdLabel.Name = "PWStdLabel";
            this.PWStdLabel.Size = new System.Drawing.Size(94, 22);
            this.PWStdLabel.TabIndex = 16;
            this.PWStdLabel.Text = "-";
            // 
            // GrainsLabel
            // 
            this.GrainsLabel.AutoSize = true;
            this.GrainsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrainsLabel.Location = new System.Drawing.Point(108, 28);
            this.GrainsLabel.Name = "GrainsLabel";
            this.GrainsLabel.Size = new System.Drawing.Size(94, 22);
            this.GrainsLabel.TabIndex = 17;
            this.GrainsLabel.Text = "-";
            // 
            // NsLabel
            // 
            this.NsLabel.AutoSize = true;
            this.NsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NsLabel.Location = new System.Drawing.Point(108, 53);
            this.NsLabel.Name = "NsLabel";
            this.NsLabel.Size = new System.Drawing.Size(94, 22);
            this.NsLabel.TabIndex = 18;
            this.NsLabel.Text = "-";
            // 
            // PooledAgeLabel
            // 
            this.PooledAgeLabel.AutoSize = true;
            this.PooledAgeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PooledAgeLabel.Location = new System.Drawing.Point(108, 228);
            this.PooledAgeLabel.Name = "PooledAgeLabel";
            this.PooledAgeLabel.Size = new System.Drawing.Size(94, 22);
            this.PooledAgeLabel.TabIndex = 19;
            this.PooledAgeLabel.Text = "-";
            // 
            // AgeStdLabel
            // 
            this.AgeStdLabel.AutoSize = true;
            this.AgeStdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgeStdLabel.Location = new System.Drawing.Point(108, 253);
            this.AgeStdLabel.Name = "AgeStdLabel";
            this.AgeStdLabel.Size = new System.Drawing.Size(94, 22);
            this.AgeStdLabel.TabIndex = 20;
            this.AgeStdLabel.Text = "-";
            // 
            // ChiLabel
            // 
            this.ChiLabel.AutoSize = true;
            this.ChiLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChiLabel.Location = new System.Drawing.Point(108, 178);
            this.ChiLabel.Name = "ChiLabel";
            this.ChiLabel.Size = new System.Drawing.Size(94, 22);
            this.ChiLabel.TabIndex = 23;
            this.ChiLabel.Text = "-";
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PLabel.Location = new System.Drawing.Point(108, 203);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(94, 22);
            this.PLabel.TabIndex = 24;
            this.PLabel.Text = "-";
            // 
            // DeleteRowAgeGrid
            // 
            this.DeleteRowAgeGrid.Location = new System.Drawing.Point(6, 356);
            this.DeleteRowAgeGrid.Name = "DeleteRowAgeGrid";
            this.DeleteRowAgeGrid.Size = new System.Drawing.Size(93, 25);
            this.DeleteRowAgeGrid.TabIndex = 22;
            this.DeleteRowAgeGrid.Text = "delete row";
            this.DeleteRowAgeGrid.UseVisualStyleBackColor = true;
            this.DeleteRowAgeGrid.Click += new System.EventHandler(this.DeleteRowAgeGrid_Click);
            // 
            // poolAgeButton
            // 
            this.poolAgeButton.Location = new System.Drawing.Point(108, 356);
            this.poolAgeButton.Name = "poolAgeButton";
            this.poolAgeButton.Size = new System.Drawing.Size(94, 25);
            this.poolAgeButton.TabIndex = 21;
            this.poolAgeButton.Text = "Pool age";
            this.poolAgeButton.UseVisualStyleBackColor = true;
            this.poolAgeButton.Click += new System.EventHandler(this.poolAgeButton_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Location = new System.Drawing.Point(6, 278);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(93, 22);
            this.label28.TabIndex = 25;
            this.label28.Text = "Central age";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Location = new System.Drawing.Point(6, 303);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(93, 22);
            this.label29.TabIndex = 26;
            this.label29.Text = "Central age SE";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Location = new System.Drawing.Point(6, 328);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(93, 22);
            this.label30.TabIndex = 27;
            this.label30.Text = "Central age disp";
            // 
            // CentralAgeLabel
            // 
            this.CentralAgeLabel.AutoSize = true;
            this.CentralAgeLabel.Location = new System.Drawing.Point(108, 278);
            this.CentralAgeLabel.Name = "CentralAgeLabel";
            this.CentralAgeLabel.Size = new System.Drawing.Size(10, 13);
            this.CentralAgeLabel.TabIndex = 28;
            this.CentralAgeLabel.Text = "-";
            // 
            // ImportTest
            // 
            this.ImportTest.FileName = "ImportTest";
            // 
            // ImportSample
            // 
            this.ImportSample.FileName = "openFileDialog1";
            // 
            // CentralAgeSTDLabel
            // 
            this.CentralAgeSTDLabel.AutoSize = true;
            this.CentralAgeSTDLabel.Location = new System.Drawing.Point(108, 303);
            this.CentralAgeSTDLabel.Name = "CentralAgeSTDLabel";
            this.CentralAgeSTDLabel.Size = new System.Drawing.Size(10, 13);
            this.CentralAgeSTDLabel.TabIndex = 29;
            this.CentralAgeSTDLabel.Text = "-";
            // 
            // CentralAgeDispLabel
            // 
            this.CentralAgeDispLabel.AutoSize = true;
            this.CentralAgeDispLabel.Location = new System.Drawing.Point(108, 328);
            this.CentralAgeDispLabel.Name = "CentralAgeDispLabel";
            this.CentralAgeDispLabel.Size = new System.Drawing.Size(10, 13);
            this.CentralAgeDispLabel.TabIndex = 30;
            this.CentralAgeDispLabel.Text = "-";
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
            this.Zeta_test.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestGrid)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.Age.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AgeGrid)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ImportZeta;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Zeta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView zetaTable;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton optiondButton;
        private System.Windows.Forms.TextBox yr1Text;
        private System.Windows.Forms.Button calculateZeta;
        private System.Windows.Forms.Button deleteRow;
        private System.Windows.Forms.OpenFileDialog ImportTest;
        private System.Windows.Forms.Label zetaErrLabel;
        private System.Windows.Forms.OpenFileDialog ImportSample;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem importZetaFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTestFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importSampleFileToolStripMenuItem;
        private System.Windows.Forms.TabPage Zeta_test;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.DataGridView TestGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TestFileLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label RawTestLabel;
        private System.Windows.Forms.Label UCaTestLabel;
        private System.Windows.Forms.Label ConvFactorLabel;
        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.Label TestStdLabel;
        private System.Windows.Forms.Label ConvStdLabel;
        private System.Windows.Forms.Button conductTestButton;
        private System.Windows.Forms.Button DeleteRowTestGrid;
        private System.Windows.Forms.TabPage Age;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.DataGridView AgeGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label FileSampleLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label ZetaAgeLabel;
        private System.Windows.Forms.Label ZetaStdAgeLAbel;
        private System.Windows.Forms.Label PWLabel;
        private System.Windows.Forms.Label PWStdLabel;
        private System.Windows.Forms.Label GrainsLabel;
        private System.Windows.Forms.Label NsLabel;
        private System.Windows.Forms.Label PooledAgeLabel;
        private System.Windows.Forms.Label AgeStdLabel;
        private System.Windows.Forms.Button poolAgeButton;
        private System.Windows.Forms.Button DeleteRowAgeGrid;
        private System.Windows.Forms.Label ChiLabel;
        private System.Windows.Forms.Label PLabel;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Ntest;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawUCaTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn UstdTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn CastdTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCaTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCastdTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConvUCaTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn SampleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn UDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn UstdDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn CastdDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCaDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn UCastdDur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weighted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weightedstd;
        private System.Windows.Forms.DataGridViewTextBoxColumn FT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigma;
        private System.Windows.Forms.ToolStripButton ImportZetafileButton;
        private System.Windows.Forms.ToolStripButton ImportTestFileButton;
        private System.Windows.Forms.ToolStripButton ImportSamplefileButton;
        private System.Windows.Forms.ToolStripButton ClearButton;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label CentralAgeLabel;
        private System.Windows.Forms.Label CentralAgeSTDLabel;
        private System.Windows.Forms.Label CentralAgeDispLabel;
    }
}

