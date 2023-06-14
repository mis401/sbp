using DatabaseAccess;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeteController:ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiDecu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetDecu()
        {
            try
            {
                var pisma = DataProvider.vratiSvuDecu();



                return new JsonResult(pisma);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
