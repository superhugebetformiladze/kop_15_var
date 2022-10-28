using DatabaseImplements.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplements
{
    public class ProductDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProductDatabase;Integrated Security=True;MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Product> Products { set; get; }
        public virtual DbSet<UnitOfMeasurement> UnitOfMeasurements { set; get; }
    }
}
