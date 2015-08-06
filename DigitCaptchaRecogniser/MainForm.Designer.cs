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
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.finalDigit4 = new System.Windows.Forms.PictureBox();
            this.finalDigit5 = new System.Windows.Forms.PictureBox();
            this.finalDigit3 = new System.Windows.Forms.PictureBox();
            this.finalDigit1 = new System.Windows.Forms.PictureBox();
            this.finalDigit2 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.finalDigit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDigit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDigit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDigit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDigit2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
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
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(810, 780);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "After Kuwahara";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kuwaharaImage
            // 
            this.kuwaharaImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kuwaharaImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kuwaharaImage.Location = new System.Drawing.Point(408, 43);
            this.kuwaharaImage.Name = "kuwaharaImage";
            this.kuwaharaImage.Size = new System.Drawing.Size(399, 164);
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
            this.sourceImage.Size = new System.Drawing.Size(399, 164);
            this.sourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceImage.TabIndex = 5;
            this.sourceImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 20);
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
            this.panel1.Size = new System.Drawing.Size(804, 34);
            this.panel1.TabIndex = 0;
            // 
            // imagePath
            // 
            this.imagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePath.Location = new System.Drawing.Point(0, 0);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(681, 32);
            this.imagePath.TabIndex = 1;
            this.imagePath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imagePath_KeyPress);
            // 
            // loadImage
            // 
            this.loadImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.loadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadImage.Location = new System.Drawing.Point(681, 0);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 423);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(804, 164);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // digit4
            // 
            this.digit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digit4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit4.Location = new System.Drawing.Point(483, 3);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(154, 158);
            this.digit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit4.TabIndex = 13;
            this.digit4.TabStop = false;
            // 
            // digit5
            // 
            this.digit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digit5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit5.Location = new System.Drawing.Point(643, 3);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(158, 158);
            this.digit5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit5.TabIndex = 12;
            this.digit5.TabStop = false;
            // 
            // digit3
            // 
            this.digit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit3.Location = new System.Drawing.Point(323, 3);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(154, 158);
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
            this.digit1.Size = new System.Drawing.Size(154, 158);
            this.digit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit1.TabIndex = 10;
            this.digit1.TabStop = false;
            // 
            // digit2
            // 
            this.digit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digit2.Location = new System.Drawing.Point(163, 3);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(154, 158);
            this.digit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.digit2.TabIndex = 9;
            this.digit2.TabStop = false;
            // 
            // thresholdImage
            // 
            this.thresholdImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdImage.Location = new System.Drawing.Point(3, 233);
            this.thresholdImage.Name = "thresholdImage";
            this.thresholdImage.Size = new System.Drawing.Size(399, 164);
            this.thresholdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thresholdImage.TabIndex = 8;
            this.thresholdImage.TabStop = false;
            // 
            // medianImage
            // 
            this.medianImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medianImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medianImage.Location = new System.Drawing.Point(408, 233);
            this.medianImage.Name = "medianImage";
            this.medianImage.Size = new System.Drawing.Size(399, 164);
            this.medianImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.medianImage.TabIndex = 9;
            this.medianImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "After Threshold";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Result. After Median filter";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "\"All Images|*.jpeg;*.jpg;*.bmp;*.png;*.gif;*.tiff\"";
            this.openImageDialog.RestoreDirectory = true;
            this.openImageDialog.Title = "Open image for recognition";
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
            this.tableLayoutPanel3.Controls.Add(this.finalDigit4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.finalDigit5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.finalDigit3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.finalDigit1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.finalDigit2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 593);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(804, 164);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // finalDigit4
            // 
            this.finalDigit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalDigit4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalDigit4.Location = new System.Drawing.Point(483, 3);
            this.finalDigit4.Name = "finalDigit4";
            this.finalDigit4.Size = new System.Drawing.Size(154, 158);
            this.finalDigit4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finalDigit4.TabIndex = 13;
            this.finalDigit4.TabStop = false;
            // 
            // finalDigit5
            // 
            this.finalDigit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalDigit5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalDigit5.Location = new System.Drawing.Point(643, 3);
            this.finalDigit5.Name = "finalDigit5";
            this.finalDigit5.Size = new System.Drawing.Size(158, 158);
            this.finalDigit5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finalDigit5.TabIndex = 12;
            this.finalDigit5.TabStop = false;
            // 
            // finalDigit3
            // 
            this.finalDigit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalDigit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalDigit3.Location = new System.Drawing.Point(323, 3);
            this.finalDigit3.Name = "finalDigit3";
            this.finalDigit3.Size = new System.Drawing.Size(154, 158);
            this.finalDigit3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finalDigit3.TabIndex = 11;
            this.finalDigit3.TabStop = false;
            // 
            // finalDigit1
            // 
            this.finalDigit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalDigit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalDigit1.Location = new System.Drawing.Point(3, 3);
            this.finalDigit1.Name = "finalDigit1";
            this.finalDigit1.Size = new System.Drawing.Size(154, 158);
            this.finalDigit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finalDigit1.TabIndex = 10;
            this.finalDigit1.TabStop = false;
            // 
            // finalDigit2
            // 
            this.finalDigit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalDigit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalDigit2.Location = new System.Drawing.Point(163, 3);
            this.finalDigit2.Name = "finalDigit2";
            this.finalDigit2.Size = new System.Drawing.Size(154, 158);
            this.finalDigit2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finalDigit2.TabIndex = 9;
            this.finalDigit2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 780);
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
            ((System.ComponentModel.ISupportInitialize)(this.finalDigit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDigit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDigit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDigit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDigit2)).EndInit();
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
        private System.Windows.Forms.PictureBox finalDigit4;
        private System.Windows.Forms.PictureBox finalDigit5;
        private System.Windows.Forms.PictureBox finalDigit3;
        private System.Windows.Forms.PictureBox finalDigit1;
        private System.Windows.Forms.PictureBox finalDigit2;
    }
}

