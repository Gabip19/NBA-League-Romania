using NBA_League_Romania.Repository.FileRepository;

namespace NBA_League_Romania.domain;

public static class EntityFactory
{
    public static Team CreateTeam(string[] properties)
    {
        var team = new Team(properties[1])
        {
            Id = Guid.Parse(properties[0])
        };
        return team;
    }

    public static Student CreateStudent(string[] properties)
    {
        var student = new Student(properties[1], properties[2])
        {
            Id = Guid.Parse(properties[0])
        };
        return student;
    }

    public static ActivePlayer CreateActivePlayer(string[] properties)
    {
        Enum.TryParse(properties[4], out ActivePlayerType myType);

        var activePlayer = new ActivePlayer(
            Guid.Parse(properties[1]),
            Guid.Parse(properties[2]),
            int.Parse(properties[3]),
            myType
        )
        {
            Id = Guid.Parse(properties[0])
        };
        
        return activePlayer;
    }

    public static Player CreatePlayer(string[] properties, Finder<Team> teamFinder)
    {
        var player = new Player(
            properties[1],
            properties[2],
            teamFinder(Guid.Parse(properties[3]))
        )
        {
            Id = Guid.Parse(properties[0])
        };
        return player;
    }

    public static Game CreateGame(string[] properties, Finder<Team> teamFinder)
    {
        var game = new Game(
            teamFinder(Guid.Parse(properties[1])),
            teamFinder(Guid.Parse(properties[2])),
            DateTime.Parse(properties[3])
        )
        {
            Id = Guid.Parse(properties[0])
        };
        return game;
    }
}