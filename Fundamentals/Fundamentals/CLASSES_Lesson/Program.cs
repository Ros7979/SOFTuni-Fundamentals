using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSES_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zada4a 1Advertisement Message
            //string[] phrases = {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };//da se dopalniat
            //string[] evevnts = { };
            //string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            //string[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            //int countOfMessagesToCreate =int.Parse( Console.ReadLine());
            //Random random = new Random();
            //for (int i = 0; i < countOfMessagesToCreate; i++)
            //{
            //    string phrase = phrases[random.Next(0, phrases.Length)];
            //    string currEvent=evevnts[random.Next(0, evevnts.Length)];
            //    string author=authors[random.Next(0, authors.Length)];
            //    string city=cities[random.Next(0, cities.Length)];
            //    Console.WriteLine($"{phrase} {currEvent} {author} {city}");
            //}
            //zada4a 2 Articles
            //string[] currentArticle = Console.ReadLine().Split(',');
            //var article = new Article(currentArticle[0], currentArticle[1], currentArticle[2]);
            //int countOfChanges = int.Parse(Console.ReadLine());
            //for (int i = 0; i < countOfChanges; i++)
            //{
            //    char[] mass = { ':', ' ' };
            //    string[] lines = Console.ReadLine().Split(':');
            //    string command = lines[0];
            //    string argument = lines[1];
            //    switch (command)
            //    {
            //        case "Edit":
            //            article.Edit(argument);
            //            break;
            //        case "ChangeAuthor":
            //            article.ChangeAuthor(argument);
            //            break;
            //        case "Rename":
            //            article.Rename(argument);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine(article);

            //zada4a 3
            //List<Article> articles = new List<Article>();
            //int countOfChanges = int.Parse(Console.ReadLine());
            //for (int i = 0; i < countOfChanges; i++)
            //{
            //    string[] currentAticle = Console.ReadLine().Split(',');
            //    var article = new Article(currentAticle[0], currentAticle[1], currentAticle[2]);
            //    articles.Add(article);
            //}
            //string line = Console.ReadLine();
            //foreach (var article in articles)
            //{
            //    Console.WriteLine(article);
            //}

            //zada4a 4
            //int countOfStudents = int.Parse(Console.ReadLine());
            //List<Student> students = new List<Student>();
            //for (int i = 0; i < countOfStudents; i++)
            //{
            //    string[] currentStudentInfo = Console.ReadLine().Split(' ');
            //    var student = new Student(currentStudentInfo[0], currentStudentInfo[1], double.Parse(currentStudentInfo[2]));
            //    students.Add(student);
            //}
            //students = students.OrderByDescending(currStudent => currStudent.Grade).ToList();
            ////students.ForEach(student=>Console.WriteLine(student)); Vmesto da se izpolzva dolniat foreach cycle tyk se izpolzva LINQ
            //foreach (var student in students)
            //{
            //    //   Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");//ako izpolzvame override ToString() ne triabva da se pi6e tova a se pi6e sledva6tia red
            //    Console.WriteLine(student);
            //}

            //zada4a 5Teamwork Projects
            //int counOfTeamsToBeCreated = int.Parse(Console.ReadLine());
            //var teams=new List<Team>();
            //for (int i = 0; i < counOfTeamsToBeCreated; i++)
            //{
            //    var currTeamInf = Console.ReadLine().Split('-');
            //    var creator =currTeamInf[0];
            //    var teamName =currTeamInf[1];
            //    if (teams.Any(curTeam=>curTeam.Name==teamName)
            //    {
            //        Console.WriteLine($"Team {teamName} was already created!");
            //    }
            //    else if (teams.Any(team => team.Creator == creator)
            //        {
            //        Console.WriteLine($"{creator} cannot create another team!");
            //    }
            //    else
            //    {
            //        var team = new Team();
            //        team.Name = teamName;   
            //        team.Creator = creator;
            //        team.Members = new List<string>(); 
            //        teams.Add(team);
            //        Console.WriteLine($"Team {teamName} has been created by {creator}");
            //    }
            //}
            //var line =Console.ReadLine();
            //while (line!="end of assignment")
            //{
            //    //  var memberInfo = line.Split(new string[] { "->" }, StringSplitOptions.None);
            //    var memberName = line.Split(new string[] { "->" },StringSplitOptions.None);
            //   // var memberName=memberInfo[0];
            //    var teamToJoin=memberName[1];
            //    if (teams.Any(team=>team.Members.Contains(memberName))||teams.Any(creator=>creator.Creator==memberName))
            //    {
            //        Console.WriteLine($"Member {memberName} cannot join team{teamToJoin}!);
            //    }
            //    else if (!teams.All(team=>team.Name==teamToJoin))
            //        {
            //        Console.WriteLine($"Team {teamToJoin} does not exist!");
            //    }
            //    else
            //    {
            //        var currTeam = teams.Find(team => team.Name == teamToJoin);
            //        currTeam.Members.Add(memberName);
            //    }
            //  line = Console.ReadLine();
            //}
            //var completedTeams = teams.Where(x => x.Members.Count > 0).ToList();
            //var disbanedTeams=teams.Where(team => team.Count == 0);
            //foreach (var team in completedTeams.OrderByDescending(team=>x.Members.Count).ThenBy(y=>y.Name))
            //{
            //    Console.WriteLine($"{team.Name}");
            //    Console.WriteLine($"- {team.Creator}");
            //foreach (var member in team.Members.OrderBy(x=>x))
            //{
            //    Console.WriteLine($"-- {member}");
            //}
            //}


            //zada4a 6 Vehicle Catalogue
            //List<Vehicle> vehicles = new List<Vehicle>();
            //while (true)
            //{
            //    string[] inpuArgs = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            //    if (inpuArgs[0] == "End")
            //    {
            //        break;
            //    }
            //    VhicleType vehicleType;
            //    bool isVehicleTypeParseSuccesful = Enum.TryParse(inpuArgs[0], true, out vehicleType);
            //    if (isVehicleTypeParseSuccesful)
            //    {
            //        string vehicleModel = inpuArgs[1];
            //        string vehicleColor = inpuArgs[2];
            //        int VehicleHorsePower = int.Parse(inpuArgs[3]);
            //        var curVehicle = new Vehicle(vehicleType, vehicleModel, vehicleColor, VehicleHorsePower);
            //        vehicles.Add(curVehicle);

            //    }
            //}
            //while (true)
            //{
            //    string cmds = Console.ReadLine();
            //    if (cmds == "Close the Catalogue")
            //    {
            //        break;
            //    }
            //    var desireVhicels = vehicles.FirstOrDefault(vehicle => vehicle.Model == cmds);
            //    Console.WriteLine(desireVhicels);
            //}
            //var cars = vehicles.Where(Vehicle => Vehicle.Type == VhicleType.Car).ToList();
            //var trucks = vehicles.Where(Vehicle => Vehicle.Type == VhicleType.Truck).ToList();
            //double carsAvgHorsepower = cars.Count > 0 ? cars.Average(car => car.HorsePower) : 0.00;
            //double trucksAvgHorsepower = trucks.Count > 0 ? trucks.Average(truck => truck.HorsePower) : 0.00;
            //Console.WriteLine($"Cars have average horsepower of: {carsAvgHorsepower:f2}.");
            //Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsepower:f2}.");


            //zada4a 7 Order by Age
            string[] commands = Console.ReadLine().Split(' ');
            List<Person> personList = new List<Person>();
            while (commands[0] != "End")
            {
                var person = new Person(commands[0], commands[1], int.Parse(commands[2]));
                personList.Add(person);
                commands = Console.ReadLine().Split(' ');
            }
            //   personList.Sort();
            foreach (var person in personList.OrderBy(person => person.Age))
            {
                Console.WriteLine($"{person}");
            }

        }
    }
    //zada4a 2
    //class Article
    //{
    //    public Article(string title, string content, string author)
    //    {
    //        Author = author;
    //        Title = title;
    //        Content = content;
    //    }
    //    public string Title { get; set; }
    //    public string Content { get; set; }
    //    public string Author { get; set; }
    //    public void ChangeAuthor(string author)=>Author=author;
    //    public void Edit(string content)=>Content=content;
    //    public void Rename(string title)=>Title=title;
    //    public override string ToString()=>$"{Title} -{Content}:{Author}";
    // {
    //  return $"{Title} - {Content}: {Author}";  po staromu napisano
    // }
    //}
    //zada4a 3
    //class Article
    //{
    //    public Article(string title, string content, string author)
    //    {
    //        Author = author;
    //        Title = title;
    //        Content = content;
    //    }
    //    public string Title { get; set; }
    //    public string Content { get; set; }
    //    public string Author { get; set; }
    //    public override string ToString() => $"{Title} -{Content}:{Author}";
    //}

    //zada4a 4
    //class Student
    //{
    //    public Student(string firstname, string lastname, double grade)
    //    {
    //        FirstName = firstname;
    //        LastName = lastname;
    //        Grade = grade;
    //    }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public double Grade { get; set; }
    //    public override string ToString() => $"{FirstName} {LastName}: {Grade:f2}";
    //}

    //zada4a 5 Teamwork Projects
    //class Team
    //{
    //    public string Name { get; set; }
    //    public string Creator { get; set; }
    //    public List<string>Members { get; set; }
    //}

    //zada4a 6 Vehicle Catalogue
    //enum VhicleType
    //{
    //    Car, Truck
    //}
    //class Vehicle
    //{
    //    public Vehicle(VhicleType type, string model, string color, int horsePower)
    //    {
    //        Model = model;
    //        Color = color;
    //        HorsePower = horsePower;
    //        Type = type;
    //    }
    //    public string Model { get; set; }
    //    public string Color { get; set; }
    //    public int HorsePower { get; set; }
    //    public VhicleType Type { get; set; }
    //    public override string ToString()
    //    {
    //        var sb = new StringBuilder();
    //        sb.AppendLine($"Type: {Type}");
    //        sb.AppendLine($"Model: {Model}");
    //        sb.AppendLine($"Color: {Color}");
    //        sb.AppendLine($"Horsepower: {HorsePower}");
    //        return sb.ToString().TrimEnd();
    //    }
    //}


    //zada4a 7

    class Person
    {
        public Person   (string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }   

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} with ID: {ID} is {Age} years old.";


    }
}
