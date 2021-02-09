using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.API.Model;


namespace ProAgil.API.Controllers
{
    [Route("site/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[]{
            new Evento(){

                eventoID = 1;
                tema = "Angular e .Net Core";
                local = "BH";
                lote = "1º lote";
                qtdPessoas = "250";
                dataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy");
            }
             new Evento(){

                eventoID = 1;
                tema = "Angular e suas novidade";
                local = "SP";
                lote = "2º lote";
                qtdPessoas = "350";
                dataEvento = DateTime.now.addDays(3).ToString("dd/MM/yyyy");
            }
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
