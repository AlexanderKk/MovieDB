using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MovieDB.model

{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class Context : DbContext
    {
        public Context() : base("name=MovieDataBaseContext"){}

        public DbSet<Films> films { get; set; }
        public DbSet<Attachments> attachments { get; set; }

        public Users Users
        {
            get => default(Users);
            set { }
        }
    }
}
