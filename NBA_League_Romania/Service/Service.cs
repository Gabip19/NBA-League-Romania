using NBA_League_Romania.domain;
using NBA_League_Romania.Repository;

namespace NBA_League_Romania.Service;

public class Service
{
    private IRepository<Guid, Team> teamRepo;
    private IRepository<Guid, Student> studentRepo;
    private IRepository<Guid, Player> playerRepo;
    private IRepository<Guid, Game> gameRepo;
    private IRepository<Guid, ActivePlayer> activePlayerRepo;

    public Service(IRepository<Guid, Team> teamRepo, IRepository<Guid, Student> studentRepo, IRepository<Guid, Player> playerRepo, IRepository<Guid, Game> gameRepo, IRepository<Guid, ActivePlayer> activePlayerRepo)
    {
        this.teamRepo = teamRepo;
        this.studentRepo = studentRepo;
        this.playerRepo = playerRepo;
        this.gameRepo = gameRepo;
        this.activePlayerRepo = activePlayerRepo;
    }

    public List<Team> GetAllTeams()
    {
        return teamRepo.FindAll().ToList();
    }

    public List<Game> GetAllGames()
    {
        return gameRepo.FindAll().ToList();
    }

    public List<Player> GetAllPlayersForTeam(Team team)
    {
        return (
            from player in playerRepo.FindAll()
            where player.Team.Id.Equals(team.Id)
            select player
        ).ToList();
    }

    public List<Player> GetActivePlayersForGame(Game game, Team team)
    {
        return (
            from activePlayer in activePlayerRepo.FindAll()
            join player in playerRepo.FindAll()
                on activePlayer.PlayerId equals player.Id
            where activePlayer.GameId == game.Id &&
                  player.Team.Id == team.Id &&
                  activePlayer.Type.Equals(ActivePlayerType.Participant)
            select player
        ).ToList();
    }

    public List<Game> GetAllGamesFromPeriod(DateOnly startDate, DateOnly endDate)
    {
        if (startDate >= endDate)
        {
            throw new Exception("\nStart date must be before end date.\n");
        }
        return (
            from game in gameRepo.FindAll()
            where startDate <= DateOnly.FromDateTime(game.GameDate) &&
                  DateOnly.FromDateTime(game.GameDate) <= endDate
            select game
        ).ToList();
    }

    public Tuple<int, int> GetScoreForGame(Game game)
    {
        int firstTeamScore = GetTeamScore(game, game.FirstTeam);
        int secondTeamScore = GetTeamScore(game, game.SecondTeam);

        return new Tuple<int, int>(firstTeamScore, secondTeamScore);
    }

    private int GetTeamScore(Game game, Team teamT)
    {
        return (from activePlayer in activePlayerRepo.FindAll()
                join player in playerRepo.FindAll()
                    on activePlayer.PlayerId equals player.Id
                join team in teamRepo.FindAll()
                    on player.Team.Id equals team.Id
                where activePlayer.GameId == game.Id &&
                      team.Id == teamT.Id
                select activePlayer.ScoredPoints
        ).Sum();
    }
}