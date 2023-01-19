using NBA_League_Romania.domain;

namespace NBA_League_Romania.Repository.FileRepository;

public delegate E Finder<E>(Guid id);

public abstract class InFileRepo<E> : InMemoryRepo<E>
    where E : Entity<Guid>, new()
{
    protected string fileName;
    private CreateEntity<E>? createEntity;

    protected InFileRepo(string fileName, CreateEntity<E>? createEntity)
    {
        this.fileName = fileName;
        this.createEntity = createEntity;
        if (createEntity != null)
            LoadFromFile();
    }

    protected void LoadFromFile()
    {
        if (createEntity != null)
        {
            List<E> entitiesList = DataReader.ReadData(fileName, createEntity);
            entitiesList.ForEach(
                x => entities[x.Id] = x
            );
        }
    }

    public override E Save(E entity)
    {
        base.Save(entity);
        WriteToFile(entity);
        return entity;
    }

    private void WriteToFile(E entity)
    {
        using var streamWriter = new StreamWriter(fileName, append:true);
        streamWriter.WriteLine(CreateEntityAsString(entity));
    }

    public override bool Delete(Guid id)
    {
        bool deleted = base.Delete(id);
        if (deleted)
        {
            UpdateFile();
        }
        return deleted;
    }

    private void UpdateFile()
    {
        new StreamWriter(fileName, append: false).Close();
        foreach (var entity in FindAll())
        {
            WriteToFile(entity);
        }
    }
    
    protected abstract string CreateEntityAsString(E entity);
}