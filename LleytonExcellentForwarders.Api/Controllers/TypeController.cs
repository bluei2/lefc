using LleytonExcellentForwarders.Interface;
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
    public class TypeController : ControllerBase
    {
            private readonly ITypeService                _typeService;
            private readonly ILogger<TypeController>     _logger;

            public TypeController(ITypeService typeService, ILogger<TypeController> logger){
                _typeService     = typeService;
                _logger          = logger;
            }

            [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAsync(Guid? id){
            if (id != null){
                var model = await _typeService.GetAsync(id);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync(){
            if (ModelState.IsValid){
                var model = await _typeService.GetAllAsync();
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }
    }
}
