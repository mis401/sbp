using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class IgrackaController:ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiIgracke")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetDecu()
        {
            try
            {
                var igracka = DataProvider.vratiSveIgracke();



                return new JsonResult(igracka);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajIgracku")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddPIgracka([FromBody] IgrackaView igracka)
        {
            try
            {
                var data = DataProvider.dodajIgracka(igracka);



                return Ok("Uspesno uneseno pismo sa IDjem" + igracka.ID);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajIgracku")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateIgracka([FromBody] IgrackaView igracka)
        {
            try
            {
                var data = DataProvider.azurirajIgracku(igracka);
                if (data) return Ok($"Uspesno promenjeno pismo sa IDjem {igracka.ID}");
                else throw new Exception("Nesto nije dobro");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiIgracka/{igrackaID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteIgracka(int igrackaID)
        {
            try
            {
                var data = DataProvider.obrisiIgracku(igrackaID);
                if (!data) throw new Exception("Nepostojeci Id pisma!");
                return Ok($"Obrisano je pismo sa IDjem {igrackaID}");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
