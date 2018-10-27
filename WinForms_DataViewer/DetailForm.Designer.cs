namespace WinForms_DataViewer
{
    partial class DetailForm
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
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.image_Picture = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbl_ReleaseDate = new System.Windows.Forms.Label();
            this.lbl_RetailPrice = new System.Windows.Forms.Label();
            this.lbl_UnitsSold = new System.Windows.Forms.Label();
            this.lbl_Media = new System.Windows.Forms.Label();
            this.lbl_Manufacturer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductName.Location = new System.Drawing.Point(106, 9);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(187, 31);
            this.lbl_ProductName.TabIndex = 5;
            this.lbl_ProductName.Text = "Product Name";
            // 
            // image_Picture
            // 
            this.image_Picture.Location = new System.Drawing.Point(71, 65);
            this.image_Picture.Name = "image_Picture";
            this.image_Picture.Size = new System.Drawing.Size(257, 170);
            this.image_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image_Picture.TabIndex = 6;
            this.image_Picture.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(306, 423);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_ReleaseDate
            // 
            this.lbl_ReleaseDate.AutoSize = true;
            this.lbl_ReleaseDate.Location = new System.Drawing.Point(12, 292);
            this.lbl_ReleaseDate.Name = "lbl_ReleaseDate";
            this.lbl_ReleaseDate.Size = new System.Drawing.Size(94, 17);
            this.lbl_ReleaseDate.TabIndex = 10;
            this.lbl_ReleaseDate.Text = "Release Date";
            // 
            // lbl_RetailPrice
            // 
            this.lbl_RetailPrice.AutoSize = true;
            this.lbl_RetailPrice.Location = new System.Drawing.Point(12, 319);
            this.lbl_RetailPrice.Name = "lbl_RetailPrice";
            this.lbl_RetailPrice.Size = new System.Drawing.Size(80, 17);
            this.lbl_RetailPrice.TabIndex = 11;
            this.lbl_RetailPrice.Text = "Retail Price";
            // 
            // lbl_UnitsSold
            // 
            this.lbl_UnitsSold.AutoSize = true;
            this.lbl_UnitsSold.Location = new System.Drawing.Point(12, 349);
            this.lbl_UnitsSold.Name = "lbl_UnitsSold";
            this.lbl_UnitsSold.Size = new System.Drawing.Size(72, 17);
            this.lbl_UnitsSold.TabIndex = 12;
            this.lbl_UnitsSold.Text = "Units Sold";
            // 
            // lbl_Media
            // 
            this.lbl_Media.AutoSize = true;
            this.lbl_Media.Location = new System.Drawing.Point(12, 375);
            this.lbl_Media.Name = "lbl_Media";
            this.lbl_Media.Size = new System.Drawing.Size(46, 17);
            this.lbl_Media.TabIndex = 13;
            this.lbl_Media.Text = "Media";
            // 
            // lbl_Manufacturer
            // 
            this.lbl_Manufacturer.AutoSize = true;
            this.lbl_Manufacturer.Location = new System.Drawing.Point(12, 262);
            this.lbl_Manufacturer.Name = "lbl_Manufacturer";
            this.lbl_Manufacturer.Size = new System.Drawing.Size(92, 17);
            this.lbl_Manufacturer.TabIndex = 14;
            this.lbl_Manufacturer.Text = "Manufacturer";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 463);
            this.Controls.Add(this.lbl_Manufacturer);
            this.Controls.Add(this.lbl_Media);
            this.Controls.Add(this.lbl_UnitsSold);
            this.Controls.Add(this.lbl_RetailPrice);
            this.Controls.Add(this.lbl_ReleaseDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.image_Picture);
            this.Controls.Add(this.lbl_ProductName);
            this.Name = "DetailForm";
            this.Text = "Detail Form";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.PictureBox image_Picture;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl_ReleaseDate;
        private System.Windows.Forms.Label lbl_RetailPrice;
        private System.Windows.Forms.Label lbl_UnitsSold;
        private System.Windows.Forms.Label lbl_Media;
        private System.Windows.Forms.Label lbl_Manufacturer;
    }
}