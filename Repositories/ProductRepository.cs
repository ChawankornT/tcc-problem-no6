using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tcc_barcode.Data;
using tcc_barcode.Entities;

namespace tcc_barcode.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly BarcodeDbContext _context;

        public ProductRepository(BarcodeDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var exist = await _context.Products.FindAsync(id);
            if (exist != null)
            {
                _context.Remove(exist);
                await _context.SaveChangesAsync();
            }
        }

        public Task UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
