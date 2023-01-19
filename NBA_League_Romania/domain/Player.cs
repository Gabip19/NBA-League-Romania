namespace NBA_League_Romania.domain;

public class Player : Student
{
    private Team team;

    public Player(string name, string school, Team team) : base(name, school)
    {
        this.team = team;
    }

    public Player() { }

    public Team Team
    {
        get => team;
        set => team = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return "Name:  " + Name + "   School:  " + School + "   Team:  " + Team.Name;
    }
}