using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasar.Application.ProductServce.Dto
{
    public class ProductDto
    {
        public int ProductsId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductQty { get; set; }
    }
}
