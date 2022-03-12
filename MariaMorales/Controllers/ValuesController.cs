using MariaMorales.Data;
using MariaMorales.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MariaMorales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ValuesController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            IEnumerable<Cliente> clientes = _context.Cliente.ToList();
            return clientes;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            Cliente clientes = _context.Cliente.Where(a => a.ClienteId == id).FirstOrDefault();
            if(clientes == null)
                return new Cliente();
            return clientes;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
