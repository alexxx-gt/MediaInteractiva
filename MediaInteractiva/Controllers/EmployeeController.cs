using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Infrastructure;
using BLL.Infrastructure.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SharedModels.DTOs;

namespace MediaInteractiva.Controllers
{
    [EnableCors("AllowAll")]
    [Route(ApiConstants.DefaultRouting)]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [EnableCors("AllowAll")]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            try
            {
                var result = await _employeeService.Get(id).ConfigureAwait(true);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [EnableCors("AllowAll")]
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            try
            {
                var result = await _employeeService.GetList().ConfigureAwait(true);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [EnableCors("AllowAll")]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] EmployeeDto dto)
        {
            try
            {
                var result = await _employeeService.Create(dto).ConfigureAwait(true);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [EnableCors("AllowAll")]
        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch([FromRoute] int id, [FromBody] EmployeeDto dto)
        {
            try
            {
                var result = await _employeeService.Update(dto, id).ConfigureAwait(true);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [EnableCors("AllowAll")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute]int id)
        {
            try
            {
                var result = await _employeeService.Delete(id).ConfigureAwait(true);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
