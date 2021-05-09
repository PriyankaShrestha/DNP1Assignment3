using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Data.AdultService;

namespace Server.Controllers
{
    [ApiController]
    [Route("/adults")]
    public class AdultFileController : ControllerBase
    {
        private IAdultService adultService;

        public AdultFileController(IAdultService service)
        {
            adultService = service;
        }

        [HttpGet]
        [Route("{Address}")]
        public async Task<ActionResult<IList<Adult>>> GetAdults([FromRoute] string Address)
        {
            try
            {
                IList<Adult> adults = await adultService.GetAdultsAsync(Address);
                return Ok(adults);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        [Route("{address}/{id:int}")]
        public async Task<ActionResult<Adult>> GetAdult([FromRoute] string address, [FromRoute] int id)
        {
            try
            {
                Adult adult = await adultService.GetAdultAsync(id, address);
                return Ok(adult);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{address}/{CprNumber:int}")]
        public async Task<ActionResult> DeleteAdult([FromRoute] string Address, [FromRoute] int CprNumber )
        {
            try
            {
                await adultService.RemoveAdultAsync(CprNumber, Address);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        [Route("{Address}")]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult adult,[FromRoute] string Address)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Adult toAdd = await adultService.AddAdultAsync(adult, Address);
                return Created($"/{toAdd}", toAdd);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPatch]
        [Route("{address}")]
        public async Task<ActionResult<Adult>> UpdateAdult([FromBody] Adult adult, [FromRoute] string address)
        {
            try
            {
                Adult toUpdate = await adultService.UpdateAdultAsync(adult, address);
                return Created($"/{toUpdate}", toUpdate);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        [Route("{address}/{id:int}")]
        public async Task<ActionResult> PostJob([FromBody] Job job, [FromRoute] string address, [FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Job toAdd = await adultService.AddJobAsync(job, address, id);
                return Created($"/{toAdd}", toAdd);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}