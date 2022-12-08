using AppPasar.Application.ProductServce.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasar.Application.ProductServce
{
    public interface IProductAppService
    {
        void Create(ProductDto model);
        void Update(ProductDto model);
        void Delete(int id);
    }
}
