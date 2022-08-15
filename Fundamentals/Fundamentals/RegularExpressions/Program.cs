using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lekcia RegularExpressions
            //20.07.2022 Mutch Full Name
            //zada4a 1
            //string input = Console.ReadLine();
            //string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            //Regex regex = new Regex(pattern);
            //MatchCollection matches = regex.Matches(input);
            //Console.WriteLine(string.Join(" ",matches));

            //zada4a 3 Match Dates

            //string input=Console.ReadLine();
            //string pattern = @"(?<day>[0-9]{2})(?<separator>[\.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})";
            //MatchCollection matches = Regex.Matches(input, pattern);
            //foreach (Match match in matches)
            //{
            //    Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            //}


            //zada4a 2 Numbers ne e viarna
            //string input =Console.ReadLine();
            //string pattern = @"\+359([ \-])2 [0-9]{3}\1[0-9}{4}\b";
            //MatchCollection mattches=Regex.Matches(input, pattern);
            //Console.WriteLine(string.Join(", ",mattches));

            //Ypraznenia 22.07.2022
            //zada4a 1 Furniture

            //string regex = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            //string input = Console.ReadLine();
            //List<string> list = new List<string>();
            //double totalPrice = 0;
            //while (input!="Purchase")
            //{
            //    Match matches = Regex.Match(input, regex,RegexOptions.IgnoreCase); 
            //    if (matches.Success)
            //    {
            //        var name=matches.Groups["name"].Value;
            //        var price =double.Parse(matches.Groups["price"].Value);
            //        var quantity = int.Parse(matches.Groups["quantity"].Value);
            //        list.Add(name);
            //        totalPrice +=price* quantity;
            //    }
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("Bought furniture: ");
            //list.ForEach(Console.WriteLine);
            //Console.WriteLine($"Total money spend: {totalPrice:f2}");

            //zada4a 2 Race
            //patern za imenata
            //string patern = @"(?<name>[A-Za-z])";
            //Regex patternForName = new Regex(patern);
            //string paternForDigits = @"(?<digits>\d+)";
            //int sumOfDigits = 0;
            //var part7icipants = new Dictionary<string, int>();
            //var names = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //string input = Console.ReadLine();
            //while (input != "end of race")
            //{
            //    MatchCollection matchedNames = patternForName.Matches(input);
            //    MatchCollection matchedDigits = Regex.Matches(input, paternForDigits);
            //    string currName = string.Join("", matchedNames);
            //    string currDigits = string.Join("", matchedDigits);
            //    sumOfDigits = 0;
            //    for (int i = 0; i < currDigits.Length; i++)
            //    {
            //        sumOfDigits += int.Parse(currDigits[i].ToString());
            //    }
            //    if (names.Contains(currName))
            //    {
            //        if (!part7icipants.ContainsKey(currName))
            //        {
            //            part7icipants.Add(currName, sumOfDigits);
            //        }
            //        else
            //        {
            //            part7icipants[currName] += sumOfDigits;
            //        }
            //    }
            //    input = Console.ReadLine();
            //}
            //var winners = part7icipants.OrderByDescending(x => x.Value).Take(3);
            //var firstPlace = winners.Take(1);
            //var secondPlace = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            //var thirdPlace = winners.OrderBy(x => x.Value).Take(1);
            //foreach (var firstName in firstPlace)
            //{
            //    Console.WriteLine($"1st place: {firstName.Key}");
            //}
            //foreach (var secondName in secondPlace)
            //{
            //    Console.WriteLine($"2nd place: {secondName.Key}");
            //}
            //foreach (var thirdName in thirdPlace)
            //{
            //    Console.WriteLine($"3rd place: {thirdName.Key}");
            //}


            //zada4a 3 SoftUni Bar Income
            //string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";
            //string input = Console.ReadLine();
            //double totalIncome = 0;
            //while (input != "end of shift")
            //{
            //    Regex regex = new Regex(pattern);
            //    bool iaValid = regex.IsMatch(input);
            //    if (iaValid)
            //    {
            //        string customer = regex.Match(input).Groups["customer"].Value;
            //        string product = regex.Match(input).Groups["product"].Value;
            //        int quantity = int.Parse(regex.Match(input).Groups["quantity"].Value);
            //        double price = double.Parse(regex.Match(input).Groups["price"].Value);
            //        double totalPriceForCurrentProduct = price * quantity;
            //        totalIncome += totalPriceForCurrentProduct;
            //        Console.WriteLine($"{customer}: {product} - {totalPriceForCurrentProduct:f2}");
            //    }
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine($"Total income: {totalIncome:f2}");

            //zada4a 4 Star Enigma
            //string pattern = @"@(?<name>[A-z]+)[^@\-!:>]*:(?<population>[\d]+)[^@\-!:>]*!(?<type>[A,D])![^@\-!:>]*->(?<count>[\d]+)";
            //int lineOfInput = int.Parse(Console.ReadLine());
            //var attacked = new List<string>();
            //var destroyed = new List<string>();
            //for (int i = 0; i < lineOfInput; i++)
            //{
            //    string message = Console.ReadLine();
            //    int sum = message.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
            //    string decryptedMessage = "";
            //    foreach (var symbol in message)
            //    {
            //        decryptedMessage += (char)(symbol - sum);
            //    }
            //    Match matches = Regex.Match(decryptedMessage, pattern, RegexOptions.IgnoreCase);
            //    if (matches.Success)
            //    {
            //        string name = matches.Groups["name"].Value;
            //        int population = int.Parse(matches.Groups["population"].Value);
            //        char type = char.Parse(matches.Groups["type"].Value);
            //        int solgiersCount = int.Parse(matches.Groups["count"].Value);
            //        if (type != 'A')
            //        {
            //            destroyed.Add(name);
            //        }
            //        else
            //        {
            //            attacked.Add(name);
            //        }
            //    }
            //}
            //Console.WriteLine($"Attacked planets: {attacked.Count()}");
            //attacked.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
            //Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            //destroyed.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));

            //zada4a 5 Nether Realms
            //string healthPattern = @"[^\+\-\*\/\.,0-9]";
            //string damagePattern = @"-?\d+\.?\d*";
            //string multiplyDividePattern = @"[\*\/]";
            //string splitPattern = @"[,\s]+";
            //string input = Console.ReadLine();
            //string[] demons = Regex.Split(input, splitPattern).OrderBy(x=>x).ToArray();
            //for (int i = 0; i < demons.Length; i++)
            //{
            //    string curDemon = demons[i];
            //    var healthMatched=Regex.Matches(curDemon, healthPattern);
            //    var health = 0;
            //    foreach (Match match in healthMatched)
            //    {
            //        char curChar = char.Parse(match.ToString());
            //        health+=curChar;
            //    }
            //    double damage = 0;
            //    var damageMatched= Regex.Matches(curDemon, damagePattern);
            //    foreach (Match match in damageMatched)
            //    {
            //        double currentDamage = double.Parse(match.ToString());
            //        damage+=currentDamage;
            //    }
            //    var multiplyAndDividers= Regex.Matches(curDemon,multiplyDividePattern);
            //    foreach (Match match in multiplyAndDividers)
            //    {
            //        char currentOperator=char.Parse(match.ToString());
            //        if (currentOperator=='*')
            //        {
            //            damage *= 2;
            //        }
            //        else
            //        {
            //            damage /= 2;
            //        }
            //    }
            //    Console.WriteLine($"{curDemon} - {health} health, {damage:f2} damage");
            //}

            //zada4a 6 Emails
            //string pattern = @"(^|\s)[A-Za-z0-9][\w*\-\.]*[A-Za-z0-9]@[A-Za-z]+([.-][A-Za-z]+)+\b";
            //string input = Console.ReadLine();
            //MatchCollection matches = Regex.Matches(input, pattern);
            //matches.ToList().ForEach(Console.WriteLine);


        }
    }
}