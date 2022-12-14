using AppPasarApplication.Default_Services.CustomerServices.Dto;
using AppPasarApplication.Default_Services.SupplierServices.Dto;
using AppPasarDB.Context;
using AppPasarDB.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.SupplierServices
{
    public class SupplierAppService : ISupplierAppService
    {
        private readonly PasarContext _pasarContext;
        private IMapper _mapper;

        public SupplierAppService(PasarContext pasarContext, IMapper mapper)
        {
            _pasarContext = pasarContext;
            _mapper = mapper;
        }

        public Supplier Create(CreateSupplierDto model)
        {
            var supplier = _mapper.Map<Supplier>(model);
            _pasarContext.Suppliers.Add(supplier);
            _pasarContext.SaveChanges();

            return supplier;
        }

        public Supplier Delete(int id)
        {
            var supplier = _pasarContext.Suppliers.FirstOrDefault(w => w.SupplierId == id);
            _pasarContext.Suppliers.Remove(supplier);
            _pasarContext.SaveChanges();

            return supplier;
        }

        public Supplier Update(UpdateSupplierDto model)
        {
            var supplier = _mapper.Map<Supplier>(model);
            _pasarContext.Suppliers.Update(supplier);
            _pasarContext.SaveChanges();

            return supplier;
        }
    }
}
