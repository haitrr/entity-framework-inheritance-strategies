using EFInheritanceStrategies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFInheritanceStrategies.Contexts
{
    public class TPTContext : DbContext
    {
        public TPTContext(DbContextOptions<TPTContext> options) : base(options)
        {

        }
        public DbSet<Person> People { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Principal> Principals { get; set; }
    }
}
