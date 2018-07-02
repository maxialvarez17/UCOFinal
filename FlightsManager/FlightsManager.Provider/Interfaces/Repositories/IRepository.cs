namespace FlightsManager.Data.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class
    {
        void Delete(int id);

        void Insert(TEntity entity);

        void Update(TEntity entity);
    }
}