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
using System.Text.Json;
using System.Data;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {

        public OperacionesController()
        {
        //    _context = contexto;

        }
        [HttpPost]
        public salida Operar(Operaciones argumentos)
        {
            salida result = new salida();

            switch (argumentos.operacion)
            {
                case "+":
                    
                    result.result = argumentos.dato1 + argumentos.dato2;
                    result.valido = "";


                    //result.result = argumentos.dato1 argumentos.operacion argumentos.dato2;
                    break;

                case "-":
                    result.result = argumentos.dato1 - argumentos.dato2;
                    result.valido = "";
                    break;

                case "/":
                    if(argumentos.dato2==0)
                        result.valido = "operacion no valida";
                    else
                    {
                        result.result = argumentos.dato1 / argumentos.dato2;
                        result.valido = "";
                    }
                    
                    break;
                case "*":
                    result.result = argumentos.dato1 * argumentos.dato2;
                    result.valido = "";
                    break;

                default:
                    result.result = argumentos.dato1 + argumentos.dato2;
                    result.valido = "Funcion no valida";

                    break;
            }
            
           return result;   
            // return await _context.HumanosItems.ToListAsync();
        }
        [HttpGet]
        public salida Operaraciones([FromHeader]double d1, [FromHeader] double d2, [FromHeader] string operacion)
        {
            salida result = new salida();

            switch (operacion)
            {
                case "+":

                    result.result = d1 + d2;
                    result.valido = "";


                    //result.result = argumentos.dato1 argumentos.operacion argumentos.dato2;
                    break;

                case "-":
                    result.result = d1 - d2;
                    result.valido = "";
                    break;

                case "/":
                    if (d2 == 0)
                        result.valido = "operacion no valida";
                    else
                    {
                        result.result = d1 / d2;
                        result.valido = "";
                    }

                    break;
                case "*":
                    result.result = d1 * d2;
                    result.valido = "";
                    break;

                default:
                    result.result = 0;
                    result.valido = "Funcion no valida";

                    break;
            }

            return result;
            // return await _context.HumanosItems.ToListAsync();
        }
    }
}
