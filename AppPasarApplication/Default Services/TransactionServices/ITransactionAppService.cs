using AppPasarApplication.Default_Services.TransactionServices.Dto;
using AppPasarDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Transaction = AppPasarDB.Models.Transaction;

namespace AppPasarApplication.Default_Services.TransactionServices
{
    public interface ITransactionAppService
    {
        Transaction Create(CreateTransactionDto model);
        Transaction Update(UpdateTransactionDto model);
    }
}
