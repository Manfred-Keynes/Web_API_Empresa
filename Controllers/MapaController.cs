using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using web_api_db.Models;
namespace web_api_db.Models.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MapaController : Controller
    {


        private Conexion dbConexion;

        public MapaController()
        {
            dbConexion = Conectar.Create();
        }
        [HttpGet]

        public ActionResult Get()
        {
            return Ok(dbConexion.Mapa.ToArray());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var mapas = await dbConexion.Mapa.FindAsync(id);
            if (mapas != null)
            {
                return Ok(mapas);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Clientes mapas)
        {
            if (ModelState.IsValid)
            {
                dbConexion.Clientes.Add(mapas);
                await dbConexion.SaveChangesAsync();
                return Ok(mapas);

            }
            else
            {
                return NotFound();
            }

        }
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Mapa mapas)
        {
            var v_mapas = dbConexion.Mapa.SingleOrDefault(a => a.id == mapas.id);
            if (v_mapas != null && ModelState.IsValid)
            {
                dbConexion.Entry(v_mapas).CurrentValues.SetValues(mapas);
                await dbConexion.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            var mapas = dbConexion.Mapa.SingleOrDefault(a => a.id == id);
            if (mapas != null)
            {
                dbConexion.Mapa.Remove(mapas);
                await dbConexion.SaveChangesAsync();
                return Ok();

            }
            else
            {
                return NotFound();
            }
        }

    }
}