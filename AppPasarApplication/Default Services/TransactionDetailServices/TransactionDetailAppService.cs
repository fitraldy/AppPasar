using AppPasarApplication.Default_Services.TransactionDetailServices.Dto;
using AppPasarApplication.Helper;
using AppPasarDB.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.TransactionDetailServices
{
    public class TransactionDetailAppService : ITransactionDetailAppService
    {
        private readonly PasarContext _pasarContext;
        private IMapper _mapper;
        
        public TransactionDetailAppService(PasarContext pasarContext, IMapper mapper)
        {
            _pasarContext = pasarContext;
            _mapper = mapper;
        }

        public PagedResult<TransactionDetailDto> GetAllTransactionsDetail(PageInfo pageInfo)
        {
            var transDetail = new PagedResult<TransactionDetailDto>
            {
                Data = (from transactionDetail in _pasarContext.TransactionDetails
                        select new TransactionDetailDto
                        {
                            TransactionDetailId = transactionDetail.TransactionDetailId,
                            CustomerId = transactionDetail.CustomerId,
                            Qty = transactionDetail.Qty,
                            SubTotal = transactionDetail.SubTotal,
                        })
                                    .Skip(pageInfo.Skip)
                                    .Take(pageInfo.PageSize)
                                    .OrderBy(w => w.TransactionDetailId),
                Total = _pasarContext.TransactionDetails.Count()
            };

            return transDetail;
        }
    }
}
