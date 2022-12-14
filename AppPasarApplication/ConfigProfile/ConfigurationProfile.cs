using AppPasarApplication.Default_Services.CustomerServices.Dto;
using AppPasarApplication.Default_Services.MarketServices.Dto;
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
            CreateMap<Customer, CreateCustomerDto>();
            CreateMap<CreateCustomerDto, Customer>();

            CreateMap<Customer, UpdateCustomerDto>();
            CreateMap<UpdateCustomerDto, Customer>();

            CreateMap<Supplier, CreateSupplierDto>();
            CreateMap<CreateSupplierDto, Supplier>();

            CreateMap<Supplier, UpdateSupplierDto>();
            CreateMap<UpdateSupplierDto, Supplier>();

            CreateMap<Market, CreateMarketDto>();
            CreateMap<CreateMarketDto, Market>();

            CreateMap<Market, MarketListDto>();
            CreateMap<MarketListDto, Market>();

            CreateMap<Market, UpdateMarketDto>();
            CreateMap<UpdateMarketDto, Market>();

            CreateMap<Transaction, CreateTransactionDto>();
            CreateMap<CreateTransactionDto, Transaction>();

            CreateMap<Transaction, UpdateTransactionDto>();
            CreateMap<UpdateTransactionDto, Transaction>();

            CreateMap<TransactionDetail, TransactionDetailDto>();
            CreateMap<TransactionDetailDto, TransactionDetail>();
        }
    }
}
