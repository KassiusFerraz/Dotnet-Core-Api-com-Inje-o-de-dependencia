using DataAccess.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class BancoDeDados : DbContext 
    {

        public DbSet<Computador> Computadores { get; set; }

        public BancoDeDados(DbContextOptions<BancoDeDados> options) : base(options) { }
    }
}
