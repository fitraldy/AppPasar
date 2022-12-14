using AppPasarApplication.Default_Services.CustomerServices;
using AppPasarApplication.Default_Services.CustomerServices.Dto;
using AppPasarApplication.Helper;
using AppPasarApplication.Model;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace AppPasarAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [HttpPost("CreateCustomer")]
        [Produces("application/json")]
        public IActionResult Create([FromBody] CreateCustomerDto model)
        {
            try
            {
                var customer = _customerAppService.Create(model);
                return Requests.Response(this, new ApiStatus(200), customer, "Success");
            }
            catch (Exception ex)
            {
                return Requests.Response(this, new ApiStatus(404), null, ex.Message);
            }
        }

        [HttpPatch("UpdateCustomer")]
        public IActionResult Update([FromBody] UpdateCustomerDto model)
        {
            try
            {
                var customer = _customerAppService.Update(model);
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

        [HttpDelete("DeleteCustomer")]
        public IActionResult Delete(int id)
        {
            try
            {
                var field = _customerAppService.Delete(id);
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
