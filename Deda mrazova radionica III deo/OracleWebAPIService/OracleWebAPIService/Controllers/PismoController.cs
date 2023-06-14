using DatabaseAccess;
using DatabaseAccess.DTOs;
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

        [HttpPut]
        [Route("AzurirajPismo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePismo([FromBody] PismoView pismo)
        {
            try
            {
                var data = DataProvider.azurirajPismo(pismo);
                if (data) return Ok($"Uspesno promenjeno pismo sa IDjem {pismo.ID}");
                else throw new Exception("Nesto nije dobro");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete]
        [Route("ObrisiPismo/{pismoID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePismo(int pismoID)
        {
            try
            {
                var data = DataProvider.obrisiPismo(pismoID);
                if (!data) throw new Exception("Nepostojeci Id pisma!");
                return Ok($"Obrisano je pismo sa IDjem {pismoID}");
                
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
            
        }



    }
}