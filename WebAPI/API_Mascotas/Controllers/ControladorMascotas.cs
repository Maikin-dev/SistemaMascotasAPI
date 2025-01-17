using API_Mascotas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Mascotas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladorMascotas : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMascotas()
        {
            List<InfoMascotas> ListaMascotas = new List<InfoMascotas>();

            ListaMascotas.Add(new InfoMascotas
            {
                nombre = "Luca",
                edad = 5,
                raza = "Pastor Alemán"
            });
            ListaMascotas.Add(new InfoMascotas
            {
                nombre = "Zeus",
                edad = 2,
                raza = "Dobberman"
            });
            ListaMascotas.Add(new InfoMascotas
            {
                nombre = "Zeus",
                edad = 9,
                raza = "Rotwailler"
            });
            ListaMascotas.Add(new InfoMascotas
            {
                nombre = "Coco",
                edad = 7,
                raza = "Husky Siberiano"
            });
            ListaMascotas.Add(new InfoMascotas
            {
                nombre = "Luca",
                edad = 4,
                raza = "Dálmata"
            });

            return Ok(ListaMascotas);
        }
    }
}
