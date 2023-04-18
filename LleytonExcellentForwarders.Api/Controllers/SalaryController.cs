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
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryService _salaryService;
        private readonly ILogger<SalaryController> _logger;

        public SalaryController(ISalaryService salaryService, ILogger<SalaryController> logger){
            _salaryService = salaryService;
            _logger = logger;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync(SalaryModel model){
            if (ModelState.IsValid){
                await _salaryService.CreateAsync(model);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> EditAsync(SalaryModel model){
            if (ModelState.IsValid){
                await _salaryService.EditAsync(model);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAsync(Guid? id){
            if (id != null){
                var model = await _salaryService.GetAsync(id);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync(){
            if (ModelState.IsValid){
                var model = await _salaryService.GetAllAsync();
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteAsync(Guid? id){
            if (id != null){
                await _salaryService.DeleteAsync(id);
                return Ok();
            }
            else{
                return BadRequest();
            }
        }
    }
}
