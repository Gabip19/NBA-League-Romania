using NBA_League_Romania.domain;
using NBA_League_Romania.Repository.FileRepository;

//TODO delegates for writing an entity to file too

delegate Team Finder(Guid id);

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var teamRepo = new TeamInFileRepo("D:\\Coding Projects\\CSharpProjects\\NBA_League_Romania\\NBA_League_Romania\\data\\teams.txt");

        var team1 = new Team("Echipa 1");
        var team2 = new Team("Echipa 2");
        var team3 = new Team("Echipa 3");

        Finder finder = teamRepo.FindOne;
        var a = finder(Guid.Parse("fcc2cac2-262f-4193-8920-b7e2b1bf2e25"));
        
        
        teamRepo.Save(team1);
        // teamRepo.Save(team2);
        // teamRepo.Save(team3);
        foreach (var team in teamRepo.FindAll())
        {
            Console.WriteLine(team);
        }
        // teamRepo.Delete(team2.Id);
    }
}