using AppPasarApplication.Default_Services.CustomerServices.Dto;
using AppPasarApplication.Helper;
using AppPasarDB.Context;
using AppPasarDB.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.CustomerServices
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly PasarContext _pasarContext;
        private IMapper _mapper;

        public CustomerAppService(PasarContext pasarContext, IMapper mapper)
        {
            _pasarContext = pasarContext;
            _mapper = mapper;
        }

        public Customers Create(CustomerDto model)
        {
            var customer = _mapper.Map<Customers>(model);
            _pasarContext.Customers.Add(customer);
            _pasarContext.SaveChanges();

            return customer;
        }

        public Customers Delete(int id)
        {
            var customer = _pasarContext.Customers.FirstOrDefault(w => w.CustomerId == id);
            _pasarContext.Customers.Remove(customer);
            _pasarContext.SaveChanges();

            return customer;
        }

        public Customers Update(CustomerDto model)
        {
            var customer = _mapper.Map<Customers>(model);
            _pasarContext.Customers.Update(customer);
            _pasarContext.SaveChanges();

            return customer;
        }
    }
}
