

using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TovarController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiTovar")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetTovar()
    {
        try
        {
            var tovar = DataProviderBenc.vratiSveTovare();

            return new JsonResult(tovar);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }





    [HttpPost]
    [Route("DodajTovar")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult AddTovar([FromBody] TovarView tovar)
    {
        try
        {
            var data = DataProviderBenc.dodajTovar(tovar);

            return Ok("Uspesno unesen tovar sa IDjem" + tovar.ID);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }



    [HttpPut]
    [Route("AzurirajTovar")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult UpdateTovar([FromBody] TovarView tovar)
    {
        try
        {
            var data = DataProviderBenc.azurirajTovar(tovar);
            if (data != null) return Ok($"Uspesno promenjen tovar sa IDjem {tovar.ID}");

            return BadRequest($"Greska pri promeni tovara sa IDjem {tovar.ID}");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    [HttpDelete]
    [Route("ObrisiTovar/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult DeleteTovar(int id)
    {
        try
        {
            var data = DataProviderBenc.obrisiTovar(id);
            if (data) return Ok($"Uspesno obrisan tovar sa IDjem {id}");

            return BadRequest($"Greska pri brisanju tovara sa IDjem {id}");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }
}