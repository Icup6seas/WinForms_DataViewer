using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_DataViewer
{
    public partial class Form1 : Form
    {
        private List<Product> _products;

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadXmlFileAndBindToDataGrid()
        {
            string dataFilePath = AppConfig.dataFilePath;

            //
            // read data file
            //
            IDataService dataService = new XmlDataService(dataFilePath);
            _products = dataService.ReadAll();

            //
            // bind list to DataGridView control
            //
            var bindingList = new BindingList<Product>(_products);
            var source = new BindingSource(bindingList, null);
            dataGridView_Products.DataSource = source;

            //
            // configure DataGridView control
            //
            this.dataGridView_Products.Columns["Id"].Visible = false;
            this.dataGridView_Products.Columns["ImageFileName"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ReadXmlFileAndBindToDataGrid();
            }
            catch (FileNotFoundException)
            {

                MessageBox.Show("Unable to locate data file.\nExiting the application.");
                this.Close();
            }

        }

        private void btn_CheckList_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_Products.SelectedRows)
            {
                dataGridView_Products.Rows.RemoveAt(row.Index);
            }
        }

        private void btn_Details_Click(object sender, EventArgs e)
        {
            if (dataGridView_Products.SelectedRows.Count == 1)
            {
                Product product = new Product();
                product = (Product)dataGridView_Products.CurrentRow.DataBoundItem;

                DetailForm detailForm = new DetailForm(product);
                detailForm.ShowDialog();
            }
        }

        //
        //Sort button vode but it doesn't seem to be working. At atleast it is not pointing to the correct column.
        //
        private void btn_PriceSortAsend_Click(object sender, EventArgs e)
        {
            dataGridView_Products.Sort(dataGridView_Products.Columns[3], ListSortDirection.Ascending);
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            if (dataGridView_Products.SelectedRows.Count >= 0)
            {
                Product product = new Product();
                product = (Product)dataGridView_Products.CurrentRow.DataBoundItem;

                HelpForm helpFrom = new HelpForm(product);
                helpFrom.ShowDialog();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            try
            {
                IDataService XmlDataService = new XmlDataService(AppConfig.dataFilePath);
                XmlDataService.WriteAll(_products);
            }
            catch (Exception)
            {

                throw;
            }
            this.Close();

        }
    }
}
