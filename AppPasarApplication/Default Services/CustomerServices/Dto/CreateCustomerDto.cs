using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.CustomerServices.Dto
{
    public class CreateCustomerDto
    {
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
