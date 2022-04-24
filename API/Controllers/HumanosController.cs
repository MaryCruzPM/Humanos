using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanosController : ControllerBase
    {
        private readonly HumanoContexto _context;
        public HumanosController(HumanoContexto contexto)
        {
            _context= contexto;

        }
        //obtener humanos mock
        [HttpGet]
        [Route("obtenerHumanosmock")]

        public List<Humanos> obtenerHumanosmock()
        {
            int id1 = 1;
            //string nombre = "Maura";
            Random myObject = new Random();
            int numero = myObject.Next(10, 50);

            List<Humanos> lista_humanos = new List<Humanos>();

            String[] nombres = { "juan", "pablo", "Paco", "jose", "Alberto", };
            String[] apellidos = { "sanchez", "perez", "lopez", "zelaya", "alvarez", };
            Double[] altura = { 1.50,160,1.80,1.70,1.75,1.65 };

            for (int i = 0; i < numero; i++)// int a in numero
            {
               
                Random num = new Random();
                int edad = myObject.Next(18, 80);
                int alturaN = myObject.Next(0,5);
                int peso = myObject.Next(50, 90);
                int nombreArray= myObject.Next(0, 4);
                int apellido1 = myObject.Next(0, 4);
                int apellido2 = myObject.Next(0, 4);
                double alturaPersona = altura[alturaN];
                String nombre = nombres[nombreArray] + " " + nombres[nombreArray] + " " + nombres[apellido1] + " " + nombres[apellido2];

                Humanos h1 = new Humanos()
                {
                    Id = id1,
                    Nombre = nombre,
                    Edad = edad,
                    Altura = alturaPersona,
                    Peso = peso,
                    Sexo = "Hombre"

                };
                lista_humanos.Add(h1);
            }
            return lista_humanos;
        }
       
        ////obtener todos los registros de humanos
        //[HttpGet]
        //[Route("humanos")]

        //public async Task<ActionResult<IEnumerable<Humanos>>> obtenerHumanos()
        //{
        //    return await _context.HumanosItems.ToListAsync();
        //}
        //obtener todos los registros de humanos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Humanos>>> GetHumano()
        {
            return await _context.HumanosItems.ToListAsync();
        }

        //obtener un solo humano por id
        [HttpGet("{id}")]
        public async Task<ActionResult<Humanos>> GetHumanoEspecifico(int id)
        {
            var HumanoId = await _context.HumanosItems.FindAsync(id);

            if (HumanoId==null)
            {
                return NotFound();
            }
            return HumanoId;
        }

        //crear humano en base de datos
        [HttpPost]
        public async Task<ActionResult<Humanos>> PostHumanoCrear(Humanos valores)
        {
            _context.HumanosItems.Add(valores);

            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetHumanoEspecifico), new { id = valores.Id }, valores);
        }


        //actualizar
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHumano(int id, Humanos valores)
        {
           if(id != valores.Id)
            {
                return BadRequest();

            }
            _context.Entry(valores).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
