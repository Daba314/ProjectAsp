using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class MvcWebAppDbContex : DbContext
    {
        public MvcWebAppDbContex(DbContextOptions<MvcWebAppDbContex> options) : base(options)
        {

        }
        public DbSet<NewCustClass> Customers { get; set; }
        public DbSet<NewAddrClass> Addresses { get; set; }
        public DbSet<NewOrdClass> Orders { get; set; }

    }
}