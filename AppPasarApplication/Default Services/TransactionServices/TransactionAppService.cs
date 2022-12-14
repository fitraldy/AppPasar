using AppPasarApplication.Default_Services.TransactionServices.Dto;
using AppPasarDB.Context;
using AppPasarDB.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPasarApplication.Default_Services.TransactionServices
{
    public class TransactionAppService: ITransactionAppService
    {
        private readonly PasarContext _pasarContext;
        private IMapper _mapper;
        
        public TransactionAppService(PasarContext pasarContext, IMapper mapper)
        {
            _pasarContext = pasarContext;
            _mapper = mapper;
        }

        public Transaction Create(TransactionDto model)
        {
            var transaction = _mapper.Map<Transaction>(model);
            _pasarContext.Transactions.Add(transaction);
            _pasarContext.SaveChanges();

            return transaction;
        }

        public Transaction Update(TransactionDto model)
        {
            var transaction = _mapper.Map<Transaction>(model);
            _pasarContext.Transactions.Update(transaction);
            _pasarContext.SaveChanges();

            return transaction;
        }
    }
}
