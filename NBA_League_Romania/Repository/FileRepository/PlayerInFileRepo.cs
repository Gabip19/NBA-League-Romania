using NBA_League_Romania.domain;

namespace NBA_League_Romania.Repository.FileRepository;

public class PlayerInFileRepo : InFileRepo<Player>
{
    public PlayerInFileRepo(string fileName) : base(fileName, null)
    {
        LoadFromFile();
    }

    protected override void LoadFromFile()
    {
        List<Team> teams = DataReader.ReadData(
            "D:\\Coding Projects\\CSharpProjects\\NBA_League_Romania\\NBA_League_Romania\\data\\teams.txt",
            EntityFactory.CreateTeam
        );

        foreach (var line in File.ReadLines(fileName))
        {
            var properties = line.Split(";");
            Player player = new Player(
                properties[1],
                properties[2],
                teams.Find(x => x.Id.Equals(Guid.Parse(properties[3])))!
            )
            {
                Id = Guid.Parse(properties[1])
            };
            entities[player.Id] = player;
        }
    }

    protected override string CreateEntityAsString(Player entity)
    {
        return entity.Id + ";" + entity.Name + ";" + entity.School + ";" +
               entity.Team.Id;
    }
}