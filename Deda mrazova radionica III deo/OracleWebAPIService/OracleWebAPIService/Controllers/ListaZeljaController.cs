using DatabaseAccess.DTOs;
using DatabaseAccess;
using Microsoft.AspNetCore.Mvc;

namespace OracleWebAPIService.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ListaZeljaController:ControllerBase
    {

        [HttpGet]
        [Route("PreuzmiListeZelja")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetDecu()
        {
            try
            {
                var listeZelja = DataProvider.vratiListeZelja();



                return new JsonResult(listeZelja);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajListuZelja")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddIrvas([FromBody] ListaZeljaView listaZelja)
        {
            try
            {
                DataProvider.dodajListuZelja(listaZelja);

               
                    return Ok("Uspesno unesena lista zelja sa IDjem" + listaZelja.ID);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


    }
}
