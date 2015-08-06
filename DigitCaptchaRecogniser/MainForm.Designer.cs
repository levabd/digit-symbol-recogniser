namespace DigitCaptchaRecogniser
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.kuwaharaImage = new System.Windows.Forms.PictureBox();
            this.sourceImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagePath = new System.Windows.Forms.TextBox();
            this.loadImage = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.digit4 = new System.Windows.Forms.PictureBox();
            this.digit5 = new System.Windows.Forms.PictureBox();
            this.digit3 = new System.Windows.Forms.PictureBox();
            this.digit1 = new System.Windows.Forms.PictureBox();
            this.digit2 = new System.Windows.Forms.PictureBox();
            this.thresholdImage = new System.Windows.Forms.PictureBox();
            this.medianImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gaussDigit4 = new System.Windows.Forms.PictureBox();
            this.gaussDigit5 = new System.Windows.Forms.PictureBox();
            this.gaussDigit3 = new System.Windows.Forms.PictureBox();
            this.gaussDigit1 = new System.Windows.Forms.PictureBox();
            this.gaussDigit2 = new System.Windows.Forms.PictureBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.contourDigit4 = new System.Windows.Forms.PictureBox();
            this.contourDigit5 = new System.Windows.Forms.PictureBox();
            this.contourDigit3 = new System.Windows.Forms.PictureBox();
            this.contourDigit1 = new System.Windows.Forms.PictureBox();
            this.contourDigit2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kuwaharaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianImage)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaussDigit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussDigit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussDigit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussDigit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussDigit2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contourDigit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contourDigit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contourDigit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contourDigit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contourDigit2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.kuwaharaImage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sourceImage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.thresholdImage, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.medianImage, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1033, 832);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "After Kuwahara";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kuwaharaImage
            // 
            this.kuwaharaImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kuwaharaImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kuwaharaImage.Location = new System.Drawing.Point(519, 43);
            this.kuwaharaImage.Name = "kuwaharaImage";
            this.kuwaharaImage.Size = new System.Drawing.Size(511, 140);
            this.kuwaharaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kuwaharaImage.TabIndex = 6;
            this.kuwaharaImage.TabStop = false;
            // 
            // sourceImage
            // 
            this.sourceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceImage.Location = new System.Drawing.Point(3, 43);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(510, 140);
            this.sourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceImage.TabIndex = 5;
            this.sourceImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source Image";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.imagePath);
            this.panel1.Controls.Add(this.loadImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 34);
            this.panel1.TabIndex = 0;
            // 
            // imagePath
            // 
            this.imagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePath.Location = new System.Drawing.Point(0, 0);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(904, 32);
            this.imagePath.TabIndex = 1;
            this.imagePath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imagePath_KeyPress);
            // 
            // loadImage
            // 
            this.loadImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.loadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadImage.Location = new System.Drawing.Point(904, 0);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(123, 34);
            this.loadImage.TabIndex = 0;
            this.loadImage.Text = "Open Image...";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.digit4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.digit5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.digit3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.digit1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.digit2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 375);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1027, 140);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // digit4
            // 
            this.digit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digit4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit4.Location = new System.Drawing.Point(618, 3);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(199, 134);
            this.digit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit4.TabIndex = 13;
            this.digit4.TabStop = false;
            // 
            // digit5
            // 
            this.digit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digit5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit5.Location = new System.Drawing.Point(823, 3);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(201, 134);
            this.digit5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit5.TabIndex = 12;
            this.digit5.TabStop = false;
            // 
            // digit3
            // 
            this.digit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit3.Location = new System.Drawing.Point(413, 3);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(199, 134);
            this.digit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit3.TabIndex = 11;
            this.digit3.TabStop = false;
            // 
            // digit1
            // 
            this.digit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit1.Location = new System.Drawing.Point(3, 3);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(199, 134);
            this.digit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit1.TabIndex = 10;
            this.digit1.TabStop = false;
            // 
            // digit2
            // 
            this.digit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit2.Location = new System.Drawing.Point(208, 3);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(199, 134);
            this.digit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit2.TabIndex = 9;
            this.digit2.TabStop = false;
            // 
            // thresholdImage
            // 
            this.thresholdImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdImage.Location = new System.Drawing.Point(3, 209);
            this.thresholdImage.Name = "thresholdImage";
            this.thresholdImage.Size = new System.Drawing.Size(510, 140);
            this.thresholdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thresholdImage.TabIndex = 8;
            this.thresholdImage.TabStop = false;
            // 
            // medianImage
            // 
            this.medianImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medianImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medianImage.Location = new System.Drawing.Point(519, 209);
            this.medianImage.Name = "medianImage";
            this.medianImage.Size = new System.Drawing.Size(511, 140);
            this.medianImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.medianImage.TabIndex = 9;
            this.medianImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "After Threshold";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Result. After Median filter";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.gaussDigit4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gaussDigit5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gaussDigit3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gaussDigit1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gaussDigit2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 521);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1027, 140);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // gaussDigit4
            // 
            this.gaussDigit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gaussDigit4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaussDigit4.Location = new System.Drawing.Point(618, 3);
            this.gaussDigit4.Name = "gaussDigit4";
            this.gaussDigit4.Size = new System.Drawing.Size(199, 134);
            this.gaussDigit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gaussDigit4.TabIndex = 13;
            this.gaussDigit4.TabStop = false;
            // 
            // gaussDigit5
            // 
            this.gaussDigit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gaussDigit5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaussDigit5.Location = new System.Drawing.Point(823, 3);
            this.gaussDigit5.Name = "gaussDigit5";
            this.gaussDigit5.Size = new System.Drawing.Size(201, 134);
            this.gaussDigit5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gaussDigit5.TabIndex = 12;
            this.gaussDigit5.TabStop = false;
            // 
            // gaussDigit3
            // 
            this.gaussDigit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gaussDigit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaussDigit3.Location = new System.Drawing.Point(413, 3);
            this.gaussDigit3.Name = "gaussDigit3";
            this.gaussDigit3.Size = new System.Drawing.Size(199, 134);
            this.gaussDigit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gaussDigit3.TabIndex = 11;
            this.gaussDigit3.TabStop = false;
            // 
            // gaussDigit1
            // 
            this.gaussDigit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gaussDigit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaussDigit1.Location = new System.Drawing.Point(3, 3);
            this.gaussDigit1.Name = "gaussDigit1";
            this.gaussDigit1.Size = new System.Drawing.Size(199, 134);
            this.gaussDigit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gaussDigit1.TabIndex = 10;
            this.gaussDigit1.TabStop = false;
            // 
            // gaussDigit2
            // 
            this.gaussDigit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gaussDigit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaussDigit2.Location = new System.Drawing.Point(208, 3);
            this.gaussDigit2.Name = "gaussDigit2";
            this.gaussDigit2.Size = new System.Drawing.Size(199, 134);
            this.gaussDigit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gaussDigit2.TabIndex = 9;
            this.gaussDigit2.TabStop = false;
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "\"All Images|*.jpeg;*.jpg;*.bmp;*.png;*.gif;*.tiff\"";
            this.openImageDialog.RestoreDirectory = true;
            this.openImageDialog.Title = "Open image for recognition";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.contourDigit4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.contourDigit5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.contourDigit3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.contourDigit1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.contourDigit2, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 667);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1027, 140);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // contourDigit4
            // 
            this.contourDigit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contourDigit4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contourDigit4.Location = new System.Drawing.Point(618, 3);
            this.contourDigit4.Name = "contourDigit4";
            this.contourDigit4.Size = new System.Drawing.Size(199, 134);
            this.contourDigit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contourDigit4.TabIndex = 13;
            this.contourDigit4.TabStop = false;
            // 
            // contourDigit5
            // 
            this.contourDigit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contourDigit5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contourDigit5.Location = new System.Drawing.Point(823, 3);
            this.contourDigit5.Name = "contourDigit5";
            this.contourDigit5.Size = new System.Drawing.Size(201, 134);
            this.contourDigit5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contourDigit5.TabIndex = 12;
            this.contourDigit5.TabStop = false;
            // 
            // contourDigit3
            // 
            this.contourDigit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contourDigit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contourDigit3.Location = new System.Drawing.Point(413, 3);
            this.contourDigit3.Name = "contourDigit3";
            this.contourDigit3.Size = new System.Drawing.Size(199, 134);
            this.contourDigit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contourDigit3.TabIndex = 11;
            this.contourDigit3.TabStop = false;
            // 
            // contourDigit1
            // 
            this.contourDigit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contourDigit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contourDigit1.Location = new System.Drawing.Point(3, 3);
            this.contourDigit1.Name = "contourDigit1";
            this.contourDigit1.Size = new System.Drawing.Size(199, 134);
            this.contourDigit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contourDigit1.TabIndex = 10;
            this.contourDigit1.TabStop = false;
            // 
            // contourDigit2
            // 
            this.contourDigit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contourDigit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contourDigit2.Location = new System.Drawing.Point(208, 3);
            this.contourDigit2.Name = "contourDigit2";
            this.contourDigit2.Size = new System.Drawing.Size(199, 134);
            this.contourDigit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contourDigit2.TabIndex = 9;
            this.contourDigit2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 832);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Digit Captcha Recogniser";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kuwaharaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianImage)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gaussDigit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussDigit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussDigit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussDigit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussDigit2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contourDigit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contourDigit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contourDigit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contourDigit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contourDigit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loadImage;
        private System.Windows.Forms.TextBox imagePath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox kuwaharaImage;
        private System.Windows.Forms.PictureBox sourceImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox thresholdImage;
        private System.Windows.Forms.PictureBox medianImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox digit4;
        private System.Windows.Forms.PictureBox digit5;
        private System.Windows.Forms.PictureBox digit3;
        private System.Windows.Forms.PictureBox digit1;
        private System.Windows.Forms.PictureBox digit2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox gaussDigit4;
        private System.Windows.Forms.PictureBox gaussDigit5;
        private System.Windows.Forms.PictureBox gaussDigit3;
        private System.Windows.Forms.PictureBox gaussDigit1;
        private System.Windows.Forms.PictureBox gaussDigit2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox contourDigit4;
        private System.Windows.Forms.PictureBox contourDigit5;
        private System.Windows.Forms.PictureBox contourDigit3;
        private System.Windows.Forms.PictureBox contourDigit1;
        private System.Windows.Forms.PictureBox contourDigit2;
    }
}

