using AppPasar.Application.ProductServce.Dto;
using AppPasar.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasar.ConfigProfile
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            CreateMap<Products, ProductDto>();
            CreateMap<ProductDto, Products>();
        }
    }
}
