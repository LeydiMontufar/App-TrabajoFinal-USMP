using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App_TrabajoFinal_USMP.Models;

namespace App_TrabajoFinal_USMP.Controllers
{   
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;

        public ContactoController(ILogger<ContactoController> logger)
        {
            _logger = logger;
        } 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(Contacto obContacto)
        {
            return View("Index");
        }
         
    }
}