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
    public partial class DetailForm : Form
    {
        Product _model = new Product();


        public DetailForm(Product model)
        {
            InitializeComponent();
            _model = model;
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            lbl_ProductName.Text = _model.ProductNameAndNumber();
            lbl_RetailPrice.Text = "Retail Price: " + "$" +  _model.Price.ToString();
            lbl_ReleaseDate.Text = "Release Date: " + _model.DateReleased.ToString();
            lbl_UnitsSold.Text = "Units Sold: " + _model.UnitsSold.ToString() + " Million";
            lbl_Media.Text = "Supported Media: " + _model.Media.ToString();
            lbl_Manufacturer.Text = "Manufacturer: " + _model.Manufacturer.ToString();
            image_Picture.Image = Image.FromFile(@"Images/" + _model.ImageFileName);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
