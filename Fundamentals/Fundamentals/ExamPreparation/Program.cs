using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //model for Exam
            //string input=Console.ReadLine();
            //string comands=Console.ReadLine();
            //while (comands!="")
            //{
            //    string[] tokens = comands.Split(':').ToArray();/// ili (new string[] { ":|:" }, StringSplitOptions.None)
            //    string action =tokens[0];
            //    switch (action)
            //    {
            //        case "":
            //            break;
            //        case "":
            //            break;
            //        case "":
            //            break;
            //        default:
            //            break;
            //    }
            //    comands = Console.ReadLine();
            //}
            //Console.WriteLine(input);




            //Secret Chat
            //string stops = Console.ReadLine();
            //string commands = Console.ReadLine();
            //int count = 0;
            //while (commands != "Travel")
            //{
            //    string[] tokens = commands.Split(':').ToArray();
            //    string action = tokens[0];
            //    switch (action)
            //    {
            //        case "Add Stop":
            //            if (int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < stops.Length)
            //            {
            //                stops = stops.Insert(int.Parse(tokens[1]), tokens[2]);
            //            }
            //            Console.WriteLine(stops);
            //            break;
            //        case "Remove Stop":
            //            if (int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < stops.Length && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) <= stops.Length)
            //            {
            //                 count = int.Parse(tokens[2]) - int.Parse(tokens[1]) + 1;
            //                stops = stops.Remove(int.Parse(tokens[1]), count);
            //            }
            //            Console.WriteLine(stops);
            //            break;
            //        case "Switch":
            //            string[] sub = stops.Split(new string[] { "::" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //            if (sub[0] == tokens[1])
            //            {
            //                stops = stops.Replace(sub[0], tokens[2]);
            //                Console.WriteLine(stops);
            //            }
            //            break;
            //        default:
            //            break;
            //    }
            //    commands = Console.ReadLine();
            //}
            //Console.WriteLine($"Ready for world tour! Planned stops: {stops}");


            //Exam Preparation 27.07.2022 World Tour
            //string message = Console.ReadLine();
            //string commands = Console.ReadLine();
            //while (commands != "Reveal")
            //{
            //    string[] cmdTokens = commands.Split(new string[] { ":|:" }, StringSplitOptions.None).ToArray();
            //    switch (cmdTokens[0])
            //    {
            //        case "ChangeAll":
            //            {
            //                string substring = cmdTokens[1];
            //                string replacement = cmdTokens[2];
            //                message = message.Replace(substring, replacement);
            //                break;
            //            }
            //        case "Reverse":
            //            {
            //                string substring = cmdTokens[1];
            //                if (message.Contains(substring))
            //                {
            //                    int index = message.IndexOf(substring);
            //                    message = message.Remove(index, substring.Length);
            //                    message = message + string.Join("", substring.Reverse());
            //                }
            //                break;
            //            }
            //        case "InsertSpace":
            //            {
            //                int index = int.Parse(cmdTokens[1]);
            //                message = message.Insert(index, " ");
            //                break;
            //            }
            //    }
            //    Console.WriteLine(message);
            //    commands = Console.ReadLine();
            //}
            //Console.WriteLine("You have a new text message {message}");

            //zada4a Fancy Barcode
            //string barcodePattern = @"@#+[A-Z][a-zA-Z\d]{4,}[A-Z]@#+";
            //int numberOfBarcodesToReceives=int.Parse(Console.ReadLine());
            //for (int i = 0; i < numberOfBarcodesToReceives; i++)
            //{
            //    string currentBarcode=Console.ReadLine();
            //    if (Regex.IsMatch(currentBarcode,barcodePattern))
            //    {
            //        char[] digits=currentBarcode.Where(char.IsDigit).ToArray();
            //        string barcodeGroup = digits.Length==0 ? "00":string.Join("",digits);
            //        Console.WriteLine($"Product group: {barcodeGroup}");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid barcode");
            //    }
            //}


            ////zada4a 3 The Pianist
            //int numberOfLines = int.Parse(Console.ReadLine());
            //Dictionary<string, KeyValuePair<string, string>> music = new Dictionary<string, KeyValuePair<string, string>>();
            //List<string> order = new List<string>();
            //for (int i = 0; i < numberOfLines; i++)
            //{
            //    var peaceInfo = Console.ReadLine().Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    string piece = peaceInfo[0];
            //    string composer = peaceInfo[1];
            //    string key = peaceInfo[2];
            //    if (!music.ContainsKey(piece))
            //    {
            //        music.Add(piece, new KeyValuePair<string, string>(composer, key));
            //        order.Add(piece);//za da znaem kak 6te sa v podredba
            //    }
            //}
            //string play = Console.ReadLine();
            //while (play != "Stop")
            //{
            //    var commands = play.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    string peace = commands[1];
            //    switch (commands[0])
            //    {
            //        case "Add":
            //            {
            //                string composer = commands[2];
            //                string key = commands[3];
            //                if (!music.ContainsKey(peace))
            //                {
            //                    music.Add(peace, new KeyValuePair<string, string>(composer, key));
            //                    Console.WriteLine($"{peace} by {composer} in {key} added to the collection!");
            //                    order.Add(peace);
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"{peace} is already in the collection!");
            //                }
            //                break;
            //            }
            //        case "ChangeKey":
            //            {
            //                string newKey = commands[2];
            //                if (music.ContainsKey(peace))
            //                {
            //                    KeyValuePair<string, string> pieceData = music[peace];
            //                    string composer1 = pieceData.Key;
            //                    music[peace] = new KeyValuePair<string, string>(composer1, newKey);
            //                    Console.WriteLine($"Changed the key of {peace} to {newKey}!");
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"Invalid operation! {peace} does not exist in the collection.");
            //                }
            //                break;
            //            }
            //        case "Remove":
            //            {
            //                if (music.ContainsKey(peace))
            //                {
            //                    music.Remove(peace);
            //                    Console.WriteLine($"Successfully removed {peace}!");
            //                    order.Remove(peace);
            //                }
            //                else
            //                {
            //                    Console.WriteLine($"Invalid operation! {peace} does not exist in the collection.");
            //                }
            //                break;
            //            }
            //        default:
            //            break;
            //    }
            //    play = Console.ReadLine();
            //}
            //foreach (string piece in order)
            //{
            //    Console.WriteLine($"{piece} -> Composer: {music[piece].Key}, Key: {music[piece].Value}");
            //}

            ////zada4a 3 The Pianist re6ena s Dictionary vmesto sas KeyValuePair
            //int numberOfpieces = int.Parse(Console.ReadLine());
            //Dictionary<string, Dictionary<string, string>> pieces = new Dictionary<string, Dictionary<string, string>>();
            //List<string> piecesList = new List<string>();
            //for (int i = 0; i < numberOfpieces; i++)
            //{
            //    string[] pieceThemselv = Console.ReadLine().Split('|');
            //    string piece = pieceThemselv[0];
            //    string composer = pieceThemselv[1];
            //    string key = pieceThemselv[2];
            //    if (!pieces.ContainsKey(piece))
            //    {
            //        pieces.Add(piece, new Dictionary<string, string>());
            //        pieces[piece][composer] = key;
            //        piecesList.Add(piece);
            //    }

            //}
            //string comands = Console.ReadLine();
            //while (comands != "Stop")
            //{
            //    string[] separate = comands.Split('|');
            //    string piece = separate[1];
            //    switch (separate[0])
            //    {
            //        case "Add":
            //            if (!pieces.ContainsKey(piece))
            //            {
            //                pieces.Add(piece, new Dictionary<string, string>());
            //                pieces[piece][separate[2]] = separate[3];
            //                piecesList.Add(piece);
            //                Console.WriteLine($"{piece} by {separate[2]} in {separate[3]} added to the collection!");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{piece} is already in the collection!");
            //            }
            //            break;
            //        case "Remove":
            //            if (pieces.ContainsKey(piece))
            //            {
            //                pieces.Remove(piece);
            //                piecesList.Remove(piece);
            //                Console.WriteLine($"Successfully removed {piece}!");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            //            }
            //            break;
            //        case "ChangeKey":
            //            if (pieces.ContainsKey(piece))
            //            {
            //                string jk = "";
            //                string jk1 = "";
            //                Dictionary<string, string> pieces2 = pieces[piece];
            //                foreach (var samo in pieces2)
            //                {
            //                    jk = samo.Key;
            //                    jk1 = samo.Value;
            //                }
            //                pieces[piece][jk] = separate[2];
            //                Console.WriteLine($"Changed the key of {piece} to {separate[2]}!");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            //            }
            //            break;
            //        default:
            //            break;
            //    }
            //    comands = Console.ReadLine();
            //}
            //foreach (string pie in piecesList)
            //{
            //    string printKey = "";
            //    string printValue = "";
            //    Dictionary<string, string> piecesEnd = pieces[pie];
            //    foreach (var samo in piecesEnd)
            //    {
            //        printKey = samo.Key;
            //        printValue = samo.Value;
            //    }
            //    string sd = piecesEnd.Keys.ToString();
            //    Console.WriteLine($"{pie} -> Composer: {printKey}, Key: {printValue}");
            //}





            //Exam Preparation 29.07.2022
            //zada4a 1 Activation Keys
            //string input = Console.ReadLine();
            //while (true)
            //{
            //    string commands = Console.ReadLine();
            //    if (commands == "Generate")
            //    {
            //        break;
            //    }
            //    string[] tokens = commands.Split(new string[] { ">>>" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    string action = tokens[0];
            //    switch (action)
            //    {
            //        case "Contains":
            //            Contains(tokens[1], input);
            //            break;
            //        case "Flip":
            //            input = Flip(tokens[1], int.Parse(tokens[2]), int.Parse(tokens[3]), input);
            //            break;
            //        case "Slice":
            //            input = Slice(int.Parse(tokens[1]), int.Parse(tokens[2]), input);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine($"Your activation key is: {input}");


            //zada4a 2 – Emoji Detector
            //string text=Console.ReadLine();
            //string patternNumbers = @"\d";
            //string patternEmoji = @"(\*{2}|:{2})(?<emoji>[A-Z][a-z]{2,})\1";
            //MatchCollection emojiMatches=Regex.Matches(text, patternEmoji);
            //MatchCollection numberMatches=Regex.Matches(text, patternNumbers);

            //long treshold = 1;
            //foreach (Match number in numberMatches)
            //{
            //    treshold *= int.Parse(number.Value);
            //}
            //Console.WriteLine($"Cool threshold: {treshold}");
            //Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");         
            //foreach (Match emojimatch in emojiMatches)
            //{
            //    string emoji = emojimatch.Groups["emoji"].Value;
            //   long emojiTreshold= emoji.ToCharArray().Sum(c => c);
            //    if (emojiTreshold>=treshold)
            //    {
            //        Console.WriteLine(emojimatch.Value);
            //    }
            //}


            //zada4a 3 Heroes of Code and Logic VII
            //Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();
            //int count = int.Parse(Console.ReadLine());
            //for (int i = 0; i < count; i++)
            //{
            //    string[] heroesProperties = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    string name = heroesProperties[0];
            //    int hitPoints = int.Parse((string)heroesProperties[1]);
            //    int manaPoints = int.Parse((string)heroesProperties[2]);
            //    if (!heroes.ContainsKey(name))
            //    {
            //        heroes.Add(name, new List<int>());
            //    }
            //    heroes[name].Add(hitPoints);
            //    heroes[name].Add(manaPoints);
            //}
            //while (true)
            //{
            //    string command = Console.ReadLine();
            //    if (command == "End")
            //    {
            //        break;
            //    }
            //    string[] tokens = command.Split(new string[] { " - " }, StringSplitOptions.None).ToArray();
            //    string action = tokens[0];
            //    switch (action)
            //    {
            //        case "CastSpell":
            //            CastSpell(tokens[1], int.Parse(tokens[2]), tokens[3], heroes);
            //            break;
            //        case "TakeDamage":
            //            TakeDamage(tokens[1], int.Parse(tokens[2]), tokens[3], heroes);
            //            break;
            //        case "Recharge":
            //            Recharge(tokens[1], int.Parse(tokens[2]), heroes);
            //            break;
            //        case "Heal":
            //            Heal(tokens[1], int.Parse(tokens[2]), heroes);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //foreach (var hero in heroes)
            //{
            //    Console.WriteLine(hero.Key);
            //    Console.WriteLine($"  HP: {hero.Value[0]}");
            //    Console.WriteLine($"  MP: {hero.Value[1]}");
            //}

            //Dopalnitelna zada4a Need for Speed |||
            List<Car> cars = new List<Car>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] carProperties = Console.ReadLine().Split('|');
                Car car = new Car
                {
                    Brand = carProperties[0],
                    Mileage = int.Parse(carProperties[1]),
                    Fuel = int.Parse(carProperties[2]),
                };
                cars.Add(car);
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Stop")
                {
                    break;
                }
                string[] tokens = command.Split(':');
                string action = tokens[0];

                switch (action)
                {
                    case "Drive":
                        Drive(tokens[1], int.Parse(tokens[2]), int.Parse(tokens[3]), cars);
                        break;
                    case "Refuel":
                        Refuel(tokens[1], int.Parse(tokens[2]), cars);
                        break;
                    case "Revert":
                        Revert(tokens[1], int.Parse(tokens[2]), cars);
                        break;
                    default:
                        break;
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Brand} -> {car.Mileage} ");
            }















        }

        static void Drive(string brand, int distance, int fuel, List<Car> cars)
        {
            Car car = cars.First(c => c.Brand == brand);
            if (car.Fuel < fuel)
            {
                Console.WriteLine("Not enogh fuel to make that ride");
                return;
            }
            car.Mileage += distance;
            car.Fuel -= fuel;
            Console.WriteLine($"{brand} driven for {distance} kilometers");
            if (car.Mileage >= 100000)
            {
                cars.Remove(car);
                Console.WriteLine("");
            }
        }

        static void Refuel(string brand, int fuel, List<Car> cars)
        {
            Car car = cars.First(c => c.Brand == brand);
            int originalFuel = car.Fuel;
            car.Fuel = fuel;
            if (car.Fuel > 75)
            {
                car.Fuel = 75;
            }
            Console.WriteLine($"{brand} ");
        }

        static void Revert(string brand, int kilometers, List<Car> cars)
        {
            Car car = cars.First(c => c.Brand == brand);// namirame kolata
            car.Mileage = -kilometers;
            Console.WriteLine($"{brand} mileage decreased by {kilometers}");
            if (car.Mileage < 10000)
            {
                car.Mileage = 10000;
            }
        }

        //static void TakeDamage(string name, int damage, string attacker, Dictionary<string, List<int>> heroes)
        //{
        //    heroes[name][0] -= damage;
        //    if (heroes[name][0] > 0)
        //    {
        //        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name][0]} HP left!");
        //        return;
        //    }
        //    Console.WriteLine($"{name} has been killed by {attacker}!");
        //    heroes.Remove(name);
        //}

        //static void CastSpell(string name, int manaNeeded, string spell, Dictionary<string, List<int>> heroes)
        //{
        //    if (heroes[name][1] >= manaNeeded)
        //    {
        //        heroes[name][1] -= manaNeeded;
        //        Console.WriteLine($"{name} has successfully cast {spell} and now has {heroes[name][1]} MP!");
        //        return;
        //    }
        //    Console.WriteLine($"{name} does not have enough MP to cast {spell}!");
        //}

        //static void Recharge(string name, int mana, Dictionary<string, List<int>> heroes)
        //{
        //    int originalMana = heroes[name][1];
        //    heroes[name][1] += mana;
        //    if (heroes[name][1] > 200)
        //    {
        //        heroes[name][1] = 200;
        //    }
        //    Console.WriteLine($"{name} recharged for {heroes[name][1] - originalMana} MP!");
        //}
        //static void Heal(string name, int healPoints, Dictionary<string, List<int>> heroes)
        //{
        //    int originaHirpoints = heroes[name][0];
        //    heroes[name][0] += healPoints;
        //    if (heroes[name][0] > 100)
        //    {
        //        heroes[name][0] = 100;
        //    }
        //    Console.WriteLine($"{name} healed for {heroes[name][0] - originaHirpoints} HP!");
        //}



        //zada4a 1 Activation Keys
        //static string Slice(int startIndex, int endIndex, string input)
        //{
        //    input = input.Remove(startIndex, endIndex - startIndex);
        //    Console.WriteLine(input);
        //    return input;
        //}
        //static string Flip(string change, int startIndex, int endIndex, string input)
        //{
        //    string up = input.Substring(startIndex, endIndex - startIndex);
        //    if (change == "Upper")
        //    {
        //        string upp = up.ToUpper();
        //        input = input.Replace(up, upp);
        //    }
        //    else
        //    {
        //        string upp = up.ToLower();
        //        input = input.Replace(up, upp);
        //    }
        //    Console.WriteLine(input);
        //    return input;
        //}
        //private static void Contains(string substring, string input)
        //{
        //    if (input.Contains(substring))
        //    {
        //        Console.WriteLine($"{input} contains {substring}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Substring not found!");
        //    }
        //}
    }
    public class Car
    {
        public string Brand { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
