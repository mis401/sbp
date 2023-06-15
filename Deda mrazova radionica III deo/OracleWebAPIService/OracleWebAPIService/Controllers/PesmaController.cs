using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PesmaController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiPesme")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetPesme()
    {
        try
        {
            var pesme = DataProviderBenc.vratiSvePesme();

            return new JsonResult(pesme);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    [HttpPost]
    [Route("DodajPesmu")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult AddPesma([FromBody] PesmaView pesma)
    {
        try
        {
            var data = DataProviderBenc.dodajPesmu(pesma);

            return Ok("Uspesno unesena pesma sa IDjem" + data.ID);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    [HttpPut]
    [Route("AzurirajPesmu")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult UpdatePesma([FromBody] PesmaView pesma)
    {
        try
        {
            var data = DataProviderBenc.azurirajPesmu(pesma);
            if (data != null) return Ok($"Uspesno promenjena pesma sa IDjem {data.ID}");

            return BadRequest("Nije promenjena pesma");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    [HttpDelete]
    [Route("ObrisiPesmu/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult DeletePesma([FromRoute]int id)
    {
        try
        {
            var deleted = DataProviderBenc.obrisiPesmu(id);
            if (deleted) return Ok($"Uspesno obrisana pesma sa IDjem {id}");

            return BadRequest("Nije obrisana pesma");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }
}