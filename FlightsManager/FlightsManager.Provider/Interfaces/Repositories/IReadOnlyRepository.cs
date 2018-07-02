using System.Collections.Generic;

namespace FlightsManager.Data.Interfaces.Repositories
{
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);

        ICollection<TEntity> GetAll();
    }
}