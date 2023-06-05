using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Peak.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CompraController : ControllerBase
  {
    private static readonly List<KeyValuePair<int, string>> listaNomes = new List<KeyValuePair<int, string>>
    {

      new KeyValuePair<int, string>(1, "João"),

      new KeyValuePair<int, string>(2, "Maria"),

      new KeyValuePair<int, string>(3, "Ana")
    };

    [HttpGet]
    public IActionResult Get(int id)
    {
      var nomeEncontrado = string.Empty;

      foreach (var nome in listaNomes)
      {
        if (nome.Key == id)
        {
          nomeEncontrado = nome.Value;
          break;
        }
      }

      if (string.IsNullOrEmpty(nomeEncontrado))
      {
        return NotFound();
      }

      return Ok(new { nome = nomeEncontrado });
    }

    // POST api/<CompraController>
    [HttpPost]
    public IActionResult Post(int parcela, double valor)
    {
      var calculo = parcela * valor;
      var percentual = calculo * 0.05;
      var resultado = calculo + percentual;
      return Ok(resultado);
    }

    // PUT api/<CompraController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<CompraController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
