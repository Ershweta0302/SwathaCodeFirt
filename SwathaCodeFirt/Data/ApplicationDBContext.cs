using Microsoft.EntityFrameworkCore;
using SwathaCodeFirt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwathaCodeFirt.Data
{
    public class ApplicationDBContext : DbContext

    {


        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {



        }

        public DbSet<Employee> employees { get; set; }
       


    }
}
