using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.TransactionDetailServices.Dto
{
    public class TransactionDetailDto
    {
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public string TransactionCode { get; set; }
        public Nullable<DateTime> TransactionDate { get; set; }
        public float Total { get; set; }
        public string Description { get; set; }
    }
}
