using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppPasar.Models
{
    public class Suppliers
    {
        public int SuppliersId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
    }
}
