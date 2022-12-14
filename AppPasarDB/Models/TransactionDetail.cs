using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarDB.Models
{
    [Table("TransactionDetail", Schema = "dbo")]

    public class TransactionDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Transaction Detail Id")]
        public int TransactionDetailId { get; set; }
        public int TransactionsId { get; set; }
        public int Qty { get; set; }
        public string Status { get; set; }
        public virtual Transaction Transactions { get; set; }
    }
}
