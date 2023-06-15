using DatabaseAccess;
using DatabaseAccess.DTOs;
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
                var deca = DataProvider.vratiSvuDecu();



                return new JsonResult(deca);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajDete")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddPismo([FromBody] DeteView dete)
        {
            try
            {
                var data = DataProvider.dodajDete(dete);



                return Ok("Uspesno uneseno dete sa IDjem" + dete.ID);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajDete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateDete([FromBody] DeteView dete)
        {
            try
            {
                var data = DataProvider.azurirajDete(dete);
                if (data) return Ok($"Uspesno promenjeno dete sa IDjem {dete.ID}");
                else throw new Exception("Nesto nije dobro");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiDete/{deteID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteDete(int deteID)
        {
            try
            {
                var data = DataProvider.obrisiDete(deteID);
                if (!data) throw new Exception("Nepostojeci Id deteta!");
                return Ok($"Obrisano je dete sa IDjem {deteID}");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
