using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LleytonExcellentForwarders.Interface;
using Microsoft.Extensions.Logging;
using LleytonExcellentForwarders.Model;

namespace LleytonExcellentForwarders.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService               _customerService;
        private readonly ILogger<CustomerController>    _logger;

        public CustomerController(ICustomerService customerService, ILogger<CustomerController> logger){
            _customerService    = customerService;
            _logger             = logger;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync(CustomerModel model){
            if (ModelState.IsValid){
                await _customerService.CreateAsync(model);
                return Ok(model);
            } else{
                return BadRequest();
            }
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> EditAsync(CustomerModel model){
            if (ModelState.IsValid){
                await _customerService.EditAsync(model);
                return Ok(model);
            } else{
                return BadRequest();
            }
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAsync(Guid? id){
            if (id != null){
                var model = await _customerService.GetAsync(id);
                return Ok(model);
            }else{
                return BadRequest();
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync(){
            if (ModelState.IsValid){
                var model = await _customerService.GetAllAsync();
                return Ok(model);
            }else{
                return BadRequest();
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteAsync(Guid? id){
            if (id != null){
                await _customerService.DeleteAsync(id);
                return Ok();
            }else{
                return BadRequest();
            }
        }
    }
}
