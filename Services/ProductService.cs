using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using tcc_barcode.Entities;
using tcc_barcode.Repositories;
using ZXing;

namespace tcc_barcode.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductViewDto>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            if (!products.Any()) return Enumerable.Empty<ProductViewDto>();


            return products.Select(p => new ProductViewDto
            {
                Id = p.Id,
                ProductCode = p.ProductCode,
                Barcode = GenerateBarcode39(p.ProductCode)
            }).ToList();
        }

        public async Task AddProductAsync(string productCode)
        {
            string pattern = @"^[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}-[A-Z0-9]{4}$";
            if (!Regex.IsMatch(productCode, pattern))
            {
                throw new Exception("Invalid barcode format. Product code must be 16 characters: A-Z and 0-9.");
            }

            var product = new Product
            {
                ProductCode = productCode,
                CreatedDate = DateTime.Now,
            };

            await _productRepository.AddAsync(product);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }

        private Image GenerateBarcode39(string text)
        {
            var writer = new BarcodeWriterPixelData
            {
                Format = BarcodeFormat.CODE_39,
                Options = new ZXing.Common.EncodingOptions()
                {
                    Height = 50,
                    Width = 200,
                    Margin = 2,
                    PureBarcode = true
                },
            };

            var data = writer.Write(text.Replace("-", ""));
            var bitmap = new Bitmap(data.Width, data.Height, PixelFormat.Format32bppArgb);
            var rect = new Rectangle(0, 0, data.Width, data.Height);
            var bmpData = bitmap.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
            try
            {
                Marshal.Copy(data.Pixels, 0, bmpData.Scan0, data.Pixels.Length);
            }
            finally
            {
                bitmap.UnlockBits(bmpData);
            }
            return bitmap;
        }
    }
}
