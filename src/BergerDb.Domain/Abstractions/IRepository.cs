using BergerDb.Domain.Primitives.Entities;

namespace BergerDb.Domain.Abstractions;

public interface IRepository<TEntity> where TEntity : Entity
{
    void Add(TEntity entity);

    void Delete(TEntity entity);
}
