using AppPasarApplication.Default_Services.MarketServices;
using AppPasarApplication.Default_Services.MarketServices.Dto;
using AppPasarApplication.Helper;
using AppPasarApplication.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppPasarAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        private readonly IMarketAppService _marketAppService;

        public MarketController(IMarketAppService marketAppService)
        {
            _marketAppService = marketAppService;
        }

        [HttpGet("GetAllMarket")]
        [Produces("application/json")]
        public IActionResult GetAllMarket([FromQuery] PageInfo pageInfo)
        {
            try
            {
                var marketList = _marketAppService.GetAllMarket(pageInfo);
                return Requests.Response(this, new ApiStatus(200), marketList, "");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(404), null, ex.Message);
            }
        }

        [HttpPost("CreateMarket")]
        public IActionResult Create([FromBody] CreateMarketDto model)
        {
            try
            {
                var market = _marketAppService.Create(model);
                if (market == null)
                {
                    return Requests.Response(this, new ApiStatus(406), market, "Error");
                }
                return Requests.Response(this, new ApiStatus(200), market, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }

        [HttpPatch("UpdateMarket")]
        public IActionResult Edit([FromBody] UpdateMarketDto model)
        {
            try
            {
                var field = _marketAppService.Update(model);
                if (field == null)
                {
                    return Requests.Response(this, new ApiStatus(406), field, "error");
                }
                return Requests.Response(this, new ApiStatus(200), field, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }

        [HttpDelete("DeleteMarket")]
        public IActionResult Delete(int id)
        {
            try
            {
                var field = _marketAppService.Delete(id);
                if (field == null)
                {
                    return Requests.Response(this, new ApiStatus(406), field, "Error");
                }
                return Requests.Response(this, new ApiStatus(200), field, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(500), null, ex.Message);
            }
        }
    }
}
