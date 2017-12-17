using System.Data.Entity;
using TaskList.DbEntities;

namespace TaskList.Repositories
{
    internal class Context : DbContext
    {
        internal Context(string connectionString)
            : base(connectionString)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbTask>();
            modelBuilder.Entity<DbUserSettings>();
        }
    }
}