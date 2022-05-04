using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App_TrabajoFinal_USMP.Models;
using App_TrabajoFinal_USMP.Data;
using Microsoft.EntityFrameworkCore;

namespace App_TrabajoFinal_USMP.Controllers
{
    public class CatalogoController: Controller
    {
        private readonly ILogger<CatalogoController> _logger;
    
        private readonly ApplicationDbContext _context;
    
        public CatalogoController(ApplicationDbContext context,
            ILogger<CatalogoController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var productos =  from o in _context.DataProductos select o;
            return View(await productos.ToListAsync()); 
        }

    }
}
