namespace NBA_League_Romania.domain;

public class Game : Entity<Guid>
{
    private Team firstTeam;
    private Team secondTeam;
    private DateTime gameDate;

    public Game(Team firstTeam, Team secondTeam, DateTime gameDate)
    {
        this.firstTeam = firstTeam;
        this.secondTeam = secondTeam;
        this.gameDate = gameDate;
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

    public DateTime GameDate
    {
        get => gameDate;
        set => gameDate = value;
    }
}