using NBA_League_Romania.domain;

namespace NBA_League_Romania.Repository.FileRepository;

public class ActivePlayerInFileRepo : InFileRepo<ActivePlayer>
{
    public ActivePlayerInFileRepo(string fileName) 
        : base(fileName, EntityFactory.CreateActivePlayer) { }

    protected override string CreateEntityAsString(ActivePlayer entity)
    {
        return entity.Id + ";" + entity.PlayerId + ";" + entity.GameId + ";" +
               entity.ScoredPoints + ";" + entity.Type;
    }
}