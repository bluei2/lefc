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
    public class FuelController : ControllerBase
    {
        private readonly IFuelService                _fuelService;
        private readonly ILogger<FuelController>     _logger;

        public FuelController(IFuelService fuelService, ILogger<FuelController> logger){
            _fuelService     = fuelService;
            _logger          = logger;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync(FuelModel model){
            if (ModelState.IsValid){
                await _fuelService.CreateAsync(model);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> EditAsync(FuelModel model){
            if (ModelState.IsValid){
                await _fuelService.EditAsync(model);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAsync(Guid? id){
            if (id != null){
                var model = await _fuelService.GetAsync(id);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync(){
            if (ModelState.IsValid){
                var model = await _fuelService.GetAllAsync();
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteAsync(Guid? id){
            if (id != null){
                await _fuelService.DeleteAsync(id);
                return Ok();
            }
            else{
                return BadRequest();
            }
        }
    }
}
