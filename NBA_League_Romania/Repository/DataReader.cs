using NBA_League_Romania.Repository.FileRepository;

namespace NBA_League_Romania.Repository;

public delegate E CreateEntity<E>(string[] properties);

public static class DataReader
{
    public static List<T> ReadData<T>(string fileName, CreateEntity<T> createEntity)
    {
        return File.ReadLines(fileName)
            .Select(
                line => createEntity(line.Split(";"))
            )
            .ToList();
    }
}