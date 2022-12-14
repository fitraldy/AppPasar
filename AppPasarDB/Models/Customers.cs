using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarDB.Models
{
    [Table("Customer", Schema = "dbo")]

    public class Customers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductQty { get; set; }
        public int SupplierId { get; set; }

        public virtual Suppliers Suppliers { get; set; }
        public virtual ICollection<TransactionDetails> TransactionDetails { get; set; }


    }
}
