using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Globalization;
using System.Threading.Tasks;
namespace testove
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            //    var commands = play.Split(new string[] {"|"},StringSplitOptions.RemoveEmptyEntries).ToArray();
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
            //                    Console.WriteLine($"Changed the key of {peace} to { newKey}!");
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


            int numberOfpieces = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, string>> pieces = new Dictionary<string, Dictionary<string, string>>();
            List<string> piecesList = new List<string>();
            for (int i = 0; i < numberOfpieces; i++)
            {
                string[] pieceThemselv = Console.ReadLine().Split('|');
                string piece = pieceThemselv[0];
                string composer = pieceThemselv[1];
                string key = pieceThemselv[2];
                if (!pieces.ContainsKey(piece))
                {
                    pieces.Add(piece, new Dictionary<string, string>());
                    pieces[piece][composer] = key;
                    piecesList.Add(piece);
                }

            }
            string comands = Console.ReadLine();
            while (comands != "Stop")
            {
                string[] separate = comands.Split('|');
                string piece = separate[1];
                switch (separate[0])
                {
                    case "Add":
                        if (!pieces.ContainsKey(piece))
                        {
                            pieces.Add(piece, new Dictionary<string, string>());
                            pieces[piece][separate[2]] = separate[3];
                            piecesList.Add(piece);
                            Console.WriteLine($"{piece} by {separate[2]} in {separate[3]} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        break;
                    case "Remove":
                        if (pieces.ContainsKey(piece))
                        {
                            pieces.Remove(piece);
                            piecesList.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        if (pieces.ContainsKey(piece))
                        {
                            string jk = "";
                            string jk1 = "";
                            Dictionary<string, string> pieces2 = pieces[piece];
                            foreach (var samo in pieces2)
                            {
                                 jk = samo.Key;
                                jk1 = samo.Value;
                            }                           
                            pieces[piece][jk] = separate[2];
                            Console.WriteLine($"Changed the key of {piece} to {separate[2]}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    default:
                        break;
                }
                comands = Console.ReadLine();
            }
            foreach (string pie in piecesList)
            {
                string printKey = "";
                string printValue = "";
                Dictionary<string, string> piecesEnd = pieces[pie];
                foreach (var samo in piecesEnd)
                {
                    printKey = samo.Key;
                    printValue = samo.Value;
                }
                string sd= piecesEnd.Keys.ToString();
                Console.WriteLine($"{pie} -> Composer: {printKey}, Key: {printValue}");
            }

        }
    }
}

//Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();
//int count = int.Parse(Console.ReadLine());
//for (int i = 0; i < count; i++)
//{
//    string[] heroesProperties = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
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
//    string[] tokens = command.Split(new string[] { " - " }, StringSplitOptions.None);
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


//int n = int.Parse(Console.ReadLine());
//Dictionary<string, Dictionary<int, int>> dic = new Dictionary<string, Dictionary<int, int>>();
//for (int i = 0; i < n; i++)
//{
//    string[] input = Console.ReadLine().Split(' ');
//    string key = input[0];
//    int valueKey = int.Parse(input[1]);
//    int value = int.Parse(input[2]);
//    if (!dic.ContainsKey(key))
//    {
//        dic.Add(key, new Dictionary<int, int>());
//    }
//    dic[key].Add(valueKey, value);//zadavat se stoinost pri dictionary
//}
//while (true)
//{
//    string[] commands = Console.ReadLine().Split(new string[] { " - " }, StringSplitOptions.None);
//    string action = commands[0];
//    if (action == "End")
//    {
//        break;
//    }
//    switch (action)
//    {
//        case "CastSpell":
//            Dictionary<int, int> dic2 = dic[commands[1]];
//            int num = 0;
//            int value = 0;
//            foreach (var item in dic2)
//            {
//                num = item.Key;
//                value = item.Value;
//            }
//            if (value >= int.Parse(commands[2]))
//            {
//                value -= int.Parse(commands[2]);
//                dic[commands[1]][num] = value;
//                Console.WriteLine($"{commands[1]} has successfully cast {commands[3]} and now has {value} MP!");
//            }
//            else
//            {
//                Console.WriteLine($"{commands[1]} does not have enough MP to cast {commands[3]}!");
//            }
//            break;
//        case "TakeDamage":
//            TakeDamageN(commands[1], int.Parse(commands[2]), commands[3], dic);
//            break;
//        case "Recharge":
//            Recharge(commands[1], int.Parse(commands[2]), dic);
//            break;
//        case "Heal":
//            Heal(commands[1], int.Parse(commands[2]), dic);
//            break;
//        default:
//            break;
//    }
//}
//foreach (var heroes in dic)
//{
//    string her = heroes.Key;
//    Dictionary<int, int> hero = dic[her];
//    Console.WriteLine(her);
//    foreach (var hpmp in heroes.Value)
//    {
//        Console.WriteLine($"  HP: {hpmp.Key}");
//        Console.WriteLine($"  MP: {hpmp.Value}");
//    }
//}

//static void Heal(string heroname, int amount, Dictionary<string, Dictionary<int, int>> dic)
//{
//    Dictionary<int, int> dic2 = dic[heroname];
//    int num = 0;
//    int value = 0;
//    int original = 0;
//    foreach (var item in dic2)
//    {
//        num = item.Key;
//        original = num;
//        value = item.Value;
//    }
//    num += amount;
//    if (num > 100)
//    {
//        num = 100;
//    }
//    dic.Remove(heroname);
//    dic.Add(heroname, new Dictionary<int, int>());
//    dic[heroname].Add(num, value);
//    Console.WriteLine($"{heroname} healed for {num - original} HP!");
//}

//static void Recharge(string heroname, int amount, Dictionary<string, Dictionary<int, int>> dic)
//{
//    Dictionary<int, int> dic2 = dic[heroname];
//    int num = 0;
//    int value = 0;
//    foreach (var item in dic2)
//    {
//        num = item.Key;
//        value = item.Value;
//    }
//    dic[heroname][num] += amount;
//    if (dic[heroname][num] > 200)
//    {
//        dic[heroname][num] = 200;
//    }
//    Console.WriteLine($"{heroname} recharged for {dic[heroname][num] - value} MP!");
//}

//static void TakeDamageN(string heroname, int damage, string attacker, Dictionary<string, Dictionary<int, int>> dic)
//{
//    Dictionary<int, int> dic2 = dic[heroname];
//    int num = 0;
//    int value = 0;
//    foreach (var item in dic2)
//    {
//        num = item.Key;
//        value = item.Value;
//    }
//    if (num > damage)
//    {
//        num -= damage;
//        dic.Remove(heroname);
//        dic.Add(heroname, new Dictionary<int, int>());
//        dic[heroname].Add(num, value);
//        Console.WriteLine($"{heroname} was hit for {damage} HP by {attacker} and now has {num} HP left!");
//        return;
//    }
//    Console.WriteLine($"{heroname} has been killed by {attacker}!");
//    dic.Remove(heroname);
//}

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










//izpit
//    using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
//            while (true)
//            {
//                string[] command = Console.ReadLine().Split(' ').ToArray();
//                if (command[0] == "End")
//                {
//                    break;
//                }

//                switch (command[0])
//                {
//                    case "Enroll":
//                        if (!dic.ContainsKey(command[1]))
//                        {
//                            dic.Add(command[1], new List<string>());
//                        }
//                        else
//                        {
//                            Console.WriteLine($"{command[1]} is already enrolled.");
//                        }
//                        break;
//                    case "Learn":
//                        if (dic.ContainsKey(command[1]))

//                        {
//                            if (dic[command[1]].Contains(command[2]))
//                            {
//                                Console.WriteLine($"{command[1]} has already learnt {command[2]}.");
//                                break;
//                            }
//                            dic[command[1]].Add(command[2]);
//                        }
//                        else
//                        {
//                            Console.WriteLine($"{command[1]} doesn't exist.");
//                        }
//                        break;
//                    case "Unlearn":
//                        if (!dic.ContainsKey(command[1]))
//                        {
//                            Console.WriteLine($"{command[1]} doesn't exist.");
//                        }
//                        else
//                        {
//                            if (!dic[command[1]].Contains(command[2]))
//                            {
//                                Console.WriteLine($"{command[1]} doesn't know {command[2]}.");
//                            }
//                            else
//                            {
//                                dic[command[1]].Remove(command[2]);
//                            }
//                        }
//                        break;
//                    default:
//                        break;
//                }

//            }
//            Console.WriteLine("Heroes:");
//            foreach (var item in dic)
//            {

//                Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)} ");
//            }



//        }


//    }
//}
