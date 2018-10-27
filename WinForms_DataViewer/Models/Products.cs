using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_DataViewer.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }
        public int DateReleased { get; set; }
        public string Media { get; set; }
        public int UnitsSold { get; set; }
        public string Manufacturer { get; set; }
        public string ImageFileName { get; set; }

        public string ProductNameAndNumber()
        {
            return ProductName + (Number != null ? " " + Number : "");
        }
    }
}
