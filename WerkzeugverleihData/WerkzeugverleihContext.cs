using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WerkzeugverleihData.Models;

namespace WerkzeugverleihData
{
    public class WerkzeugverleihContext : DbContext
    {
        public WerkzeugverleihContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users{ get; set; }
        public DbSet<Checkout> Checkouts{ get; set; }
        public DbSet<Werkzeug> Werkzeugs { get; set; }
    }
}
