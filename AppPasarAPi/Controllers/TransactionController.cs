using AppPasarApplication.Default_Services.TransactionServices;
using AppPasarApplication.Default_Services.TransactionServices.Dto;
using AppPasarApplication.Helper;
using AppPasarApplication.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppPasarAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionAppService _transactionAppService;
        public TransactionController(ITransactionAppService transactionAppService)
        {
            _transactionAppService = transactionAppService;
        }

        [HttpPost("CreateTransaction")]
        public IActionResult Create([FromBody] CreateTransactionDto model)
        {
            try
            {
                var trans = _transactionAppService.Create(model);
                if (trans == null)
                {
                    return Requests.Response(this, new ApiStatus(406), trans, "Error");
                }
                return Requests.Response(this, new ApiStatus(200), trans, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }


        [HttpPatch("UpdateTransaction")]
        public IActionResult Update([FromBody] UpdateTransactionDto model)
        {
            try
            {
                var trans = _transactionAppService.Update(model);
                if (trans == null)
                {
                    return Requests.Response(this, new ApiStatus(406), trans, "error");
                }
                return Requests.Response(this, new ApiStatus(200), trans, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }
    }
}
