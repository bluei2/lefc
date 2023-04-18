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
    public class WageController : ControllerBase
    {
        private readonly IWageService                _wageService;
        private readonly ILogger<WageController>     _logger;

        public WageController(IWageService wageService, ILogger<WageController> logger){
            _wageService     = wageService;
            _logger          = logger;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync(WageModel model){
            if (ModelState.IsValid){
                await _wageService.CreateAsync(model);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> EditAsync(WageModel model){
            if (ModelState.IsValid){
                await _wageService.EditAsync(model);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAsync(Guid? id){
            if (id != null){
                var model = await _wageService.GetAsync(id);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync(){
            if (ModelState.IsValid){
                var model = await _wageService.GetAllAsync();
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteAsync(Guid? id){
            if (id != null){
                await _wageService.DeleteAsync(id);
                return Ok();
            }
            else{
                return BadRequest();
            }
        }
    }
}
