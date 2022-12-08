using AppPasar.Application.SupplierService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasar.Application.SupplierService
{
    public interface ISupplierAppService
    {
        void Create(SupplierDto model);
        void Update(SupplierDto model);
        void Delete(int id);
    }
}
