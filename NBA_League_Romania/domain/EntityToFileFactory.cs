namespace NBA_League_Romania.domain;

public static class EntityToFileFactory
{
    public static string GetEntityAsString(ActivePlayer entity)
    {
        return entity.Id + ";" + entity.PlayerId + ";" + entity.GameId + ";" +
               entity.ScoredPoints + ";" + entity.Type;
    }
    
    public static string GetEntityAsString(Game entity)
    {
        return entity.Id + ";" + entity.FirstTeam.Id + ";" + entity.SecondTeam.Id + ";" + entity.GameDate;
    }
    
    public static string GetEntityAsString(Player entity)
    {
        return entity.Id + ";" + entity.Name + ";" + entity.School + ";" +
               entity.Team?.Id;
    }
    
    public static string GetEntityAsString(Student entity)
    {
        return entity.Id + ";" + entity.Name + ";" + entity.School;
    }
    
    public static string GetEntityAsString(Team entity)
    {
        return entity.Id + ";" + entity.Name;
    }
}