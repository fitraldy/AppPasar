using AppPasarApplication.Default_Services.MarketServices.Dto;
using AppPasarApplication.Helper;
using AppPasarDB.Context;
using AppPasarDB.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.MarketServices
{

    public class MarketAppService : IMarketAppService
    {
        private readonly PasarContext _pasarContext;
        private IMapper _mapper;
        public MarketAppService(PasarContext pasarContext, IMapper mapper)
        {
            _pasarContext = pasarContext;
            _mapper = mapper;
        }

        public Market Create(CreateMarketDto model)
        {
            var market = _mapper.Map<Market>(model);
            _pasarContext.Markets.Add(market);
            _pasarContext.SaveChanges();

            return market;
        }

        public Market Delete(int id)
        {
            var market = _pasarContext.Markets.FirstOrDefault(w => w.MarketId == id);
            _pasarContext.Markets.Remove(market);
            _pasarContext.SaveChanges();

            return market;
        }

        public PagedResult<MarketListDto> GetAllMarket(PageInfo pageInfo)
        {
            var pagedResult = new PagedResult<MarketListDto>
            {
                Data = (from market in _pasarContext.Markets
                        join customer in _pasarContext.Customers
                        on market.MarketId equals customer.CustomerId
                        select new MarketListDto
                        {
                            MarketName = market.MarketName,
                            MarketNumber = market.MarketNumber,
                            CustomerId = customer.CustomerId
                        })
                                    .Skip(pageInfo.Skip)
                                    .Take(pageInfo.PageSize)
                                    .OrderBy(w => w.MarketNumber),
                Total = _pasarContext.Markets.Count()
            };

            return pagedResult;
        }

        public Market Update(UpdateMarketDto model)
        {
            var market = _mapper.Map<Market>(model);
            _pasarContext.Markets.Update(market);
            _pasarContext.SaveChanges();

            return market;
        }
    }
}
