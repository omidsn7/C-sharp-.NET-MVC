using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvcMovies.Models;

namespace mvcMovies.Data
{
    public class mvcMoviesContext : DbContext
    {
        public mvcMoviesContext(DbContextOptions<mvcMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<mvcMovies.Models.Movie> Movie { get; set; }
    }
}
