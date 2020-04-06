using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace Vjezba02.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BazaDbContext : DbContext
    {
        public DbSet<Student> PopisStudenata { get; set; }
    }
}