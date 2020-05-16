using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace Site {

    public class DataContext : DbContext {

        public DataContext(DbContextOptions<DataContext> options) : base(options) {

            // Nothing to do here yet
        }

        public DbSet<Item> Items { get; set; }
    }

    public class Item {

        public int Id { get; set; }

        public string Value { get; set; }
    }
}