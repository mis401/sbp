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
        [Route("PreuzmiDeoRadionice")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetDeoRadionice()
        {
            try
            {
                var igracka = DataProvider.vratiSveRadionice();



                return new JsonResult(igracka);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajDeoRadionice")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddDeoRadionice([FromBody] DeoRadioniceView deoRad)
        {
            try
            {
                var data = DataProvider.dodajDeoRadionice(deoRad);
                return Ok("Uspesno unesena radionica sa IDjem" + deoRad.ID);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajDeoRadionice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateDeoRadionice([FromBody] DeoRadioniceView dr)
        {
            try
            {
                var data = DataProvider.azurirajDeoRadionice(dr);
                if (data) return Ok($"Uspesno promenjena radionica sa IDjem {dr.ID}");
                else throw new Exception("Nesto nije dobro");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiDeoRadionice/{ime}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteIrvas(string ime)
        {
            try
            {
                var data = DataProvider.obrisiDeoRadionice(ime);
                if (!data) throw new Exception("Nepostojeci Id radionice!");
                return Ok($"Obrisan je deo radionice sa imenom {ime}");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
