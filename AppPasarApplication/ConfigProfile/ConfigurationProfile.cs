using AppPasarApplication.Default_Services.CustomerServices.Dto;
using AppPasarApplication.Default_Services.SupplierServices.Dto;
using AppPasarApplication.Default_Services.TransactionDetailServices.Dto;
using AppPasarApplication.Default_Services.TransactionServices.Dto;
using AppPasarDB.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.ConfigProfile
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            CreateMap<Customers, CustomerDto>();
            CreateMap<CustomerDto, Customers>();

            CreateMap<Suppliers, SupplierDto>();
            CreateMap<SupplierDto, Suppliers>();

            CreateMap<Transaction, TransactionDto>();
            CreateMap<TransactionDto, Transaction>();

            CreateMap<TransactionDetails, TransactionDetailDto>();
            CreateMap<TransactionDetailDto, TransactionDetails>();
        }
    }
}
