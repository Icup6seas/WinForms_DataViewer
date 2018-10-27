namespace WinForms_DataViewer
{
    partial class HelpForm
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Instructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(255, 323);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(81, 32);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Instructions
            // 
            this.lbl_Instructions.AutoSize = true;
            this.lbl_Instructions.Location = new System.Drawing.Point(13, 35);
            this.lbl_Instructions.Name = "lbl_Instructions";
            this.lbl_Instructions.Size = new System.Drawing.Size(84, 17);
            this.lbl_Instructions.TabIndex = 1;
            this.lbl_Instructions.Text = "Instructions";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 367);
            this.Controls.Add(this.lbl_Instructions);
            this.Controls.Add(this.btn_Close);
            this.Name = "HelpForm";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Instructions;
    }
}