using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class BDMinimumrentContext : DbContext
    {
        public DbSet<Adminhotelrent> Adminhotelrents { get; set; }

        public DbSet<Adminhotelinfo> Adminhotelinfos { get; set; }

        public DbSet<Adminhotelreview> Adminhotelreviews { get; set; }
    }
}
