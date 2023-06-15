using DatabaseAccess.DTOs;
using DatabaseAccess;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class DeoRadioniceController:ControllerBase
    {
        [HttpGet]
        [Route("Preuzmi")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetIrvase()
        {
            try
            {
                var igracka = DataProvider.vratiSveIrvase();



                return new JsonResult(igracka);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajIrvasa")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddIrvas([FromBody] IrvasView irvas)
        {
            try
            {
                var data = DataProvider.dodajIrvasa(irvas);



                return Ok("Uspesno uneseno pismo sa IDjem" + irvas.ID);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajIrvasa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateIgracka([FromBody] IrvasView irvas)
        {
            try
            {
                var data = DataProvider.azurirajIrvasa(irvas);
                if (data) return Ok($"Uspesno promenjeno pismo sa IDjem {irvas.ID}");
                else throw new Exception("Nesto nije dobro");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiIrvasa/{irvasIme}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteIrvas(string irvasIme)
        {
            try
            {
                var data = DataProvider.obrisiIrvasa(irvasIme);
                if (!data) throw new Exception("Nepostojeci Id pisma!");
                return Ok($"Obrisano je pismo sa imenom {irvasIme}");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
