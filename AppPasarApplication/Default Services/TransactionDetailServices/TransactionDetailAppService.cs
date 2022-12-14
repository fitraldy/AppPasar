using AppPasarApplication.Default_Services.TransactionDetailServices.Dto;
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
                Data = (from transaction in _pasarContext.Transactions
                        select new TransactionDetailDto
                        {
                            TransactionId = transaction.TransactionId,
                            CustomerId = transaction.CustomerId,
                            TransactionCode = transaction.TransactionCode,
                            TransactionDate = transaction.TransactionDate,
                            Total = transaction.Total,
                            Description = transaction.Description
                        })
                                    .Skip(pageInfo.Skip)
                                    .Take(pageInfo.PageSize)
                                    .OrderBy(w => w.TransactionDate),
                Total = _pasarContext.TransactionDetails.Count()
            };

            return transDetail;
        }
    }
}
