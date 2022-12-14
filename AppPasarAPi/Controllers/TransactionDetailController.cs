using AppPasarApplication.Default_Services.TransactionDetailServices;
using AppPasarApplication.Helper;
using AppPasarApplication.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppPasarAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionDetailController : ControllerBase
    {
        private readonly ITransactionDetailAppService _transactionDetailAppService;
        public TransactionDetailController(ITransactionDetailAppService transactionDetailAppService)
        {
            _transactionDetailAppService = transactionDetailAppService;
        }

        [HttpGet("GetAllTransactionDetails")]
        [Produces("application/json")]
        public IActionResult GetAllTransactionDetails([FromQuery] PageInfo pageInfo)
        {
            try
            {
                var details = _transactionDetailAppService.GetAllTransactionsDetail(pageInfo);
                return Requests.Response(this, new ApiStatus(200), details, "");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(404), null, ex.Message);
            }
        }
    }
}
