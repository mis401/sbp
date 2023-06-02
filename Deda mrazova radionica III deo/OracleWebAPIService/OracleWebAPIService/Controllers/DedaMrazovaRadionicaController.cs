using DatabaseAccess;
using DatabaseAccess.DTOs;
using DatabaseAccess.Entiteti;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DedaMrazovaRadionicaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPisma")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPisma()
        {
            try
            {
                var pisma = DataProvider.vratiSvaPisma();

                var all = pisma.Select(p => new { p.ID, p.tekst, p.indDobrote }).ToList();

                return new JsonResult(all);
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