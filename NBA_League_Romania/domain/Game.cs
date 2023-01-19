namespace NBA_League_Romania.domain;

public class Game : Entity<Guid>
{
    private Team firstTeam;
    private Team secondTeam;
    public DateTime GameDate { get; set; }

    public Game() { }
    
    public Game(Team firstTeam, Team secondTeam, DateTime gameDate)
    {
        this.firstTeam = firstTeam;
        this.secondTeam = secondTeam;
        this.GameDate = gameDate;
        base.Id = Guid.NewGuid();
    }

    public Team FirstTeam
    {
        get => firstTeam;
        set => firstTeam = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Team SecondTeam
    {
        get => secondTeam;
        set => secondTeam = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return "Team 1:  " + firstTeam.Name + "   Team 2:  " + secondTeam.Name +
               "   Date:  " + GameDate;
    }
}