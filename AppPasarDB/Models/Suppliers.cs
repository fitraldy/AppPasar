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

    public class Suppliers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int SupplierId { get; set; }
        [Required]
        public string SupplierName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductQty { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }


    }
}
