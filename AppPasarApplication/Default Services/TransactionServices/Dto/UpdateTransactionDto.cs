using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.TransactionServices.Dto
{
    public class UpdateTransactionDto
    {
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public string TransactionCode { get; set; }
        public Nullable<DateTime> TransactionDate { get; set; }
        public float Total { get; set; }
        public string Description { get; set; }
    }
}
