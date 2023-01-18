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

    protected override void LoadFromFile()
    {
        // foreach (var line in File.ReadLines(fileName))
        // {
        //     var properties = line.Split(";");
        //     Player player = EntityFactory.CreatePlayer(properties, teamFinder);
        //     entities[player.Id] = player;
        // }

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
        return entity.Id + ";" + entity.Name + ";" + entity.School + ";" +
               entity.Team.Id;
    }
}