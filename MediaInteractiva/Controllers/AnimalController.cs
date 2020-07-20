using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Infrastructure;
using BLL.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using SharedModels.DTOs;

namespace MediaInteractiva.Controllers
{
    [EnableCors("AllowAll")]
    [Route(ApiConstants.DefaultRouting)]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalService _animalService;
        public AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [EnableCors("AllowAll")]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            try
            {
                var result = await _animalService.Get(id).ConfigureAwait(true);
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
                var result = await _animalService.GetList().ConfigureAwait(true);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [EnableCors("AllowAll")]
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] AnimalDto dto)
        {
            try
            {
                var result = await _animalService.Create(dto).ConfigureAwait(true);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [EnableCors("AllowAll")]
        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch([FromRoute] int id, [FromBody] AnimalDto dto)
        {
            try
            {
                var result = await _animalService.Update(dto, id).ConfigureAwait(true);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [EnableCors("AllowAll")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                var result = await _animalService.Delete(id).ConfigureAwait(true);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
