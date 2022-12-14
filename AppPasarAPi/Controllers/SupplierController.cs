using AppPasarApplication.Default_Services.CustomerServices.Dto;
using AppPasarApplication.Default_Services.CustomerServices;
using AppPasarApplication.Helper;
using AppPasarApplication.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AppPasarApplication.Default_Services.SupplierServices;
using AppPasarApplication.Default_Services.SupplierServices.Dto;

namespace AppPasarAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {

        private readonly ISupplierAppService _supplierAppService;

        public SupplierController(ISupplierAppService supplierAppService)
        {
            _supplierAppService = supplierAppService;
        }

        [HttpPost("CreateSupplier")]
        [Produces("application/json")]
        public IActionResult Create([FromBody] SupplierDto model)
        {
            try
            {
                var customer = _supplierAppService.Create(model);
                return Requests.Response(this, new ApiStatus(200), customer, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(404), null, ex.Message);
            }
        }

        [HttpPatch("UpdateSupplier")]
        public IActionResult Update([FromBody] SupplierDto model)
        {
            try
            {
                var customer = _supplierAppService.Update(model);
                if (customer == null)
                {
                    return Requests.Response(this, new ApiStatus(406), customer, "error");
                }
                return Requests.Response(this, new ApiStatus(200), customer, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(404), null, ex.Message);
            }
        }

        [HttpDelete("DeleteSupplier")]
        public IActionResult Delete(int id)
        {
            try
            {
                var field = _supplierAppService.Delete(id);
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
