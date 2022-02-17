using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TreysUpadatedRunningApp.Models
{
    public partial class RunnerDataContext : DbContext
    {
        public RunnerDataContext()
            : base("name=RunnerDataContext")
        {
        }

        public virtual DbSet<Runner> Runners { get; set; }
        public virtual DbSet<Runner_Log> Runner_Log { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Runner>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);
        }
    }
}
