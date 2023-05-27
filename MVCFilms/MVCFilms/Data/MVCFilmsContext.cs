using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCFilms.Models;

namespace MVCFilms.Data
{
    public class MVCFilmsContext : DbContext
    {
        public MVCFilmsContext (DbContextOptions<MVCFilmsContext> options)
            : base(options)
        {
        }

        public DbSet<MVCFilms.Models.Films> Films { get; set; } = default!;
    }
}
