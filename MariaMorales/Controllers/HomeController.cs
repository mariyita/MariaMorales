using MariaMorales.Data;
using MariaMorales.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace MariaMorales.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _context;

        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        //this is a test
        public IActionResult Index()
        {
            //simular los datos como que estoy usando base de datos
            List<Paciente> pacientes = new List<Paciente>();

            pacientes.Add(new Paciente()
            {
                Nombre = "Jorge Urbina",
                Direccion = "Alguna direccion",
                Edad = 33,
                Telefono = "4545454"
            });

            pacientes.Add(new Paciente()
            {
                Nombre = "Jorge espinoza",
                Direccion = "Alguna direccion",
                Edad = 33,
                Telefono = "4545454"
            });
            return View(pacientes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Prueba()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Cliente()
        {
            return View();
        }

        public IActionResult EditarCliente(int id)
        {
            Cliente modelo = _context.Cliente.Where(c => c.ClienteId == id).FirstOrDefault();
            return View("EditarCliente", modelo);
        }
        public IActionResult EditarvalorCliente(Cliente cliente)
        {
            //recupero el valor actual en la base de datos
            Cliente clienteActual= _context.Cliente.Where(a => a.ClienteId == cliente.ClienteId).FirstOrDefault();

            clienteActual.Nombre = cliente.Nombre;
            clienteActual.Apellido = cliente.Apellido;
            clienteActual.Telefono = cliente.Telefono;
            clienteActual.Direccion = cliente.Direccion;
            //persisto los datos den la base de datos
            _context.SaveChanges();
            List<Cliente> clientes = _context.Cliente.ToList();
            return View("ListaCliente", clientes);
        }

        public IActionResult CrearCliente(Cliente cliente)
        {
           // cliente.FechaCreacion = DateTime.Now;
           // cliente.Nombre = "probando";
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
            //  return View();
            return RedirectToAction("ListaCliente");
            
        }
        public IActionResult ListaCliente()
        {
            List<Cliente> cliente = _context.Cliente.ToList();
            return View(cliente);
            
        }

        public IActionResult EliminarCategoria(int id)
        { 
            List<Prestamo> prestamos = _context.Prestamo.Where(a => a.ClienteId == id).ToList();
            //elimina todos los prestamos asociados al cliente
            _context.RemoveRange(prestamos);

            //con entity framework eliminar el valor
            Cliente cliente = _context.Cliente.Where(a => a.ClienteId == id).FirstOrDefault();
             if(cliente != null)
            _context.Remove(cliente);
            

            _context.SaveChanges();
            List<Cliente> clientes = _context.Cliente.ToList();
            return View("ListaCliente", clientes);
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
