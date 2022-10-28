using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplements.Models
{
    public class UnitOfMeasurement
    {
        public int Id { get; set; }
        [Required]
        public string UnitOfMeasurementName { get; set; }
    }
}
