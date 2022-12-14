using AppPasarApplication.Default_Services.CustomerServices.Dto;
using AppPasarApplication.Helper;
using AppPasarDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.CustomerServices
{
    public interface ICustomerAppService
    {
        Customers Create(CustomerDto model);
        Customers Delete(int id);
        Customers Update(CustomerDto model);
    }
}
