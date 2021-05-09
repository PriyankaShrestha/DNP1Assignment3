using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Data.FamilyService;

namespace Server.Controllers
{
    [ApiController]
    [Route("/families")]
    public class FamilyFileController : ControllerBase
    {
        private IFamilyService familyService;

        public FamilyFileController(IFamilyService service)
        {
            familyService = service;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Family>>> GetFamilies()
        {
            try
            {
                IList<Family> families = await familyService.GetFamiliesAsync();
                return Ok(families);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        [Route("{address}")]
        public async Task<ActionResult<Family>> GetFamily([FromRoute] string address)
        {
            try
            {
                Family family = await familyService.GetFamilyAsync(address);
                return Ok(family);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpDelete]
        [Route("{address}")]
        public async Task<ActionResult> DeleteFamily([FromRoute] string address)
        {
            try
            {
                Console.WriteLine(address);
                await familyService.RemoveFamilyAsync(address);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        public async Task<ActionResult<Family>> AddFamily([FromBody] Family family)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Family toAdd = await familyService.AddFamilyAsync(family);
                return Created($"/{toAdd}", toAdd);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPatch]
        [Route("{address}")]
        public async Task<ActionResult<Family>> UpdateFamily([FromRoute] string address, [FromBody] Family family)
        {
            try
            {
                Family toUpdate = await familyService.UpdateFamilyAsync(address, family);
                return Created($"/{toUpdate}", toUpdate);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }  
    }
}