namespace WinForms_DataViewer
{
    partial class Form1
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
            this.dataGridView_Products = new System.Windows.Forms.DataGridView();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Details = new System.Windows.Forms.Button();
            this.btn_DeleteSelected = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Products
            // 
            this.dataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Products.Location = new System.Drawing.Point(12, 48);
            this.dataGridView_Products.Name = "dataGridView_Products";
            this.dataGridView_Products.RowTemplate.Height = 24;
            this.dataGridView_Products.Size = new System.Drawing.Size(614, 317);
            this.dataGridView_Products.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(551, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 30);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(12, 12);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(75, 30);
            this.btn_Help.TabIndex = 2;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.Load += new System.EventHandler(this.HelpForm_Load);
            // 
            // btn_Details
            // 
            this.btn_Details.Location = new System.Drawing.Point(13, 372);
            this.btn_Details.Name = "btn_Details";
            this.btn_Details.Size = new System.Drawing.Size(74, 35);
            this.btn_Details.TabIndex = 3;
            this.btn_Details.Text = "Details";
            this.btn_Details.UseVisualStyleBackColor = true;
            this.btn_Details.Click += new System.EventHandler(this.btn_Details_Click);
            // 
            // btn_DeleteSelected
            // 
            this.btn_DeleteSelected.Location = new System.Drawing.Point(509, 372);
            this.btn_DeleteSelected.Name = "btn_DeleteSelected";
            this.btn_DeleteSelected.Size = new System.Drawing.Size(117, 35);
            this.btn_DeleteSelected.TabIndex = 4;
            this.btn_DeleteSelected.Text = "Delete Selected";
            this.btn_DeleteSelected.UseVisualStyleBackColor = true;
            this.btn_DeleteSelected.Click += new System.EventHandler(this.btn_CheckList_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(115, 6);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(405, 36);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "PlayStation Popular Products";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 414);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_DeleteSelected);
            this.Controls.Add(this.btn_Details);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dataGridView_Products);
            this.Name = "Form1";
            this.Text = "WinForms Data Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Products;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Details;
        private System.Windows.Forms.Button btn_DeleteSelected;
        private System.Windows.Forms.Label lbl_Title;
    }
}

