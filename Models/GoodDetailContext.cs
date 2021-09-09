using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWarehouseAPI.Models
{
    public class GoodDetailContext:DbContext
    {
        public GoodDetailContext(DbContextOptions<GoodDetailContext> options):base(options)
        {

        }

        public DbSet<GoodDetail> GoodDetails { get; set; }
    }
}
