using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TungSon;

    public class NTSContext : DbContext
    {
        public NTSContext (DbContextOptions<NTSContext> options)
            : base(options)
        {
        }

        public DbSet<TungSon.NTS> NTS { get; set; }
    }
