﻿namespace Handwriting
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabSamples = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.dgvTrainingSource = new System.Windows.Forms.DataGridView();
            this.colTrainingImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTrainingLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrainingFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvAnalysisTesting = new System.Windows.Forms.DataGridView();
            this.colTestingImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colTestingExpected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestingOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTestingFeatures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numEpsilon = new System.Windows.Forms.NumericUpDown();
            this.numTolerance = new System.Windows.Forms.NumericUpDown();
            this.numComplexity = new System.Windows.Forms.NumericUpDown();
            this.numConstant = new System.Windows.Forms.NumericUpDown();
            this.numDegree = new System.Windows.Forms.NumericUpDown();
            this.numSigma = new System.Windows.Forms.NumericUpDown();
            this.rbPolynomial = new System.Windows.Forms.RadioButton();
            this.rbGaussian = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClassify = new System.Windows.Forms.Button();
            this.btnSampleRunAnalysis = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbSize = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvVectors = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMachines = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubproblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThreshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbCanvasClassification = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.canvas = new Handwriting.Canvas();
            this.button2 = new System.Windows.Forms.Button();
            this.tbPenWidth = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.graphClassification = new ZedGraph.ZedGraphControl();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.tabSamples.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingSource)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysisTesting)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEpsilon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComplexity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigma)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVectors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenWidth)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem2.Text = "&Open";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator4,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(143, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuItem5.Text = "E&xit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem6});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem6.Text = "&Help";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem7.Text = "&About...";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tabSamples
            // 
            this.tabSamples.Controls.Add(this.splitContainer3);
            this.tabSamples.Location = new System.Drawing.Point(4, 22);
            this.tabSamples.Name = "tabSamples";
            this.tabSamples.Padding = new System.Windows.Forms.Padding(3);
            this.tabSamples.Size = new System.Drawing.Size(636, 370);
            this.tabSamples.TabIndex = 0;
            this.tabSamples.Text = "Samples (Input)";
            this.tabSamples.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer7);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer3.Size = new System.Drawing.Size(630, 364);
            this.splitContainer3.SplitterDistance = 448;
            this.splitContainer3.TabIndex = 8;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.groupBox15);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.groupBox7);
            this.splitContainer7.Size = new System.Drawing.Size(448, 364);
            this.splitContainer7.SplitterDistance = 156;
            this.splitContainer7.TabIndex = 9;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.dgvTrainingSource);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Location = new System.Drawing.Point(0, 0);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(156, 364);
            this.groupBox15.TabIndex = 8;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Training";
            // 
            // dgvTrainingSource
            // 
            this.dgvTrainingSource.AllowUserToAddRows = false;
            this.dgvTrainingSource.AllowUserToDeleteRows = false;
            this.dgvTrainingSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvTrainingSource.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTrainingSource.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTrainingSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTrainingSource.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrainingSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainingSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrainingImage,
            this.colTrainingLabel,
            this.colTrainingFeatures});
            this.dgvTrainingSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrainingSource.Location = new System.Drawing.Point(3, 16);
            this.dgvTrainingSource.Name = "dgvTrainingSource";
            this.dgvTrainingSource.ReadOnly = true;
            this.dgvTrainingSource.RowHeadersVisible = false;
            this.dgvTrainingSource.Size = new System.Drawing.Size(150, 345);
            this.dgvTrainingSource.TabIndex = 6;
            // 
            // colTrainingImage
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            this.colTrainingImage.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTrainingImage.HeaderText = "Character";
            this.colTrainingImage.Name = "colTrainingImage";
            this.colTrainingImage.ReadOnly = true;
            this.colTrainingImage.Width = 59;
            // 
            // colTrainingLabel
            // 
            this.colTrainingLabel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTrainingLabel.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTrainingLabel.HeaderText = "Index";
            this.colTrainingLabel.Name = "colTrainingLabel";
            this.colTrainingLabel.ReadOnly = true;
            // 
            // colTrainingFeatures
            // 
            this.colTrainingFeatures.HeaderText = "Features (array)";
            this.colTrainingFeatures.Name = "colTrainingFeatures";
            this.colTrainingFeatures.ReadOnly = true;
            this.colTrainingFeatures.Visible = false;
            this.colTrainingFeatures.Width = 105;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvAnalysisTesting);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(288, 364);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Testing";
            // 
            // dgvAnalysisTesting
            // 
            this.dgvAnalysisTesting.AllowUserToAddRows = false;
            this.dgvAnalysisTesting.AllowUserToDeleteRows = false;
            this.dgvAnalysisTesting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnalysisTesting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAnalysisTesting.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAnalysisTesting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnalysisTesting.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAnalysisTesting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalysisTesting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTestingImage,
            this.colTestingExpected,
            this.colTestingOutput,
            this.colTestingFeatures});
            this.dgvAnalysisTesting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnalysisTesting.Location = new System.Drawing.Point(3, 16);
            this.dgvAnalysisTesting.Name = "dgvAnalysisTesting";
            this.dgvAnalysisTesting.ReadOnly = true;
            this.dgvAnalysisTesting.RowHeadersVisible = false;
            this.dgvAnalysisTesting.Size = new System.Drawing.Size(282, 345);
            this.dgvAnalysisTesting.TabIndex = 6;
            // 
            // colTestingImage
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            this.colTestingImage.DefaultCellStyle = dataGridViewCellStyle5;
            this.colTestingImage.HeaderText = "Character";
            this.colTestingImage.Name = "colTestingImage";
            this.colTestingImage.ReadOnly = true;
            // 
            // colTestingExpected
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTestingExpected.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTestingExpected.HeaderText = "Index";
            this.colTestingExpected.Name = "colTestingExpected";
            this.colTestingExpected.ReadOnly = true;
            // 
            // colTestingOutput
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTestingOutput.DefaultCellStyle = dataGridViewCellStyle7;
            this.colTestingOutput.HeaderText = "Classification";
            this.colTestingOutput.Name = "colTestingOutput";
            this.colTestingOutput.ReadOnly = true;
            // 
            // colTestingFeatures
            // 
            this.colTestingFeatures.HeaderText = "Features (array)";
            this.colTestingFeatures.Name = "colTestingFeatures";
            this.colTestingFeatures.ReadOnly = true;
            this.colTestingFeatures.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numEpsilon);
            this.groupBox6.Controls.Add(this.numTolerance);
            this.groupBox6.Controls.Add(this.numComplexity);
            this.groupBox6.Controls.Add(this.numConstant);
            this.groupBox6.Controls.Add(this.numDegree);
            this.groupBox6.Controls.Add(this.numSigma);
            this.groupBox6.Controls.Add(this.rbPolynomial);
            this.groupBox6.Controls.Add(this.rbGaussian);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.btnClassify);
            this.groupBox6.Controls.Add(this.btnSampleRunAnalysis);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(178, 364);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Settings";
            // 
            // numEpsilon
            // 
            this.numEpsilon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numEpsilon.DecimalPlaces = 6;
            this.numEpsilon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numEpsilon.Location = new System.Drawing.Point(89, 176);
            this.numEpsilon.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEpsilon.Name = "numEpsilon";
            this.numEpsilon.Size = new System.Drawing.Size(82, 20);
            this.numEpsilon.TabIndex = 7;
            this.numEpsilon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numEpsilon.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // numTolerance
            // 
            this.numTolerance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numTolerance.DecimalPlaces = 6;
            this.numTolerance.Location = new System.Drawing.Point(89, 224);
            this.numTolerance.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTolerance.Name = "numTolerance";
            this.numTolerance.Size = new System.Drawing.Size(82, 20);
            this.numTolerance.TabIndex = 7;
            this.numTolerance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTolerance.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // numComplexity
            // 
            this.numComplexity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numComplexity.DecimalPlaces = 6;
            this.numComplexity.Location = new System.Drawing.Point(89, 200);
            this.numComplexity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numComplexity.Name = "numComplexity";
            this.numComplexity.Size = new System.Drawing.Size(82, 20);
            this.numComplexity.TabIndex = 7;
            this.numComplexity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numComplexity.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // numConstant
            // 
            this.numConstant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numConstant.DecimalPlaces = 4;
            this.numConstant.Location = new System.Drawing.Point(89, 130);
            this.numConstant.Name = "numConstant";
            this.numConstant.Size = new System.Drawing.Size(82, 20);
            this.numConstant.TabIndex = 7;
            this.numConstant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numDegree
            // 
            this.numDegree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numDegree.Location = new System.Drawing.Point(89, 104);
            this.numDegree.Name = "numDegree";
            this.numDegree.Size = new System.Drawing.Size(82, 20);
            this.numDegree.TabIndex = 7;
            this.numDegree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDegree.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numSigma
            // 
            this.numSigma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numSigma.DecimalPlaces = 4;
            this.numSigma.Location = new System.Drawing.Point(89, 52);
            this.numSigma.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSigma.Name = "numSigma";
            this.numSigma.Size = new System.Drawing.Size(82, 20);
            this.numSigma.TabIndex = 7;
            this.numSigma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSigma.Value = new decimal(new int[] {
            622,
            0,
            0,
            131072});
            // 
            // rbPolynomial
            // 
            this.rbPolynomial.AutoSize = true;
            this.rbPolynomial.Checked = true;
            this.rbPolynomial.Location = new System.Drawing.Point(6, 81);
            this.rbPolynomial.Name = "rbPolynomial";
            this.rbPolynomial.Size = new System.Drawing.Size(108, 17);
            this.rbPolynomial.TabIndex = 6;
            this.rbPolynomial.TabStop = true;
            this.rbPolynomial.Text = "Polynomial Kernel";
            this.rbPolynomial.UseVisualStyleBackColor = true;
            // 
            // rbGaussian
            // 
            this.rbGaussian.AutoSize = true;
            this.rbGaussian.Location = new System.Drawing.Point(6, 29);
            this.rbGaussian.Name = "rbGaussian";
            this.rbGaussian.Size = new System.Drawing.Size(102, 17);
            this.rbGaussian.TabIndex = 6;
            this.rbGaussian.Text = "Gaussian Kernel";
            this.rbGaussian.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tolerance:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Epsilon:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Complexity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Constant:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Degree:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sigma:";
            // 
            // btnClassify
            // 
            this.btnClassify.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClassify.Enabled = false;
            this.btnClassify.Location = new System.Drawing.Point(7, 310);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(165, 48);
            this.btnClassify.TabIndex = 1;
            this.btnClassify.Text = "Classify";
            this.btnClassify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClassify.UseVisualStyleBackColor = true;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // btnSampleRunAnalysis
            // 
            this.btnSampleRunAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSampleRunAnalysis.Enabled = false;
            this.btnSampleRunAnalysis.Location = new System.Drawing.Point(7, 250);
            this.btnSampleRunAnalysis.Name = "btnSampleRunAnalysis";
            this.btnSampleRunAnalysis.Size = new System.Drawing.Size(165, 54);
            this.btnSampleRunAnalysis.TabIndex = 1;
            this.btnSampleRunAnalysis.Text = "Start training";
            this.btnSampleRunAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSampleRunAnalysis.UseVisualStyleBackColor = true;
            this.btnSampleRunAnalysis.Click += new System.EventHandler(this.btnRunTraining_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSamples);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(644, 396);
            this.tabControl.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbSize);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dgvVectors);
            this.tabPage2.Controls.Add(this.dgvMachines);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 370);
            this.tabPage2.TabIndex = 11;
            this.tabPage2.Text = "Machines";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(174, 349);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(47, 13);
            this.lbSize.TabIndex = 9;
            this.lbSize.Text = "0 (0 MB)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total number of support vectors:";
            // 
            // dgvVectors
            // 
            this.dgvVectors.AllowUserToAddRows = false;
            this.dgvVectors.AllowUserToDeleteRows = false;
            this.dgvVectors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvVectors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVectors.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvVectors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVectors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVectors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVectors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3});
            this.dgvVectors.Location = new System.Drawing.Point(369, 6);
            this.dgvVectors.Name = "dgvVectors";
            this.dgvVectors.ReadOnly = true;
            this.dgvVectors.RowHeadersVisible = false;
            this.dgvVectors.Size = new System.Drawing.Size(259, 345);
            this.dgvVectors.TabIndex = 8;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle9.NullValue")));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewImageColumn1.HeaderText = "Vector";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 44;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn3.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dgvMachines
            // 
            this.dgvMachines.AllowUserToAddRows = false;
            this.dgvMachines.AllowUserToDeleteRows = false;
            this.dgvMachines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMachines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMachines.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMachines.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMachines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colSubproblem,
            this.dataGridViewTextBoxColumn2,
            this.colThreshold});
            this.dgvMachines.Location = new System.Drawing.Point(8, 6);
            this.dgvMachines.Name = "dgvMachines";
            this.dgvMachines.ReadOnly = true;
            this.dgvMachines.RowHeadersVisible = false;
            this.dgvMachines.Size = new System.Drawing.Size(355, 332);
            this.dgvMachines.TabIndex = 7;
            this.dgvMachines.CurrentCellChanged += new System.EventHandler(this.dgvMachines_CurrentCellChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn1.HeaderText = "Machine";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // colSubproblem
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSubproblem.DefaultCellStyle = dataGridViewCellStyle13;
            this.colSubproblem.HeaderText = "Subproblem";
            this.colSubproblem.Name = "colSubproblem";
            this.colSubproblem.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Support Vectors";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // colThreshold
            // 
            this.colThreshold.HeaderText = "Threshold";
            this.colThreshold.Name = "colThreshold";
            this.colThreshold.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(636, 370);
            this.tabPage1.TabIndex = 10;
            this.tabPage1.Text = "Classification";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox8.Controls.Add(this.lbCanvasClassification);
            this.groupBox8.Location = new System.Drawing.Point(14, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(198, 167);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Classification";
            // 
            // lbCanvasClassification
            // 
            this.lbCanvasClassification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCanvasClassification.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCanvasClassification.Location = new System.Drawing.Point(3, 16);
            this.lbCanvasClassification.Name = "lbCanvasClassification";
            this.lbCanvasClassification.Size = new System.Drawing.Size(192, 148);
            this.lbCanvasClassification.TabIndex = 3;
            this.lbCanvasClassification.Text = "0";
            this.lbCanvasClassification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.canvas);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.tbPenWidth);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(8, 176);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 191);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Drawing Canvas";
            // 
            // canvas
            // 
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.canvas.Location = new System.Drawing.Point(15, 19);
            this.canvas.MaximumSize = new System.Drawing.Size(128, 128);
            this.canvas.MinimumSize = new System.Drawing.Size(128, 128);
            this.canvas.Name = "canvas";
            this.canvas.PenSize = 5;
            this.canvas.Size = new System.Drawing.Size(128, 128);
            this.canvas.TabIndex = 0;
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Classify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCanvasClassify_Click);
            // 
            // tbPenWidth
            // 
            this.tbPenWidth.Location = new System.Drawing.Point(149, 19);
            this.tbPenWidth.Minimum = 1;
            this.tbPenWidth.Name = "tbPenWidth";
            this.tbPenWidth.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbPenWidth.Size = new System.Drawing.Size(45, 128);
            this.tbPenWidth.TabIndex = 5;
            this.tbPenWidth.Value = 3;
            this.tbPenWidth.Scroll += new System.EventHandler(this.tbPenWidth_Scroll);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCanvasClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.graphClassification);
            this.groupBox3.Location = new System.Drawing.Point(218, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 370);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discriminant functions relative response";
            // 
            // graphClassification
            // 
            this.graphClassification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphClassification.Location = new System.Drawing.Point(3, 16);
            this.graphClassification.Name = "graphClassification";
            this.graphClassification.ScrollGrace = 0;
            this.graphClassification.ScrollMaxX = 0;
            this.graphClassification.ScrollMaxY = 0;
            this.graphClassification.ScrollMaxY2 = 0;
            this.graphClassification.ScrollMinX = 0;
            this.graphClassification.ScrollMinY = 0;
            this.graphClassification.ScrollMinY2 = 0;
            this.graphClassification.Size = new System.Drawing.Size(412, 351);
            this.graphClassification.TabIndex = 6;
            // 
            // groupBox20
            // 
            this.groupBox20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox20.Location = new System.Drawing.Point(0, 0);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(450, 445);
            this.groupBox20.TabIndex = 8;
            this.groupBox20.TabStop = false;
            // 
            // groupBox19
            // 
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox19.Location = new System.Drawing.Point(0, 0);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(459, 445);
            this.groupBox19.TabIndex = 8;
            this.groupBox19.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(644, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(629, 17);
            this.lbStatus.Spring = true;
            this.lbStatus.Text = "toolStripStatusLabel1";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 442);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Multiclass Support Vector Machines for Handwriting Recognition";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabSamples.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            this.splitContainer7.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainingSource)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysisTesting)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEpsilon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numComplexity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSigma)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVectors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachines)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPenWidth)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabPage tabSamples;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numConstant;
        private System.Windows.Forms.NumericUpDown numDegree;
        private System.Windows.Forms.NumericUpDown numSigma;
        private System.Windows.Forms.RadioButton rbPolynomial;
        private System.Windows.Forms.RadioButton rbGaussian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSampleRunAnalysis;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.DataGridView dgvTrainingSource;
        private System.Windows.Forms.NumericUpDown numComplexity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvAnalysisTesting;
        private System.Windows.Forms.DataGridViewImageColumn colTrainingImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainingLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrainingFeatures;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.NumericUpDown numEpsilon;
        private System.Windows.Forms.Label label6;
        private Canvas canvas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar tbPenWidth;
        private System.Windows.Forms.Label lbCanvasClassification;
        private ZedGraph.ZedGraphControl graphClassification;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewImageColumn colTestingImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestingExpected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestingOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestingFeatures;
        private System.Windows.Forms.NumericUpDown numTolerance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMachines;
        private System.Windows.Forms.DataGridView dgvVectors;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubproblem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThreshold;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label7;

    }
}

