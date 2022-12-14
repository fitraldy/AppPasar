using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarDB.Models
{
    [Table("Market", Schema = "dbo")]
    public class Market
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public string MarketNumber { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
