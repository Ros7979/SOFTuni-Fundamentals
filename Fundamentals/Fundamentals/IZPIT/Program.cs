using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace IZPIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zada4a 2 Problem 2 Message Translator
            //int n = int.Parse(Console.ReadLine());
            //string patern = @"!(?<da>[A-Z][a-z]{3,})!";
            //string patern1 = @"\[(?<tr>[A-z]{8,})\]";
            //List<int> ascII = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();
            //    Regex r = new Regex(patern);
            //    Regex r1 = new Regex(patern1);
            //    bool isValid = r.IsMatch(input);
            //    bool isValid1 = r1.IsMatch(input);
            //    if (isValid && isValid1)
            //    {
            //        Match gh = Regex.Match(input, patern);
            //        Match gh1 = Regex.Match(input, patern1);
            //        for (int z = 0; z < gh1.Groups["tr"].Value.Length; z++)
            //        {
            //            int askii = gh1.Groups["tr"].Value[z];
            //            ascII.Add(askii);
            //        }
            //        Console.WriteLine($"{gh.Groups["da"].Value}: {string.Join(" ", ascII)}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The message is invalid");
            //    }
            //}


            // zada4a 1 Problem 1 String Manipulator
            //string input = Console.ReadLine();
            //string comands = Console.ReadLine();
            //while (comands != "End")
            //{
            //    string[] tokens = comands.Split(' ').ToArray();/// ili (new string[] { ":|:" }, StringSplitOptions.None)
            //    string action = tokens[0];
            //    switch (action)
            //    {
            //        case "Translate":
            //            input = input.Replace(tokens[1], tokens[2]);
            //            Console.WriteLine(input);
            //            break;
            //        case "Includes":
            //            bool da = input.Contains(tokens[1]);
            //            if (da)
            //            {
            //                Console.WriteLine("True");
            //            }
            //            else
            //            {
            //                Console.WriteLine("False");
            //            }
            //            break;
            //        case "Start":
            //            string[] inpArr = input.Split(' ');
            //            if (inpArr[0] == tokens[1])
            //            {
            //                Console.WriteLine("True");
            //            }
            //            else
            //            {
            //                Console.WriteLine("False");
            //            }
            //            break;
            //        case "Lowercase":
            //            input = input.ToLower();
            //            Console.WriteLine(input);
            //            break;
            //        case "FindIndex":
            //            //    int coun=input.Count();
            //            int index = input.LastIndexOf(tokens[1]);
            //            Console.WriteLine(index);
            //            break;
            //        case "Remove":
            //            input = input.Remove(int.Parse(tokens[1]), int.Parse(tokens[2]));
            //            Console.WriteLine(input);
            //            break;
            //        default:
            //            break;
            //    }
            //    comands = Console.ReadLine();
            //}


            //zada4a 3 Problem 3 Hero Recruitment
            //Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            //while (true)
            //{
            //    string[] command = Console.ReadLine().Split(' ').ToArray();
            //    if (command[0] == "End")
            //    {
            //        break;
            //    }

            //    switch (command[0])
            //    {
            //        case "Enroll":
            //            if (!dic.ContainsKey(command[1]))
            //            {
            //                dic.Add(command[1], new List<string>());
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{command[1]} is already enrolled.");
            //            }
            //            break;
            //        case "Learn":
            //            if (dic.ContainsKey(command[1]))

            //            {
            //                if (dic[command[1]].Contains(command[2]))
            //                {
            //                    Console.WriteLine($"{command[1]} has already learnt {command[2]}.");
            //                    break;
            //                }
            //                dic[command[1]].Add(command[2]);
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{command[1]} doesn't exist.");
            //            }
            //            break;
            //        case "Unlearn":
            //            if (!dic.ContainsKey(command[1]))
            //            {
            //                Console.WriteLine($"{command[1]} doesn't exist.");
            //            }
            //            else
            //            {
            //                if (!dic[command[1]].Contains(command[2]))
            //                {
            //                    Console.WriteLine($"{command[1]} doesn't know {command[2]}.");
            //                }
            //                else
            //                {
            //                    dic[command[1]].Remove(command[2]);
            //                }
            //            }
            //            break;
            //        default:
            //            break;
            //    }

            //}
            //Console.WriteLine("Heroes:");
            //foreach (var item in dic)
            //{

            //    Console.WriteLine($"== {item.Key}: {string.Join(", ", item.Value)} ");
            //}







        }
    }
}
