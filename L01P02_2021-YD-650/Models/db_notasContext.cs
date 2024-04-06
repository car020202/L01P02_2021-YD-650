using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
namespace L01P02_2021_YD_650.Models
{
    public class db_notasContext : DbContext
    {
        public db_notasContext(DbContextOptions options) : base(options) 
            {

            }
        public DbSet<facultades> facultades { get; set; }
        public virtual DbSet<alumnos> alumnos { get; set; }

        public virtual DbSet<departamentos> departamentos { get; set; }

        public virtual DbSet<materias> materias { get; set; }
    }

}
