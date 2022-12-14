using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.SupplierServices.Dto
{
    public class UpdateSupplierDto
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
