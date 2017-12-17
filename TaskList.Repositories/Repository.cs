using System;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using TaskList.Abstractions.Repositories;

namespace TaskList.Repositories
{
    public class Repository: IRepository
    {
        private static string ConnectionString
        {
            get
            {
                var connectionStrings = ConfigurationManager.ConnectionStrings
                    .Cast<ConnectionStringSettings>()
                    .Select(x => x.Name)
                    .Where(x => x.StartsWith("DefaultConnection", StringComparison.InvariantCultureIgnoreCase))
                    .OrderBy(x => x)
                    .ToArray();

                return connectionStrings[0];
            }
        }

        public DbContext CreateContext()
        {
            return CreateContext(true);
        }

        public DbContext CreateContext(bool lazyLoadingEnabled)
        {
            var context = new Context(ConnectionString);
            context.Configuration.LazyLoadingEnabled = lazyLoadingEnabled;
            return context;
        }
    }
}
