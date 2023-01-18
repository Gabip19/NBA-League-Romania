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
        
        // foreach (var team in teamRepo.FindAll())
        // {
        //     Console.WriteLine(team);
        // }

        // Populate(teamRepo, playerRepo, gameRepo, activePlayerRepo);
        // PopulateStudents(studentRepo);
    }

    private static void Populate(TeamInFileRepo teamInFileRepo, PlayerInFileRepo playerInFileRepo,
        GameInFileRepo gameInFileRepo, ActivePlayerInFileRepo activePlayerInFileRepo)
    {
        var t1 = new Team("Houston Rockets");
        teamInFileRepo.Save(t1);

        var t2 = new Team("Los Angeles Lakers");
        teamInFileRepo.Save(t2);
        
        var t3 = new Team("LA Clippers");
        teamInFileRepo.Save(t3);
        
        var t4 = new Team("Chicago Bulls");
        teamInFileRepo.Save(t4);
        
        var t5 = new Team("Cleveland Cavaliers");
        teamInFileRepo.Save(t5);
        
        var t6 = new Team("Utah Jazz");
        teamInFileRepo.Save(t6);
        
        var t7 = new Team("Brooklyn Nets");
        teamInFileRepo.Save(t7);
        
        var t8 = new Team("New Orleans Pelicans");
        teamInFileRepo.Save(t8);
        
        var t9 = new Team("Indiana Pacers");
        teamInFileRepo.Save(t9);
        
        var t10 = new Team("Toronto Raptors");
        teamInFileRepo.Save(t10);
        
        var t11 = new Team("Charlotte Hornets");
        teamInFileRepo.Save(t11);
        
        var t12 = new Team("Phoenix Suns");
        teamInFileRepo.Save(t12);
        
        var t13 = new Team("Portland TrailBlazers");
        teamInFileRepo.Save(t13);
        
        var t14 = new Team("Golden State Warriors");
        teamInFileRepo.Save(t14);
        
        var t15 = new Team("Washington Wizards");
        teamInFileRepo.Save(t15);
        
        var t16 = new Team("San Antonio Spurs");
        teamInFileRepo.Save(t16);
        
        var t17 = new Team("Orlando Magic");
        teamInFileRepo.Save(t17);
        
        var t18 = new Team("Denver Nuggets");
        teamInFileRepo.Save(t18);
        
        var t19 = new Team("Detroit Pistons");
        teamInFileRepo.Save(t19);
        
        var t20 = new Team("Atlanta Hawks");
        teamInFileRepo.Save(t20);
        
        var t21 = new Team("Dallas Mavericks");
        teamInFileRepo.Save(t21);
        
        var t22 = new Team("Sacramento Kings");
        teamInFileRepo.Save(t22);
        
        var t23 = new Team("Oklahoma City Thunder");
        teamInFileRepo.Save(t23);
        
        var t24 = new Team("Boston Celtics");
        teamInFileRepo.Save(t24);
        
        var t25 = new Team("New York Knicks");
        teamInFileRepo.Save(t25);
        
        var t26 = new Team("Minnesota Timberwolves");
        teamInFileRepo.Save(t26);
        
        var t27 = new Team("Miami Heat");
        teamInFileRepo.Save(t27);
        
        var t28 = new Team("Milwaukee Bucks");
        teamInFileRepo.Save(t28);
        
        List<Team> teams = new List<Team>()
        {
            t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17,
            t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28
        };
        
        PopulatePlayers(playerInFileRepo, teams);
        PopulateGames(gameInFileRepo, teams);
        PopulateActivePlayers(activePlayerInFileRepo, playerInFileRepo, gameInFileRepo);
    }

    private static void PopulateGames(GameInFileRepo gameInFileRepo, List<Team> teams)
    {
        List<Game> games = new List<Game>();
        games.Add(new Game(teams[17], teams[21], DateTime.Parse("2017-03-26T19:24:45Z")));
        games.Add(new Game(teams[22], teams[0], DateTime.Parse("2017-04-09T14:14:37Z")));
        games.Add(new Game(teams[11], teams[12], DateTime.Parse("2017-04-11T00:06:01Z")));
        games.Add(new Game(teams[2],	teams[3], DateTime.Parse("2017-06-05T04:39:59Z")));
        games.Add(new Game(teams[15], teams[27], DateTime.Parse("2017-08-07T00:41:45Z")));
        games.Add(new Game(teams[23], teams[21], DateTime.Parse("2017-09-24T13:41:25Z")));
        games.Add(new Game(teams[18], teams[2], DateTime.Parse("2017-09-29T11:07:31Z")));
        games.Add(new Game(teams[21], teams[25], DateTime.Parse("2017-11-03T06:32:48Z")));
        games.Add(new Game(teams[8],	teams[6], DateTime.Parse("2018-03-02T13:28:36Z")));
        games.Add(new Game(teams[20], teams[9], DateTime.Parse("2018-03-06T23:15:52Z")));
        games.Add(new Game(teams[1],	teams[22], DateTime.Parse("2018-04-29T16:31:14Z")));
        games.Add(new Game(teams[6],	teams[1], DateTime.Parse("2018-05-15T02:52:11Z")));
        games.Add(new Game(teams[23], teams[26], DateTime.Parse("2018-11-02T04:47:20Z")));
        games.Add(new Game(teams[11], teams[6], DateTime.Parse("2018-11-04T06:52:26Z")));
        games.Add(new Game(teams[0],	teams[25], DateTime.Parse("2019-03-27T09:13:52Z")));
        games.Add(new Game(teams[19], teams[5], DateTime.Parse("2019-07-17T06:35:25Z")));
        games.Add(new Game(teams[6],	teams[10], DateTime.Parse("2019-09-05T11:46:24Z")));
        games.Add(new Game(teams[15], teams[6], DateTime.Parse("2019-09-28T22:02:17Z")));
        games.Add(new Game(teams[18], teams[15], DateTime.Parse("2019-10-22T12:37:28Z")));
        games.Add(new Game(teams[15], teams[16], DateTime.Parse("2019-12-28T06:29:45Z")));
        games.Add(new Game(teams[12], teams[13], DateTime.Parse("2020-05-06T03:12:10Z")));
        games.Add(new Game(teams[22], teams[10], DateTime.Parse("2020-08-09T06:44:30Z")));
        games.Add(new Game(teams[9],	teams[14], DateTime.Parse("2021-01-13T16:58:56Z")));
        games.Add(new Game(teams[5],	teams[16], DateTime.Parse("2021-04-16T07:50:13Z")));
        games.Add(new Game(teams[3],	teams[16], DateTime.Parse("2021-09-16T09:16:05Z")));
        games.Add(new Game(teams[13], teams[22], DateTime.Parse("2022-01-15T07:44:32Z")));
        games.Add(new Game(teams[9],	teams[26], DateTime.Parse("2022-03-15T09:03:49Z")));
        games.Add(new Game(teams[5],	teams[8], DateTime.Parse("2022-04-20T09:47:21Z")));
        games.Add(new Game(teams[26], teams[4], DateTime.Parse("2022-05-27T22:18:37Z")));
        games.Add(new Game(teams[27], teams[10], DateTime.Parse("2022-07-25T05:55:33Z")));
        
        games.ForEach(x => gameInFileRepo.Save(x));
    }

    private static void PopulatePlayers(PlayerInFileRepo repo, List<Team> teams)
    {
        repo.Save(new Player("Cristina Adriana", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Adela Petronela", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Iuliu Ani", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Iulian Maricica", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Iosif Simon", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Aurel Rebeca", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Lenuta Sanda", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Eugenia Melania", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Amalia Dragos", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Emanuela Emil", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Nicolae Filip", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Catalina Ovidiu", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Constantin Rozalia", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Aurora Cezar", "Scoala Gimnaziala Horea", teams[0]));
        repo.Save(new Player("Luminita Sofia", "Scoala Gimnaziala Horea", teams[0]));


        repo.Save(new Player("Simion Delia", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Horia Amalia", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Flaviu Ionela", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Danut Veronica", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Oana Ramona", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Valeria George", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Cornel Lavinia", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Beatrice Isabela", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Octavian Ilinca", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Razvan Octavia", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Stefania Daniel", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Cezara Natalia", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Marinela Elisabeta", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Ancuta Noemi", "Scoala Gimnaziala Octavian Goga", teams[1]));
        repo.Save(new Player("Neculai Sebastian", "Scoala Gimnaziala Octavian Goga", teams[1]));
        

        repo.Save(new Player("Elisabeta Ion", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Petrut Camelia", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Bianca Alina", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Denisa Nicusor", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Ancuta Iulian", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Catina Violeta", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Casandra Razvan", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Valeriu Magda", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Virgil Iuliana", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Dorina Ileana", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Virgil Octavian", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Ladislau Mihail", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Antonia Victor", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Sebastian Robert", "Liceul Teoretic Lucian Blaga", teams[2]));
        repo.Save(new Player("Bogdan Ecaterina", "Liceul Teoretic Lucian Blaga", teams[2]));
        

        repo.Save(new Player("Mihail Andra", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Carmen Ruxandra", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Cristiana Ilie", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Fane Sebastian", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Ancuta Georgiana", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Silvia Valentin", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Razvan Delia", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Isabella Demetra", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Ilie Rares", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Vasilica Ioana", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Noemi Raluca", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Raul Alexandra", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Andra Anghel", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Violeta Adrian", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        repo.Save(new Player("Margareta Corneliu", "Scoala Gimnaziala \"Ioan Bob\"", teams[3]));
        

        repo.Save(new Player("Costin Magda", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Lavinia Liviu", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Ovidia Theodor", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Emil Beatrice", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Florina Corneliu", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Alin Laurențiu", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Lavinia Horia", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Diana Aurel", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Anton Nicusor", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Nicolae Apostol", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Viorel Maricica", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Mihaită Ilie", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Valentina Gavril", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Amalia Dorian", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));
        repo.Save(new Player("Simona Felicia", "Scoala Gimnaziala \"Ion Creanga\"", teams[4]));


        repo.Save(new Player("Mihail Liana", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Doina Pompiliu", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Gavrila Nicoleta", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Cristiana Luca", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Cezar Miron", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Otilia Miruna", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Elisabeta Georgeta", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Adi Vasilica", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Emilia Ionela", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Remus Catalina", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Antonia Nicu", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Larisa Anastasie", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Toma Mariana", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Denis Doru", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));
        repo.Save(new Player("Florentin Gabriel", "Colegiul National Pedagogic \"Gheorghe Lazar\"", teams[5]));

        
        repo.Save(new Player("Maricica Ioan", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Constanta Doina", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Ilie Mihai", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Valentin Cristian", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Elisabeta Daria", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Ioana Camelia", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Anca Horea", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Toma Natalia", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Sofia Magda", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Valerian Loredana", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Laura Horea", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Catina Emanuel", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Lucian Ionela", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Crina Florina", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        repo.Save(new Player("Casandra Isabella", "Scoala Gimnaziala Internationala SPECTRUM", teams[6]));
        

        repo.Save(new Player("Robert Timotei", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Luciana Teodora", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Leonard Iosif", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Nicusor Traian", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Fabian Dragos", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Sonia Alin", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Eduard Adi", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Livia Sergiu", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Gabi Oana", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Petru Ovidiu", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Ruxandra Codrin", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Rebeca Casandra", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Ramona Alexandrina", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Daniela Vali", "Colegiul National \"Emil Racovita\"", teams[7]));
        repo.Save(new Player("Marta Octavian", "Colegiul National \"Emil Racovita\"", teams[7]));
        

        repo.Save(new Player("Mihai Stefana", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Mitica Lavinia", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Ion Fabian", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Eliza Bogdan", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Georgeta Marin", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Ovidiu Adela", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("David Ionel", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Marius Sara", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Antonia Rodica", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Martin Cornel", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Nicusor Sofia", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Damian Ladislau", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Cristiana Loredana", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Ionela Antoniu", "Colegiul National \"George Cosbuc\"", teams[8]));
        repo.Save(new Player("Manuel Anastasie", "Colegiul National \"George Cosbuc\"", teams[8]));
        

        repo.Save(new Player("Iulian Maria", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Fabian Vasilica", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Doina Lucia", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Carol Vasilica", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Larisa Isabella", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Gabi Eusebiu", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Angela Lucian", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Cezara Pompiliu", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Decebal Livia", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Alin Ligia", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Aurica Luca", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Ciprian Catalin", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Gavrila Cosmina", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Virginia Maricica", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        repo.Save(new Player("Silvia Carmen", "Scoala Gimnaziala \"Ion Agarbiceanu\"", teams[9]));
        
        
        repo.Save(new Player("Fabian Aurica", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Narcisa Cecilia", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Stefan Cristina", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Vasilica Alin", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Tiberiu Costache", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Liviu Mihaita", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Larisa Florina", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Nicusor Lucian", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Adelina Florentin", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Timotei Adela", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Horia Ionu", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Marius Stefania", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Daniela Simion", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Marius Adela", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
        repo.Save(new Player("Dorina Alin", "Liceul Teoretic \"Avram Iancu\"", teams[10]));
            
        
        repo.Save(new Player("Paula Sergiu", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Dana Sabina", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Serghei Constanța", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Petrut Steliana", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Estera Anisoara", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Victoria Renata", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Flaviu Tereza", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Raluca Ilie", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Mircea Ivan", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Horea Gabriela", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Nicolae Horea", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Vlad Lucia", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Ghita Adelina", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Dan Pompiliu", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
        repo.Save(new Player("Vasilica Demetra", "Scoala Gimnaziala \"Constantin Brancusi\"", teams[11]));
            
            
        repo.Save(new Player("Angela Simon", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Alexandrina Magda", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Dan Renata", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Mirela Adelina", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Andrei Leonard", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Anastasie Ghenadie", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Danut Apostol", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Catrinel Lenuța", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Costel Grigore", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Timotei Felix", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Theodor Alina", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Magdalena Augustin", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Razvan Beatrice", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Constanta Sabina", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
        repo.Save(new Player("Veronica Vlad", "Liceul Teoretic \"Onisifor Ghibu\"", teams[12]));
            
            
        repo.Save(new Player("Iuliana Costel", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Marilena Denis", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Petru Floriana", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Alex Irina", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Veronica Cristian", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Cristina Ieronim", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Petrica Ladislau", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Ladislau Decebal", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Alexandru Roxana", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Paul Viorel", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Catalina Andra", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Lucia Marina", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Georgeta Anton", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Sanda Sara", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
        repo.Save(new Player("Rozalia Razvan", "Liceul Teoretic \"Onisifor Ghibu\"", teams[13]));
            
            
        repo.Save(new Player("Violeta Cezara", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Constantina Horatiu", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Aurelia Melania", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Ramona Teodor", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Stefana Damian", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Camelia Georgiana", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Isabela Ion", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Cornel Elisabeta", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Georgiana Razvan", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Rares Darius", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Emil Carol", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Petrica Violeta", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Ancuta Iolanda", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Ionela Mihaela", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
        repo.Save(new Player("Aurica Georgiana", "Liceul cu Program Sportiv Cluj-Napoca", teams[14]));
            
            
        repo.Save(new Player("Magdalena Adriana", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Costache Camelia", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Delia Florian", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Catrinel Eugen", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Alexandru Rafael", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Dragos Eusebiu", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Eduard Lenuta", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Livia Alin", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Bianca Rafael", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Veronica Floriana", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Diana Lazar", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Gavrila Angelica", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Oana Aurelia", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Timotei Cornel", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
        repo.Save(new Player("Marcel Eugen", "Liceul Teoretic \"Nicolae Balcescu\"", teams[15]));
            
            
        repo.Save(new Player("Albert Leonard", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Eusebiu Sabina", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Beniamin Daniel", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Dionisie Aurică", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Veronica Constanta", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Raul Codrut", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Cristiana Natalia", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Petru Petre", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Marcel Horia", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Monica Iolanda", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Dumitru Dorian", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Petre Paul", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Matei Mihail", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Cristi Delia", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
        repo.Save(new Player("Doru Fabian", "Liceul Teoretic \"Gheorghe Sincai\"", teams[16]));
            
            
        repo.Save(new Player("Manuela Florentin", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Daniela Livia", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Doru Dorian", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Emanuel Angelica", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Nicoleta David", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Nicolae Gabriela", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Adina Demetra", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Radu Manuela", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Angelica Romulus", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Ileana Augustin", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Marcel Vasile", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Marinela Ioan", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Antoniu Octavian", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Margareta Danut", "Scoala \"Nicolae Titulescu\"", teams[17]));
        repo.Save(new Player("Cristina Dumitru", "Scoala \"Nicolae Titulescu\"", teams[17]));

        
        repo.Save(new Player("Cornel Darius", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Valerian Flavius", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Costică Veronica", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Simona Mihail", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Sorina Ionut", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Viorica Simion", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Constanta Estera", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Miron Virgiliu", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Crina Miron", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Bogdana Iosif", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Cristina Florentina", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Floriana Angelica", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Stelian Vasilica", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Alina Cezar", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
        repo.Save(new Player("Georgiana Sara", "Scoala Gimnaziala \"Liviu Rebreanu\"", teams[18]));
            
            
        repo.Save(new Player("Catrinel Cezar", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Cosmin Mircea", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Otilia Albert", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Steliana Anca", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Stefan Carmen", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Floriana Iuliana", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Albert Iacob", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Simon Otilia", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Cristi Diana", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Eva Ieronim", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Angelica Nelu", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Noemi Serghei", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Valerian Nicoleta", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Magda Crina", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
        repo.Save(new Player("Paula Eusebiu", "Scoala Gimnaziala \"Iuliu Hatieganu\"", teams[19]));
            
            
        repo.Save(new Player("Daniela Mihaela", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Sandu Costica", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Leonard Octavia", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Octavian Marcel", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Elisabeta Adelina", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Iulian Stan", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Dana Denisa", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Andrei Monica", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Eva Mihail", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Ligia Isabela", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Carmen Georgiana", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Anisoara Cosmin", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Floriana Viorela", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Petru Stelian", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
        repo.Save(new Player("Adrian Cristi", "Liceul Teoretic \"Bathory Istvan\"", teams[20]));
            
            
        repo.Save(new Player("Ghenadie Albert", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Iuliu Anca", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Vlad Daciana", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Dezideriu Catrinel", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Emilian Lucia", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Valentin Aurica", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Sanda Renata", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Eugenia Laurentiu", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Sara Gabriel", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Serghei Bianca", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Paul Sofia", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Claudiu Magda", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Denisa Sabina", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Valentina Monica", "Colegiul National \"George Baritiu\"", teams[21]));
        repo.Save(new Player("Demetra Luminita", "Colegiul National \"George Baritiu\"", teams[21]));
            
            
        repo.Save(new Player("Cosmina Dumitra", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Madalina Adelina", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Catina Pompiliu", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Viorica Traian", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Teodora Catalin", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Sara Madalina", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Constanta Demetra", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Ileana Fabian", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Anisoara Vasilica", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Ciprian Dorinel", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Luciana Damian", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Simona Stelian", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Viorela Ramona", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Olimpia Dumitru", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
        repo.Save(new Player("Andra Dragos", "Liceul Teoretic \"Apaczai Csere Janos\"", teams[22]));
            
            
        repo.Save(new Player("Mihai Cezara", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Mihaita Corneliu", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Flavius Andreea", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Tiberiu Aurelian", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Larisa Nicusor", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("David Catrinel", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Sanda Ghenadie", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Constanța Anghel", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Marilena Andra", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Andrada Daciana", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Dorina Floriana", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Codrin Atanasie", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Ligia Dorian", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Sabina Sandra", "Seminarul Teologic Ortodox", teams[23]));
        repo.Save(new Player("Iosif Eliza", "Seminarul Teologic Ortodox", teams[23]));
            
            
        repo.Save(new Player("Bogdan Ieronim", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Diana Damian", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Lucian Romulus", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Mihail Toma", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Madalina Catalina", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Ciprian Dezideriu", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Horea Daniela", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Mihaită Adelina", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Dinu David", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Fane Octavian", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Daniel Silvia", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Roxana Oana", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Vali Iulian", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Marcel Iuliu", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
        repo.Save(new Player("Sorin Isac", "Liceul de Informatica \"Tiberiu Popoviciu\"", teams[24]));
            
            
        repo.Save(new Player("Amalia Teodor", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Brândusa Daria", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Daria Codruț", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Sara Doru", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Dorina Martin", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Iosif Natalia", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Claudia Renata", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Aurelia Simon", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Emilia Stefan", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Claudiu Estera", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Mariana Robert", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Teodora Vasilica", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Cosmin Rodica", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Crina Estera", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
        repo.Save(new Player("Horatiu Ancuța", "Scoala Gimnaziala \"Alexandru Vaida – Voevod\"", teams[25]));
            
            
        repo.Save(new Player("Iosif Ilinca", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Isac Filimon", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Dinu Atanase", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Virgiliu Andreea", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Stelian Emilian", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Aurica Emanuela", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Sandra Luca", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Marcela David", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Constantina Serghei", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Veronica Isac", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Atanasie Loredana", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Atanase Costica", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Anastasie Nicusor", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Flavia Eva", "Liceul Teoretic ELF", teams[26]));
        repo.Save(new Player("Mihaela Ozana", "Liceul Teoretic ELF", teams[26]));
            
            
        repo.Save(new Player("Ionel Flaviu", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Cornel Dumitra", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Lucian Demetra", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Marius Lidia", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Felix Sara", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Fane Anamaria", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Lidia Veaceslav", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Sofia Sandu", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Constantina Valentin", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Camelia Margareta", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Ecaterina Petrut", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Codrin Alexandru", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Cornelia Anton", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Margareta Rafael", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
        repo.Save(new Player("Daniela Sabina", "Scoala Gimnaziala \"Gheorghe Sincai\" Floresti", teams[27]));
    }

    private static void PopulateActivePlayers(ActivePlayerInFileRepo activePlayerInFileRepo, PlayerInFileRepo playerInFileRepo, GameInFileRepo gameInFileRepo)
    {
        gameInFileRepo.FindAll()
            .ToList()
            .ForEach(game =>
                {
                    playerInFileRepo.FindAll()
                        .Where(player => 
                            player.Team.Id.Equals(game.FirstTeam.Id) || 
                            player.Team.Id.Equals(game.SecondTeam.Id))
                        .ToList()
                        .ForEach(player =>
                        {
                            var random = new Random();
                            var points = random.Next(5, 21);
                            activePlayerInFileRepo.Save(
                                new ActivePlayer(player.Id, game.Id, points, ActivePlayerType.Participant)
                            );
                        });
                }
            );
    }

    private static void PopulateStudents(StudentInFileRepo repo)
    {
        repo.Save(new Student("Cristina Adriana", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Adela Petronela", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Iuliu Ani", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Iulian Maricica", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Iosif Simon", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Aurel Rebeca", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Lenuta Sanda", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Eugenia Melania", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Amalia Dragos", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Emanuela Emil", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Nicolae Filip", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Catalina Ovidiu", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Constantin Rozalia", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Aurora Cezar", "Scoala Gimnaziala Horea"));
        repo.Save(new Student("Luminita Sofia", "Scoala Gimnaziala Horea"));


        repo.Save(new Student("Simion Delia", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Horia Amalia", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Flaviu Ionela", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Danut Veronica", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Oana Ramona", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Valeria George", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Cornel Lavinia", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Beatrice Isabela", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Octavian Ilinca", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Razvan Octavia", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Stefania Daniel", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Cezara Natalia", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Marinela Elisabeta", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Ancuta Noemi", "Scoala Gimnaziala Octavian Goga"));
        repo.Save(new Student("Neculai Sebastian", "Scoala Gimnaziala Octavian Goga"));
        

        repo.Save(new Student("Elisabeta Ion", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Petrut Camelia", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Bianca Alina", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Denisa Nicusor", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Ancuta Iulian", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Catina Violeta", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Casandra Razvan", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Valeriu Magda", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Virgil Iuliana", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Dorina Ileana", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Virgil Octavian", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Ladislau Mihail", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Antonia Victor", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Sebastian Robert", "Liceul Teoretic Lucian Blaga"));
        repo.Save(new Student("Bogdan Ecaterina", "Liceul Teoretic Lucian Blaga"));
        

        repo.Save(new Student("Mihail Andra", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Carmen Ruxandra", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Cristiana Ilie", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Fane Sebastian", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Ancuta Georgiana", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Silvia Valentin", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Razvan Delia", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Isabella Demetra", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Ilie Rares", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Vasilica Ioana", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Noemi Raluca", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Raul Alexandra", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Andra Anghel", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Violeta Adrian", "Scoala Gimnaziala \"Ioan Bob\""));
        repo.Save(new Student("Margareta Corneliu", "Scoala Gimnaziala \"Ioan Bob\""));
        

        repo.Save(new Student("Costin Magda", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Lavinia Liviu", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Ovidia Theodor", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Emil Beatrice", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Florina Corneliu", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Alin Laurențiu", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Lavinia Horia", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Diana Aurel", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Anton Nicusor", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Nicolae Apostol", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Viorel Maricica", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Mihaită Ilie", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Valentina Gavril", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Amalia Dorian", "Scoala Gimnaziala \"Ion Creanga\""));
        repo.Save(new Student("Simona Felicia", "Scoala Gimnaziala \"Ion Creanga\""));


        repo.Save(new Student("Mihail Liana", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Doina Pompiliu", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Gavrila Nicoleta", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Cristiana Luca", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Cezar Miron", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Otilia Miruna", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Elisabeta Georgeta", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Adi Vasilica", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Emilia Ionela", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Remus Catalina", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Antonia Nicu", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Larisa Anastasie", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Toma Mariana", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Denis Doru", "Colegiul National Pedagogic \"Gheorghe Lazar\""));
        repo.Save(new Student("Florentin Gabriel", "Colegiul National Pedagogic \"Gheorghe Lazar\""));

        
        repo.Save(new Student("Maricica Ioan", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Constanta Doina", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Ilie Mihai", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Valentin Cristian", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Elisabeta Daria", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Ioana Camelia", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Anca Horea", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Toma Natalia", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Sofia Magda", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Valerian Loredana", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Laura Horea", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Catina Emanuel", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Lucian Ionela", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Crina Florina", "Scoala Gimnaziala Internationala SPECTRUM"));
        repo.Save(new Student("Casandra Isabella", "Scoala Gimnaziala Internationala SPECTRUM"));
        

        repo.Save(new Student("Robert Timotei", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Luciana Teodora", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Leonard Iosif", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Nicusor Traian", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Fabian Dragos", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Sonia Alin", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Eduard Adi", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Livia Sergiu", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Gabi Oana", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Petru Ovidiu", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Ruxandra Codrin", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Rebeca Casandra", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Ramona Alexandrina", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Daniela Vali", "Colegiul National \"Emil Racovita\""));
        repo.Save(new Student("Marta Octavian", "Colegiul National \"Emil Racovita\""));
        

        repo.Save(new Student("Mihai Stefana", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Mitica Lavinia", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Ion Fabian", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Eliza Bogdan", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Georgeta Marin", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Ovidiu Adela", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("David Ionel", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Marius Sara", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Antonia Rodica", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Martin Cornel", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Nicusor Sofia", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Damian Ladislau", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Cristiana Loredana", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Ionela Antoniu", "Colegiul National \"George Cosbuc\""));
        repo.Save(new Student("Manuel Anastasie", "Colegiul National \"George Cosbuc\""));
        

        repo.Save(new Student("Iulian Maria", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Fabian Vasilica", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Doina Lucia", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Carol Vasilica", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Larisa Isabella", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Gabi Eusebiu", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Angela Lucian", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Cezara Pompiliu", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Decebal Livia", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Alin Ligia", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Aurica Luca", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Ciprian Catalin", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Gavrila Cosmina", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Virginia Maricica", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
        repo.Save(new Student("Silvia Carmen", "Scoala Gimnaziala \"Ion Agarbiceanu\""));
    }
    
}