using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App_TrabajoFinal_USMP.Models;
using App_TrabajoFinal_USMP.Data;



namespace App_TrabajoFinal_USMP.Controllers
{
    public class ContactoController: Controller
    {
        private readonly ILogger<ContactoController> _logger;
        private readonly ApplicationDbContext _context;

        public ContactoController(ApplicationDbContext context,
            ILogger<ContactoController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contacto objContacto)
        {
            _context.Add(objContacto);
            _context.SaveChanges();
            ViewData["Message"] = "Se registro el contacto";
            return View("Index");
        }


    }
}