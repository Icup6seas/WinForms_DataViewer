using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_DataViewer
{
    public partial class HelpForm : Form
    {
        Product _productHelp = new Product();

        public HelpForm(Product productHelp)
        {
            InitializeComponent();
            _productHelp = productHelp;
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            lbl_Instructions.Text = 
                "Instructions: " + 
                "\nPlease highlight the entire row before" + 
                "\nviewing the details or delete a row.";
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
