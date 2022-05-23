using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
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




        }
    }
}

