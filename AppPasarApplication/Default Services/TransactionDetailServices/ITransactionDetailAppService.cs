using AppPasarApplication.Default_Services.TransactionDetailServices.Dto;
using AppPasarApplication.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.TransactionDetailServices
{
    public interface ITransactionDetailAppService
    {
        PagedResult<TransactionDetailDto> GetAllTransactionsDetail(PageInfo pageInfo);
    }
}
