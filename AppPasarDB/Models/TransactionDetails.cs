using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarDB.Models
{
    public class TransactionDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Transaction Detail Id")]
        public int TransactionDetailId { get; set; }
        public int TransactionsId { get; set; }
        public int CustomerId { get; set; }
        public int Qty { get; set; }
        public int SubTotal { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Transaction Transactions { get; set; }
    }
}
