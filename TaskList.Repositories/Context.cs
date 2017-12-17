using System.Data.Entity;
using TaskList.DbEntities;

namespace TaskList.Repositories
{
    internal class Context : DbContext
    {
        internal Context(string connectionString)
            : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbTask>();
        }
    }
}