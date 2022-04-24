using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;
namespace API.Data
{
    public class HumanoContexto : DbContext

    {
        public HumanoContexto(DbContextOptions<HumanoContexto> options):base(options) 
        { 
        }
        public DbSet<Humanos> HumanosItems { get; set; }
    }
}
