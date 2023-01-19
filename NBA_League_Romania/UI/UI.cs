using System.Collections;
using NBA_League_Romania.domain;

namespace NBA_League_Romania.UI;

public class ConsoleUi
{
    private Service.Service srv;

    public ConsoleUi(Service.Service srv)
    {
        this.srv = srv;
    }

    public void Run()
    {
        bool running = true;

        while (running)
        {
            try
            {
                PrintMenu();
                int option = GetUserOption();
                if (option != 0)
                {
                    ExecuteUserOption(option);
                }
                else
                {
                    running = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    private static void PrintMenu()
    {
        Console.WriteLine("\n--------------------------- MENU ---------------------------\n");
        Console.WriteLine("1. Print all players of given team.");
        Console.WriteLine("2. Print all active players of a team for a given game.");
        Console.WriteLine("3. Print all game from a period of time.");
        Console.WriteLine("4. Print score for a given game.");
        Console.WriteLine("0. EXIT.");
        Console.WriteLine("\n--------------------------- ---- ---------------------------\n");
    }

    private static int GetUserOption()
    {
        Console.Write("Your option: ");
        return int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
    }

    private void ExecuteUserOption(int option)
    {
        switch (option)
        {
            case 1: PrintAllTeamPlayers();
                break;
            case 2: PrintActivePlayersFromMatch();
                break;
            case 3: PrintMatchesFromTimePeriod();
                break;
            case 4: PrintScoreForMatch();
                break;
            default: Console.WriteLine("\nInvalid option.\n");
                break;
        }
    }

    private void PrintList<T>(List<T> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("List is empty.");
            return;
        }
        Console.WriteLine();
        list.ForEach(x => Console.WriteLine(list.IndexOf(x) + ".  " + x));
        Console.WriteLine();
    }

    private static int GetIndex(IList list, string message)
    {
        Console.WriteLine(message);
        int index = GetUserOption();

        if (index < 0 || index >= list.Count)
        {
            throw new Exception("Invalid index.");
        }

        return index;
    }

    private void PrintAllTeamPlayers()
    {
        var teams = srv.GetAllTeams();
        
        PrintList(teams);
        var index = GetIndex(teams,"Choose a team: ");

        PrintList(srv.GetAllPlayersForTeam(teams[index]));
    }

    private void PrintActivePlayersFromMatch()
    {
        var games = srv.GetAllGames();
        
        PrintList(games);
        var gameIndex = GetIndex(games, "Choose a game: ");

        var teams = new List<Team> {games[gameIndex].FirstTeam, games[gameIndex].SecondTeam};
        PrintList(teams);
        var teamIndex = GetIndex(teams, "Choose a team: ");
        
        PrintList(srv.GetActivePlayersForGame(games[gameIndex], teams[teamIndex]));
    }

    private void PrintMatchesFromTimePeriod()
    {
        Console.Write("Choose start date: ");
        DateOnly startDate = DateOnly.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        
        Console.Write("Choose end date: ");
        DateOnly endDate = DateOnly.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        
        PrintList(srv.GetAllGamesFromPeriod(startDate, endDate));
    }

    private void PrintScoreForMatch()
    {
        var games = srv.GetAllGames();
        
        PrintList(games);
        var index = GetIndex(games, "Choose a game: ");

        Tuple<int, int> score = srv.GetScoreForGame(games[index]);

        Console.WriteLine("\nThe score was:\n");
        Console.WriteLine(games[index].FirstTeam + "  " + 
                          score.Item1 + " : " + score.Item2 + "  " + 
                          games[index].SecondTeam + "\n");
    }
}