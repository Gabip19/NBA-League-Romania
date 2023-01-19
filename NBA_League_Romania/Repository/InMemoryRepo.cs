using NBA_League_Romania.domain;

namespace NBA_League_Romania.Repository;

public class InMemoryRepo<E> : IRepository<Guid, E>
    where E : Entity<Guid>, new()
{
    protected Dictionary<Guid, E> entities;

    protected InMemoryRepo()
    {
        entities = new Dictionary<Guid, E>();
    }

    public E FindOne(Guid id)
    {
        return (!entities.ContainsKey(id) ? null : entities[id])!;
    }

    public IEnumerable<E> FindAll()
    {
        return entities.Values;
    }

    public virtual E Save(E entity)
    {
        entities[entity.Id] = entity;
        return entity;
    }

    public virtual bool Delete(Guid id)
    {
        return entities.Remove(id);
    }
}