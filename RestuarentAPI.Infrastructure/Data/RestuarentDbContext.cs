using Microsoft.EntityFrameworkCore;
using RestuarentAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarentAPI.Infrastructure.Data
{
    public class RestuarentDbContext : DbContext
    {
        public RestuarentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Restuarent>    Restuarents { get; set; }
    }
}
