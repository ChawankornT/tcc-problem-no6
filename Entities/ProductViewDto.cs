using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc_barcode.Entities
{
    public class ProductViewDto
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public Image? Barcode { get; set; }
    }
}
