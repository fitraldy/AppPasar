using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.TransactionDetailServices.Dto
{
    public class TransactionDetailDto
    {
        public int TransactionDetailId { get; set; }
        public int TransactionsId { get; set; }
        public int CustomerId { get; set; }
        public int Qty { get; set; }
        public int SubTotal { get; set; }
    }
}
