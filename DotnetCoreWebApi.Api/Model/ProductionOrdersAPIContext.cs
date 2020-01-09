using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCoreWebApi.Api.Model
{
    public class ProductionOrdersAPIContext : DbContext
    {
        public ProductionOrdersAPIContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<ProductionOrder> ProductionOrders { get; set; }
    }
}
