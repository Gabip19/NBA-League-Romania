using NBA_League_Romania.domain;

namespace NBA_League_Romania.Repository.FileRepository;

public class TeamInFileRepo : InFileRepo<Team>
{
    public TeamInFileRepo(string fileName) : base(fileName, EntityFactory.CreateTeam) { }

    protected override string CreateEntityAsString(Team entity)
    {
        return EntityToFileFactory.GetEntityAsString(entity);
    }
}