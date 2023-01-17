namespace NBA_League_Romania.domain;

public class Team : Entity<Guid>
{
    private string name;

    public Team(string name)
    {
        this.name = name;
        base.Id = new Guid();
    }

    public Team(Guid id, string name)
    {
        this.name = name;
        base.Id = id;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }
}