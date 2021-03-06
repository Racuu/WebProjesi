using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProgProje.Models.FilmModel;

namespace WebProgProje.Models.Context
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options)
           : base(options)
        {
        }

        public DbSet<Film> Films { get; set; }
    }
   
}
