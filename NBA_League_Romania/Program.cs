using NBA_League_Romania.domain;
using NBA_League_Romania.Repository.FileRepository;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var teamRepo = new TeamFileRepo("D:\\Coding Projects\\CSharpProjects\\NBA_League_Romania\\NBA_League_Romania\\data\\teams.txt");

        var team1 = new Team("Echipa 1");
        var team2 = new Team("Echipa 2");
        var team3 = new Team("Echipa 3");
        
        // teamRepo.Save(team1);
        // teamRepo.Save(team2);
        // teamRepo.Save(team3);
        foreach (var team in teamRepo.FindAll())
        {
            Console.WriteLine(team);
        }
        // teamRepo.Delete(team2.Id);
    }
}