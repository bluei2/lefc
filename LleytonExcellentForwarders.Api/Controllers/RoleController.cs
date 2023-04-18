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
    public class RoleController : ControllerBase
    {
        private readonly IRoleService                _roleService;
        private readonly ILogger<RoleController>     _logger;

        public RoleController(IRoleService roleService, ILogger<RoleController> logger){
            _roleService     = roleService;
            _logger          = logger;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateAsync(RoleModel model){
            if (ModelState.IsValid){
                await _roleService.CreateAsync(model);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> EditAsync(RoleModel model){
            if (ModelState.IsValid){
                await _roleService.EditAsync(model);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetAsync(Guid? id){
            if (id != null){
                var model = await _roleService.GetAsync(id);
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllAsync(){
            if (ModelState.IsValid){
                var model = await _roleService.GetAllAsync();
                return Ok(model);
            }
            else{
                return BadRequest();
            }
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteAsync(Guid? id){
            if (id != null){
                await _roleService.DeleteAsync(id);
                return Ok();
            }
            else{
                return BadRequest();
            }
        }
    }
}
