using NBA_League_Romania.domain;
using NBA_League_Romania.Repository.FileRepository;

//TODO delegates for writing an entity to file too

namespace NBA_League_Romania;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        var teamRepo = new TeamInFileRepo(
            "D:\\Coding Projects\\CSharpProjects\\NBA_League_Romania\\NBA_League_Romania\\data\\teams.txt"
        );
        var studentRepo = new StudentInFileRepo(
            "D:\\Coding Projects\\CSharpProjects\\NBA_League_Romania\\NBA_League_Romania\\data\\students.txt"
        );
        var playerRepo = new PlayerInFileRepo(
            "D:\\Coding Projects\\CSharpProjects\\NBA_League_Romania\\NBA_League_Romania\\data\\players.txt",
            teamRepo.FindOne
        );
        var gameRepo = new GameInFileRepo(
            "D:\\Coding Projects\\CSharpProjects\\NBA_League_Romania\\NBA_League_Romania\\data\\games.txt",
            teamRepo.FindOne
        );
        var activePlayerRepo = new ActivePlayerInFileRepo(
            "D:\\Coding Projects\\CSharpProjects\\NBA_League_Romania\\NBA_League_Romania\\data\\activeplayers.txt"
        );
        
        foreach (var team in teamRepo.FindAll())
        {
            Console.WriteLine(team);
        }

        // PopulateTeams(teamRepo);
    }

    private static void PopulateTeams(TeamInFileRepo teamInFileRepo)
    {
        teamInFileRepo.Save(new Team("Houston Rockets"));
        teamInFileRepo.Save(new Team("Los Angeles Lakers"));
        teamInFileRepo.Save(new Team("LA Clippers"));
        teamInFileRepo.Save(new Team("Chicago Bulls"));
        teamInFileRepo.Save(new Team("Cleveland Cavaliers"));
        teamInFileRepo.Save(new Team("Utah Jazz"));
        teamInFileRepo.Save(new Team("Brooklyn Nets"));
        teamInFileRepo.Save(new Team("New Orleans Pelicans"));
        teamInFileRepo.Save(new Team("Indiana Pacers"));
        teamInFileRepo.Save(new Team("Toronto Raptors"));
        teamInFileRepo.Save(new Team("Charlotte Hornets"));
        teamInFileRepo.Save(new Team("Phoenix Suns"));
        teamInFileRepo.Save(new Team("Portland TrailBlazers"));
        teamInFileRepo.Save(new Team("Golden State Warriors"));
        teamInFileRepo.Save(new Team("Washington Wizards"));
        teamInFileRepo.Save(new Team("San Antonio Spurs"));
        teamInFileRepo.Save(new Team("Orlando Magic"));
        teamInFileRepo.Save(new Team("Denver Nuggets"));
        teamInFileRepo.Save(new Team("Detroit Pistons"));
        teamInFileRepo.Save(new Team("Atlanta Hawks"));
        teamInFileRepo.Save(new Team("Dallas Mavericks"));
        teamInFileRepo.Save(new Team("Sacramento Kings"));
        teamInFileRepo.Save(new Team("Oklahoma City Thunder"));
        teamInFileRepo.Save(new Team("Boston Celtics"));
        teamInFileRepo.Save(new Team("New York Knicks"));
        teamInFileRepo.Save(new Team("Minnesota Timberwolves"));
        teamInFileRepo.Save(new Team("Milwaukee Bucks"));
    }

    private static void PopulateStudents()
    {
        // Scoala Gimnaziala “Horea” -  
        //     Scoala Gimnaziala "Octavian Goga" -  
        //     Liceul Teoretic "Lucian Blaga" -  
        //     Scoala Gimnaziala "Ioan Bob" -  
        //     Scoala Gimnaziala "Ion Creanga" -  
        //     Colegiul National Pedagogic "Gheorghe Lazar" -  
        //     Scoala Gimnaziala Internationala SPECTRUM -  
        //     Colegiul National „Emil Racovita” -  
        //     Colegiul National "George Cosbuc" -  
        //     Scoala Gimnaziala "Ion Agarbiceanu" -  
        //     Liceul Teoretic "Avram Iancu" -  
        //     Scoala Gimnaziala "Constantin Brancusi" -  
        //     Liceul Teoretic "Onisifor Ghibu" -  
        //     Liceul Teoretic "Onisifor Ghibu" -  
        //     Liceul cu Program Sportiv Cluj-Napoca -  
        //     Liceul Teoretic "Nicolae Balcescu" -  
        //     Liceul Teoretic "Gheorghe Sincai" -  
        //     Scoala "Nicolae Titulescu" -  
        //     Scoala Gimnaziala "Liviu Rebreanu" -  
        //     Scoala Gimnaziala "Iuliu Hatieganu" -  
        //     Liceul Teoretic "Bathory Istvan" -  
        //     Colegiul National "George Baritiu" -  
        //     Liceul Teoretic "Apaczai Csere Janos" -  
        //     Seminarul Teologic Ortodox -  
        //     Liceul de Informatica "Tiberiu Popoviciu" -  
        //     Scoala Gimnaziala „Alexandru Vaida – Voevod" -  +
        // "Liceul Teoretic ELF - Miami Heat " +
        //     "Scoala Gimnaziala "Gheorghe Sincai" Floresti - 
    }
}