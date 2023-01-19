using NBA_League_Romania.domain;

namespace NBA_League_Romania.Repository.FileRepository;

public class PlayerInFileRepo : InFileRepo<Player>
{
    private Finder<Team> teamFinder;
    
    public PlayerInFileRepo(string fileName, Finder<Team> teamFinder) : base(fileName, null)
    {
        this.teamFinder = teamFinder;
        LoadFromFile();
    }

    protected new void LoadFromFile()
    {
        File.ReadLines(fileName).ToList()
            .ForEach(line =>
                {
                    var properties = line.Split(";");
                    Player player = EntityFactory.CreatePlayer(properties, teamFinder);
                    entities[player.Id] = player;
                }
            );
    }

    protected override string CreateEntityAsString(Player entity)
    {
        return EntityToFileFactory.GetEntityAsString(entity);
    }
}