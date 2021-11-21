using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCRUD.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Carro> Carros { get; set; }

        public Contexto(DbContextOptions<Contexto> option) : base(option)
        {

        }
    }
}
