using AppPasarApplication.Default_Services.MarketServices.Dto;
using AppPasarApplication.Helper;
using AppPasarDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.MarketServices
{
    public interface IMarketAppService
    {
        Market Create(CreateMarketDto model);
        Market Update(UpdateMarketDto model);
        Market Delete(int id);
        PagedResult<MarketListDto> GetAllMarket(PageInfo pageInfo);
    }
}
