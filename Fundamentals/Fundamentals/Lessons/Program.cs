using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace Lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////zada4a 1 student information
            //string name = Console.ReadLine();
            //int age =int.Parse(Console.ReadLine());
            //double grade =double.Parse(Console.ReadLine());
            //Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");

            ////zada4a 2
            //double grade = double.Parse(Console.ReadLine());
            //if (grade >= 3.00)
            //{
            //    Console.WriteLine("Passed!");
            //}

            ////zada4a 3
            //double grade = double.Parse(Console.ReadLine());
            //if (grade >= 3.00)
            //{
            //    Console.WriteLine("Passed!");
            //}
            //else
            //{
            //    Console.WriteLine("Failed!");
            //}

            //zada4a 4
            //int hours=int.Parse(Console.ReadLine());
            //int minutes=int.Parse(Console.ReadLine());
            //minutes += 30;
            //if (minutes>=60)
            //{
            //    minutes -= 60;
            //    hours++;
            //}
            //if (hours==24)
            //{
            //    hours = 0;
            //}
            //Console.WriteLine($"{hours}:{minutes:d2}");

            ////zada4a 5
            //int month=int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("June");
            //        break;
            //    case 7:
            //        Console.WriteLine("July");
            //        break;
            //    case 8:
            //        Console.WriteLine("August");
            //        break;
            //    case 9:
            //        Console.WriteLine("September");
            //        break;
            //    case 10:
            //        Console.WriteLine("October");
            //        break;
            //    case 11:
            //        Console.WriteLine("November");
            //        break;
            //    case 12:
            //        Console.WriteLine("December");
            //        break;
            //    default:
            //        break;
            //}


            ////zada4a 6
            //string country=Console.ReadLine();
            //switch (country)
            //{
            //    case "England":
            //    case "USA":
            //        Console.WriteLine("English");
            //        break;
            //    case "Spain":
            //    case "Argentina":
            //    case "Mexico":
            //        Console.WriteLine("Spanish");
            //        break;

            //    default:
            //        Console.WriteLine("unknown");
            //        break;
            //}

            ////zada4a 7 Promotions
            //string dayOfweek = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //if (dayOfweek == "Weekday")
            //{
            //    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
            //    {
            //        Console.WriteLine("12$");
            //    }
            //    else if (age > 18 && age <= 64)
            //    {
            //        Console.WriteLine("18$");
            //    }
            //}
            //if (dayOfweek == "Weekend")
            //{
            //    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
            //    {
            //        Console.WriteLine("15$");
            //    }
            //    else if (age > 18 && age <= 64)
            //    {
            //        Console.WriteLine("20$");
            //    }
            //}
            //if (dayOfweek == "Holiday")
            //{
            //    if (age >= 0 && age <= 18)
            //    {
            //        Console.WriteLine("5$");
            //    }
            //    else if (age > 18 && age <= 64)
            //    {
            //        Console.WriteLine("12$");
            //    }
            //    else if (age > 64 && age <= 122)
            //    {
            //        Console.WriteLine("10$");
            //    }
            //}
            //if (age < 0 || age > 122)
            //{
            //    Console.WriteLine("Error!");
            //}

            ////zada4a 8
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////zada4a 9
            //int count=int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i < count; i++)
            //{
            //    int current = 1+(i*2);
            //    Console.WriteLine(current);
            //    sum += current;
            //}
            //Console.WriteLine($"Sum: {sum}");

            ////zada4a 10 Table
            //int integer = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{integer} X {i} = {integer * i}");
            //}

            ////zada4a 11 Table 2
            //int integer = int.Parse(Console.ReadLine());
            //int times = int.Parse(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine($"{integer} X {times}");
            //    times++;
            //}
            //while (times <= 10);

            ////zada4a 13

            //var startDate = DateTime.ParseExact(Console.ReadLine(),

            //"d.M.yyyy", CultureInfo.InvariantCulture);

            //var endDate = DateTime.ParseExact(Console.ReadLine(),

            //"d.M.yyyy", CultureInfo.InvariantCulture);

            //var holidaysCount = 0;

            //for (var date = startDate; date <= endDate; date = date.AddDays(1))
            //{

            //    if (date.DayOfWeek == DayOfWeek.Saturday ||

            //    date.DayOfWeek == DayOfWeek.Sunday)
            //    {
            //        holidaysCount++;
            //    }
            //}

            //Console.WriteLine(holidaysCount);

            ////zada4a 12
            //while (true)
            //{
            //    int number = int.Parse(Console.ReadLine());

            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine($"The number is: {Math.Abs(number)}");
            //        return;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please write an even number.");
            //    }
            //}

            //YPRAZNENIE 20.05.2022

            //zada4a 1
            //int age = int.Parse(Console.ReadLine());
            //if (age<=2)
            //{
            //    Console.WriteLine("baby");
            //}
            //else if (age>2 && age<=13)
            //{
            //    Console.WriteLine("child");
            //}
            //else if (age>13 && age<=19)
            //{
            //    Console.WriteLine("teenager");
            //}
            //else if (age>19 && age<=65)
            //{
            //    Console.WriteLine("adult");
            //}
            //else
            //{
            //    Console.WriteLine("elder");
            //}

            //zada4a 2 Division
            //int number = int.Parse(Console.ReadLine());
            //if (number % 10 == 0)
            //{
            //    Console.WriteLine("The number is divisible by 10");
            //}
            //else if (number % 7 == 0)
            //{
            //    Console.WriteLine("The number is divisible by 7");
            //}
            //else if (number % 6 == 0)
            //{
            //    Console.WriteLine("The number is divisible by 6");
            //}
            //else if (number % 3 == 0)
            //{
            //    Console.WriteLine("The number is divisible by 3");
            //}
            //else if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is divisible by 2");
            //}
            //else 
            //{
            //    Console.WriteLine("Not divisible");
            //}



            //zada4a 3
            //int peopleCount = int.Parse(Console.ReadLine());
            //string groupType = Console.ReadLine();
            //string day = Console.ReadLine();
            //double totalPrice = 0;
            //if (groupType == "Students")
            //{
            //    if (day == "Friday")
            //    {
            //        totalPrice = peopleCount * 8.45;
            //    }
            //    else if (day == "Saturday")
            //    {
            //        totalPrice = peopleCount * 9.80;
            //    }
            //    else if (day == "Sunday")
            //    {
            //        totalPrice = peopleCount * 10.46;
            //    }
            //    if (peopleCount >= 30)
            //    {
            //        totalPrice -= totalPrice * 0.15;
            //    }
            //}
            //else if (groupType == "Business")
            //{
            //    if (day == "Friday")
            //    {
            //        totalPrice = peopleCount * 10.90;
            //    }
            //    else if (day == "Saturday")
            //    {
            //        totalPrice = peopleCount * 15.60;
            //    }
            //    else if (day == "Sunday")
            //    {
            //        totalPrice = peopleCount * 16;
            //    }
            //    if (peopleCount >= 100)
            //    {
            //        totalPrice -= totalPrice / peopleCount * 10;
            //    }
            //}
            //else if (groupType == "Regular")
            //{
            //    if (day == "Friday")
            //    {
            //        totalPrice = peopleCount * 15;
            //    }
            //    else if (day == "Saturday")
            //    {
            //        totalPrice = peopleCount * 20;
            //    }
            //    else if (day == "Sunday")
            //    {
            //        totalPrice = peopleCount * 22.50;
            //    }
            //    if (peopleCount >= 10 && peopleCount <= 20)
            //    {
            //        totalPrice -= totalPrice * 0.05;
            //    }
            //}
            //Console.WriteLine($"Total price: {totalPrice:f2}");

            //zada4a 4
            //int startNum = int.Parse(Console.ReadLine());
            //int endNum = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = startNum; i <= endNum; i++)
            //{
            //    Console.Write($"{i} ");
            //    sum += i;
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Sum: {sum}");

            //zada4a 5
            //string username = Console.ReadLine();
            //string password = "";
            //for (int i = username.Length - 1; i >= 0; i--)
            //{
            //    password += username[i];
            //}
            //int countOfWrongPasswords = 0;
            //string inputPassword = Console.ReadLine();
            //while (inputPassword != password)
            //{
            //    countOfWrongPasswords++;
            //    if (countOfWrongPasswords > 3)
            //    {
            //        Console.WriteLine($"User {username} blocked!");
            //        return;
            //    }
            //    Console.WriteLine($"Incorrect password. Try again.");
            //    inputPassword = Console.ReadLine();
            //}
            //if (inputPassword == password)
            //{
            //    Console.WriteLine($"User {username} logged in.");
            //}

            //zada4a 6
            //int number=int.Parse(Console.ReadLine());
            //int numberCopy = number;
            //int sum = 0;
            //while (number>0)
            //{
            //    int factorialNumber = 1;
            //    int currNumber = number % 10;
            //    number /= 10;
            //    for (int i = 2; i <= currNumber; i++)
            //    {
            //        factorialNumber *= i;
            //    }
            //    sum+=factorialNumber;
            //}
            //Console.WriteLine(sum==numberCopy?"Yes":"No");

            //zada4a 7
            //string command = Console.ReadLine();
            //double totalMoneyACC = 0;
            //while (command != "Start")
            //{
            //    double inputMoney = double.Parse(command);
            //    if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney == 0.5 ||
            //        inputMoney == 1 || inputMoney == 2)
            //    {
            //        totalMoneyACC += inputMoney;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Cannot accept {inputMoney}");
            //    }
            //command=Console.ReadLine();
            //}
            //command = Console.ReadLine();
            //double totalPrice = 0;
            //while (command!="End")
            //{
            //    switch (command)
            //    {
            //        case "Nuts":
            //            totalPrice = 2;
            //            break;
            //        case "Water":
            //            totalPrice = 0.7;
            //            break;
            //        case "Crisps":
            //            totalPrice = 1.5;
            //            break;
            //        case "Soda":
            //            totalPrice = 0.8;
            //            break;
            //        case "Coke":
            //            totalPrice = 1;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid product");
            //            command = Console.ReadLine();
            //            continue;
            //    }
            //    if (totalMoneyACC>=totalPrice)
            //    {
            //        totalMoneyACC -= totalPrice;
            //        Console.WriteLine($"Purchased {command.ToLower()}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, not enough money");
            //    }
            //    command = Console.ReadLine();
            //}
            //Console.WriteLine(($"Change: {totalMoneyACC:f2}"));
            //zada4a 9
            //double budget=double.Parse(Console.ReadLine()); 
            //int studentsCount=int.Parse(Console.ReadLine());
            //double priceOfSaber=double.Parse(Console.ReadLine());
            //double priceOfRobes=double.Parse(Console.ReadLine());
            //double priceOfBelts=double.Parse(Console.ReadLine());
            //double totalNumbersOfSabers = Math.Ceiling(studentsCount * 1.10);
            //double NumberOfFreeBelts = Math.Floor(studentsCount / 6.0);
            //double finalPriceForSabers = totalNumbersOfSabers * priceOfSaber;
            //double finalForRobes = studentsCount * priceOfRobes;
            //double finalPriceForBelts = (studentsCount-NumberOfFreeBelts)*priceOfBelts;

            //double totalFinalPrice = finalPriceForSabers + finalForRobes + finalPriceForBelts;
            //if (budget>=totalFinalPrice)
            //{
            //    Console.WriteLine($"The money is enough - it would cost {totalFinalPrice:f2}lv.");
            //}
            //else
            //{
            //    Console.WriteLine($"John will need {Math.Abs(totalFinalPrice-budget):f2}lv more.");
            //}

            //zada4a 8
            //int number=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = 1; j <=i ; j++)
            //    {
            //    Console.Write($"{i} ");
            //    }
            //Console.WriteLine();
            //}

            //zada4a 10
            //int lostGamesCount = int.Parse(Console.ReadLine());
            //double hesdsetPrice = double.Parse(Console.ReadLine());
            //double mousePrice = double.Parse(Console.ReadLine());
            //double keyboardPrice = double.Parse(Console.ReadLine());
            //double displayPrice = double.Parse(Console.ReadLine());
            //int trashedHeadset = 0;
            //int trashedMouse = 0;
            //int trashedKeyboard = 0;
            //int trashedKeyboard2 = 0;
            //int trashedDisplay = 0;
            //for (int i = 2; i < lostGamesCount; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        trashedHeadset++;
            //    }
            //    if (i % 3 == 0)
            //    {
            //        trashedMouse++;
            //    }
            //    if (i % 2 == 0 || i % 3 == 0)
            //    {
            //        trashedKeyboard++;
            //        trashedKeyboard2++;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //    if (trashedKeyboard2 % 2 == 0 && trashedKeyboard2 != 0)
            //    {
            //        trashedDisplay++;
            //    }
            //    if (trashedKeyboard2 == 2)
            //    {
            //        trashedKeyboard2 = 0;
            //    }
            //}
            //Console.WriteLine($"Rage expenses: {(trashedHeadset * hesdsetPrice + trashedMouse * mousePrice + trashedKeyboard * keyboardPrice + trashedDisplay * displayPrice):f2} lv.");

            //zada4a 11
            //int orders = int.Parse(Console.ReadLine());
            //double price = 0;
            //double totalPrice = 0;
            //for (int i = 1; i <= orders; i++)
            //{
            //    double pricePerCapsule = double.Parse(Console.ReadLine());
            //    int days = int.Parse(Console.ReadLine());
            //    int capsulesCount = int.Parse(Console.ReadLine());
            //    price = (days * 1.0 * capsulesCount * 1.0) * pricePerCapsule;
            //    Console.WriteLine($"The price for the coffee is: ${(price):f2}");
            //    totalPrice += price;
            //}
            //Console.WriteLine($"Total: ${totalPrice:f2}");

            /////////////////////// LEKCIA 25.05.2022
            //zada4a 1
            //int meters=int.Parse(Console.ReadLine());
            //double kilometers = meters / 1000.0;//1000d
            //Console.WriteLine($"{kilometers:f2}");

            //zada4a 2
            //double pounds = double.Parse(Console.ReadLine());
            //double poundToUsd = 1.31;
            //double result = pounds * poundToUsd;
            //Console.WriteLine($"{result:f3}");

            //zada4a 3
            //int count = int.Parse(Console.ReadLine());
            //decimal sum = 0;
            //for (int i = 0; i <count; i++)
            //{
            //    decimal number=decimal.Parse(Console.ReadLine());
            //    sum += number;
            //}
            //Console.WriteLine(sum);

            //zada4a 4
            //int centuries = int.Parse(Console.ReadLine());
            //int years = centuries*100;
            //int days = (int)(years * 365.2422);
            //long hours = days * 24;
            //long minutes = hours * 60;
            //Console.WriteLine();//dase dovar6i

            //zada4a 5
            //int count = int.Parse(Console.ReadLine());
            //for (int i = 0; i <=count; i++)
            //{
            //    int sum = 0;
            //    int currentNum = i;
            //    while (currentNum!=0)
            //    {
            //        sum += currentNum % 10;
            //        currentNum /= 10;
            //        //124
            //        //124%10=4
            //        //124/10=12
            //        //sum=4

            //        //12%10=2
            //        //12/10=1
            //        //sum=4+2

            //        //1%10=1
            //        //1/10=0
            //        //sum=4+2+1
            //    }
            //    if (sum==5 || sum==7||sum==11)
            //    {
            //        Console.WriteLine($"{i} -> True");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i} -> False");
            //    }
            //}

            //zada4a 6
            //char first=char.Parse(Console.ReadLine());
            //char secind=char.Parse(Console.ReadLine());
            //char third=char.Parse(Console.ReadLine());
            //Console.WriteLine($"{third} {secind} {first}");

            //zada4a 10
            //char ch = char.Parse(Console.ReadLine());
            //if (char.IsUpper(ch))
            //{
            //    Console.WriteLine("upper-case");
            //}
            //else
            //{
            //    Console.WriteLine("lower-case");
            //}

            //zada4a 11
            //ot lekciata

            //Ypraznenia 27.05.2022
            //zada4a 1
            //int firstNumber=int.Parse(Console.ReadLine());
            //int seconNumber=int.Parse(Console.ReadLine());
            //int divideNumber=int.Parse(Console.ReadLine());
            //int multiplayNumber=int.Parse(Console.ReadLine());
            //int sumNums = firstNumber + seconNumber;
            //int division = sumNums / divideNumber;
            //int multiplayResult = division * multiplayNumber;
            //Console.WriteLine(multiplayResult);

            //zada4a 2
            //  //first try to solve the problem
            //int firstNumber = int.Parse(Console.ReadLine());
            //int finalSum = 0;
            //while (firstNumber!=0)
            //{
            //    int lastDigit = firstNumber % 10;
            //    finalSum += lastDigit;
            //    firstNumber /= 10;
            //}
            //Console.WriteLine(finalSum);
            // //second try to solve the problem
            //string input=Console.ReadLine();
            //char[] charArray=input.ToCharArray();
            //int finalSum = 0;
            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    finalSum += int.Parse(charArray[i].ToString());
            //}
            //    Console.WriteLine(finalSum);

            // //third try to solve the problem
            //string input = Console.ReadLine();            
            //int finalSum = 0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    finalSum += int.Parse(i.ToString());
            //}
            //Console.WriteLine(finalSum);

            //zada4a 3
            //int persons = int.Parse(Console.ReadLine());
            //int capacity = int.Parse(Console.ReadLine());
            //double withRemindeCources=(double)persons/capacity;
            //Console.WriteLine(Math.Ceiling(withRemindeCources));

            //zada4a 4
            //int n = int.Parse(Console.ReadLine());
            //int finalSum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    char digit = char.Parse(Console.ReadLine());
            //    finalSum+=(int)digit;
            //    //Console.WriteLine((int)digit);
            //}
            //Console.WriteLine($"The sum equals: {finalSum}");

            //zada4a 5
            //int startChar = int.Parse(Console.ReadLine());
            //int endChar = int.Parse(Console.ReadLine());
            //for (int i = startChar; i <= endChar; i++)
            //{
            //    Console.Write($"{(char)i} ");
            //}

            //zada4a 1 more Exercise
            //string input = Console.ReadLine();
            //int valueInt = 0;
            //float valueFloat = 0.0f;
            //char valueChar;
            //bool valueBool;
            //while (input!="END")
            //{
            //    if (int.TryParse(input, out valueInt))
            //    {
            //        Console.WriteLine($"{input} is integer type");
            //    }
            //    else if (float.TryParse(input, out valueFloat))
            //    {
            //        Console.WriteLine($"{input} is floating point type");
            //    }
            //    else if (char.TryParse(input, out valueChar))
            //    {
            //        Console.WriteLine($"{input} is character type");
            //    }
            //    else if (bool.TryParse(input, out valueBool))
            //    {
            //        Console.WriteLine($"{input} is boolean type");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{input} is string type");
            //    }
            //    input = Console.ReadLine();
            //}

            //zada4a 2 more Exercise Ne e 100% viarna
            //int lines = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= lines; i++)
            //{
            //    int sumLeft = 0;
            //    int sumRight = 0;
            //    string[] input = Console.ReadLine().Split().ToArray();
            //    string str1 = input[0];
            //    string str2 = input[1];
            //    Double inputFirst = Math.Round(Double.Parse(input[0]));
            //    Double inputSecond = Math.Round(Double.Parse(input[1]));
            //    if (inputFirst >= inputSecond)
            //    {
            //        for (int p = 0; p < str1.Length; p++)
            //        {
            //            if (str1[p] == '.')
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                sumLeft += Convert.ToInt32(new string(str1[p], 1));
            //            }
            //        }
            //        Console.WriteLine(sumLeft);
            //    }
            //    else
            //    {
            //        for (int e = 0; e < str2.Length; e++)
            //        {
            //            if (str2[e] == '.')
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                sumRight += Convert.ToInt32(new string(str2[e], 1));
            //            }
            //        }
            //        Console.WriteLine(sumRight);
            //    }
            //}

            //zada4a 3 more Exercise
            //double first = double.Parse(Console.ReadLine());
            //double second = double.Parse(Console.ReadLine());
            //double third = Math.Abs(first - second);
            //if (third <= 0.000001)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            //zada4a 4 more Exercise
            //int numDoControl = int.Parse(Console.ReadLine());
            //for (int num = 2; num <= numDoControl; num++)
            //{
            //    bool isThatTrue = true;
            //    for (int check = 2; check < num; check++)
            //    {
            //        if (num % check == 0)
            //        {
            //            isThatTrue = false;
            //            break;
            //        }
            //    }
            //    string lover = isThatTrue.ToString().ToLower();
            //    Console.WriteLine($"{num} -> {lover}");

            //zada4a 6 more Exercise
            //int lines = int.Parse(Console.ReadLine());
            //int checkOpen = 0;
            //int checkClose = 0;
            //bool checkTwo = false;
            //int twoConsec = 0;
            //for (int i = 0; i < lines; i++)
            //{
            //    string line = Console.ReadLine();
            //    for (int k = 0; k < line.Length; k++)
            //    {
            //        if (line[k] == '(')
            //        {
            //            checkOpen++;
            //            twoConsec++;
            //        }
            //        else if (line[k] == ')')
            //        {
            //            checkClose++;
            //            twoConsec = 0;
            //        }
            //        if (twoConsec == 2)
            //        {
            //            checkTwo = true;
            //        }
            //    }
            //}
            //bool checkOpenClose = false;
            //if (Math.Abs(checkOpen - checkClose) == 0)
            //{
            //    checkOpenClose = true;
            //}
            //if (checkOpenClose == false || checkTwo)
            //{
            //    Console.WriteLine("UNBALANCED");
            //}
            //else
            //{
            //    Console.WriteLine("BALANCED");
            //}


            //zada4a 7
            //const int CAPACITY = 255;
            //int nLines=int.Parse(Console.ReadLine());
            //int totalQuality = CAPACITY;
            //for (int i = 0; i < nLines; i++)
            //{
            //    int currQuantity= int.Parse(Console.ReadLine());
            //    if (totalQuality-currQuantity>=0)
            //    {
            //        totalQuality -= currQuantity;

            //    }
            //    else
            //    {
            //        Console.WriteLine("Insufficient capacity!");
            //    }
            //}
            //int totalFieldQuantity = CAPACITY - totalQuality;
            //Console.WriteLine(totalFieldQuantity);

            //zada4a 8
            //int nLines = int.Parse(Console.ReadLine());
            //double biggestKeg = double.MinValue;
            //string biggestKegName = "";
            //for (int i = 0; i < nLines; i++)
            //{
            //    string model = Console.ReadLine();
            //    float radius = float.Parse(Console.ReadLine());
            //    int hight = int.Parse(Console.ReadLine());
            //    double volumeOfTheCurrentKeg = Math.PI * Math.Pow(radius, 2) * hight;

            //    if (volumeOfTheCurrentKeg > biggestKeg)
            //    {
            //        biggestKeg = volumeOfTheCurrentKeg;
            //        biggestKegName = model;
            //    }
            //}
            //Console.WriteLine(biggestKegName);

            //zada4a 9
            //const int CONSUMED_BY_WORKERS = 26;
            //const int MINIMUM_SPICES = 100;
            //const int DAILY_DECREES = 10;
            //int countOfSpices=int.Parse(Console.ReadLine());
            //int totalConsumed = 0;
            //int daysCounted = 0;
            //while (countOfSpices>=MINIMUM_SPICES)
            //{
            //    totalConsumed += countOfSpices - CONSUMED_BY_WORKERS;
            //    countOfSpices-=DAILY_DECREES;
            //    daysCounted++;
            //    if (countOfSpices<MINIMUM_SPICES)
            //    {
            //        totalConsumed -= CONSUMED_BY_WORKERS;
            //    }
            //}
            //Console.WriteLine(daysCounted);
            //Console.WriteLine(totalConsumed);

            //zada4a 10
            //int power = int.Parse(Console.ReadLine());
            //int distance = int.Parse(Console.ReadLine());
            //int exhaustionFactor = int.Parse(Console.ReadLine());
            //int startingPower = power;
            //int countOfPokedTar = 0;
            //while (power>=distance)
            //{
            //    power -= distance;
            //    countOfPokedTar++;
            //    if (startingPower*0.5==power && exhaustionFactor>0)
            //    {
            //        power /= exhaustionFactor;
            //    }
            //}
            //Console.WriteLine(power);
            //Console.WriteLine(countOfPokedTar);

            //zada4a 11
            //int snowBalls=int.Parse(Console.ReadLine());
            //BigInteger snowBallValue = 0;
            //BigInteger snowBallSnow = 0;
            //BigInteger snowBallTime = 0;
            //int snowBallQuality = 0;
            //BigInteger bestSnowBall = int.MinValue;
            //string bestSnowBallFormula = "";
            //for (int i = 0; i < snowBalls; i++)
            //{
            //    snowBallSnow = BigInteger.Parse(Console.ReadLine());
            //    snowBallTime = BigInteger.Parse(Console.ReadLine());
            //    snowBallQuality = int.Parse(Console.ReadLine());
            //    BigInteger currentSnowBallValue = snowBallSnow / snowBallTime;
            //    snowBallValue = BigInteger.Pow(currentSnowBallValue, snowBallQuality);
            //    if (snowBallValue>bestSnowBall)
            //    {
            //        bestSnowBall = snowBallValue;
            //        bestSnowBallFormula=$"{snowBallSnow} : {snowBallTime} = {snowBallValue} ({snowBallQuality})";
            //    }

            //}
            //Console.WriteLine(bestSnowBallFormula);

            //Yrok 30.05.2022


            //Yrok 01.06.2022
            //zada4a 1
            //int dayOfWeek=int.Parse(Console.ReadLine());
            //string[] weekDays = { "Monday", "Tuesay", "Wednesday", "Thursday", "Friday", "Saturday", "Suday" };
            //if (dayOfWeek>=1 && dayOfWeek<=7)
            //{
            //    Console.WriteLine(weekDays[dayOfWeek-1]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid day!");
            //}

            //zada4a 2
            //int count=int.Parse(Console.ReadLine());
            //int[] numbers=new int[count];
            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = numbers.Length-1; i >=0; i--)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}

            //zada4a 3
            //string[] input=Console.ReadLine().Split(' ');
            //double[] numbers=new double[input.Length];
            //for (int i = 0; i < input.Length; i++)
            //{
            //    numbers[i] = double.Parse(input[i]);
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i],MidpointRounding.AwayFromZero)}");
            //}

            //zada4a 4
            //string[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < elements.Length / 2; i++)
            //{
            //    string frontElement = elements[i];
            //    string backElement = elements[(elements.Length - 1) - i];
            //    string tempElement = frontElement;
            //    elements[i] = backElement;
            //    elements[(elements.Length - 1) - i] = tempElement;
            //}
            //Console.WriteLine(string.Join(" ", elements));

            //zada4a 5
            //int[] numbers=Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int sum = 0;
            //foreach (int number in numbers)
            //{
            //    if (number%2==0)
            //    {
            //        sum += number;
            //    }
            //}
            //Console.WriteLine(sum);

            //zada4a 6
            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int oddsum = 0;
            //int evensum = 0;
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        evensum += number;
            //    }
            //    else{
            //        oddsum += number;
            //    }
            //}
            //Console.WriteLine(evensum-oddsum);

            //zada4a 7
            //int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int sum = 0;
            //for (int i = 0; i < firstArray.Length; i++)
            //{
            //    if (firstArray[i] != secondArray[i])
            //    {
            //        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
            //        break;
            //    }
            //    else
            //    {
            //        sum += firstArray[i];
            //    }
            //    if (i==firstArray.Length-1)
            //    {
            //        Console.WriteLine($"Arrays are identical. Sum: {sum}");
            //    }
            //}

            //zada4a 8
            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int[] condensed = new int[numbers.Length - 1];
            //while (numbers.Length > 1)
            //{
            //    for (int i = 0; i < numbers.Length - 1; i++)
            //    {
            //        condensed[i] = numbers[i] + numbers[i + 1];
            //        if (i == numbers.Length - 2)
            //        {
            //            numbers = condensed;
            //            condensed = new int[numbers.Length - 1];
            //        }
            //    }
            //}
            //Console.WriteLine(numbers[0]);

            //Ypraznenia 03.06.2022
            //zada4a 1 Train
            //int numberOfvagons = int.Parse(Console.ReadLine());
            //int[] wagons = new int[numberOfvagons];
            //int sum = 0;
            //for (int i = 0; i < wagons.Length; i++)
            //{
            //    wagons[i] = int.Parse(Console.ReadLine());
            //    sum += wagons[i];
            //}
            //for (int i = 0; i < wagons.Length; i++)
            //{
            //    Console.Write($"{wagons[i]} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(sum);

            //zada4a 2 Common elementsstring
            //string[] arrone = Console.ReadLine().Split(' ');
            //string[] arrtwo = Console.ReadLine().Split(' ');
            //foreach (var word in arrone)
            //{
            //    for (int i = 0; i < arrtwo.Length; i++)
            //    {
            //        string secondelement = arrtwo[i];
            //        if (word == secondelement)
            //        {
            //            Console.Write($"{word} ");
            //            break;
            //        }
            //    }
            //}

            //zada4a 3 Zig Zag Arrays
            //int lines = int.Parse(Console.ReadLine());
            //int[] evevArray = new int[lines];
            //int[] oddArray = new int[lines];

            //for (int i = 0; i < lines; i++)
            //{
            //    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //    if (i % 2 == 0)
            //    {
            //        evevArray[i] = numbers[0];
            //        oddArray[i] = numbers[1];
            //    }
            //    else
            //    {
            //        evevArray[i] = numbers[1];
            //        oddArray[i] = numbers[0];
            //    }
            //}
            //Console.WriteLine(String.Join(" ", evevArray));
            //Console.WriteLine(String.Join(" ", oddArray));

            //zada4a 4 Array Rotationintintintint
            //int[] arr=Console.ReadLine().Split().Select(int.Parse).ToArray();   
            //int rotations=int.Parse(Console.ReadLine());
            //for (int i = 0; i < rotations; i++)
            //{
            //    int tempE1 = arr[0];
            //    for (int j = 0; j < arr.Length-1; j++)
            //    {
            //        arr[j] = arr[j + 1];
            //    }
            //    arr[arr.Length-1] = tempE1;
            //}
            //Console.WriteLine(String.Join(" ",arr));

            //zada4a 5 Top integers
            //int[] inputArray= Console.ReadLine().Split().Select(int.Parse).ToArray();

            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    bool currIterationNumIsBigger = true;
            //    for (int j = i+1; j < inputArray.Length; j++)
            //    {
            //        if (inputArray[i] <= inputArray[j])
            //        {
            //            currIterationNumIsBigger = false;
            //            break;
            //        }
            //    }
            //    if (currIterationNumIsBigger)
            //    {
            //        Console.Write($"{inputArray[i]} ");
            //    }
            //}

            //zada4a 6 Equal sums
            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int leftSum = 0;
            //int rightSum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers.Length == 1)
            //    {
            //        Console.WriteLine(0);
            //        return;
            //    }
            //    leftSum = 0;
            //    for (int j = i; j > 0; j--)
            //    {
            //        int nextLeftElementPosition = j - 1;
            //        if (j > 0)
            //        {
            //            leftSum += numbers[nextLeftElementPosition];
            //        }
            //    }
            //    rightSum = 0;
            //    for (int k = i; k < numbers.Length; k++)
            //    {
            //        int nextRightElelemntPosition = k + 1;
            //        if (k < numbers.Length - 1)
            //        {
            //            rightSum += numbers[nextRightElelemntPosition];
            //        }
            //    }
            //    if (leftSum == rightSum)
            //    {
            //        Console.WriteLine(i);
            //        return;
            //    }
            //}
            //Console.WriteLine("no");

            //zada4a 7
            //int[] mas = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int beststart = 0;
            //int bestLen = 0;
            //int Len = 0;
            //int index = 0;
            //for (int i = 1; i < mas.Length; i++)
            //{
            //    if (mas[i - 1] == mas[i])
            //    {
            //        Len += 1;
            //        if (Len > bestLen)
            //        {
            //            bestLen = Len;
            //            beststart = i - 1;
            //            index = i - bestLen + 1;
            //        }
            //    }
            //    else
            //    {
            //        Len = 1;
            //    }
            //}
            //if (index == 1)
            //{
            //    if (mas[0] == mas[1])
            //    {
            //        index -= 1;
            //        beststart += 1;
            //        for (int i = index; i <= bestLen + index; i++)
            //        {
            //            Console.Write($"{mas[i]} ");
            //        }
            //    }
            //    else
            //    {
            //        for (int i = index; i <= bestLen; i++)
            //        {
            //            Console.Write($"{mas[i]} ");
            //        }
            //    }
            //}
            //else if (index == 0)
            //{
            //    Console.Write($"{mas[0]}");
            //}
            //else
            //{
            //    for (int i = index; i < bestLen + index; i++)
            //    {
            //        Console.Write($"{mas[i]} ");
            //    }
            //}

            //zada4a 8
            //int[] N = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;
            //int S = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i < N.Length; i++)
            //{
            //    for (int r = i + 1; r < N.Length; r++)
            //    {
            //        sum = N[i] + N[r];
            //        if (sum == S)
            //        {
            //            Console.Write($"{N[i]} ");
            //            Console.Write($"{N[r]} ");
            //            Console.WriteLine();
            //        }
            //        sum = 0;
            //    }
            //}

            //zada4a 9 Kamino Factory
            //int sequenceLenght = int.Parse(Console.ReadLine());
            //string input = Console.ReadLine();

            //int[] DNA = new int[sequenceLenght];
            //int dnaSum = 0;
            //int dnaCount = -1;
            //int dnaStartIndex = -1;
            //int dnaSamples = 0;
            //int sample = 0;
            //while (input != "Clone them!")
            //{
            //    sample++;
            //    char[] zaSplit = { '!' };
            //    int[] currDNA = input.Split(zaSplit, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //    int currentCount = 0;
            //    int currStartIndex = 0;
            //    int currEndIndex = 0;
            //    int currDnaSum = 0;
            //    bool isCurrentDnaBetter = false;

            //    int count = 0;
            //    for (int i = 0; i < currDNA.Length; i++)
            //    {
            //        if (currDNA[i] != 1)
            //        {
            //            count = 0;
            //            continue;
            //        }
            //        count++;
            //        if (count > currentCount)
            //        {
            //            currentCount = count;
            //            currEndIndex = i;
            //        }
            //    }
            //    currStartIndex = currEndIndex - currentCount + 1;
            //    currDnaSum = currDNA.Sum();

            //    if (currentCount > dnaCount)
            //    {
            //        isCurrentDnaBetter = true;
            //    }
            //    else if (currentCount == dnaCount)
            //    {
            //        if (currStartIndex < dnaStartIndex)
            //        {
            //            isCurrentDnaBetter = true;
            //        }
            //        else if (currStartIndex == dnaStartIndex)
            //        {
            //            if (currDnaSum > dnaSum)
            //            {
            //                isCurrentDnaBetter = true;
            //            }
            //        }

            //    }
            //    if (isCurrentDnaBetter)
            //    {
            //        DNA = currDNA;
            //        dnaCount = currentCount;
            //        dnaStartIndex = currStartIndex;
            //        dnaSum = currDnaSum;
            //        dnaSamples = sample;
            //    }
            //    input = Console.ReadLine();

            //}
            //Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");
            //Console.WriteLine(String.Join(" ", DNA));

            //zada4a 10 LadyBug
            //int fieldSize = int.Parse(Console.ReadLine());

            //int[] ladyBugsField = new int[fieldSize];
            //string[] occupiedIndex=Console.ReadLine().Split();

            //for (int i = 0; i < occupiedIndex.Length; i++)
            //{
            //    int currentIndex=int.Parse(occupiedIndex[i]);
            //    if (currentIndex>=0 && currentIndex<fieldSize)
            //    {
            //        ladyBugsField[currentIndex] = 1;
            //    }
            //}
            //string[] commands=Console.ReadLine().Split();
            //while (commands[0]!="end")
            //{
            //    bool isFirst = true;
            //    int currentIndex = int.Parse(commands[0]);
            //    while (currentIndex>=0 && currentIndex<fieldSize && ladyBugsField[currentIndex]!=0)
            //    {
            //        if (isFirst)
            //        {
            //            ladyBugsField[currentIndex] = 0;
            //            isFirst= false;
            //        }
            //        string direction = commands[1];
            //        int flightLenght = int.Parse(commands[2]);
            //        if (direction=="left")
            //        {
            //            currentIndex -= flightLenght;

            //            if (currentIndex>=0 && currentIndex<fieldSize)
            //            {
            //                if (ladyBugsField[currentIndex]==0)
            //                {
            //                    ladyBugsField[currentIndex] = 1;
            //                    break;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            currentIndex+=flightLenght;
            //            if (currentIndex>=0 && currentIndex<fieldSize)
            //            {
            //                if (ladyBugsField[currentIndex]==0)
            //                {
            //                    ladyBugsField[currentIndex] = 1;
            //                    break ;
            //                }
            //            }

            //        }

            //    }
            //    commands=Console.ReadLine().Split();    
            //}
            //Console.WriteLine(String.Join(" ",ladyBugsField));

            //More Exercise
            //zada4a 1
            //int n = int.Parse(Console.ReadLine());
            //int[] sortArray = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    string s = Console.ReadLine();
            //    int strLen = s.Length;
            //    int sumLenght = 0;
            //    for (int j = 0; j < s.Length; j++)
            //    {
            //        if (s[j] == 'a' || s[j] == 'o' || s[j] == 'e' || s[j] == 'u' || s[j] == 'i' || s[j] == 'A' || s[j] == 'O' || s[j] == 'E' || s[j] == 'U' || s[j] == 'I')
            //        {
            //            sumLenght += (int)s[j] * s.Length;
            //        }
            //        else
            //        {
            //            sumLenght += (int)s[j] / s.Length;
            //        }
            //    }
            //    sortArray[i] = sumLenght;
            //}
            //Array.Sort(sortArray);
            //for (int i = 0; i < sortArray.Length; i++)
            //{
            //    Console.WriteLine(sortArray[i]);
            //}

            //zada4a 2
            //int n = int.Parse(Console.ReadLine());
            //int[] rowArray = new int[n];
            //rowArray[0] = 1;
            //rowArray[1] = 1;
            //int[] temp2 = new int[1];
            //for (int row = 0; row < n; row++)
            //{
            //    int[] temp1 = new int[row + 1];
            //    for (int t = 0; t < temp1.Length; t++)
            //    {
            //        int lastOne = temp1.Length - 1;
            //        if (t == 0 || t == lastOne)
            //        {
            //            temp1[t] = rowArray[0];
            //        }
            //        else
            //        {
            //            temp1[t] = temp2[t] + temp2[t - 1];
            //        }
            //    }
            //    temp2 = temp1;
            //    Console.WriteLine(String.Join(" ", temp2));
            //}

            //zada4a 3 Fibona4i
            //    int n = int.Parse(Console.ReadLine());
            //    long result = Fib(n);
            //    Console.WriteLine(result);
            //}
            //private static long Fib(int n)
            //{
            //    long fn = 1;
            //    long fnMinus1 = 1;
            //    long fnMinus2 = 1;
            //    for (int i = 2; i < n; i++)
            //    {
            //        fn = fnMinus1 + fnMinus2;
            //        fnMinus2 = fnMinus1;
            //        fnMinus1 = fn;
            //    }
            //    return fn;
            //}

            //zada4a 4 Fold and Sum
            //int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int lenght = n.Length;
            //int k = lenght / 2;
            //int leftRightSide = k / 2;
            //int[] left = new int[leftRightSide];
            //int[] right = new int[leftRightSide];
            //int count = 0;
            //int countArr = 0;
            //for (int i = 0; i < leftRightSide; i++)
            //{
            //    left[i] = n[i];
            //}
            //Array.Reverse(left);
            //// Console.WriteLine(String.Join(" ", left));
            //for (int i = lenght - leftRightSide; i < lenght; i++)
            //{
            //    right[count] = n[i];
            //    count++;
            //}
            //Array.Reverse(right);
            //// Console.WriteLine(String.Join(" ", right));
            //int[] leftRightArr = left.Concat(right).ToArray();
            //int[] finalArr = new int[leftRightArr.Length];
            //// Console.WriteLine(String.Join(" ", leftRightArr));
            //int[] partOfArrN = new int[k];
            //int countPart = 0;
            //for (int i = k - leftRightSide; i < k + leftRightSide; i++)
            //{
            //    partOfArrN[countPart++] = n[i];
            //}
            //// Console.WriteLine(String.Join(" ", partOfArrN));
            //for (int i = 0; i < finalArr.Length; i++)
            //{
            //    finalArr[i] = leftRightArr[i] + partOfArrN[i];
            //    countArr++;
            //}
            //Console.WriteLine(String.Join(" ", finalArr));

            //Yrok 07.06.2022 HTML & CSS

            //Yrok 08.06.2022 Methods
            //zada4a 1
            //string input = Console.ReadLine();
            //int number1 = int.Parse(input);
            //PrintSign(number1);

            ////zada4a 2
            //double grade=double.Parse(args[0]);
            //PrintGradeWithWord(grade);

            //zada4a 4
            //int height=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= height; i++)
            //{
            //    PrintLine(1, i);
            //}
            //for (int i = height-1; i >=1; i--)
            //{
            //    PrintLine(1, i);
            //}

            //zada4a 6
            //double width=double.Parse(Console.ReadLine());
            //double height=double.Parse(Console.ReadLine());
            //double area = CalculateArea(width, height);
            //Console.WriteLine(area);

            //zada4a 7
            //string input=Console.ReadLine();
            //int times= int.Parse(Console.ReadLine());
            //Console.WriteLine(RepeatString(input,times));

            //zada4a 8
            //double basa = double.Parse(Console.ReadLine());
            //int power = int.Parse(Console.ReadLine());
            //Console.WriteLine(MathPower( basa,power));

            //zada4 9
            //string type=Console.ReadLine();
            //switch (type)
            //{
            //    case "int":
            //        int firstInt = int.Parse(Console.ReadLine());
            //        int secondInt = int.Parse(Console.ReadLine());
            //        Console.WriteLine(GetMax(firstInt, secondInt));
            //        break;
            //    case "char":
            //        char firstChar = char.Parse(Console.ReadLine());
            //        char secondChar = char.Parse(Console.ReadLine());
            //        Console.WriteLine(GetMax(firstChar, secondChar));
            //        break;
            //    case "string":
            //        string firstString = Console.ReadLine();
            //        string secondString = Console.ReadLine();
            //        Console.WriteLine(GetMax(firstString, secondString));
            //        break;

            //}

            //zada4a 10
            //int number=int.Parse(Console.ReadLine());
            //number=Math.Abs(number);
            //int evenSum=GetSumOfEvenDigits(number);
            //int oddSum=GetSumOfOddDigits(number);
            //int result=GetMultipleOfEvenAndOdds(evenSum, oddSum);
            //Console.WriteLine(result);  

            //zada4a 3
            //string command = Console.ReadLine();
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //switch (command)
            //{
            //    case "add":
            //        Add(a, b);
            //        break;
            //    case "subtract":
            //        Subtract(a, b);
            //        break;
            //    case "multiply":
            //        Multiply(a, b);
            //        break;
            //    case "divide":
            //        Divide(a, b);
            //        break;
            //    default:
            //        break;
            //}

            //zada4a 11
            //int a = int.Parse(Console.ReadLine());
            //string operatora = Console.ReadLine();
            //int b = int.Parse(Console.ReadLine());
            //double result = Calculate(a, operatora, b);
            //Console.WriteLine(result);


            //Ypraznenie 10.06.2022
            //zada4a 1
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //Console.WriteLine(SmallestNumber(num1,num2,num3));

            //zada4a 2
            //string input=Console.ReadLine().ToLower();
            //SearchForVowels(input);

            //zada4a 3
            //char firstChar = char.Parse(Console.ReadLine());
            //char secondChar = char.Parse(Console.ReadLine());
            //CharsInRange(firstChar, secondChar);

            //zada4a 4

            //string password = Console.ReadLine();
            //bool isPasswordLenghtValid = ValidatePasswordLenght(password);
            //bool isPasswordContainsValidSymbols = ValidatePasswordText(password);
            //bool isDigitInPasswordTwo = ValidatePasswordDigit(password);
            //if (!isPasswordLenghtValid)
            //{
            //    Console.WriteLine("Password must be between 6 and 10 characters");
            //}
            //if (!isPasswordContainsValidSymbols)
            //{
            //    Console.WriteLine("Password must consist only of letters and digits");
            //}
            //if (!isDigitInPasswordTwo)
            //{
            //    Console.WriteLine("Password must have at least 2 digits");
            //}
            //if (isPasswordLenghtValid && isPasswordContainsValidSymbols && isDigitInPasswordTwo)
            //{
            //    Console.WriteLine("Password is valid");
            //}

            //zada4a 5
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //int result = Add(num1, num2);
            //int sub = Substract(result, num3);
            //PrintResult(sub);

            //zada4a 6
            //string word=Console.ReadLine();
            //PrintMiddleCharscters(word);

            //zada4a 7
            //int input=int.Parse(Console.ReadLine());
            //MatrixCreator(input);

            //zada4a 8
            //int firstNum = int.Parse(Console.ReadLine());
            //int secondNum = int.Parse(Console.ReadLine());
            //double result1 = Factoriel(firstNum);
            //double result2 = Factoriel(secondNum);
            //double res = result1 / result2;
            //Console.WriteLine($"{res:f2}");

            //zada4a 9

            //string input = Console.ReadLine();
            //while (input!="END")
            //{
            //    bool isNumberPalindrome1 =isNumberPalindrome(input);
            //    Console.WriteLine(isNumberPalindrome1.ToString().ToLower());
            // input = Console.ReadLine();
            //}

            //zada4a 10
            //int numer = int.Parse(Console.ReadLine());
            //PrintTopNumbers(numer);

            //zada4a 11
            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //string[] command = Console.ReadLine().Split();
            //while (command[0] != "end")
            //{
            //    if (command[0] == "exchange")
            //    {
            //        int givenIndex = int.Parse(command[1]);
            //        arr = ExchangeArr(arr, givenIndex);
            //    }
            //    else if (command[0] == "max" || command[0] == "min")
            //    {
            //        FindMinMax(arr, command[0], command[1]);
            //    }
            //    else
            //    {

            //        FindNumbers(arr, command[0], int.Parse(command[1]), command[2]);
            //    }
            //    command = Console.ReadLine().Split();
            //}
            //Console.WriteLine($"[{string.Join(", ", arr)}]");


            //15.06.2022 YROK LIST
            //zada4a 1 
            //List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            //int coun = numbers.Count;
            //for (int i = 0; i < numbers.Count - 1; i++)
            //{
            //    if (numbers[i] == numbers[i + 1])
            //    {
            //        numbers[i] += numbers[i + 1];
            //        numbers.RemoveAt(i + 1);
            //        i = -1;
            //    }
            //}
            //Console.WriteLine(string.Join(" ", numbers));

            //zada4a 2
            //List<int> numbers=Console.ReadLine().Split().Select(int.Parse).ToList().ToList();
            //List<int> gaussNumbers= new List<int>();
            //for (int i = 0; i < numbers.Count/2; i++)
            //{
            //    int currentGaussNumber = numbers[i] +numbers[ numbers.Count - 1 - i];
            //    gaussNumbers.Add(currentGaussNumber);
            //}
            //if (numbers.Count%2!=0)
            //{
            //    gaussNumbers.Add(numbers[numbers.Count/2]);
            //}
            //Console.WriteLine(String.Join(" ",gaussNumbers));

            //zada4a 3 Merging List
            //List<int> firstList=Console.ReadLine().Split().Select(int.Parse).ToList().ToList();
            //List<int> secondList=Console.ReadLine().Split().Select(int.Parse).ToList().ToList();
            //List<int> result=new List<int>();
            //int biggerCount=Math.Max(firstList.Count, secondList.Count);
            //for (int i = 0; i < biggerCount; i++)
            //{
            //    if (firstList.Count>i)
            //    {
            //    result.Add(firstList[i]);
            //    }
            //    if (secondList.Count > i)
            //    {
            //        result.Add(secondList[i]);
            //    }
            //}
            //Console.WriteLine(String.Join(" ", result));

            //zada4a 4 List of products
            // List<string> products = new List<string>();
            // int count=int.Parse(Console.ReadLine());
            // for (int i = 0; i <count; i++)
            // {
            //     products.Add(Console.ReadLine());
            // }
            // products.Sort();
            // int counter = 1;
            //foreach (string product in products)
            // {
            //     Console.WriteLine($"{counter}.{product}");
            //     counter++;  
            // }

            //zada4a 5 Remove Negatives and Reverse

            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList().ToList();

            //for (int i = 0; i <numbers.Count ; i++)
            //{
            //    if (numbers[i]<0)
            //    {
            //        numbers.RemoveAt(i);
            //        i--;
            //    }
            //}
            //numbers.Reverse();
            //if (numbers.Count>0)
            //{
            //Console.WriteLine(String.Join(" ",numbers));
            //    return;
            //}
            //Console.WriteLine("empty");

            //zada4a 6 List Manipulation Basics
            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList().ToList();
            //while (true)
            //{
            //    string command = Console.ReadLine();
            //    if (command=="end")
            //    {
            //        break;
            //    }
            //    string[] tokens=command.Split();
            //    string action=tokens[0];
            //    switch (action)
            //    {
            //        case "Add":
            //            int numberToAdd=int.Parse(tokens[1]);
            //            numbers.Add(numberToAdd);
            //            break;
            //        case "Remove":
            //            int numberTpRemove=int.Parse(tokens[1]);
            //            numbers.Remove(numberTpRemove);
            //            break;
            //        case "RemoveAt":
            //            int indexToRemove = int.Parse(tokens[1]);
            //            numbers.RemoveAt(indexToRemove);
            //            break;
            //        case "Insert":
            //            int numberToInsert = int.Parse(tokens[1]);
            //            int indexToInsert = int.Parse(tokens[2]);
            //            numbers.Insert(indexToInsert,numberToInsert);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine(String.Join(" ",numbers));

            //zada4a 7
            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList().ToList();
            //bool isListChanged = false;
            //while (true)
            //{
            //    string command = Console.ReadLine();
            //    if (command == "end")
            //    {
            //        break;
            //    }
            //    string[] tokens = command.Split();
            //    string action = tokens[0];
            //    switch (action)
            //    {
            //        case "Add":
            //            int numberToAdd = int.Parse(tokens[1]);
            //            numbers.Add(numberToAdd);
            //            isListChanged = true;
            //            break;
            //        case "Remove":
            //            int numberTpRemove = int.Parse(tokens[1]);
            //            numbers.Remove(numberTpRemove);
            //            isListChanged = true;
            //            break;
            //        case "RemoveAt":
            //            int indexToRemove = int.Parse(tokens[1]);
            //            numbers.RemoveAt(indexToRemove);
            //            isListChanged = true;
            //            break;
            //        case "Insert":
            //            int numberToInsert = int.Parse(tokens[1]);
            //            int indexToInsert = int.Parse(tokens[2]);
            //            numbers.Insert(indexToInsert, numberToInsert);
            //            isListChanged = true;
            //            break;
            //        case "Contains":
            //            CheckContains(int.Parse(tokens[1]), numbers);
            //            break;
            //        case "PrintEven":
            //            PrintEven(numbers);
            //            break;
            //        case "PrintOdd":
            //            PrintOdd(numbers);
            //            break;
            //        case "GetSum":
            //            int sum = GetSum(numbers);
            //            Console.WriteLine(sum);
            //            break;
            //        case "Filter":
            //            PrintFiltered(tokens[1], int.Parse(tokens[2]), numbers);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //if (isListChanged)
            //{
            //    Console.WriteLine(String.Join(" ", numbers));
            //}

            // 17.06.2022 Ypraznenie List
            //zada4a 1
            //List<int> wagons=Console.ReadLine().Split().Select(int.Parse).ToList();
            //int maxCapacity=int.Parse(Console.ReadLine());
            //string command=Console.ReadLine();

            //while (command !="end")
            //{
            //    string[] tokens = command.Split();
            //    if (tokens.Length==2)
            //    {
            //        int wagpn = int.Parse(tokens[1]);
            //        wagons.Add(wagpn);
            //    }
            //    else
            //    {
            //        int passengers=int.Parse(tokens[0]);
            //        FindWagon(wagons, maxCapacity, passengers);
            //    }
            //    command=Console.ReadLine();
            //}
            //Console.WriteLine(String.Join(" ",wagons));

            //zada4a 2 Change List
            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //string line = Console.ReadLine();
            //while (line != "end")
            //{
            //    string[] tokens = line.Split();
            //    string cmd = tokens[0];
            //    if (cmd == "Delete")
            //    {
            //        int element = int.Parse(tokens[1]);
            //        numbers.RemoveAll(el => el == element);//vmesto for cicle //kazva 4e za vsi4ki elementi t.e 
            // elementyt el==element i kogato nameri vsi4kite elementi
            //    }
            //    else if (cmd == "Insert")
            //    {
            //        int element = int.Parse(tokens[1]);
            //        int index = int.Parse(tokens[2]);
            //        numbers.Insert(index, element);
            //    }
            //    line = Console.ReadLine();
            //}
            //Console.WriteLine(String.Join(" ", numbers));

            //zada4a 3 House Party
            //int n=int.Parse(Console.ReadLine());
            //var listOfNames= new List<string>();
            //for (int i = 0; i < n; i++)
            //{
            //    var command = Console.ReadLine().Split();
            //    string currName=command[0];
            //    if (listOfNames.Contains(currName) && command[2]=="going!")
            //    {
            //        Console.WriteLine($"{currName} is already in the list!");
            //    }
            //    else if (listOfNames.Contains(currName) && command[2] == "not")
            //    {
            //        listOfNames.Remove(currName);
            //    }
            //    else if (!listOfNames.Contains(currName) && command[2] == "not")
            //    {
            //        Console.WriteLine($"{currName} is not in the list!");
            //    }
            //    else
            //    {
            //        listOfNames.Add(currName);
            //    }
            //}
            //foreach (var item in listOfNames)
            //{
            // Console.WriteLine(item);
            //}

            //zada4a 4
            //var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //string command=Console.ReadLine();
            //while (command!="End")
            //{
            //    string[] tokens = command.Split();
            //    if (tokens[0]=="Add")
            //    {
            //        int number = int.Parse(tokens[1]);
            //        numbers.Add(number);
            //    }
            //    else if (tokens[0] == "Insert")
            //    {
            //        int number=int.Parse(tokens[1]);
            //        int index = int.Parse(tokens[2]);
            //        if (index>numbers.Count-1 || index<0)
            //        {
            //            Console.WriteLine("Invalid index");
            //            continue;
            //        }
            //        numbers.Insert(index, number);
            //    }
            //    else if (tokens[0] == "Remove")
            //    {
            //        int index = int.Parse(tokens[1]);
            //        if (index > numbers.Count - 1 || index < 0)
            //        {
            //            Console.WriteLine("Invalid index");
            //            continue;
            //        }
            //        numbers.RemoveAt(index);

            //    }
            //    else if (tokens[0]=="Shift")
            //    {
            //        int count=int.Parse(tokens[2]);
            //        if (tokens[1]=="left")
            //        {
            //            for (int i = 0; i < count; i++)
            //            {
            //                numbers.Add(numbers[0]);
            //                numbers.RemoveAt(0);
            //            }
            //        }
            //        else if (tokens[1] == "right")
            //        {
            //            for (int i = 0; i < count; i++)
            //            {
            //                numbers.Insert(0, numbers[numbers.Count-1]);
            //                numbers.RemoveAt(numbers.Count-1);
            //            }
            //        }

            //    }
            //    command = Console.ReadLine();
            //}
            //Console.WriteLine(String.Join(" ",numbers));

            //zada4a 5 Bomb numbers
            //List<int>numbers=Console.ReadLine().Split().Select(int.Parse).ToList();
            //int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int bombNumber=tokens[0];
            //int power = tokens[1];
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    int target = numbers[i];
            //    if (target==bombNumber)
            //    {
            //        BombNumber(numbers, power, i);
            //    }
            //}
            //Console.WriteLine(numbers.Sum());

            //zada4a 6 Cards Game
            //List<int> firstPlayer= Console.ReadLine().Split().Select(int.Parse).ToList();
            //List<int> secondPlayer= Console.ReadLine().Split().Select(int.Parse).ToList();
            //while (firstPlayer.Count>0 && secondPlayer.Count>0)
            //{
            //    if (firstPlayer[0] > secondPlayer[0])
            //    {
            //        firstPlayer.Add(firstPlayer[0]);
            //        firstPlayer.Add(secondPlayer[0]);
            //    }
            //    else if (firstPlayer[0] < secondPlayer[0])
            //    {
            //        secondPlayer.Add(secondPlayer[0]);
            //        secondPlayer.Add(firstPlayer[0]);
            //    }
            //    firstPlayer.Remove(firstPlayer[0]);
            //    secondPlayer.Remove(secondPlayer[0]);
            //    if (firstPlayer.Count==0)
            //    {
            //        int sum = secondPlayer.Sum();
            //        Console.WriteLine($"Second player wins! Sum: {sum}");
            //        break;
            //    }
            //     if (secondPlayer.Count==0)
            //    {
            //        int sum = firstPlayer.Sum();
            //        Console.WriteLine($"First player wins! Sum: {sum}");
            //        break;
            //    }
            //}

            //zada4a 7 Append Array
            //List<string> numberAsStrings = Console.ReadLine().Split('|').Reverse().ToList();
            //List<int> numbers = new List<int>();
            //foreach (var number in numberAsStrings)
            //{
            //    numbers.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            //}
            //Console.WriteLine(string.Join(" ", numbers));

            //zada4a 8 Anonymous Threat
            //char[] forSplit=new char[] { ' ' };
            //List<string> myList = Console.ReadLine().Split(forSplit,StringSplitOptions.RemoveEmptyEntries).ToList();

            //while (true)
            //{
            //    string[] commands = Console.ReadLine().Split();
            //    string command = commands[0];
            //    if (command == "3:1") break;
            //    int startIndex = int.Parse(commands[1]);
            //    int endIndex = int.Parse(commands[2]);
            //    string concatWord = "";
            //    if (endIndex>myList.Count-1 || endIndex<0) //dali e izvan masiva
            //    {
            //        endIndex = myList.Count-1;
            //    }
            //    if (startIndex<0 || startIndex>myList.Count-1)
            //    {
            //        startIndex = 0;

            //    }
            //    if (command=="merge")
            //    {
            //        for (int i = startIndex; i <=endIndex; i++)
            //        {
            //            concatWord += myList[i];
            //        }
            //        myList.RemoveRange(startIndex, endIndex-startIndex+1);
            //        myList.Insert(startIndex, concatWord);
            //    }
            //    else if (command == "divide")
            //    {
            //        var dividetList=new List<string>();
            //        int partitions=int.Parse(commands[2]);
            //        string word=myList[startIndex];
            //        myList.RemoveAt(startIndex);
            //        int parts = word.Length / partitions;
            //        for (int i = 0; i < partitions; i++)
            //        {
            //            if (i == partitions - 1)
            //            {
            //                dividetList.Add(word.Substring(i*parts));
            //            }
            //            else
            //            {
            //                dividetList.Add(word.Substring(i * parts,parts));
            //            }

            //        }
            //        myList.InsertRange(startIndex, dividetList);
            //    }

            //}
            //Console.WriteLine(string.Join(" ",myList));


            //zada4a 9 pokemon do not go
            //var sequence=Console.ReadLine().Split().Select(int.Parse).ToList();
            //int index;
            //int currentValue;
            //int sum=0;
            //while (sequence.Count!=0)
            //{
            //    index = int.Parse(Console.ReadLine());
            //    if (index<0)
            //    {
            //        currentValue = sequence[0];
            //        sum += currentValue;
            //        sequence[0] =sequence[ sequence.Count - 1];
            //    }
            //    else if (index>sequence.Count-1)
            //    {
            //        currentValue = sequence[sequence.Count - 1];
            //        sum += currentValue;
            //        sequence[sequence.Count - 1] = sequence[0];
            //    }
            //    else
            //    {
            //        currentValue = sequence[index];
            //        sum += currentValue;
            //        sequence.RemoveAt(index);
            //    }
            //    for (int i = 0; i < sequence.Count; i++)
            //    {
            //        if (sequence[i]<=currentValue)
            //        {
            //            sequence[i] += currentValue;
            //        }
            //        else
            //        {
            //            sequence[i] -= currentValue;
            //        }
            //    }
            //}
            //Console.WriteLine(sum);

            //Predi izpit 20.06.2022
            //zada4a 1
            //double food=double.Parse(Console.ReadLine())*1000;
            //double hay=double.Parse(Console.ReadLine())*1000;
            //double cover=double.Parse(Console.ReadLine())*1000;
            //double wight=double.Parse(Console.ReadLine())*1000;
            //for (int i = 1; i <= 30; i++)
            //{
            //    food -=300;
            //    if (i%2==0)
            //    {
            //        hay -= 0.05 * food;
            //    }
            //    if (i%3==0)
            //    {
            //        cover -= wight / 3;
            //    }
            //    if (food<=0 || hay<=0 || cover<=0)
            //    {
            //        Console.WriteLine("Merry must go to the pet store!");

            //        return;
            //    }
            //}
            //Console.WriteLine($"Everithing is fine! Puppy is happy. Food {(food/1000):f2}, Hay: {(hay/1000):f2}, Cover: {(cover / 1000):f2}");

            //zada4a 2 The Lift
            //int peopleWaithing=int.Parse(Console.ReadLine());
            //List<int> lift=Console.ReadLine().Split().Select(int.Parse).ToList();
            //int maxPeoplePerWagon = 4;
            //for (int i = 0; i <lift.Count ; i++)
            //{
            //    for (int j = lift[i]; j < maxPeoplePerWagon; j++)
            //    {
            //        lift[i]++;
            //        peopleWaithing--;
            //        if (peopleWaithing==0)
            //        {
            //            if (lift.Sum()<lift.Count*maxPeoplePerWagon)
            //            {
            //                Console.WriteLine("The lift has empty spots!");
            //            }
            //        Console.WriteLine(String.Join(" ",lift));

            //            return;
            //        }
            //    }
            //}
            //Console.WriteLine($"There isnot space!");
            //Console.WriteLine(String.Join(" ", lift));

            //zada4a 3 target
            //List<int> target = Console.ReadLine().Split().Select(int.Parse).ToList() ;
            //while (true)
            //{
            //    string command = Console.ReadLine();
            //    if (command=="End")
            //    {
            //        break;
            //    }
            //    string[] tokens = command.Split();
            //    string action=tokens[0];

            //    switch (action)
            //    {
            //        case "Shoot":
            //            Shoot(int.Parse(tokens[1]), int.Parse(tokens[1]),target);
            //            break;
            //        case "Add":
            //            Add(int.Parse(tokens[1]), int.Parse(tokens[1]), target);
            //            break;
            //        case "Strike":
            //            Strike(int.Parse(tokens[1]), int.Parse(tokens[1]), target);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine(string.Join("|",target));

            //zada4i izpit 26.06.2022
            //zada4a 1
            //double budget = double.Parse(Console.ReadLine());
            //int students = int.Parse(Console.ReadLine());
            //float pricePackageOfFlour = float.Parse(Console.ReadLine());
            //float priceSingleEggs = float.Parse(Console.ReadLine());
            //float priceSingleApron = float.Parse(Console.ReadLine());
            //double result = 0;
            //double result1 = 0;
            //double result2 = 0;
            //double resultCom = 0;
            //double meb = 0;
            //int freePackages = 0;
            //if (students / 5 >= 0)
            //{
            //    freePackages = students / 5;
            //}
            //meb = students * 20 / 100.0;
            //if (meb > 0 && meb < 0.5)
            //{
            //    meb += 0.3;
            //}
            //result = Math.Round(students + meb) * priceSingleApron;
            //result1 = priceSingleEggs * 10 * students;
            //result2 = pricePackageOfFlour * (students - freePackages);
            //resultCom = result + result1 + result2;
            //if (resultCom < budget)
            //{
            //    Console.WriteLine($"Items purchased for {resultCom:f2}$.");
            //}
            //else
            //{
            //    Console.WriteLine($"{Math.Abs(budget - resultCom):f2}$ more needed.");
            //}

            //zada4a 2 nedovar6ena
            //char[] forSplit = new char[] { '|','|' };           
            //List<string> list2 = Console.ReadLine().Split(forSplit).ToList();
            //int amountOfFuel=0;
            //int amountOfmun=0;
            //for (int i = 0; i < list2.Count; i++)
            //{
            //    if (i%2!=0)
            //    {
            //        continue;
            //    }
            //    string str = list2[i];
            //    int str1 =int.Parse( list2[i+1]);
            //    if (str=="Travel")
            //    {
            //        if (amountOfFuel>str1)
            //        {
            //            amountOfFuel -= str1;
            //            Console.WriteLine($"The spaceship travelled {str1} light-years.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Mission failed.");
            //            return;
            //        }

            //    }
            //    else if (str=="Enemy")
            //    {
            //        if (amountOfmun>=str1)
            //        {
            //            Console.WriteLine($"An enemy with {str1} armour is defeated.");
            //        }
            //    }

            // }

            //zada4a 3
            //List<string> list = new List<string>();
            //string command = "";
            //while (true)
            //{
            //    command = Console.ReadLine();
            //    if (command == "end")
            //    {
            //        break;
            //    }
            //    string[] spl = command.Split().ToArray();
            //    if (spl[0] == "Chat")
            //    {
            //        list.Add(spl[1]);
            //    }
            //    else if (spl[0] == "Delete")
            //    {
            //        DeleteMet(list, spl[1]);
            //    }
            //    else if (spl[0] == "Edit")
            //    {
            //        EditMet(list, spl[1], spl[2]);
            //    }
            //    else if (spl[0] == "Pin")
            //    {
            //        PinMet(list, spl[1]);
            //    }
            //    else if (spl[0] == "Spam")
            //    {
            //        SpamMet(list, command);
            //    }

            //}
            //for (int i = 0; i <= list.Count - 1; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}


            //4AST VTORA sled parvia izpit 
            //zada4a 1 Randomize words
            //string[] words = Console.ReadLine().Split(' ');
            //Random random1 = new Random();           
            //for (int i = 0; i < words.Length; i++)
            //{
            //    int randomIdex = random1.Next(0, words.Length);
            //    string currentWord = words[i];
            //    words[i] = words[randomIdex];
            //    words[randomIdex] = currentWord;
            //}
            //foreach (string word in words)
            //{
            //    Console.WriteLine(word);
            //}

            //zada4a 2 Big Factorial
            //int number=int.Parse(Console.ReadLine());
            //BigInteger result = 1;
            //for (int i = 2; i <=number; i++)
            //{
            //    result *=i;
            //}
            //Console.WriteLine(result);

            //zada4a 3
            //List<Song> songs = new List<Song>();
            //int numbers=int.Parse(Console.ReadLine());
            //for (int i = 0; i < numbers; i++)
            //{
            //    string[] songProperties = Console.ReadLine().Split('_').ToArray();
            //    Song song = new Song(songProperties[0], songProperties[1], songProperties[2]);
            //    songs.Add(song);
            //}
            //string typeList=Console.ReadLine();
            //if (typeList=="all")
            //{
            //    foreach (Song song in songs)
            //    {
            //        Console.WriteLine(song.Name);
            //    }
            //}
            //else
            //{
            //    foreach (Song song in songs)
            //    {
            //        if (song.TypeList == typeList)
            //        {
            //        Console.WriteLine(song.Name);
            //        }
            //    }
            //}

            //zada4a 4 Students
            //List<Student1> students = new List<Student1>();
            //while (true)
            //{
            //    string command = Console.ReadLine();
            //    if (command == "end")
            //    {
            //        break;
            //    }
            //    string[] studentsProps=command.Split(' ');
            //    Student1 student = new Student1
            //    {
            //        FirstName = studentsProps[0],
            //        LastName = studentsProps[1],
            //        Age =int.Parse(studentsProps[2]),
            //        HomeTown=studentsProps[3],
            //    };
            //    students.Add(student);
            //}
            //string cityName = Console.ReadLine();
            //foreach (Student1 student in students)
            //{
            //    if (student.HomeTown==cityName)
            //    {
            //    Console.WriteLine($"{student.FirstName } {student.LastName} is {student.Age} years old.");
            //    }
            //}

            //zada4a 5 Students 2.0
            //List<Student> students = new List<Student>();
            //while (true)
            //{
            //    string command = Console.ReadLine();
            //    if (command == "end")
            //    {
            //        break;
            //    }
            //    string[] tokens = command.Split(' ');
            //    string firstName = tokens[0];
            //    string lastName = tokens[1];
            //    int age = int.Parse(tokens[2]);
            //    string town = tokens[3];
            //    if (IsStudentExisting(students, firstName, lastName))
            //    {
            //        Student student = GetStudent(students, firstName, lastName);
            //        student.FirstName = firstName;
            //        student.LastName = lastName; student.Age = age;
            //        student.HomeTown = town;
            //    }
            //    else
            //    {
            //        Student student = new Student()
            //        {
            //            FirstName = firstName,
            //            LastName = lastName,
            //            Age = age,
            //            HomeTown = town
            //        };
            //        students.Add(student);
            //    }
            //}
            //string cityName = Console.ReadLine();
            //List<Student> students2 = students.Where(std => std.HomeTown == cityName).ToList();
            //foreach (Student stud in students2)
            //{
            //    Console.WriteLine($"{stud.FirstName} {stud.LastName} is {stud.Age} years old.");
            //}

            //zada4a 6 Store Boxes
            //List<Box> boxes = new List<Box>();
            //while (true)
            //{
            //    string command = Console.ReadLine();
            //    if (command=="end")
            //    {
            //        break;
            //    }
            //    string[] tokens=command.Split(' ');
            //    Box box = new Box
            //    {
            //        SerialNumber= tokens[0],
            //        Item=new Item(tokens[1], decimal.Parse(tokens[3])),
            //      ItemQuantity=int.Parse(tokens[2]),
            //    };
            //    boxes.Add(box);
            //}
            //List<Box> orderedBoxex = boxes.OrderByDescending(box=>box.Price).ToList();
            //foreach (Box box in orderedBoxex)
            //{
            //    Console.WriteLine(box.SerialNumber);
            //    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
            //    Console.WriteLine($"-- ${box.Price:f2}");
            //}
            //zada4a 7 Vehicle
            //Catalogue catalogue = new Catalogue();
            //while (true)
            //{
            //    string command = Console.ReadLine();
            //    if (command == "end")
            //    {
            //        break;
            //    }
            //    string[] tokens=command.Split('/');
            //    string type=tokens[0];
            //    switch (type)
            //    {
            //        case "Car":
            //            Car car = new Car
            //            {
            //                Brand = tokens[1],
            //                Model = tokens[2],
            //                HorsePower = int.Parse(tokens[3])
            //            };
            //            catalogue.Cars.Add(car);
                        
            //            break;
            //        case "Truck":
            //            Truck truck = new Truck
            //            {
            //                Brand = tokens[1],
            //                Model = tokens[2],
            //                Weight = int.Parse(tokens[3])
            //            };
            //            catalogue.Trucks.Add(truck);
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //if (catalogue.Cars.Count>0)
            //{
            //    List<Car> orderedCars = catalogue.Cars.OrderBy(c => c.Brand).ToList();
            //    Console.WriteLine("Cars:");
            //    foreach (var car in orderedCars)
            //    {
            //        Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            //    }
            //}
            //if (catalogue.Trucks.Count > 0)
            //{
            //    List<Truck> orderedTrucks = catalogue.Trucks.OrderBy(c => c.Brand).ToList();
            //    Console.WriteLine("Trucks:");
            //    foreach (var truck in orderedTrucks)
            //    {
            //        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            //    }
            //}




        }

















        //metodi za zada4ite za izpit zada4a 3
        //static void SpamMet(List<string> list, string command)
        //{

        //    string[] spl2 = command.Split().ToArray();
        //    for (int i = 1; i < spl2.Length; i++)
        //    {
        //        list.Add(spl2[i]);
        //    }
        //    return;
        //}

        //static void PinMet(List<string> list, string message)
        //{
        //    int coun = list.Count;
        //    for (int i = 0; i < coun; i++)
        //    {
        //        if (list[i] == message)
        //        {
        //            list.RemoveAt(i);
        //            list.Add(message);

        //        }
        //    }
        //    return;
        //}

        //static void EditMet(List<string> list, string message, string editmessage)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i] == message)
        //        {
        //            list.RemoveAt(i);
        //            list.Insert(i, editmessage);

        //        }
        //    }
        //    return;
        //}

        //static void DeleteMet(List<string> list, string message)
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i] == message)
        //        {
        //            list.RemoveAt(i);
        //        }
        //    }
        //    return;
        //}


        //zada4a 5 Students 2.0 ot Objects
        //static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        //{
        //    foreach (Student stud in students)
        //    {
        //        if (stud.FirstName == firstName && stud.LastName == lastName)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //static Student GetStudent(List<Student> students, string firstName, string lastName)
        //{
        //    Student existingStudent = null;
        //    foreach (Student stud in students)
        //    {
        //        if (stud.FirstName == firstName && stud.LastName == lastName)
        //        {
        //            existingStudent = stud;
        //        }
        //    }
        //    return existingStudent;
        //}































    }



    //internal struct NewStruct
    //{
    //    public object Item1;
    //    public object Item2;

    //    public NewStruct(object item1, object item2)
    //    {
    //        Item1 = item1;
    //        Item2 = item2;
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        return obj is NewStruct other &&
    //               EqualityComparer<object>.Default.Equals(Item1, other.Item1) &&
    //               EqualityComparer<object>.Default.Equals(Item2, other.Item2);
    //    }

    //    public override int GetHashCode()
    //    {
    //        int hashCode = -1030903623;
    //        hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Item1);
    //        hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Item2);
    //        return hashCode;
    //    }

    //    public void Deconstruct(out object item1, out object item2)
    //    {
    //        item1 = Item1;
    //        item2 = Item2;
    //    }

    //    public static implicit operator (object, object)(NewStruct value)
    //    {
    //        return (value.Item1, value.Item2);
    //    }

    //    public static implicit operator NewStruct((object, object) value)
    //    {
    //        return new NewStruct(value.Item1, value.Item2);
    //    }
    //}

    //static void Shoot(int index, int power, List<int> target)
    //{
    //    if (index<0 || index>target.Count-1)
    //    {
    //        return;
    //    }
    //    target[index] -= power;
    //    if (target[index]<=0)
    //    {
    //        target.RemoveAt(index);
    //    }
    //}
    //static void Add(int index, int value, List<int> target)
    //{
    //    if (index < 0 || index > target.Count - 1)
    //    {
    //        Console.WriteLine("Invalid placement");
    //        return;
    //    }
    //    target.Insert(index,value);

    //}
    //static void Strike(int index, int radius, List<int> target)
    //{
    //    if (index < 0 || index > target.Count - 1 || index-radius<0 || index+radius>target.Count-1)
    //    {
    //        Console.WriteLine("Strike missed!");
    //        return;
    //    }
    //    target.RemoveRange(index-radius,radius*2+1);

    //}

    //zada4a 7 Arrays

    //static int GetSum(List<int> numbers)
    //{
    //    int sum = 0;
    //    foreach (int number in numbers)
    //    {
    //        sum += number;
    //    }
    //    return sum;
    //}

    //static void PrintEven(List<int> numbers)
    //{
    //    foreach (int number in numbers)
    //    {
    //        if (number % 2 == 0)
    //        {
    //            Console.Write($"{number} ");
    //        }
    //    }
    //}
    //static void PrintOdd(List<int> numbers)
    //{
    //    foreach (int number in numbers)
    //    {
    //        if (number % 2 != 0)
    //        {
    //            Console.Write($"{number} ");
    //        }
    //    }
    //}

    //static void CheckContains(int number, List<int> numbers)
    //{
    //    if (numbers.Contains(number))
    //    {
    //        Console.WriteLine("Yes");
    //    }
    //    else
    //    {
    //        Console.WriteLine("No such number");
    //    }
    //}
    //static void PrintFiltered(string filter, int numberToFilter, List<int> numbers)
    //{
    //    switch (filter)
    //    {
    //        case "<":
    //            foreach (var number in numbers)
    //            {
    //                if (number < numberToFilter)
    //                {
    //                    Console.Write($"{number} ");
    //                }
    //            }
    //            Console.WriteLine();
    //            break;
    //        case "<=":
    //            foreach (var number in numbers)
    //            {
    //                if (number <= numberToFilter)
    //                {
    //                    Console.Write($"{number} ");
    //                }
    //            }
    //            Console.WriteLine();
    //            break;
    //        case ">":
    //            foreach (var number in numbers)
    //            {
    //                if (number > numberToFilter)
    //                {
    //                    Console.Write($"{number} ");
    //                }
    //            }
    //            Console.WriteLine();
    //            break;
    //        case ">=":
    //            foreach (var number in numbers)
    //            {
    //                if (number >= numberToFilter)
    //                {
    //                    Console.Write($"{number} ");
    //                }
    //            }
    //            Console.WriteLine();
    //            break;
    //        default:
    //            break;
    //    }
    //}



    // Yrok ot 08.06.2022
    //zada4a 4 Triangle
    //static void PrintLine(int start, int end)
    //{
    //    for (int i = start; i <= end; i++)
    //    {
    //        Console.Write($"{i} ");
    //    }
    //    Console.WriteLine();
    //}
    //zada4a 2
    //static void PrintGradeWithWord(double grade)
    //{
    //    if (grade>=2 && grade<=2.99)
    //    {
    //        Console.WriteLine("Fail");
    //    }
    //    else if (grade>=3.00 && grade<=3.49)
    //    {
    //        Console.WriteLine("Poor");
    //    }
    //    else if (grade >= 3.50 && grade <= 4.49)
    //    {
    //        Console.WriteLine("Good");
    //    }
    //    else if (grade >= 4.50 && grade <= 5.49)
    //    {
    //        Console.WriteLine("Very good");
    //    }
    //    else if (grade >= 5.50)
    //    {
    //        Console.WriteLine("Excellent");
    //    }
    //}
    // za zada4a 1
    //static void PrintSign(int number)
    //{
    //    if (number > 0)
    //    {
    //        Console.WriteLine($"The number {number} is positive.");
    //    }
    //    else if (number < 0)
    //    {

    //        Console.WriteLine($"The number {number} is negative.");
    //    }
    //    else
    //    {
    //        Console.WriteLine($"The number {number} is zero.");
    //    }
    //}
    //zada4a 6
    //static double CalculateArea(double width,double height)
    //{
    //    double area = width*height;
    //    return area;
    //}

    //zada4a 7
    //static string RepeatString(string input,int times)
    //{
    //    string result=string.Empty;
    //    for (int i = 0; i < times; i++)
    //    {
    //        result = result + input;
    //    }
    //    return result;
    //}

    //zada4a 8
    //static double MathPower(double basa,int power)
    //{
    //    double result = 1;
    //    for (int i = 0; i < power; i++)
    //    {
    //        result *= basa;
    //    }
    //    return result;
    //}

    //zada4a 9
    //static int GetMax(int first,int second)
    //{
    //    if (first>second)
    //    {
    //        return first;
    //    }
    //    return second;
    //}
    //static char GetMax(char first, char second)
    //{
    //    if (first > second)
    //    {
    //        return first;
    //    }
    //    return second;
    //}
    //static string GetMax(string first, string second)
    //{
    //    int result=first.CompareTo(second);
    //    if (result > 0)
    //    {
    //        return first;
    //    }
    //    return second;
    //}
    //zada4a 10
    //static int GetSumOfEvenDigits(int number)
    //{
    //    int sum = 0;
    //    int digits = number;
    //    while (digits>0)
    //    {
    //        int currentDigit = digits % 10;
    //        if (currentDigit%2==0)
    //        {
    //            sum += currentDigit;
    //        }
    //        digits =digits/10;

    //    }
    //    return sum;
    //}
    //static int GetSumOfOddDigits(int number)
    //{
    //    int sum = 0;
    //    int digits = number;
    //    while (digits > 0)
    //    {
    //        int currentDigit = digits % 10;
    //        if (currentDigit % 2 != 0)
    //        {
    //            sum += currentDigit;
    //        }
    //        digits=digits/10;

    //    }
    //    return sum;
    //}
    //static int GetMultipleOfEvenAndOdds(int evenSum,int oddSum)
    //{
    //    return evenSum * oddSum;
    //}

    //zada4a 3 
    //private static void Multiply(int a, int b)
    //{
    //    Console.WriteLine(a * b);
    //}
    //private static void Divide(int a, int b)
    //{
    //    Console.WriteLine(a / b);
    //}
    //private static void Add(int a, int b)
    //{
    //    Console.WriteLine(a + b);
    //}
    //private static void Subtract(int a, int b)
    //{
    //    Console.WriteLine(a - b);
    //}

    //zada4a 11
    //private static double Calculate(int a, string @operator, int b)
    //{
    //    double result = 0;
    //    switch (@operator)
    //    {
    //        case "/":
    //            result = a / b;
    //            break;
    //        case "*":
    //            result = a * b;
    //            break;
    //        case "+":
    //            result = a + b;
    //            break;
    //        case "-":
    //            result = a - b;
    //            break;
    //        default:
    //            break;
    //    }
    //    return result;
    //}

    //Ypraznenie 10.06.2022
    //zada4a 1
    //static int SmallestNumber(int num1,int num2,int num3)
    //{
    //    return Math.Min(num1,Math.Min(num2,num3));
    //}

    //zada4a 2
    //private static void SearchForVowels(string text)
    //{
    //    Console.WriteLine(text.Count(vowles=>"aouei".Contains(vowles)));
    //}

    //zada4a 3
    //private static void CharsInRange(char firstChar, char secondChar)
    //{
    //    int startChar = Math.Min(firstChar, secondChar);
    //    int endChar = Math.Max(firstChar, secondChar);

    //    for (int i = startChar+1; i < endChar; i++)
    //    {
    //        Console.Write((char)i+" ");
    //    }
    //}

    //zada4a 4
    //private static bool ValidatePasswordLenght(string password)
    //{
    //    return password.Length >= 6 && password.Length <= 10;
    //}
    //private static bool ValidatePasswordText(string password)
    //{
    //    foreach (char symbol in password)
    //    {
    //        if (!char.IsLetterOrDigit(symbol))
    //        {
    //            return false;
    //        }
    //    }
    //    return true;
    //}
    //private static bool ValidatePasswordDigit(string password)
    //{
    //    int count = 0;
    //    foreach (char symbol in password)
    //    {
    //        if (char.IsDigit(symbol))
    //        {
    //            count++;
    //        }
    //    }
    //    return count >= 2;
    //}


    //zada4a 5
    //private static int Add(int num1, int num2) => num1 + num2;

    //private static int Substract(int result, int num3) => result - num3;
    //private static void PrintResult(int sub) => Console.WriteLine(sub);

    //zada4 6
    //private static void PrintMiddleCharscters(string word)
    //{
    //    if (word.Length % 2 == 0)
    //    {
    //        Console.Write(word[word.Length / 2 - 1]);
    //        Console.WriteLine(word[word.Length / 2]);
    //    }
    //    else
    //    {
    //        Console.WriteLine(word[word.Length / 2]);
    //    }
    //}

    //zada4a 7
    //private static void MatrixCreator(int input)
    //{
    //    for (int i = 0; i < input; i++)
    //    {
    //        for (int k = 0; k < input; k++)
    //        {
    //            Console.Write(input + " ");
    //        }
    //        Console.WriteLine();
    //    }
    //    Console.WriteLine();
    //}

    //zada4a 8
    //private static double Factoriel(int firstNum)
    //{
    //    double result = 1;
    //    while (firstNum != 1)
    //    {
    //        result *= firstNum;
    //        firstNum--;
    //    }
    //    return result;
    //}

    //zada4a 9
    //private static bool   isNumberPalindrome(string input)
    //   {
    //       int number=int.Parse(input);
    //       if (number>=0 && number<=9)
    //       {
    //           return true;
    //       }
    //       for (int i = 0; i < input.Length/2; i++)
    //       {
    //           if (input[i] == input[input.Length-1])
    //           {
    //               return true;
    //           }
    //       }
    //       return false;
    //   }

    //zada4a 10
    //static void PrintTopNumbers(int number)
    //{
    //    for (int i = 8; i <= number; i++)
    //    {
    //        int sum = 0;
    //        int digits = i;
    //        bool oddDigit = false;
    //        while (digits > 0)
    //        {
    //            int currentDigit = digits % 10;
    //            if (currentDigit % 2 != 0)
    //            {
    //                oddDigit = true;
    //            }
    //            sum = sum + currentDigit;
    //            digits = digits / 10;
    //        }
    //        if (sum % 8 == 0 && oddDigit == true)
    //        {
    //            Console.WriteLine(i);
    //        }
    //    }
    //}

    //zada4a 11
    //private static void FindNumbers(int[] arr, string position, int numbersCount, string evenOdd)
    //{
    //    if (numbersCount > arr.Length)
    //    {
    //        Console.WriteLine("Invalid count");
    //        return;
    //    }
    //    if (numbersCount == 0)
    //    {
    //        Console.WriteLine($"[]");
    //        return;
    //    }
    //    int resultEvenOdd = 1;
    //    if (evenOdd == "even") resultEvenOdd = 0;
    //    int count = 0;
    //    List<int> nums = new List<int>();
    //    if (position == "first")
    //    {
    //        foreach (int num in arr)
    //        {
    //            if (num % 2 == resultEvenOdd)
    //            {
    //                count++;
    //                nums.Add(num);
    //            }
    //            if (count == numbersCount) break;

    //        }
    //    }
    //    else
    //    {
    //        for (int currIndex = arr.Length - 1; currIndex >= 0; currIndex--)
    //        {
    //            if (arr[currIndex] % 2 == resultEvenOdd)
    //            {
    //                count++;
    //                nums.Add(arr[currIndex]);
    //            }
    //            if (count == numbersCount) break;
    //        }
    //        nums.Reverse();
    //    }
    //    Console.WriteLine($"[{string.Join(", ", nums)}]");
    //}

    //private static void FindMinMax(int[] arr, string minOrMax, string evenOrOdd)
    //{
    //    int index = -1;
    //    int min = int.MaxValue;
    //    int max = int.MinValue;
    //    int resultOddEven = 1;
    //    if (evenOrOdd == "even") resultOddEven = 0;
    //    for (int currIndex = 0; currIndex < arr.Length; currIndex++)
    //    {
    //        if (arr[currIndex] % 2 == resultOddEven)
    //        {
    //            if (minOrMax == "min" && min >= arr[currIndex])
    //            {
    //                min = arr[currIndex];
    //                index = currIndex;
    //            }
    //            else if (minOrMax == "max" && max <= arr[currIndex])
    //            {
    //                max = arr[currIndex];
    //                index = currIndex;
    //            }
    //        }
    //    }
    //    Console.WriteLine(index > -1 ? index.ToString() : "No matches");

    //}

    //private static int[] ExchangeArr(int[] arr, int splitIndex)
    //{
    //    if (splitIndex >= arr.Length || splitIndex < 0)
    //    {
    //        Console.WriteLine("Invalid index");
    //        return arr;
    //    }
    //    int[] exchangedArray = new int[arr.Length];
    //    int index = 0;
    //    for (int i = splitIndex + 1; i < arr.Length; i++)
    //    {
    //        exchangedArray[index] = arr[i];
    //        index++;
    //    }
    //    for (int i = 0; i <= splitIndex; i++)
    //    {
    //        exchangedArray[index] = arr[i];
    //        index++;
    //    }
    //    return exchangedArray;
    //}


    // 17.06.2022 Ypraznenie List
    //zada4a 1
    //private static void FindWagon(List<int> wagons, int maxCapacity, int passengers)
    //{
    //    for (int i = 0; i < wagons.Count; i++)
    //    {
    //        int currentWagon = wagons[i];
    //        if (currentWagon + passengers <= maxCapacity)
    //        {
    //            wagons[i] += passengers;
    //            break;
    //        }
    //    }
    //}

    //zada4a 5 Bomb Numbers
    //private static void BombNumber(List<int> numbers, int power, int index)
    //{
    //    int start = Math.Max(0, index - power);
    //    int end = Math.Min(numbers.Count - 1, index + power);
    //    for (int i = start; i <= end; i++)
    //    {
    //        numbers[i] = 0;
    //    }
    //}


    //4AST VTORA sled parvia izpit 
    //zada4a 3
    //class Song
    //{
    //    public Song(string typeList, string name, string time)
    //    {
    //       this. TypeList = typeList;
    //       this. Name = name;
    //       this. Time = time;
    //    }

    //    public string TypeList { get; set; }
    //    public string Name { get; set; }
    //    public string Time { get; set; }
    //}
    //zada4a 4 Students 
    //internal class Student1
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int Age { get; set; }
    //    public string HomeTown { get; set; }
    //}
    //zada4a 5 Students 2.0
    //class Student
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int Age { get; set; }
    //    public string HomeTown { get; set; }
    //}

    //zada4a 6 Store Boxes
    //class Item
    //{
    //    public Item(string name, decimal price)
    //    {
    //        Name = name;
    //        Price = price;
    //    }

    //    public string Name { get; set; }
    //    public decimal Price { get; set; }
    //}
    //class Box
    //{
    //    public string SerialNumber { get; set; }
    //    public Item Item { get; set; }
    //    public int ItemQuantity { get; set; }
    //    public decimal Price { get
    //        {
    //            return this.ItemQuantity*this.Item.Price;
    //        }
    //    }
    //}
    //zada4a 7
    //class Car
    //{
    //    public string Brand { get; set; }
    //    public string Model { get; set; }
    //    public int HorsePower { get; set; }
    //}
    //class Truck
    //{
    //    public string Brand { get; set; }
    //    public string Model { get; set; }
    //    public int Weight { get; set; }
    //}
    //class Catalogue
    //{
    //    public Catalogue  ()
    //        {
    //        this.Cars = new List<Car> ();
    //        this.Trucks = new List<Truck> ();
    //        }
    //   public List<Truck> Trucks { get; set; }
    //  public  List<Car> Cars { get; set; }
    //}







}


