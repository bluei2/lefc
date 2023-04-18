using LleytonExcellentForwarders.Interface;
using LleytonExcellentForwarders.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LleytonExcellentForwarders.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PayrollController : ControllerBase
    {
        private readonly IPayrollService             _payrollService;
        private readonly ILogger<PayrollController>  _logger;

        public PayrollController(IPayrollService payrollService, ILogger<PayrollController> logger){
            _payrollService  = payrollService;
            _logger          = logger;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync(PayrollModel model){
            if (ModelState.IsValid){
                await _payrollService.CreateAsync(model);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> EditAsync(PayrollModel model){
            if (ModelState.IsValid){
                await _payrollService.EditAsync(model);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAsync(Guid? id){
            if (id != null){
                var model = await _payrollService.GetAsync(id);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync(){
            if (ModelState.IsValid){
                var model = await _payrollService.GetAllAsync();
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteAsync(Guid? id){
            if (id != null){
                await _payrollService.DeleteAsync(id);
                return Ok();
            }
            else{
                return BadRequest();
            }
        }
    }
}
