using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microsoft.EntityFrameworkCore;
using AngularAPI.Models;

namespace AngularAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Evento> Eventos {get; set;}
    }
}