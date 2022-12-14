using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.MarketServices.Dto
{
    public class UpdateMarketDto
    {
        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public string MarketNumber { get; set; }

        public int CustomerId { get; set; }
    }
}
