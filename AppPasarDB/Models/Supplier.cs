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
    [Table("Supplier", Schema = "dbo")]

    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string PhoneNumber { get; set; }
        public virtual IEnumerable<Transaction> Transactions { get; set; }


    }
}
