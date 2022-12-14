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

    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public virtual IEnumerable<Transaction> Transactions { get; set; }


    }
}
