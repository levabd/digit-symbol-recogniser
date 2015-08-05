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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadImage = new System.Windows.Forms.Button();
            this.imagePath = new System.Windows.Forms.TextBox();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.sourceImage = new System.Windows.Forms.PictureBox();
            this.kuwaharaImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.thresholdImage = new System.Windows.Forms.PictureBox();
            this.medianImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuwaharaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianImage)).BeginInit();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(696, 526);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.imagePath);
            this.panel1.Controls.Add(this.loadImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 34);
            this.panel1.TabIndex = 0;
            // 
            // loadImage
            // 
            this.loadImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.loadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadImage.Location = new System.Drawing.Point(567, 0);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new System.Drawing.Size(123, 34);
            this.loadImage.TabIndex = 0;
            this.loadImage.Text = "Open Image...";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new System.EventHandler(this.loadImage_Click);
            // 
            // imagePath
            // 
            this.imagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePath.Location = new System.Drawing.Point(0, 0);
            this.imagePath.Name = "imagePath";
            this.imagePath.ReadOnly = true;
            this.imagePath.Size = new System.Drawing.Size(567, 32);
            this.imagePath.TabIndex = 1;
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "\"All Images|*.jpeg;*.jpg;*.bmp;*.png;*.gif;*.tiff\"";
            this.openImageDialog.RestoreDirectory = true;
            this.openImageDialog.Title = "Open image for recognition";
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 366);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(690, 135);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source Image";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sourceImage
            // 
            this.sourceImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceImage.Location = new System.Drawing.Point(3, 43);
            this.sourceImage.Name = "sourceImage";
            this.sourceImage.Size = new System.Drawing.Size(342, 135);
            this.sourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceImage.TabIndex = 5;
            this.sourceImage.TabStop = false;
            // 
            // kuwaharaImage
            // 
            this.kuwaharaImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kuwaharaImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kuwaharaImage.Location = new System.Drawing.Point(351, 43);
            this.kuwaharaImage.Name = "kuwaharaImage";
            this.kuwaharaImage.Size = new System.Drawing.Size(342, 135);
            this.kuwaharaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kuwaharaImage.TabIndex = 6;
            this.kuwaharaImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "After Kuwahara";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thresholdImage
            // 
            this.thresholdImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thresholdImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thresholdImage.Location = new System.Drawing.Point(3, 204);
            this.thresholdImage.Name = "thresholdImage";
            this.thresholdImage.Size = new System.Drawing.Size(342, 136);
            this.thresholdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thresholdImage.TabIndex = 8;
            this.thresholdImage.TabStop = false;
            // 
            // medianImage
            // 
            this.medianImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medianImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medianImage.Location = new System.Drawing.Point(351, 204);
            this.medianImage.Name = "medianImage";
            this.medianImage.Size = new System.Drawing.Size(342, 136);
            this.medianImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.medianImage.TabIndex = 9;
            this.medianImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "After Threshold";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Result. After Median filter";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 526);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Digit Captcha Recogniser";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuwaharaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medianImage)).EndInit();
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
    }
}

