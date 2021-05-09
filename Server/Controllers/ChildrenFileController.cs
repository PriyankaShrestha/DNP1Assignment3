using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Data.ChildrenService;

namespace Server.Controllers
{
    [ApiController]
    [Route("/children")]
    public class ChildrenFileController :ControllerBase
    {
        private IChildrenService childrenService;

        public ChildrenFileController(IChildrenService service)
        {
            childrenService = service;
        }

        [HttpGet]
        [Route("{Address}")]
        public async Task<ActionResult<IList<Child>>> GetChild([FromRoute] string Address)
        {
            try
            {
                IList<Child> children = await childrenService.GetChildrenAsync(Address);
                return Ok(children);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{address}/{CprNumber:int}")]
        public async Task<ActionResult> DeleteChild([FromRoute] string Address, [FromRoute] int CprNumber)
        {
            try
            {
                await childrenService.RemoveChildAsync(CprNumber, Address);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        [Route("{Address}")]
        public async Task<ActionResult<Child>> AddChild([FromBody] Child child, [FromRoute] string address)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Child toAdd = await childrenService.AddChildAsync(child, address);
                return Created($"/{toAdd}", toAdd);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}