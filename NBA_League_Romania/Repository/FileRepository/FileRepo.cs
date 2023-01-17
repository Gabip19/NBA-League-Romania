using System.Xml.Linq;
using NBA_League_Romania.domain;

namespace NBA_League_Romania.Repository.FileRepository;

public abstract class FileRepo<E> : InMemoryRepo<E>
    where E : Entity<Guid>, new()
{
    private string fileName;

    protected FileRepo(string fileName)
    {
        this.fileName = fileName;
        LoadFromFile();
    }

    private void LoadFromFile()
    {
        foreach (var line in File.ReadLines(fileName))
        {
            base.Save(ExtractEntityFromString(line));
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
        foreach (var entity in base.FindAll())
        {
            WriteToFile(entity);
        }
    }

    protected abstract E ExtractEntityFromString(string line);
    protected abstract string CreateEntityAsString(E entity);
}