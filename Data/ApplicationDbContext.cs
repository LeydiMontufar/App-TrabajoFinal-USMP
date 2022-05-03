using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using App_TrabajoFinal_USMP.Models;


namespace App_TrabajoFinal_USMP.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
      public DbSet<App_TrabajoFinal_USMP.Models.Contacto> DataContactos { get; set; }

}
