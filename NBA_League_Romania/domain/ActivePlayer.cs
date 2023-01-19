namespace NBA_League_Romania.domain;

public enum ActivePlayerType
{
    Participant,
    Reserve
}

public class ActivePlayer : Entity<Guid>
{
    private Guid playerId;
    private Guid gameId;
    private int scoredPoints;
    private ActivePlayerType type;

    public ActivePlayer() {}
    
    public ActivePlayer(Guid playerId, Guid gameId, int scoredPoints, ActivePlayerType type)
    {
        this.playerId = playerId;
        this.gameId = gameId;
        this.scoredPoints = scoredPoints;
        this.type = type;
        Id = Guid.NewGuid();
    }

    public Guid PlayerId
    {
        get => playerId;
        set => playerId = value;
    }

    public Guid GameId
    {
        get => gameId;
        set => gameId = value;
    }

    public int ScoredPoints
    {
        get => scoredPoints;
        set => scoredPoints = value;
    }

    public ActivePlayerType Type
    {
        get => type;
        set => type = value;
    }
}