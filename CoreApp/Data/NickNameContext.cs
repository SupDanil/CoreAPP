using CoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Data
{
    public class NickNameContext : DbContext
    {
            public DbSet<NickName> NickNames { get; set; }
            public NickNameContext(DbContextOptions<NickNameContext> options)
                : base(options)
            {
                Database.EnsureCreated();   
            }
    }
}
