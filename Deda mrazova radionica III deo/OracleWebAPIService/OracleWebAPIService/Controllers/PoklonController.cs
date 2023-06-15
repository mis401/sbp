using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class PoklonController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiPoklone")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetPoklone()
    {
        try
        {
            var pokloni = DataProviderBenc.VratiSvePoklone();

            return new JsonResult(pokloni);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    [HttpPost]
    [Route("DodajPoklon")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult AddPoklon([FromBody] PoklonView poklon)
    {
        try
        {
            var data = DataProviderBenc.DodajPoklon(poklon);

            return Ok("Uspesno unesen poklon sa IDjem" + data.ID);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    [HttpPut]
    [Route("AzurirajPoklon")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult UpdatePoklon([FromBody] PoklonView poklon)
    {
        try
        {
            var data = DataProviderBenc.AzurirajPoklon(poklon);
            if (data != null) return Ok($"Uspesno promenjen poklon sa IDjem {data.ID}");
            else throw new Exception("Nesto nije dobro");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    [HttpDelete]
    [Route("ObrisiPoklon")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult DeletePoklon(int id)
    {
        try
        {
            var deleted = DataProviderBenc.ObrisiPoklon(id);
            if (deleted) return Ok();
            else throw new Exception("Neuspesno brisanje");


        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }
}