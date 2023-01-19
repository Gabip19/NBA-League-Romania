using NBA_League_Romania.domain;

namespace NBA_League_Romania.Repository.FileRepository;

public class StudentInFileRepo : InFileRepo<Student>
{
    public StudentInFileRepo(string fileName) : base(fileName, EntityFactory.CreateStudent) { }

    protected override string CreateEntityAsString(Student entity)
    {
        return EntityToFileFactory.GetEntityAsString(entity);
    }
}