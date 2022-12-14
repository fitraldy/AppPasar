using AppPasarApplication.Default_Services.CustomerServices.Dto;
using AppPasarApplication.Default_Services.SupplierServices.Dto;
using AppPasarDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.SupplierServices
{
    public interface ISupplierAppService
    {
        Supplier Create(CreateSupplierDto model);
        Supplier Delete(int id);
        Supplier Update(UpdateSupplierDto model);
    }
}
