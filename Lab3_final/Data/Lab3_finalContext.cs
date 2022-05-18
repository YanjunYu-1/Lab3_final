using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab3_final.Models;

namespace Lab3_final.Data
{
    public class Lab3_finalContext : DbContext
    {
        public Lab3_finalContext (DbContextOptions<Lab3_finalContext> options)
            : base(options)
        {
        }

        public DbSet<Lab3_final.Models.Pass>? Pass { get; set; }
    }
}
