using NBA_League_Romania.domain;

namespace NBA_League_Romania.Repository.FileRepository;

public class GameInFileRepo : InFileRepo<Game>
{
    private Finder<Team> teamFinder;

    public GameInFileRepo(string fileName, Finder<Team> teamFinder) : base(fileName, null)
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
                    Game game = EntityFactory.CreateGame(properties, teamFinder);
                    entities[game.Id] = game;
                }
            );
    }

    protected override string CreateEntityAsString(Game entity)
    {
        return EntityToFileFactory.GetEntityAsString(entity);
    }
}