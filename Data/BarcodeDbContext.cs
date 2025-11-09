using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_barcode.Entities;

namespace tcc_barcode.Data
{
    public class BarcodeDbContext : DbContext
    {
        public BarcodeDbContext(DbContextOptions<BarcodeDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
