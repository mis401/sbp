using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;
namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiTimove")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTimove()
        {
            try
            {
                var timovi = DataProviderBenc.vratiSveTimove();

                return new JsonResult(timovi);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajTim")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddTim([FromBody] TimView tim)
        {
            try
            {
                var data = DataProviderBenc.dodajTim(tim);

                return Ok("Uspesno unesen tim sa IDjem" + data.ID);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajTim")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateTim([FromBody] TimView tim)
        {
            try
            {
                var data = DataProviderBenc.azurirajTim(tim);
                if (data != null) return Ok($"Uspesno promenjen tim sa IDjem {data.ID}");
                else throw new Exception("Nesto nije dobro");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiTim/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteTim([FromRoute] int id)
        {
            try
            {
                var data = DataProviderBenc.obrisiTim(id);
                if (data) return Ok($"Uspesno obrisan tim sa IDjem {id}");
                else throw new Exception("Nesto nije dobro");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}