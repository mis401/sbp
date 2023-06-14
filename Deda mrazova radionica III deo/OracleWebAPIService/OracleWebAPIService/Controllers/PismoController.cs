using DatabaseAccess;
using DatabaseAccess.DTOs;
using DatabaseAccess.Entiteti;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PismoController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPisma")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPisma()
        {
            try
            {
                var pisma = DataProvider.vratiSvaPisma();

                

                return new JsonResult(pisma);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPismo")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddPismo([FromBody]PismoView pismo)
        {
            try
            {
                DataProvider.dodajPismo(pismo);
                
                    
                
                return Ok("Uspesno uneseno pismo sa IDjem" + pismo.ID);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



    }
}