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
        return
            (from player in playerRepo.FindAll()
                where player.Team.Id.Equals(team.Id)
                select player)
            .ToList();
    }

    public List<Player> GetActivePlayersForGame(Game game, Team team)
    {
        throw new NotImplementedException();
    }

    public List<Game> GetAllGamesFromPeriod(DateOnly startDate, DateOnly endDate)
    {
        throw new NotImplementedException();
    }

    public Tuple<int, int> GetScoreForGame(Game game)
    {
        throw new NotImplementedException();
    }
}