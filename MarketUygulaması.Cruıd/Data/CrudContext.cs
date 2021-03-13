using MarketUygulaması.Cruıd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketUygulaması.Cruıd.Data
{
    public class CrudContext:DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options) { }
        public DbSet<Asker> askers { get; set; }
    }
}
