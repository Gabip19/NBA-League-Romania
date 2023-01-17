using NBA_League_Romania.domain;

namespace NBA_League_Romania.Repository;

public interface IRepository<ID, E> where E : Entity<ID>
{
    E FindOne(ID id);
    
    IEnumerable<E> FindAll();

    E Save(E entity);

    bool Delete(ID id);
}