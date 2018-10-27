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
    public partial class HelpFrom : Form
    {
        Product _productHelp = new Product();

        public HelpFrom(Product productHelp)
        {
            InitializeComponent();
            _productHelp = productHelp;
        }

        private void HelpFrom_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Test" + _productHelp.HelpTextBox.ToString();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
