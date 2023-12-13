using Core.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace API.Data
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions options):base(options){

        }

        public Microsoft.EntityFrameworkCore.DbSet<Product> Products {get;set;}
    }
}