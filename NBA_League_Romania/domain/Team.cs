namespace NBA_League_Romania.domain;

public class Team : Entity<Guid>
{
    private string name;

    public Team(string name)
    {
        this.name = name;
        Id = Guid.NewGuid();
    }

    public Team() { name = ""; }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return name;
    }
}