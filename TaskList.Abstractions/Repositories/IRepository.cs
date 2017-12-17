using System.Data.Entity;

namespace TaskList.Abstractions.Repositories
{
    public interface IRepository
    {
        DbContext CreateContext();

        DbContext CreateContext(bool lazyLoadingEnabled);
    }
}