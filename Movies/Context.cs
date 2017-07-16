using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Movies.Models;
using System.Data.Entity;

namespace Movies
{
    public class Context : DbContext
    {
        public Context() : base("MoviesConnectionString")
        {
            Database.SetInitializer(new MyInitializer());
        }

        public DbSet<Review> Reviews { get; set; }
    }

    public class MyInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            base.Seed(context);
        }
    }
}