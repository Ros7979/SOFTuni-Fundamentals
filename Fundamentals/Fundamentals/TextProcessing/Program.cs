using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //upraznenia 13.07.2022
            //zada4a 1 Reverse Strings
            //string line = Console.ReadLine();
            //while (line != "end")
            //{
            //    string reversed = "";
            //    for (int i = line.Length - 1; i >= 0; i--)
            //    {
            //        reversed += line[i];
            //    }
            //    Console.WriteLine($"{line} = {reversed}");
            //    line = Console.ReadLine();
            //}

            //zada4a 2 Repeat Strings
            //string[] strings = Console.ReadLine().Split();
            //string results = string.Empty;
            //foreach (var str in strings)
            //{
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        results += str;
            //    }
            //}
            //Console.WriteLine(results);

            //zada4a 3 Substrings
            //string substringToRemove = Console.ReadLine();
            //string fullString = Console.ReadLine();
            //while (fullString.Contains(substringToRemove))
            //{
            //    int startIndex = fullString.IndexOf(substringToRemove);
            //    fullString = fullString.Remove(startIndex, substringToRemove.Length);
            //}
            //Console.WriteLine(fullString);

            //zada4a 4 Text Filter

            //string[] bannedWords=Console.ReadLine().Split(new string[] { ", "},StringSplitOptions.RemoveEmptyEntries);
            //string text=Console.ReadLine();
            //foreach (var bannedWord in bannedWords)
            //{
            //    string replacedWirhAsterisks = new string('*', bannedWord.Length);
            //    text = text.Replace(bannedWord, replacedWirhAsterisks);
            //}
            //Console.WriteLine(text);

            //zada4a 5
            //string input=Console.ReadLine();
            //StringBuilder digits=new StringBuilder();
            //StringBuilder letters=new StringBuilder();
            //StringBuilder others=new StringBuilder();
            //foreach (var ch in input)
            //{
            //    if (char.IsDigit(ch))
            //    {
            //        digits.Append(ch);
            //    }
            //   else if (char.IsLetter(ch))
            //    {
            //        letters.Append(ch);
            //    }
            //    else
            //    {
            //        others.Append(ch);
            //    }
            //}
            //Console.WriteLine(digits);
            //Console.WriteLine(letters);
            //Console.WriteLine(others);


            //zada4a dopalnitelna ot izpit Imitation game

            //string message = Console.ReadLine();
            //while (true)
            //{
            //    string command = Console.ReadLine();
            //    if (command == "Decode")
            //    {
            //        break;
            //    }
            //    string[] tokens = command.Split('|');
            //    string action = tokens[0];
            //    switch (action)
            //    {
            //        case "Move":
            //            int lenght = int.Parse(tokens[1]);
            //            string stringToMove = message.Substring(0, lenght);
            //            message = message.Remove(0, lenght);
            //            message += stringToMove;
            //            break;
            //        case "Insert":
            //            int index=int.Parse(tokens[1]);
            //            string value=tokens[2];
            //            message= message.Insert(index, value);
            //            break;
            //        case "ChangeAll":
            //            string substring=tokens[1];
            //            string replacement=tokens[2];
            //            message = message.Replace(substring, replacement);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine($"The decripted message {message}");


            //zada4a dopalnitelna World Tour

            //string stops=Console.ReadLine();
            //while (true)
            //{
            //    string command = Console.ReadLine();
            //    if (command=="")
            //    {
            //        break;
            //    }
            //    string[] tokens=command.Split(':');
            //    string action=tokens[0];
            //    switch (action)
            //    {
            //        case "Add Stop":
            //            int index=int.Parse(tokens[1]);
            //            string newStop=tokens[2];
            //            if (index>=0 && index<stops.Length)
            //            {
            //                stops = stops.Insert(index, newStop);
            //            }
            //            break;
            //        case "Remove Stop":
            //            int startIndex=int.Parse(tokens[1]);
            //            int endIndex=int.Parse(tokens[2]);
            //            if (startIndex >= 0 && startIndex < stops.Length && endIndex >= 0 && endIndex < stops.Length)
            //            {
            //                stops = stops.Remove(startIndex, endIndex-startIndex+1);
            //            }
            //            break;
            //        case "Switch":
            //            string oldString=tokens[1];
            //            string newString = tokens[2];
            //            if (stops.Contains(oldString))
            //            {
            //                stops = stops.Replace(oldString,newString);
            //            }
            //            break;
            //        default:
            //            break;
            //    }
            //    Console.WriteLine(stops);
            //}
            //Console.WriteLine(stops);


            //Ypraznenia 15.07.2022 
            //zada4a 1
            //string[] input=Console.ReadLine().Split(new string[] {", "},StringSplitOptions.RemoveEmptyEntries);
            //List<string> validUsernames=new List<string>();
            //foreach (var username in input)
            //{
            //    if (username.Length>=3 && username.Length<=16)
            //    {
            //        bool isValid=true;
            //        for (int i = 0; i < username.Length; i++)
            //        {
            //            char currentChar=username[i];
            //            if (!(currentChar=='-' || currentChar=='_'||char.IsDigit(currentChar)|| char.IsLetter(currentChar)))
            //            {
            //                isValid=false;
            //                break;
            //            }
            //        }
            //        if (isValid)
            //        {
            //            validUsernames.Add(username);
            //        }
            //    }              
            //}
            //Console.WriteLine(string.Join(Environment.NewLine,validUsernames));

            //zada4a 2 Character Multiplier
            //string[] input=Console.ReadLine().Split(' ');
            //Console.WriteLine(CharMultiplayer(input[0], input[1]));

            //zada4a 3 Extract File
            //string[] fileName = Console.ReadLine().Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //int cn = fileName.Count();
            //string fileDir = fileName[fileName.Count() - 1];
            //string[] last = fileDir.Split('.').ToArray();
            //Console.WriteLine($"File name: {last[0]}");
            //Console.WriteLine($"File extension: {last[1]}");

            //zada4a 4 Caeser Cipher
            //string message=Console.ReadLine();
            //StringBuilder sb=new StringBuilder();
            //for (int i = 0; i < message.Length; i++)
            //{
            //    char encryptedChar=(char)(message[i]+3);
            //    sb.Append(encryptedChar);
            //}
            //Console.WriteLine(sb);

            //zada4a 5 Multiply Big Number
            //string reallyBigNum = Console.ReadLine();
            //int num = int.Parse(Console.ReadLine());
            //if (num == 0)
            //{
            //    Console.WriteLine(0);
            //    return;
            //}
            //StringBuilder sb = new StringBuilder();
            //int remainder = 0;
            //for (int i = reallyBigNum.Length-1; i >= 0; i--)
            //{
            //    char lastNum = reallyBigNum[i];
            //    int lastNumAsDigit = int.Parse(lastNum.ToString());
            //    int result = lastNumAsDigit * num+remainder;
            //    sb.Append(result%10);
            //    remainder = result / 10;
            //}
            //if (remainder!=0)
            //{
            //    sb.Append(remainder);
            //}
            //StringBuilder reversedString=new StringBuilder();
            //for (int i = sb.Length-1; i >=0; i--)
            //{
            //    reversedString.Append(sb[i]);
            //}
            //Console.WriteLine(reversedString);

            //zada4a 6 Replace Repeating Chars
            //string str = Console.ReadLine();
            //string newData = "";
            //for (int i = 0; i < str.Length - 1; i++)
            //{
            //    if (str[i] == str[i + 1])
            //    {
            //        newData = str.Remove(i, 1);
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //    str = newData;
            //    i--;
            //}
            //Console.WriteLine(str);

            //zada4a 7 String Explosion
            //string input = Console.ReadLine();
            //StringBuilder sb = new StringBuilder();
            //int power = 0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    char current = input[i];
            //    if (current=='>')
            //    {
            //         power+=int.Parse(input[i+1].ToString());
            //        sb.Append(current);
            //    }
            //    else if (power==0)
            //    {
            //        sb.Append(current);
            //    }
            //    else
            //    {
            //        power--;
            //    }
            //}
            //Console.WriteLine(sb);

            //zada4a 8 Letters Change Numbers
            //string[] input=Console.ReadLine().Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries);
            //double sum = 0;
            //foreach (var item in input)
            //{
            //    char firstLetter=item[0];
            //    char lastLetter=item[item.Length-1];
            //    double number=double.Parse(item.Substring(1,item.Length-2));
            //    double result = 0;                 
            //    if (firstLetter>=65 && firstLetter<=90)//proverka za glavna ili malka bukvi
            //    {
            //        int firstLetterPositionInTheAlphabet = firstLetter - 64;
            //        result =  number / firstLetterPositionInTheAlphabet;
            //    }
            //    else
            //    {
            //        int firstLetterPositionInTheAlphabet = firstLetter - 96;
            //        result = number * firstLetterPositionInTheAlphabet;
            //    }
            //    if (lastLetter >= 65 && lastLetter <= 90)//proverka za glavna ili malka bukvi
            //    {
            //    int lastLetterPositionInTheAlphabet = lastLetter - 64;
            //        sum+= result-lastLetterPositionInTheAlphabet;
            //    }
            //    else
            //    {
            //        int lastLetterPositionInTheAlphabet = lastLetter - 96;
            //        sum += result + lastLetterPositionInTheAlphabet;
            //    }
            //}
            //Console.WriteLine($"{sum:f2}");


            //More exercises
            //zada4a 1 Extract Person Information
            //int numberOfLines = int.Parse(Console.ReadLine());
            //for (int i = 0; i < numberOfLines; i++)
            //{
            //    string searchNameAge = Console.ReadLine();
            //    int age = searchNameAge.IndexOf('#');
            //    int age1 = searchNameAge.IndexOf('*');
            //    int Name = searchNameAge.IndexOf('@');
            //    int Name1 = searchNameAge.IndexOf('|');
            //    string readName = searchNameAge.Substring(Name + 1, Name1 - Name - 1);
            //    string readAge = searchNameAge.Substring(age + 1, age1 - age - 1);
            //    Console.WriteLine($"{readName} is {readAge} years old.");
            //}

            //zada4a 2 Ascii Sumator
            //char ch1 = char.Parse(Console.ReadLine());
            //char ch2 = char.Parse(Console.ReadLine());
            //string randomString = Console.ReadLine();
            //Console.WriteLine(SumAsciiNumbers(ch1, ch2, randomString));








        }
        //public static int CharMultiplayer(string str1,string str2)
        //{
        //    int sum = 0;
        //    string longest = "";
        //    string shortest = "";
        //    if (str1.Length>str2.Length)
        //    {
        //        longest = str1;
        //        shortest=str2;
        //    }
        //    else
        //    {
        //        longest = str2;
        //        shortest = str1;
        //    }
        //    for (int i = 0; i < shortest.Length; i++)
        //    {
        //        sum += str1[i] * str2[i];
        //    }
        //    for (int i = shortest.Length; i < longest.Length; i++)
        //    {
        //        sum += longest[i];
        //    }
        //    return sum;
        //}

        //zada4a 2 More Exersices
        //private static int SumAsciiNumbers(char v1, char v2, string randomNumber)
        //{
        //    int sum = 0;
        //    int asciiChar1 = v1;
        //    int asciiChar2 = v2;
        //    for (int i = 0; i < randomNumber.Length; i++)
        //    {
        //        int asciiNumber = randomNumber[i];
        //        if (asciiNumber > asciiChar1 && asciiNumber < asciiChar2)
        //        {
        //            sum += asciiNumber;
        //        }
        //    }
        //    return sum;
        //}
    }
}
