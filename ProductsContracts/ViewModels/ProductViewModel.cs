using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsContracts.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string SupplierOne { get; set; }
        public string SupplierTwo { get; set; }
        public string SupplierThree { get; set; }
        public List<string> UnitOfMeasurement { get; set; }
        public string Country { get; set; }
    }
}
