using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarDB.Models
{
    [Table("Transaction", Schema = "dbo")]

    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Transaction Id")]
        public int TransactionId { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public string TransactionCode { get; set; }
        public Nullable<DateTime> TransactionDate { get; set; }
        public float Total { get; set; }
        public string Description { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual IEnumerable<TransactionDetail> TransactionDetails { get; set; }

    }
}
