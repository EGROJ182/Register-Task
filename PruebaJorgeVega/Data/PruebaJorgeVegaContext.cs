using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaJorgeVega.Models;

namespace PruebaJorgeVega.Data
{
    public class PruebaJorgeVegaContext : DbContext
    {
        public PruebaJorgeVegaContext (DbContextOptions<PruebaJorgeVegaContext> options)
            : base(options)
        {
        }

        public DbSet<PruebaJorgeVega.Models.Tarea> Tarea { get; set; } = default!;
    }
}
