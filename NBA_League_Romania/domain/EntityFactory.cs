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
}