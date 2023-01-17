namespace NBA_League_Romania.domain;

public class Entity<ID>
{
    private ID id;

    public ID Id
    {
        get => id;
        set => id = value;
    }
}