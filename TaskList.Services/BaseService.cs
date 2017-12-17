using TaskList.Abstractions.Repositories;

namespace TaskList.Services
{
    public abstract class BaseService
    {
        protected IRepository Repository { get; }

        protected BaseService(IRepository repository)
        {
            Repository = repository;
        }
    }
}
