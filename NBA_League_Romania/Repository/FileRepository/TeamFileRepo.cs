using NBA_League_Romania.domain;

namespace NBA_League_Romania.Repository.FileRepository;

public class TeamFileRepo : FileRepo<Team>
{
    public TeamFileRepo(string fileName) : base(fileName) { }

    protected override Team ExtractEntityFromString(string line)
    {
        var properties = line.Split(";");
        return EntityFactory.CreateTeam(properties);
    }

    protected override string CreateEntityAsString(Team entity)
    {
        return entity.Id + ";" + entity.Name;
    }
}