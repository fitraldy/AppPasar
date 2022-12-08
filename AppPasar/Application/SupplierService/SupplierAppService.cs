using AppPasar.Application.SupplierService.Dto;
using AppPasar.Context;
using AppPasar.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasar.Application.SupplierService
{
    public class SupplierAppService : ISupplierAppService
    {
        private readonly PasatContext _pasatContext;
        private IMapper _mapper;

        public SupplierAppService(PasatContext pasatContext, IMapper mapper)
        {
            _pasatContext = pasatContext;
            _mapper = mapper;
        }

        public void Create(SupplierDto model)
        {
            var supplier = _mapper.Map<Suppliers>(model);
            _pasatContext.Suppliers.Add(supplier);
            _pasatContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var supplier = _pasatContext.Suppliers.FirstOrDefault(w => w.SuppliersId == id);
            if (supplier != null)
            {
                _pasatContext.Suppliers.Remove(supplier);
                _pasatContext.SaveChanges();
            }
        }

        public void Update(SupplierDto model)
        {
            var supplier = _mapper.Map<Suppliers>(model);
            _pasatContext.Suppliers.Update(supplier);
            _pasatContext.SaveChanges();
        }
    }
}
