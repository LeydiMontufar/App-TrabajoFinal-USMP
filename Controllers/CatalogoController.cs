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

        public async Task<IActionResult> Index(String? searchString)
        {
            var productos =  from o in _context.DataProductos select o;
            //select *FON t_producto
            if(!String.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s => s.Nombre.Contains(searchString) || s.Descripcion.Contains(searchString)); // algebra bool
                //busca el nombre 'mmm'
            }
            
            return View(await productos.ToListAsync()); 
        }
        public async Task<IActionResult> Details(int? id)
        {
            Producto objProduct = await _context.DataProductos.FindAsync(id);
            if(objProduct == null){
                return NotFound();
            }
            return View(objProduct);

        }

    }
}
