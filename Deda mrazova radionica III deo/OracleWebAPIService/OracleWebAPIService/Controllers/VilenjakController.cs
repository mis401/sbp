

using DatabaseAccess;
using Microsoft.AspNetCore.Mvc;
using DatabaseAccess.DTOs;

namespace OracleWebAPIService.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class VilenjakController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiVilenjake")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVilenjake()
        {
            try
            {
                var vilenjaci = DataProviderBenc.VratiSveVilenjake();

                return new JsonResult(vilenjaci);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



        [HttpGet]
        [Route("PreuzmiVilenjakeZaIzraduIgracaka/{imeVilenjaka}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVilenjakeZaIzraduIgracaka(string imeVilenjaka)
        {
            try
            {
                var vilenjaci = DataProviderBenc.VratiVilenjakeZaIzraduIgracakaView(imeVilenjaka);

                return new JsonResult(vilenjaci);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiVilenjakeZaIsporuku/{imeVilenjaka}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVilenjakeZaIsporuku([FromRoute(Name = "imeVilenjaka")] string imeVilenjaka)
        {
            try
            {
                var vilenjaci = DataProviderBenc.VratiSveVilenjakeZaIsporukuView(imeVilenjaka);

                return new JsonResult(vilenjaci);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiVilenjakeZaPoklone/{imeVilenjaka}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVilenjakeZaPoklone([FromRoute(Name = "imeVilenjaka")] string imeVilenjaka)
        {
            try
            {

                var vilenjaci = DataProviderBenc.VratiSveVilenjakeZaPokloneView(imeVilenjaka);

                return new JsonResult(vilenjaci);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiVilenjakeZaIrvase/{imeVilenjaka}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVilenjakeZaIrvaseView([FromRoute(Name = "imeVilenjaka")] string imeVilenjaka)
        {
            try
            {
                var vilenjaci = DataProviderBenc.vratiVilenjakaZaIrvaseView(imeVilenjaka);

                return new JsonResult(vilenjaci);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        [Route("DodajVilenjakaZaIzraduIgracaka")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajVilenjakaZaIzraduIgracaka([FromBody] VilenjakZaIzraduIgracakaView vilenjak)
        {
            try
            {
                var vilenjakEntitet = DataProviderBenc.DodajVilenjakaZaIzraduIgracaka(vilenjak);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}