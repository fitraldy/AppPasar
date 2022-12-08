using AppPasar.Application.ProductServce.Dto;
using AppPasar.Context;
using AppPasar.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasar.Application.ProductServce
{
    internal class ProductAppService : IProductAppService
    {
        private readonly PasatContext _pasatContext;
        private IMapper _mapper;

        public ProductAppService(PasatContext appContext, IMapper mapper)
        {
            _pasatContext = appContext;
            _mapper = mapper;
        }
        public void Create(ProductDto model)
        {
            var product = _mapper.Map<Products>(model);
            _pasatContext.Products.Add(product);
            _pasatContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _pasatContext.Products.FirstOrDefault(w => w.ProductsId == id);

            if (product != null)
            {
                _pasatContext.Products.Remove(product);
                _pasatContext.SaveChanges();
            }
        }

        public void Update(ProductDto model)
        {
            var product = _mapper.Map<Products>(model);
            _pasatContext.Products.Update(product);
            _pasatContext.SaveChanges();
        }
    }
}
