using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplements.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string SupplierOne { get; set; }
        [Required]
        public string SupplierTwo { get; set; }
        [Required]
        public string SupplierThree { get; set; }
        [Required]
        [NotMapped]
        public List<UnitOfMeasurement> UnitOfMeasurement { get; set; }
        [Required]
        [MaxLength(50),MinLength(10)]
        public string Country { get; set; }
    }
}
