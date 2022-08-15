using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociativeARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Lekcia 06.07.2022 Count real Numbers
            //SortedDictionary<int, int> occurencesByNumber = new SortedDictionary<int, int>();
            // int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            // foreach (int number in numbers)
            // {
            //     if (occurencesByNumber.ContainsKey(number))
            //     {

            //         int curreOcurences = occurencesByNumber[number];
            //         curreOcurences += 1;
            //         occurencesByNumber[number] = curreOcurences;
            //     }
            //     else
            //     {
            //         occurencesByNumber.Add(number, 1);
            //     }
            // }
            // foreach (var occurenBy in occurencesByNumber)
            // {
            //     Console.WriteLine($"{occurenBy.Key} -> {occurenBy.Value}");
            // }

            //zada4a 2 Odd ocurences
            //Dictionary<string,int> wordCount = new Dictionary<string, int>();
            //string[] words = Console.ReadLine().Split().Select(word=>word.ToLower()).ToArray();
            //foreach (var word in words)
            //{
            //    if (!wordCount.ContainsKey(word))
            //    {
            //        wordCount.Add(word, 0);
            //    }
            //    wordCount[word]++;
            //}
            //string[] oddCountWords=wordCount.Where(w=>w.Value%2!=0).Select(w=>w.Key).ToArray();
            //Console.WriteLine(String.Join(" ",oddCountWords));

            //zada4a 3
            // Dictionary<string, List<string>>synonims = new Dictionary<string, List<string>>();
            // int count=int.Parse(Console.ReadLine());
            // for (int i = 0; i < count; i++)
            // {
            //     string word = Console.ReadLine();
            //     string sinonym = Console.ReadLine();
            //     if (!synonims.ContainsKey(word))
            //     {
            //         synonims.Add(word, new List<string>());
            //     }
            //  //   List<string> currentxSynonym=synonims[word]; i po tozi na4in moze // za obiasnenie 
            ////    currentxSynonym.Add(sinonym);
            //     synonims[word].Add(sinonym);
            // }
            // foreach (var item in synonims)
            // {
            //   //  List<string> list = item.Value;
            //     Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            // }

            //zada4a 4 word filter

            //string[] words=Console.ReadLine().Split();
            //string[] evenLenghtWords=words.Where(word=>word.Length%2==0).ToArray();
            //Console.WriteLine(string.Join(Environment.NewLine,evenLenghtWords));

            //Ypraznenia 08.07.2022
            //zada4a 1 Count Chars in a string
            //char[] word=Console.ReadLine().ToCharArray();
            //Dictionary<char,int> letters=new Dictionary<char,int>();
            //foreach (var letter in word)//4etem bukva po bukva
            //{
            //    if (letter!=' ') //ako ne e prazno prostranstvo
            //    {
            //        if (!letters.ContainsKey(letter))
            //        {
            //            letters[letter]=0;
            //        }
            //        letters[letter]++;

            //    }
            //}
            //foreach (var kvpLetter in letters)
            //{
            //    Console.WriteLine($"{kvpLetter.Key} -> {kvpLetter.Value}");
            //}


            //zada4a 2 A miner task
            //var items=new Dictionary<string, int>();
            //string resources=Console.ReadLine();
            //while (resources!="stop")
            //{
            //    int quantity=int.Parse(Console.ReadLine());
            //    if (!items.ContainsKey(resources))
            //    {
            //        items.Add(resources, 0);
            //    }
            //    items[resources]+=quantity;
            //    resources=Console.ReadLine();
            //}
            //foreach (var curResources in items)
            //{
            //    Console.WriteLine($"{curResources.Key} -> {curResources.Value}");
            //}

            //zada4a 3 Orders
            //var orders=new Dictionary<string, double>();
            //var newOrders=new Dictionary<string, int>();
            //var input=Console.ReadLine();
            //while (input!="buy")
            //{
            //    var cmd=input.Split(' ');
            //    var productName=cmd[0];
            //    double productPrice=double.Parse(cmd[1]);
            //    int quantity=int.Parse(cmd[2]);
            //    if (!orders.ContainsKey(productName))
            //    {
            //        orders.Add(productName, productPrice);
            //        newOrders.Add(productName, quantity);
            //    }
            //    else if (orders.ContainsKey(productName))
            //    {
            //        orders.Remove(productName);
            //        orders.Add(productName, productPrice);
            //        newOrders[productName] += quantity;
            //    }
            //    input = Console.ReadLine();
            //}
            //foreach (var order in orders)
            //{
            //    foreach (var newOrder in newOrders)
            //    {
            //        if (order.Key==newOrder.Key)
            //        {
            //            Console.WriteLine($"{order.Key} -> {order.Value*newOrder.Value:f2}");
            //        }
            //    }
            //}

            //zada4a 4 softuni pasrking
            //var users=new Dictionary<string,string>();
            //int numberOfCommands=int.Parse(Console.ReadLine());
            //for (int i = 0; i < numberOfCommands; i++)
            //{
            //    var commands = Console.ReadLine().Split();
            //    var actions = commands[0];
            //    var userName=commands[1];

            //    switch (actions)
            //    {
            //        case "register":
            //            var plateNumber=commands[2];
            //            if (!users.ContainsKey(userName))
            //            {
            //                users.Add(userName, plateNumber);
            //                Console.WriteLine($"{userName} registered {plateNumber} successfully");

            //            }
            //            else
            //            {
            //                Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
            //            }
            //            break;
            //        case "unregister":
            //            if (!users.ContainsKey(userName))
            //            {
            //                Console.WriteLine($"ERROR: user {userName} not found");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{userName} unregistered successfully");
            //                users.Remove(userName);
            //            }
            //                break;
            //        default:
            //            break;
            //    }
            //}
            //foreach (var user in users)
            //{
            //    Console.WriteLine($"{user.Key} => {user.Value}");
            //}

            //zada4a 5 Courses
            //var courseInfo=new Dictionary<string, List<string>>();
            //string cmd = Console.ReadLine();
            //while (cmd!="end")
            //{
            //    string[] tokens=cmd.Split(new string[] { " : " },StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    string courseName=tokens[0];
            //    string studentName=tokens[1];
            //    if (!courseInfo.ContainsKey(courseName))
            //    {
            //        courseInfo[courseName] = new List<string>();
            //    }
            //    courseInfo[courseName].Add(studentName);



            //    cmd = Console.ReadLine();

            //}
            //PrintCourseInfo(courseInfo);


            //zada4a 6 Student Academy
            //var students=new Dictionary<string, List<double>>();
            //int n=int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    string studentName = Console.ReadLine();
            //    double studentGrade=double.Parse(Console.ReadLine());
            //    if (!students.ContainsKey(studentName))
            //    {
            //        students[studentName]=new List<double>();
            //    }
            //    students[studentName].Add(studentGrade);
            //}
            //foreach (var student in students)
            //{
            //    string studentName = student.Key;
            //    double studentAvgGrade=student.Value.Average();
            //    if (studentAvgGrade>=4.5)
            //    {
            //        Console.WriteLine($"{studentName} -> {studentAvgGrade:f2}");
            //    }
            //}

            //zada4a 7 Company Users
            //var companies=new Dictionary<string, List<string>>();
            //string cmd=Console.ReadLine();
            //while (cmd !="End")
            //{
            //    string[] tokens = cmd.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            //    var companyName=tokens[0];
            //    var emploiedId=tokens[1];
            //    if (!companies.ContainsKey(companyName))
            //    {
            //        companies.Add(companyName, new List<string>());
            //    }
            //    if (companies[companyName].Contains(emploiedId))
            //    {
            //        cmd = Console.ReadLine();
            //        continue;
            //    }
            //    companies[companyName].Add(emploiedId);
            //    cmd = Console.ReadLine();
            //}
            //foreach (var company in companies)
            //{
            //    Console.WriteLine($"{company.Key}");
            //    foreach (var emploeeID in company.Value)
            //    {
            //        Console.WriteLine($"-- {emploeeID}");
            //    }
            //}

            //More exercises zada4a 1 Ranking
            //Dictionary<string, string> contests = new Dictionary<string, string>();
            //string cmd = Console.ReadLine();
            //while (cmd != "end of contests")
            //{
            //    string[] tokens = cmd.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    string contest = tokens[0];
            //    string passwordForContest = tokens[1];
            //    if (!contests.ContainsKey(contest))
            //    {
            //        contests[contest] = passwordForContest;
            //    }
            //    cmd = Console.ReadLine();
            //}
            //Dictionary<string, List<string>> userName = new Dictionary<string, List<string>>();
            //Dictionary<string, int> points = new Dictionary<string, int>();
            //while (true)
            //{
            //    string cmd1 = Console.ReadLine();
            //    if (cmd1 == "end of submissions")
            //    {
            //        break;
            //    }
            //    string[] tokens = cmd1.Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    string contestUn = tokens[0];
            //    string passwordForContestUn = tokens[1];
            //    string userNameUn = tokens[2];
            //    int pointsUn = int.Parse(tokens[3]);
            //    string combain = $"{userNameUn} {contestUn}";
            //    if (!contests.ContainsKey(contestUn) || !(contests[contestUn] == passwordForContestUn))
            //    {
            //        continue;
            //    }
            //    if (contests.ContainsKey(contestUn) && contests[contestUn] == passwordForContestUn && !userName.ContainsKey(userNameUn))
            //    {
            //        userName.Add(userNameUn, new List<string>());
            //    }
            //    if (!userName[userNameUn].Contains(contestUn))
            //    {
            //        userName[userNameUn].Add(contestUn);
            //    }
            //    if (!points.ContainsKey(combain))
            //    {
            //        points[combain] = pointsUn;
            //    }
            //    if (points.ContainsKey(combain) && points[combain] < pointsUn)
            //    {
            //        points[combain] = pointsUn;
            //    }
            //}
            //string usra = null;
            //int sum1 = 0;
            //int sumAll = 0;
            //foreach (var point in userName.OrderBy(x => x.Key))
            //{
            //    foreach (var poiint in points.OrderByDescending(x => x.Value))
            //    {
            //        if (point.Key == poiint.Key.Split()[0])
            //        {
            //            sum1 += poiint.Value;
            //        }
            //    }
            //    if (sum1 > sumAll)
            //    {
            //        sumAll = sum1;
            //        usra = point.Key;
            //    }
            //    sum1 = 0;
            //}
            //Console.WriteLine($"Best candidate is {usra} with total {sumAll} points.");
            //Console.WriteLine($"Ranking: ");
            //string spisak = null;
            //foreach (var point in userName.OrderBy(x => x.Key))
            //{
            //    if (point.Key != spisak)
            //    {
            //        Console.WriteLine($"{point.Key}");
            //        spisak = point.Key;
            //    }
            //    foreach (var poiint in points.OrderByDescending(x => x.Value))
            //    {
            //        if (point.Key == poiint.Key.Split()[0])
            //        {
            //            string edno = poiint.Key.Split()[0];
            //            Console.WriteLine($"# {poiint.Key.Remove(0, edno.Count())} -> {poiint.Value}");
            //        }
            //    }
            //}

            //zada4a 2 Judge
            //Dictionary<string, Dictionary<string, int>> dic = new Dictionary<string, Dictionary<string, int>>();
            //Dictionary<string, int> dic1 = new Dictionary<string, int>();
            //string command = Console.ReadLine();
            //while (command != "no more time")
            //{
            //    string[] tokens = command.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    string userName = tokens[0];
            //    string content = tokens[1];
            //    int point = int.Parse(tokens[2]);
            //    if (!dic.ContainsKey(content))
            //    {
            //        dic.Add(content, new Dictionary<string, int>());
            //    }
            //    if (!dic[content].ContainsKey(userName))
            //    {
            //        dic[content][userName] = point;
            //    }
            //    else
            //    {
            //        dic[content][userName] = Math.Max(point, dic[content][userName]);
            //    }
            //    command = Console.ReadLine();
            //}
            //foreach (var kees in dic.Keys)
            //{
            //    int fr = dic[kees].Values.Count();
            //    Console.WriteLine($"{kees}: {fr} participants");
            //    int cn = 0;
            //    foreach (var itemi in dic[kees].OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            //    {
            //        cn++;
            //        Console.WriteLine($"{cn}. {itemi.Key} <::> {itemi.Value}");
            //    }
            //}
            //Console.WriteLine("Individual standings:");
            //foreach (var indi in dic.Values)
            //{
            //    foreach (var item in indi)
            //    {
            //        if (!dic1.ContainsKey(item.Key))
            //        {
            //            dic1[item.Key] = item.Value;
            //        }
            //        else if (dic1.ContainsKey(item.Key))
            //        {
            //            dic1[item.Key] += item.Value;
            //        }
            //    }
            //}
            //int cot = 0;
            //foreach (var last in dic1.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            //{
            //    cot++;
            //    Console.WriteLine($"{cot}. {last.Key} -> {last.Value}");
            //}


            //More Exercises Snowwhite zada4a 4
            //var drawrds=new Dictionary<string, int>();
            //string cmd=Console.ReadLine();
            //while(cmd != "Once upon a time")
            //{
            //    var tokens=cmd.Split(new string[] {" <:> "},StringSplitOptions.RemoveEmptyEntries);
            //    var dwarfName=tokens[0];
            //    var hatColor=tokens[1];
            //    var phisics=int.Parse(tokens[2]);
            //    var dwarfID=$"{dwarfName}:{hatColor}";
            //    if (!drawrds.ContainsKey(dwarfID))
            //    {
            //        drawrds.Add(dwarfID, phisics);
            //    }
            //    else
            //    {
            //        drawrds[dwarfID] = Math.Max(drawrds[dwarfID],phisics);
            //    }
            //    cmd=Console.ReadLine();
            //}
            //foreach (var dwarf in drawrds.OrderByDescending(x => x.Value).ThenByDescending(cuurDwarf =>
            //drawrds.Where(hatcolor => hatcolor.Key.Split(':')[1] == cuurDwarf.Key.Split(':')[1].Count()));
            //{
            //    string hatColor = dwarf.Key.Split(':')[1];
            //    string dwarfName = dwarf.Key.Split(':')[0];
            //    int dwarfPhysics = dwarf.Value;
            //    Console.WriteLine($"({hatColor}) {dwarfName} <-> {dwarfPhysics}");
            //}



        }

        //Metod kam 5-ta zada4a
        //private static void PrintCourseInfo(Dictionary<string, List<string>> courseInfo)
        //{
        //    foreach (var kvp in courseInfo)
        //    {
        //        string courseName = kvp.Key;
        //        var students=kvp.Value;
        //        Console.WriteLine($"{courseName}: {students.Count}");
        //        foreach (var student in students)
        //        {
        //            Console.WriteLine($"-- {student}");
        //        }

        //    }
        //}
    }
}
