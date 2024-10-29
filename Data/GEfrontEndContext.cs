using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GEfrontEnd.Model;

namespace GEfrontEnd.Data
{
    public class GEfrontEndContext : DbContext
    {
        public GEfrontEndContext (DbContextOptions<GEfrontEndContext> options)
            : base(options)
        {
        }

        public DbSet<GEfrontEnd.Model.Product> Product { get; set; } = default!;
    }
}
