using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is program....
            //int age = 25;
            //Double b = 10.09;
            //string name = "Ivan";
            //string surname = "Ivanov";
            //double height = 1.80;
            //string phoneNumber = "08888888";
            ////          Console.WriteLine($"{a}+{b}={sum}");  Interpolacia
            //Console.WriteLine($"Name:{name}");
            //Console.WriteLine($"Surname:{surname}");
            //Console.WriteLine($"Age:{age}");
            //Console.WriteLine($"Height:{height:f2}cm");
            //Console.WriteLine($"Phone:{phoneNumber}");

            //1,2,5,8-10=>int
            //2.5,3.6-8.7,1,2,5 =>double
            //hello, softuni..."text/string" =>string
            //c,a,b,g....'a' => char

            //zada4a 1
            //double usd = double.Parse(Console.ReadLine());
            //double bgn = usd * 1.79549;
            //Console.WriteLine(bgn);

            //zada4a 2
            //   double radians = double.Parse(Console.ReadLine());
            //   double degrees = (radians * 180) / Math.PI;
            //   Console.WriteLine(degrees);

            //zada4a 5
            //int pensCount = int.Parse(Console.ReadLine());
            //int marcersCount = int.Parse(Console.ReadLine());
            //int preparationCount = int.Parse(Console.ReadLine());
            //int percent = int.Parse(Console.ReadLine());
            //double pensPrice = pensCount * 5.80;
            //double markersPrice = marcersCount * 7.20;
            //double preparationPrice = preparationCount * 1.20;
            //double sum = pensPrice + preparationPrice + markersPrice;
            //double totalSum = sum - sum * (percent / 100.0);
            //Console.WriteLine(totalSum);

            //zada4a 8

            //double taxPerYear = double.Parse(Console.ReadLine());
            //double shouesPrice = taxPerYear - taxPerYear * (40 / 100.0);
            //double outfitPrice = shouesPrice - shouesPrice * (20 / 100.0);
            //double ballPrice = outfitPrice / 4;
            //double accPrice = ballPrice / 5;
            //double sum = taxPerYear + shouesPrice + outfitPrice + ballPrice+accPrice;
            //Console.WriteLine(sum);

            //zada4a 9

            //int lenght = int.Parse(Console.ReadLine());
            //int width = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());
            //double perent = double.Parse(Console.ReadLine());
            //double volume = lenght * width * height;
            //double volumeInLiters = volume / 1000;
            //double busy = perent / 100;
            //double litters = volumeInLiters * (1 - busy);
            //Console.WriteLine(litters);

            //zada4a 6
            //int nailon = int.Parse(Console.ReadLine());
            //int boia = int.Parse(Console.ReadLine());
            //int razreditel = int.Parse(Console.ReadLine());
            //int chasove = int.Parse(Console.ReadLine());
            //double sumNailon = (nailon + 2) * 1.50;
            //double sumBoia = (boia + (boia * 10 / 100.0)) * 14.50;
            //double sumRazreditel = razreditel * 5.00;
            //double sum = sumNailon + sumBoia + sumRazreditel + 0.40;
            //double sumMaistori = (sum * 30 / 100) * 8;
            //double endSum = sum + sumMaistori;
            //Console.WriteLine(endSum);
            //zada4a 7
            //int chikenMenu = int.Parse(Console.ReadLine());
            //int fishMenu = int.Parse(Console.ReadLine());
            //int vegMenu = int.Parse(Console.ReadLine());
            //double priceChik = chikenMenu * 10.35;
            //double priceFish = fishMenu * 12.40;
            //double priceVeg = vegMenu * 8.15;
            //double priceMenus = priceChik + priceFish + priceVeg;
            //double priceDes = priceMenus * 20 / 100;
            //double sum = priceMenus + priceDes + 2.50;
            //Console.WriteLine(sum);

            //KURS 15/01/2022
            //01.Excellent result

            //  Console.WriteLine(5<=6);
            //  Console.WriteLine("softuni"!="Softuni");
            //   int age = int.Parse(Console.ReadLine());
            // bool isOfAge = age >= 18;
            //Console.WriteLine(isOfAge);
            //int a = 5;
            //bool isPositive = a > 0;

            //if (isPositive)
            //{
            //    Console.WriteLine("The number is positive");
            //}
            //int age = 39;
            //if (age >= 18)
            //{
            //    Console.WriteLine("You can drink beer");
            //}

            //double grade = double.Parse(Console.ReadLine());
            //if (grade >= 5.50)
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else
            //{
            //    Console.WriteLine("Try again!");
            //}
            //zada4a 2
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //if (num1 > num2)
            //{
            //    Console.WriteLine(num1);
            //}
            //else
            //{
            //    Console.WriteLine(num2);
            //}

            //
            //double num = 5.689040;
            //Console.WriteLine($"{num:f4}");
            //Console.WriteLine($"{Math.Round(num, 4)}");///propusca nulata sled zakraglenieto

            //skorost
            //sedma
            //    double area = 0;
            //    string figure = Console.ReadLine();
            //    if (figure == "square")
            //    {
            //        double a = double.Parse(Console.ReadLine());
            //        area = a * a;

            //    }
            //    else if (figure == "rectngle")
            //    {
            //        double a = double.Parse(Console.ReadLine());
            //        double b = double.Parse(Console.ReadLine());
            //        area = a * b;

            //    }
            //    else if (figure == "circle")
            //    {
            //        double a = double.Parse(Console.ReadLine());
            //        area = a * a * Math.PI;

            //    }
            //    else if (figure == "triangle")
            //    {
            //        double a = double.Parse(Console.ReadLine());
            //        double ha = double.Parse(Console.ReadLine());
            //        area = a * ha / 2;

            //    }
            //    Console.WriteLine($"{area:f3}");


            //16.01.22 kurs
            //Sumirane na secundi
            //int first = int.Parse(Console.ReadLine());
            //int second = int.Parse(Console.ReadLine());
            //int third = int.Parse(Console.ReadLine());
            //int time = first + second + third;//v secundi 150 sek=> 2 min i 30 sec maximum
            //int min = time / 60;//150/60=2 min
            //int sec = time % 60;//150:60=2 (30)
            //if (sec < 10)
            //{
            //    Console.WriteLine($"{min}:0{sec}");
            //}
            //else
            //{
            //    Console.WriteLine($"{min}:{sec}");
            //}
            //Bonus to4ki
            //int num = int.Parse(Console.ReadLine());
            //double bonus = 0;
            //if (num <= 100)//znaem 4e e po-malko ot 100
            //{
            //    bonus = 5;
            //}
            //else if (num>1000)//znaem 4e e po goliamo ot 1000
            //{
            //    bonus = num * (10 / 100.0);
            //}
            //else
            //{//tuk e mezdy 100 i hiliada
            //    bonus = num * 0.2;
            //}
            //if (num % 2 == 0)
            //{
            //    bonus = bonus + 1;//bonus+=1;
            //}
            ////142,14,6844 samo poslednata cifra kato delim na deset i stava 14(2), 1(4), 684(4)
            ////142/10 =>14; 142%10 =>2
            //if (num % 10 == 5)
            //{
            //    bonus = bonus + 2;//bonus+=2;
            //}
            //Console.WriteLine(bonus);
            //Console.WriteLine(num+bonus);

            //Vreme +15min
            //int h = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //int timeInMin= m + h * 60;//30+1*60=9min
            //timeInMin += 15;//9+15=105min

            //h = timeInMin / 60;//106/60=1(45)
            //m = timeInMin % 60;//105%60=45
            //if (h == 24)
            //{
            //    h = 0;//h = h - 24;
            //}
            //if (m < 10)
            //{
            //    Console.WriteLine($"{h}:0{m}");
            //}
            //else
            //{
            //    Console.WriteLine($"{h}:{m}");
            //}

            //zada4a 4 Toy Shop
            //double tripPrice = double.Parse(Console.ReadLine());
            //int puzzleQuantity = int.Parse(Console.ReadLine());
            //int dollsQuantity = int.Parse(Console.ReadLine());
            //int bearsQuantity = int.Parse(Console.ReadLine());
            //int minionsQuantity = int.Parse(Console.ReadLine());
            //int truckQuantity = int.Parse(Console.ReadLine());

            //int toysQuantity = puzzleQuantity + dollsQuantity + bearsQuantity + minionsQuantity + truckQuantity;


            //double totalPrice = puzzleQuantity*2.6 + dollsQuantity*3 + bearsQuantity*4.1 + minionsQuantity*8.2 + truckQuantity*2;

            //if (toysQuantity >= 50)
            //{
            //    totalPrice = totalPrice - totalPrice * 0.25;
            //}
            //totalPrice = totalPrice - totalPrice * 0.1;

            //if (totalPrice >= tripPrice)
            //{
            //    Console.WriteLine($"Yes! {(totalPrice-tripPrice):F2} lv left");
            //}
            //else
            //{
            //    Console.WriteLine($"Not enough money {(tripPrice - totalPrice):F2} lv needed");
            //}

            //zada4a 7 Shopping
            //double budget = double.Parse(Console.ReadLine());
            //int videocardQauntity = int.Parse(Console.ReadLine());
            //int processorQauntity = int.Parse(Console.ReadLine());
            //int ramQauntity = int.Parse(Console.ReadLine());

            //double videocardPrice = videocardQauntity * 250;
            //double procesorPrice = processorQauntity * (videocardPrice * 0.35);
            //double ramPrice = ramQauntity * (videocardPrice * 0.1);
            //double totalPrice = videocardPrice + procesorPrice + ramPrice;
            //if (videocardQauntity > processorQauntity)
            //{
            //    totalPrice = totalPrice - (totalPrice * 0.15);
            //}
            //double difference = budget - totalPrice;
            //if (difference >= 0)
            //{
            //    Console.WriteLine($"You have {difference:F2} leva left!");
            //}
            //else
            //{
            //    Console.WriteLine($"Not enough money! You need {Math.Abs(difference):F2} leva more!");
            //}

            //namirane na procent 10% ot 40 =>40*(10/100) drug na4in  40*0.1

            //zada4a 8 Obedna po4ivka

            //wreme za obedna po4ivka =8/8
            //1/8=za obiad
            //1/4=za otdih =2/8
            //1/8+2/8=3/8 sa zaeti
            //8/8-3/8= za seriala imame 5/8 ot obedna si po4ivka
            //string seriesName = Console.ReadLine();
            //int seriesTime = int.Parse(Console.ReadLine());
            //int lunchBreakTime = int.Parse(Console.ReadLine());

            //double timeForSeries = lunchBreakTime * 5.0 / 8;
            //if (timeForSeries >= seriesTime)
            //{
            //    Console.WriteLine($"You have enough time to watch {Math.Ceiling(timeForSeries - seriesTime)} minutes free time.");
            //}
            //else
            //{
            //    Console.WriteLine($"You don't have time to watch {seriesName}, you need {Math.Ceiling(seriesTime - timeForSeries)} more minutes");
            //}


            //22.01.2022   KYRS

            //Zada4a 4
            //double age = double.Parse(Console.ReadLine());
            //char gender= char.Parse(Console.ReadLine());

            //if (gender == 'f')
            //{
            //    if (age < 16)
            //    {
            //        Console.WriteLine("Miss");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ms.");
            //    }
            //}
            //else if (gender == 'm')
            //{
            //    if (age < 16)
            //    {
            //        Console.WriteLine("Master");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Mr.");
            //    }
            //}


            //magazin4e
            //1. read input
            //string item = Console.ReadLine();
            //string city = Console.ReadLine();
            //double quantity = double.Parse(Console.ReadLine());
            ////2. create a variable named price
            //double price = 0;
            ////3. Series of condition for the city
            //switch (city)
            //{
            //    case "Sofia":
            //        if (item == "coffee")
            //        {
            //            price = 0.50;
            //        }
            //        else if (item == "water")
            //        {
            //            price = 0.80;
            //        }
            //        else if (item == "beer")
            //        {
            //            price = 1.20;
            //        }
            //        else if (item == "sweets")
            //        {
            //            price = 1.45;
            //        }
            //        else if (item == "peanuts")
            //        {
            //            price = 1.60;
            //        }

            //        break;
            //    case "Plovdiv":
            //        if (item == "coffee")
            //        {
            //            price = 0.40;
            //        }
            //        else if (item == "water")
            //        {
            //            price = 0.70;
            //        }
            //        else if (item == "beer")
            //        {
            //            price = 1.17;
            //        }
            //        else if (item == "sweets")
            //        {
            //            price = 1.30;
            //        }
            //        else if (item == "peanuts")
            //        {
            //            price = 1.50;
            //        }
            //        break;
            //    case "Varna":
            //        if (item == "coffee")
            //        {
            //            price = 0.45;
            //        }
            //        else if (item == "water")
            //        {
            //            price = 0.70;
            //        }
            //        else if (item == "beer")
            //        {
            //            price = 1.20;
            //        }
            //        else if (item == "sweets")
            //        {
            //            price = 1.45;
            //        }
            //        else if (item == "peanuts")
            //        {
            //            price = 1.55;
            //        }
            //        break;
            //}
            //double totalPrice = price * quantity;
            //Console.WriteLine(quantity);

            //zada4a 11
            //string fruit = Console.ReadLine();
            //string dayOfweek = Console.ReadLine();
            // double quantity = double.Parse(Console.ReadLine());
            //double price = 0;
            //switch (dayOfweek)
            //{
            //    case "Monday":
            //    case "Tuesday":
            //    case "Thursday":
            //    case "Wednesday":
            //    case "Friday":
            //        switch (fruit)
            //        {
            //            case "banana":
            //                price = 2.50;
            //                break;
            //            case "apple":
            //                price = 1.20;
            //                    break;
            //            case "orange":
            //                price = 0.85;
            //                break;
            //            case "grapefruit":
            //                price = 1.45;
            //                break;
            //            case "kiwi":
            //                price = 2.70;
            //                break;
            //            case "pineapple":
            //                price = 5.50;
            //                break;
            //            case "grapes":
            //                price = 3.85;
            //                break;
            //            default:
            //                Console.WriteLine("error");
            //                break;
            //        }
            //        break;
            //    case "Saturday":
            //    case "Sunday":
            //        switch (fruit)
            //        {
            //            case "banana":
            //                price = 2.70;
            //                break;
            //            case "apple":
            //                price = 1.25;
            //                break;
            //            case "orange":
            //                price = 0.90;
            //                break;
            //            case "grapefruit":
            //                price = 1.60;
            //                break;
            //            case "kiwi":
            //                price = 3.00;
            //                break;
            //            case "pineapple":
            //                price = 5.60;
            //                break;
            //            case "grapes":
            //                price = 4.20;
            //                break;
            //            default:
            //                Console.WriteLine("error");
            //                break;
            //        }
            //        break;
            //    default:  
            //        Console.WriteLine("error");
            //        break;
            //}
            //double totalPrice = price * quantity;
            //if (totalPrice != 0)
            //{
            //    Console.WriteLine($"Total price {totalPrice:f2}");
            //}





            //zada4a 12

            //string city = Console.ReadLine();
            //double sales = double.Parse(Console.ReadLine());
            //double percent = 0;
            //switch (city)
            //{
            //    case "Sofia":
            //        if (sales>0 && sales <= 500)
            //        {
            //            percent = 0.05;
            //        }
            //        else if (sales>500 && sales <=1000)

            //        {
            //            percent =0.07;
            //        }
            //        else if (sales > 1000 && sales <= 10000)

            //        {
            //            percent =0.08;
            //        }
            //        else if (sales>10000)
            //        {
            //            percent = 0.12;
            //        }
            //        break;
            //    case "Varna":
            //        if (sales > 0 && sales <= 500)
            //        {
            //            percent = 0.045;
            //        }
            //        else if (sales > 500 && sales <= 1000)

            //        {
            //            percent = 0.075;
            //        }
            //        else if (sales > 1000 && sales <= 10000)

            //        {
            //            percent = 0.10;
            //        }
            //        else if (sales>10000)
            //        {
            //            percent = 0.13;
            //        }
            //        break;
            //    case "Plovdiv":
            //        if (sales > 0 && sales <= 500)
            //        {
            //            percent = 0.055;
            //        }
            //        else if (sales > 500 && sales <= 1000)

            //        {
            //            percent = 0.08;
            //        }
            //        else if (sales > 1000 && sales <= 10000)

            //        {
            //            percent = 0.12;
            //        }
            //        else if (sales>10000)
            //        {
            //            percent = 0.145;
            //        }
            //        break;

            //}
            //double commision = percent * sales;
            //if (commision > 0)
            //{
            //    Console.WriteLine($"{commision:f2}");
            //}

            //else{
            //    Console.WriteLine("error");
            //}

            //ypraznenie 23.01.2022
            //zada4a KINO

            ////4etem ot konzolata
            //string ticjetType = Console.ReadLine();
            //int row = int.Parse(Console.ReadLine());
            //int col = int.Parse(Console.ReadLine());

            ////iz4isliavame broi mesta v zalata
            //double income = row * col;
            ////proveriavame tip na biletite i zi4isliavame prihodite ot biletite
            //if (ticjetType == "Premiere")
            //{
            //    income = income * 12.00;
            //}
            //else if (ticjetType == "Normal")
            //{
            //    income = income * 7.50;
            //}
            //else
            //{
            //    income = income * 5.00;
            //}
            ////izvezdane na rezultat
            //Console.WriteLine("{0:f2} leva",income);

            //Zada4a 2 Liatno oblekolo
            //int degrees = int.Parse(Console.ReadLine());
            //string time = Console.ReadLine();
            //string outfit = "";
            //string shoes = "";

            //if (time == "Morning")
            //{
            //    if (degrees <= 18)
            //    {
            //        outfit = "Sweatshirt";
            //        shoes = "Sneakers";
            //    }
            //    else if (degrees <= 24)
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else
            //    {
            //        outfit = "T-Shirt";
            //        shoes = "Sandals";
            //    }
            //}
            //else if (time == "Afternoon")
            //{
            //    if (degrees <= 18)
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else if (degrees <= 24)
            //    {
            //        outfit = "T-Shirt";
            //        shoes = "Sandals";
            //    }
            //    else
            //    {
            //        outfit = "Swim Suit";
            //        shoes = "Barefoot";
            //    }
            //}
            //else //time-Evening
            //{
            //    if (degrees <= 18)
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else if (degrees <= 24)
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //    else
            //    {
            //        outfit = "Shirt";
            //        shoes = "Moccasins";
            //    }
            //}
            //Console.WriteLine($"It's {degrees} degrees,get your {outfit} and {shoes}.");

            //zada4a 3
            //string flowersType = Console.ReadLine();
            //int flowersQuantity = int.Parse(Console.ReadLine());
            //int budget = int.Parse(Console.ReadLine());
            //double price = 0.0;
            //if (flowersType == "Roses")
            //{
            //    price = flowersQuantity * 5.00;
            //    if (flowersQuantity > 80)
            //    {
            //        price = price - price * 0.10;
            //    }
            //}
            //else if (flowersType == "Dahlias")
            //{
            //    price = flowersQuantity * 3.80;
            //    if (flowersQuantity > 90)
            //    {
            //        price = price - price * 0.15;
            //    }
            //}
            //else if (flowersType == "Tullips")
            //{
            //    price = flowersQuantity * 2.80;
            //    if (flowersQuantity > 80)
            //    {
            //        price = price - price * 0.15;
            //    }
            //}
            //else if (flowersType == "Narcissus")
            //{
            //    price = flowersQuantity * 3;
            //    if (flowersQuantity < 120)
            //    {
            //        price = price + price * 0.15;
            //    }
            //}
            //else if (flowersType == "Gladiolus")
            //{
            //    price = flowersQuantity * 2.50;
            //    if (flowersQuantity < 80)
            //    {
            //        price = price + price * 0.2;
            //    }
            //}
            //if  (budget >= price)
            //{
            //    Console.WriteLine($"Hey, you have a great garden with {flowersQuantity} {flowersType} and {budget-price} leva left.");
            //}
            //else
            //{
            //    Console.WriteLine($"Not enough money, you need {Math.Abs(price-budget)} leva more.");
            //}





            //zada4a 4 Lodka za riblov
            //   int budget = int.Parse(Console.ReadLine());
            //   string season = Console.ReadLine();
            //   int fishmen = int.Parse(Console.ReadLine());
            //   double price = 0.0;

            //   switch (season)
            //   {
            //       case "Spring":
            //           price = 3000;
            //           break;
            //       case "Summer":                                      
            //       case "Autumn":
            //           price = 4200;
            //           break;
            //       case "Winter":
            //           price = 2600;
            //           break;
            //       default:
            //           break;
            //   }


            //if (fishmen<=6)
            //   {
            //       price = price - price * 0.1;//price-=price*0.1;
            //   }
            //else if (fishmen <= 11)
            //   {
            //       price = price - price * 0.15;//price-=price*0.15;
            //   }
            //else
            //   {
            //       price = price - price * 0.25;
            //   }

            //if (fishmen % 2 == 0 && season!="Autumn")
            //   {
            //       price -= price * 0.05;
            //   }

            //if (budget >= price)
            //   {
            //       Console.WriteLine($"Yes! You have {budget-price:f2} leva left.");
            //   }
            //else
            //   {
            //       Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            //   }

            //zada4a 6 operacii mezdy 4isla
            //int nim1 = int.Parse(Console.ReadLine());
            //int nim2 = int.Parse(Console.ReadLine());
            //char operation = char.Parse(Console.ReadLine());
            //double result = 0;

            //if (operation=='+' || operation=='-' || operation == '*')
            //{

            //    if (operation == '+')
            //    {
            //        result = nim1 + nim2;
            //    }
            //    else if (operation == '-')
            //    {
            //        result = nim1 - nim2;
            //    }
            //    else
            //    {
            //        result = nim1 * nim2;
            //    }
            //    string evenOrodd = "odd";
            //    if (result % 2 == 0)
            //    {

            //        evenOrodd = "even";
            //    }
            //    Console.WriteLine($"{nim1} {operation} {nim2}={result}-{evenOrodd}");

            //}

            //else//operation=='%' || opration='/'
            //{
            //    if (nim2 == 0)
            //    {
            //        Console.WriteLine($"Cannot divide {nim1} by zero");
            //    }
            //    else
            //    {
            //        if (operation == '/')
            //        {
            //            result = nim1 * 1.0 / nim2;
            //            Console.WriteLine($"{nim1} {operation} {nim2}={result:f2}");
            //        }
            //        else //operatio="%"
            //        {
            //            result = nim1 % nim2;
            //            Console.WriteLine($"{nim1} {operation} {nim2}={result}");
            //        }
            //    }


            //}

            //zada4a 8 Izpit

            //int examHour = int.Parse(Console.ReadLine());
            //int examMin = int.Parse(Console.ReadLine());

            //int arrivalHour = int.Parse(Console.ReadLine());
            //int arrivalMin = int.Parse(Console.ReadLine());

            //examMin = examMin + examHour * 60;
            //arrivalMin = arrivalMin + arrivalHour * 60;
            //int difference = 0;
            //int diffHour = 0;
            //int diffmin = 0;

            //if (examMin < arrivalMin)
            //{
            //    Console.WriteLine("Late");
            //    difference = arrivalMin - examMin;
            //    diffHour = difference / 60;
            //    diffmin = difference % 60;
            //    if (diffHour >= 1)
            //    {
            //        if (diffmin < 10)
            //        {
            //            Console.WriteLine($"{diffHour}:0{diffmin} hours after the start");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{diffHour}:{diffmin} hours after the start");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{diffmin} hours after the start");//da vidia kakvo e
            //    }

            //}
            //else if (examMin - arrivalMin <= 30)
            //{
            //    Console.WriteLine("On time");
            //    if (examMin != arrivalMin)
            //    {
            //        difference = examMin - arrivalMin;
            //        Console.WriteLine($"{difference} minutes before the start");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Early");
            //    difference = examMin - arrivalMin;
            //    diffHour = difference / 60;
            //    diffmin = difference % 60;
            //    if (diffHour >= 1)
            //    {
            //        if (diffmin < 10)
            //        {
            //            Console.WriteLine($"{diffHour}:0{diffmin} hours before the start");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{diffHour}:{diffmin} hours before the start");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{diffmin} hours before the start");//da vidia kakvo e
            //    }

            //}



            //zada4a ot u4ebnika izpitni zada4i 6.2 Krepost

            //var n = int.Parse(Console.ReadLine());
            //var colSize = n / 2;
            //var midSize = 2 * n - 2 * colSize - 4;
            ////  Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', colSize), new string('_', midSize));
            //Console.Write('/');
            //for (int i = 0; i < colSize; i++)
            //{
            //    Console.Write('^');
            //}
            //Console.Write('\\');
            //for (int i = 0; i < midSize; i++) //C++ na4in na pravene
            //{
            //    Console.Write('_');
            //}
            //Console.Write('/');
            //for (int i = 0; i < colSize; i++)
            //{
            //    Console.Write('^');
            //}
            //Console.WriteLine('\\');
            ////for (int i = 1; i < n - 3; i++)
            ////{
            ////    Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
            ////}
            //for (int row = 1; row < n - 3; row++)
            //{
            //    Console.Write('|');
            //    for (int em = 0; em < 2 * n - 2; em++) //C++ na4in na pravene
            //    {
            //        Console.Write(' ');
            //    }
            //    Console.WriteLine('|');
            //}
            ////  Console.WriteLine("|{0}{1}{0}|", new string(' ', colSize+1), new string('_', midSize));
            //Console.Write('|');
            //for (int i = 0; i < colSize + 1; i++)
            //{
            //    Console.Write(' ');
            //}
            //for (int i = 0; i < midSize; i++)
            //{
            //    Console.Write('_');
            //}
            //for (int i = 0; i < colSize + 1; i++)
            //{
            //    Console.Write(' ');
            //}
            //Console.WriteLine('|');
            ////  Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', colSize), new string(' ', midSize));
            //Console.Write('\\');
            //for (int i = 0; i < colSize; i++)
            //{
            //    Console.Write('_');
            //}
            //Console.Write('/');
            //for (int i = 0; i < midSize; i++)
            //{
            //    Console.Write(' ');
            //}
            //Console.Write('\\');
            //for (int i = 0; i < colSize; i++)
            //{
            //    Console.Write('_');
            //}
            //Console.WriteLine('/');


            //zada4a ot u4ebnika izpitni zada4i 6.2 Peperuda
            //var n = int.Parse(Console.ReadLine());
            //var falfRowSize = n - 2; //zvezdi4kite ot liavo i diasno sa tolkova na broi kakto i samoto krilo
            //for (int i = 1; i <= falfRowSize; i++) //razmah na ednoto krilo
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine("{0}\\ /{0}", new string('*', falfRowSize)); //za C#
            //        //for (int j = 0; j < falfRowSize; j++)
            //        //{
            //        //    Console.Write('*');
            //        //}
            //        //Console.Write("\\ /");
            //        //for (int j = 0; j < falfRowSize; j++) //Za C++ sas cikli napraveno
            //        //{
            //        //    Console.Write('*');
            //        //}
            //        //Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}\\ /{0}", new string('-', falfRowSize));
            //        //for (int j = 0; j < falfRowSize; j++)
            //        //{
            //        //    Console.Write('-');
            //        //}
            //        //Console.Write("\\ /");
            //        //for (int j = 0; j < falfRowSize; j++)  //Za C++ sas cikli napraveno
            //        //{
            //        //    Console.Write('-');
            //        //}
            //        //Console.WriteLine();
            //    }

            //}
            //Console.WriteLine("{0} @ {0}", new string(' ', falfRowSize));  //za C#
            ////for (int i = 0; i < falfRowSize; i++)//za C++
            ////{
            ////    Console.Write(' ');  //Za C++ sas cikli napraveno
            ////}
            ////Console.WriteLine(" @");
            //for (int i = 1; i <= falfRowSize; i++) //razmah na ednoto krilo
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine("{0}/ \\{0}", new string('*', falfRowSize));  //Za C#
            //        //for (int j = 0; j < falfRowSize; j++)
            //        //{
            //        //    Console.Write('*');
            //        //}
            //        //Console.Write("/ \\");
            //        //for (int j = 0; j < falfRowSize; j++)  //Za C++
            //        //{
            //        //    Console.Write('*');
            //        //}
            //        //Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}/ \\{0}", new string('-', falfRowSize));  //Za C#
            //        //for (int j = 0; j < falfRowSize; j++)
            //        //{
            //        //    Console.Write('-');
            //        //}
            //        //Console.Write("/ \\");
            //        //for (int j = 0; j < falfRowSize; j++)  //Za C++
            //        //{
            //        //    Console.Write('-');
            //        //}
            //        //Console.WriteLine();
            //    }

            //}


            //KYRS 29.01.2022

            //Zada4a N do 1 obraten red
            //  int n = int.Parse(Console.ReadLine());
            //for (int i = n; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i < n; i+=3)
            //{
            //    Console.WriteLine(i);
            //}
            //for (double i = 1; i < n; i += 3.5)
            //{
            //    Console.WriteLine(i);
            //}

            //otpe4atva 4etnite stepeni
            //for (int power = 0; power <=n; power+=2)
            //{
            //    Console.WriteLine(Math.Pow(2, power));
            //}

            // zada4a 4etene na text
            //string text = Console.ReadLine();
            //int sum = 0;
            //for (int i = 0; i < text.Length; i++)
            //{
            //    char currentSymbol = text[i];

            //    switch (currentSymbol)
            //    {
            //        case 'a':
            //            sum++;
            //            break;
            //        case 'e':
            //            sum += 2;
            //            break;
            //        case 'i':
            //            sum += 3;
            //            break;
            //        case 'o':
            //            sum += 4;
            //            break;
            //        case 'u':
            //            sum += 5;
            //            break;
            //        default:
            //            break;
            //    }

            //}
            //Console.WriteLine(sum);


            //presmiatane na 4isla
            //int n = int.Parse(Console.ReadLine());
            //int suM = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    suM += num;
            //}
            //Console.WriteLine(suM);

            ////
            //int maxNum = int.MinValue;
            //for (int i = 0; i < n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());

            //    if (num > maxNum)
            //    {
            //        maxNum = num;
            //    }

            //}
            //Console.WriteLine(maxNum);


            //YPRAZNENIA FOR cycle 30.01.2022
            //zada4a 1
            //for (int i = 7; i <= 997; i++)
            //{
            //    if (i % 10 == 7)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 7; i <= 997; i += 10)
            //{
            //    Console.WriteLine(i);
            //}

            //zada4a 2
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int maxNum = int.MinValue;
            //for (int i = 1; i <= n; i++)
            //{
            //    int num= int.Parse(Console.ReadLine());
            //    sum += num;
            //    if (num > maxNum) 
            //    {
            //        maxNum = num;
            //    }

            //}
            //sum = sum - maxNum;

            //if (sum == maxNum)
            //{
            //    Console.WriteLine("Yes");
            //    Console.WriteLine("Sum = "+ sum);
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //    Console.WriteLine("Diff = "+ Math.Abs(maxNum - sum));
            //}

            //zada4a Histograma
            //int n = int.Parse(Console.ReadLine());
            //double p1 = 0;
            //double p2 = 0;
            //double p3 = 0;
            //double p4 = 0;
            //double p5 = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());

            //    if (num <= 199)
            //    {
            //        p1++;
            //    }
            //    else if (num <= 399)
            //    {
            //        p2++;
            //    }
            //    else if (num <= 599)
            //    {
            //        p3++;
            //    }
            //    else if (num <= 799)
            //    {
            //        p4++;
            //    }
            //    else
            //    {
            //        p5++;
            //    }

            //}
            //p1 = p1 / n * 100;
            //p2 = p2 / n * 100;
            //p3 = p3 / n * 100;
            //p4 = p4 / n * 100;
            //p5 = p5 / n * 100;
            //Console.WriteLine($"{p1:f2}%");
            //Console.WriteLine($"{p2:f2}%");
            //Console.WriteLine($"{p3:f2}%");
            //Console.WriteLine($"{p4:f2}%");
            //Console.WriteLine($"{p5:f2}%");

            //zada4a Lili
            //int age = int.Parse(Console.ReadLine());
            //double washingMashine = double.Parse(Console.ReadLine());
            //int toyPrice = int.Parse(Console.ReadLine());

            //double money = 0;
            //for (int i = 1; i <= age; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        money += i * 5 - 1;
            //    }
            //   else
            //    {
            //        money += toyPrice;
            //    }

            //}
            //if (money >= washingMashine)
            //{
            //    Console.WriteLine($"Yes! {money-washingMashine:f2}");
            //}
            //     else
            //{
            //    Console.WriteLine($"No! {washingMashine-money:f2}");
            //}     

            //zada4a 5 Zaplata
            //int n = int.Parse(Console.ReadLine());
            //int salary = int.Parse(Console.ReadLine());
            //int penalty = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    string site = Console.ReadLine();
            //    if (site == "Facebook")
            //    {
            //        penalty += 150;
            //    }
            //    else if (site == "Instagram")
            //    {
            //        penalty += 100;
            //    }
            //    else if (site == "Reddit")
            //    {
            //        penalty += 50;
            //    }
            //    if (penalty >= salary)
            //    {
            //        Console.WriteLine("You have lost your salary.");
            //        break;
            //    }
            //                }
            //if (penalty < salary)
            //{
            //    Console.WriteLine(salary-penalty);
            //}

            //zad 7 kato 3

            //zada4a 6
            //string actorName = Console.ReadLine();
            //int academyPoints = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    string assesorName = Console.ReadLine();
            //    double assesorsPoints = double.Parse(Console.ReadLine());

            //    academyPoints += assesorName.Length * assesorsPoints / 2);

            //    if (academyPoints >= 1250.0)
            //    {
            //        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading");
            //        break;
            //    }

            //}

            //if (academyPoints < 1250.5)
            //{
            //    Console.WriteLine($"Sorry, {actorName} you need {1250.0-academyPoints:f2}");
            //}



            //KYRS 05.02.2022
            //zada4a 1
            //string input = Console.ReadLine();
            //while (input!="Stop")
            //{
            //    Console.WriteLine(input);
            //    input = Console.ReadLine();
            //}

            //zada4a 2
            //string username = Console.ReadLine();
            //string password = Console.ReadLine();


            //string passwordAttempt = Console.ReadLine();

            //while (passwordAttempt!=password)
            //{
            //    passwordAttempt = Console.ReadLine();

            //}
            // Console.WriteLine($"Welcome {input}");

            //zada4a 3
            //int num = int.Parse(Console.ReadLine());
            //int sum = 0;
            //while (sum < num)
            //{
            //    sum += int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(sum);

            //zada4a 5 balans na smetka
            //string input = Console.ReadLine();
            //double account = 0;

            //while (input!="NoMoreMoney")
            //{
            //    double amount = double.Parse(input);
            //    if (amount<0)
            //    {
            //        Console.WriteLine("Invalid operation!");
            //        break;
            //    }
            //    account += amount;
            //    Console.WriteLine($"Increase: {amount:f2}");
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine($"Total: {account:f2}");

            //zada4a 8
            //string name = Console.ReadLine();
            //int grade = 1;
            //double sum = 0;
            //int counter = 0;//counts the number of times the student has been excluded
            //while (grade <= 12)
            //{
            //    double yearlyGrade = double.Parse(Console.ReadLine());
            //    if (yearlyGrade < 4)//za da povtori y4enika v sa6tia klas
            //    {
            //        if (counter == 1)
            //        {
            //            break;
            //        }
            //        counter++;
            //        continue;
            //    }
            //    sum += yearlyGrade;
            //    grade++;
            //}
            //double averageGrade = sum / 12;
            //if (grade > 12)
            //{
            //    Console.WriteLine($"{name} graduated. Average grade: {averageGrade}");
            //}
            //else
            //{

            //    Console.WriteLine($"{name} has been  {averageGrade}");
            //}

            //ypraznenia 06.02.2022
            //zada4a 1


            //zapazvame knigata na Ani
            //string favorouriteBiik = Console.ReadLine();
            //int count = 0;//broia knigi cme pregledali v tarsene na lubimata
            //string input = Console.ReadLine();
            ////sazdavame cicle, v koito vseki pat 6te 4etem zaglavieto na nova kniga
            ////=>dokato ne minem prez vsi4ki knigi "NoMore Books"
            //while (input!="No More Books")//tyk ni triabva false
            //{
            //    if (input==favorouriteBiik)//tyk ni triabva true
            //    {
            //        break;
            //    }
            //    count++;
            //    input = Console.ReadLine();
            //}
            //if (input==favorouriteBiik) 
            //{
            //    Console.WriteLine($"You checked {count} books and found it.");
            //}
            //else
            //{
            //    Console.WriteLine($"The book you search is not here!");
            //    Console.WriteLine($"You checked {count} books.");
            //}

            ////zada4a 2

            //int failedTimes = int.Parse(Console.ReadLine());

            //double avaluationSum = 0;
            //double evaluationCount = 0;
            //string lastExercise = string.Empty;
            //int evaluation = 0;
            //int failedCount = 0;

            //string input = Console.ReadLine();
            //while (input != "Enough")
            //{
            //    lastExercise = input;
            //    evaluation = int.Parse(Console.ReadLine());
            //    avaluationSum += evaluation;
            //    evaluationCount++;
            //    if (evaluation <= 4)
            //    {
            //        failedCount++;
            //        if (failedCount == failedTimes)
            //        {
            //            Console.WriteLine($"You need a break, {failedCount} poor grades.");
            //            break;
            //        }
            //    }
            //    input = Console.ReadLine();
            //}

            //double averageevaluationAv = avaluationSum / evaluationCount;
            //if (failedCount != failedTimes)
            //{
            //    Console.WriteLine($"Average score: {averageevaluationAv:F2}");
            //    Console.WriteLine($"Number of problems: {evaluationCount}");
            //    Console.WriteLine($"Last problem: {lastExercise}");

            //}


            ////zada4a 4

            //int steps = 0;
            //string input = Console.ReadLine();
            //while (input!="Going home")
            //{
            //    steps += int.Parse(input);
            //    if (steps>=10000)
            //    {
            //        break;
            //    }
            //    input = Console.ReadLine();
            //}
            //if (input=="Going home")
            //{
            //    input = Console.ReadLine();
            //    steps += int.Parse(input);
            //}
            //if (steps < 10000)
            //{
            //    Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            //}
            //else
            //{
            //    Console.WriteLine("Goal reached! Good job");
            //    Console.WriteLine($"{steps - 10000} steps overthe goal!");


            //zada4a 5
            //double changeToReturn = 100*double.Parse(Console.ReadLine());//5,23=523  za da ne se raboti s drobi

            //int count = 0;

            ////2lv, 1lv, 0.5, 0.2,0.1, 0.05,  0.02,  0.01
            ////5,23=>2x2.00+1.00+0.20+0.02+0.01

            //while (changeToReturn > 0)
            //{
            //    if (changeToReturn >= 200)
            //    {
            //        changeToReturn -= 200;
            //        count++;
            //    }
            //    else if (changeToReturn >= 100)
            //    {
            //        changeToReturn -= 100;
            //        count++;
            //    }
            //    else if (changeToReturn >= 50)
            //    {
            //        changeToReturn -= 50;
            //        count++;
            //    }
            //    else if (changeToReturn >= 20)
            //    {
            //        changeToReturn -= 20;
            //        count++;
            //    }
            //    else if (changeToReturn >= 10)
            //    {
            //        changeToReturn -= 10;
            //        count++;
            //    }
            //    else if (changeToReturn >= 5)
            //    {
            //        changeToReturn -= 5;
            //        count++;
            //    }
            //    else if (changeToReturn >= 2)
            //    {
            //        changeToReturn -= 2;
            //        count++;
            //    }
            //    else if (changeToReturn >= 1)
            //    {
            //        changeToReturn -= 1;
            //        count++;
            //    }
            //    else
            //    {
            //        changeToReturn = 0;
            //    }


            //}
            //Console.WriteLine(count);

            //}

            //zada4a 3 Po4ivka
            //double neededMoney = double.Parse(Console.ReadLine());
            //double availMoney = double.Parse(Console.ReadLine());
            //string input = "";
            //double money = 0;
            //int daysCount = 0;
            //int spendCount = 0;
            //while (availMoney<neededMoney)
            //{
            //    input = Console.ReadLine();
            //    money = double.Parse(Console.ReadLine());
            //    daysCount++;
            //    if (input=="save")
            //    {
            //        availMoney += money;
            //        spendCount = 0;
            //    }
            //    else
            //    {
            //        availMoney -= money;
            //        spendCount++;

            //        if (availMoney<0)
            //        {
            //            availMoney = 0;
            //        }
            //        if (spendCount == 5)
            //        {
            //            Console.WriteLine($"You can't save the money");
            //            Console.WriteLine($"{daysCount}");
            //            break;
            //        }

            //    }

            //}
            //if (availMoney>=neededMoney)
            //{
            //    Console.WriteLine($"You saved the money for {daysCount} days");
            //}


            //УРОК 12.02.2022
            //4asownik zada4a 1
            //for (int hour = 0; hour <= 23; hour++)
            //{

            //    for (int min = 0; min <= 59; min++)
            //    {
            //        Console.WriteLine($"{hour}:{min}");
            //    }
            //}

            //ymnozenie na 4islata do 10 zada4a 2
            //for (int m = 1; m <= 10; m++)
            //{
            //    for (int num2 = 1; num2 <=10; num2++)
            //    {
            //int product = m * num2;
            //        Console.WriteLine($"{m} * {num2} = {product}");
            //    }

            //}

            //zada4a 4

            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());
            //int magicNum = int.Parse(Console.ReadLine());
            //int counter = 0;
            //for (int i = start; i <= end; i++)
            //{
            //    for (int j = start; j <=end; j++)
            //    {
            //        counter++;
            //        if (i+j==magicNum)
            //        {
            //            Console.WriteLine($"Combination N:{counter} ({i}+{j} = {magicNum})");
            //            return;
            //           // Environment.Exit(0);
            //        }

            //    }
            //}
            //Console.WriteLine($"{counter} combinations - neither equals {magicNum}");



            //zada4a 5 Patuvane
            //string destination = Console.ReadLine();            
            //while (destination!="End")
            //{
            //    double minBudget=double.Parse(Console.ReadLine());
            //    double savings = 0;
            //    while (savings<minBudget)
            //    {
            //        savings+= double.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine($"Going to {destination}!");
            //    destination = Console.ReadLine();
            //}

            //zada4a 6 Sgrada

            //int flors = int.Parse(Console.ReadLine());
            //int rooms = int.Parse(Console.ReadLine());
            //for (int floor = flors; floor > 0; floor--)
            //{
            //    for (int room = 0; room < rooms; room++)
            //    {
            //        if (floor == flors)
            //        {
            //            Console.Write($"L{floor}{room} ");
            //            continue;
            //        }
            //        if (floor % 2 == 0)
            //        {
            //            Console.Write($"O{floor}{room} ");
            //        }
            //        else
            //        {
            //            Console.Write($"A{floor}{room} ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //zada4i ypraznenia 13.02.2022
            //zada4a 1
            //int n = int.Parse(Console.ReadLine());
            //int currentNum = 1;
            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = 0; j <=i; j++)
            //    {
            //        Console.WriteLine(currentNum+" ");
            //        currentNum++;
            //        if (currentNum>n)
            //        {
            //            break;
            //        }
            //    }
            //    Console.WriteLine();
            //    if (currentNum > n)
            //    {
            //        break;
            //    }
            //}

            //zada4a 2
            //int firstNum = int.Parse(Console.ReadLine());
            //int secondNum = int.Parse(Console.ReadLine());
            //int oddSum = 0;
            //int evenSum = 0;

            //for (int i = firstNum; i <= secondNum; i++)
            //{
            //    oddSum = 0;
            //    evenSum = 0;

            //    string currentNum = i.ToString();
            //    for (int n = 0; n < currentNum.Length; n++)
            //    {
            //        if (n%2==0)
            //        {
            //            evenSum += currentNum[n];
            //        }
            //        else
            //        {
            //            oddSum += currentNum[n];
            //        }
            //    }
            //    if (oddSum==evenSum)
            //    {
            //        Console.WriteLine(currentNum +" ");
            //    }

            //}

            //zada4a 3

            //string input = Console.ReadLine();
            //int num;
            //int primeSum = 0;
            //int nonprimeSum = 0;
            //while (input!="stop")
            //{
            //    num = int.Parse(input);
            //    if (num<0)
            //    {
            //        Console.WriteLine("Number is negative.");
            //        input = Console.ReadLine();
            //        continue;
            //    }
            //    bool isPrime = true;
            //    for (int i = 2; i < num-1; i++)
            //    {
            //        if (num%i==0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        primeSum += num;
            //    }
            //    else
            //    {
            //        nonprimeSum += num;
            //    }

            //    input = Console.ReadLine();
            //}
            //Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            //Console.WriteLine($"Sum of all non prime numbers is: {nonprimeSum}");

            //zada4a 4
            //int n = int.Parse(Console.ReadLine());
            //string input = Console.ReadLine();
            //double presentationEv=0;
            //double Evaluation = 0;
            //int presentationNum = 0;
            //string presentationName="";
            //while (input!="Finish")
            //{

            //    presentationName = input;
            //    presentationEv = 0;
            //    for (int i = 0; i <= n; i++)
            //    {

            //        presentationEv += double.Parse(Console.ReadLine());

            //    }
            //    presentationEv = presentationEv / n;
            //    Evaluation += presentationEv;
            //    Console.WriteLine($"{input} - {presentationEv:f2}.");
            //    presentationNum++;
            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"Student's final assessment is {Evaluation/presentationNum:f2}.");

            //zada4a 5
            //int n = int.Parse(Console.ReadLine());

            //for (int k = 1; k <= 9; k++)
            //{


            //    for (int l = 1; l <= 9; l++)
            //    {

            //        for (int j = 1; j <= 9; j++)
            //        {
            //            for (int i = 1; i <= 9; i++)
            //            {

            //                if (n % i == 0 && n % j == 0 && n % l == 0 && n % k == 0)
            //                {

            //                }
            //                Console.Write($"{k}{l}{j}{i} +  ");


            //            }

            //        }
            //    }

            //}


            //zada 6

            //string input = Console.ReadLine();
            //string filmName;
            //int studentTickets = 0;
            //int standardTickets = 0;
            //int kidTickets = 0;
            //int soldTickets;
            //int freePlace = 0;
            //int totalTik = 0;
            //string input1;
            //while (input != "Finish")
            //{
            //    filmName = input;
            //    freePlace = int.Parse(Console.ReadLine());
            //    soldTickets = 0;
            //    input1 = input;
            //    while (input1 != "End")
            //    {

            //            string tipeTicket = Console.ReadLine();
            //            if (tipeTicket == "student")
            //            {
            //                studentTickets++;
            //                soldTickets++;
            //            }
            //            else if (tipeTicket == "standard")
            //            {
            //                standardTickets++;
            //                soldTickets++;
            //            }
            //            else
            //            {
            //                kidTickets++;
            //                soldTickets++;
            //            }
            //            if (soldTickets == freePlace)
            //            {
            //                break;
            //            }
            //         input1 = Console.ReadLine();
            //        totalTik += soldTickets;

            //    }
            //    Console.WriteLine($"{filmName} - {soldTickets*100.0/freePlace}% full.");
            //    input = Console.ReadLine();
            //}
            //double studPr = studentTickets * 100.0 / freePlace;
            //double kidPr = kidTickets * 100.0 / freePlace;
            //double standPr = standardTickets * 100.0 / freePlace;
            //Console.WriteLine($"Total tickets: {totalTik}");
            //Console.WriteLine($"{studPr}% student tickets.");
            //Console.WriteLine($"{standPr}% standard tickets.");
            //Console.WriteLine($"{kidPr}% kids tickets.");

            //zada4a pazar
            //double priceIag = double.Parse(Console.ReadLine());
            //double qualityBananas = double.Parse(Console.ReadLine());
            //double qualityOranges = double.Parse(Console.ReadLine());
            //double qualityMalini = double.Parse(Console.ReadLine());
            //double qualityIag = double.Parse(Console.ReadLine());

            //double maliniPrice = priceIag / 2;
            //double orangePrice = maliniPrice - (0.4 * maliniPrice);
            //double bananaPrice = maliniPrice - (0.8 * maliniPrice);
            //double sumMalini = qualityMalini * maliniPrice;
            //double sumOrange = qualityOranges * orangePrice;
            //double sumBanana = qualityBananas *bananaPrice;
            //double sumIag = qualityIag *priceIag;
            //double sum = sumMalini + sumBanana + sumOrange + sumIag;
            //Console.WriteLine("{0:f2}",sum);

            //zada4aSemeina po4ivka
            //double budget = double.Parse(Console.ReadLine());
            //int nights = int.Parse(Console.ReadLine());
            //double pricePerNight = double.Parse(Console.ReadLine());
            //int procentRaz = int.Parse(Console.ReadLine());
            //if (nights>7)
            //{
            //    pricePerNight = pricePerNight - (pricePerNight * 5 / 100);
            //}
            //double allForNights = nights * pricePerNight;
            //double addRaz = (budget * procentRaz / 100);
            //double allRaz = allForNights + addRaz;
            //if (allRaz<=budget)
            //{
            //    double hj = budget - allRaz;

            //    Console.WriteLine($"Ivanovi will be left with {hj:f2} leva after vacation");
            //}
            //else
            //{
            //    double jh = Math.Abs(allRaz - budget);
            //    Console.WriteLine($"{jh:f2} leve needed");
            //}

            //zada4a destinacia za film
            //double budget = double.Parse(Console.ReadLine());
            //string destination = Console.ReadLine();
            //string season = Console.ReadLine();
            //int days = int.Parse(Console.ReadLine());
            //double dubai = 0.0;
            //double sofia = 0.0;
            //double sum = 0.0;
            //switch (season)
            //{
            //    case "Winter":
            //        if (destination == "Dubai")
            //        {
            //            dubai = days * 45000;
            //            sum = dubai - (dubai * 30 / 100);
            //        }
            //        else if (destination == "Sofia")
            //        {
            //            sofia = days * 17000;
            //            sum = sofia + (sofia * 25 / 100);
            //        }
            //        else if (destination == "London")
            //        {
            //            sum = days * 24000;
            //        }
            //        break;
            //    case "Summer":
            //        if (destination == "Dubai")
            //        {
            //            dubai = days * 40000;
            //            sum = dubai - (dubai * 30 / 100);
            //        }
            //        else if (destination == "Sofia")
            //        {
            //            sofia = days * 12500;
            //            sum = sofia + (sofia * 25 / 100);
            //        }
            //        else if (destination == "London")
            //        {
            //            sum = days * 20250;
            //        }
            //        break;
            //    default:
            //        break;
            //}

            //if (sum <= budget)
            //{
            //    Console.WriteLine($"The budget for the movie is enough! We have {(budget - sum):f2} leva left!");
            //}
            //else
            //{
            //    Console.WriteLine($"The director needs {Math.Abs(sum - budget):f2} leva more!");
            //}


            //zada4a Hrana za doma6ni lubimci
            //int days = int.Parse(Console.ReadLine());
            //double foodQuality = double.Parse(Console.ReadLine());
            //double sumDogFood = 0.0;
            //double sumcatFood = 0.0;

            //for (int i = 1; i <= days; i++)
            //{
            //    int dogFood = int.Parse(Console.ReadLine());
            //    int catFood = int.Parse(Console.ReadLine());
            //    sumDogFood += dogFood;
            //    sumcatFood += catFood;
            //    if (i == days)
            //    {
            //        double bis = (catFood + dogFood) * 10.0 / 100;
            //        Console.WriteLine($"Total eaten biscuits: {bis:f0}gr.");
            //    }

            //}
            //double eatenFood = sumcatFood + sumDogFood;
            //double eatenProcFood = eatenFood * 100 /foodQuality;
            //double eatenProcFoodDog = sumDogFood * 100 /eatenFood;
            //double eatenProcFoodcat = sumcatFood * 100 / eatenFood;
            //Console.WriteLine($"{eatenProcFood:f2}% of the foo has been eaten.");
            //Console.WriteLine($"{eatenProcFoodDog:f2}% eaten from the dog.");
            //Console.WriteLine($"{eatenProcFoodcat:f2}% eaten from the cat.");

            ////zada4a Bitkata na velikdenskite ica
            //int firstPlayer = int.Parse(Console.ReadLine());
            //int secondPlayer = int.Parse(Console.ReadLine());
            //string winner = Console.ReadLine();

            //while (winner!="End of battle")
            //{

            //    if (winner=="one")
            //    {
            //        secondPlayer--;              
            //    }
            //    if (winner == "two")
            //    {
            //        firstPlayer--;
            //    }
            //    if (secondPlayer<=0)
            //    {
            //        Console.WriteLine($"Player two is out of egge. Player one has {firstPlayer} eggs left.");
            //        break; 
            //    }
            //    if (firstPlayer <= 0)
            //    {
            //        Console.WriteLine($"Player one is out of egge. Player two has {secondPlayer} eggs left.");
            //        break;
            //    }
            //    winner = Console.ReadLine();
            //}
            //if (winner== "End of battle")
            //{
            //    Console.WriteLine($"Player one has {firstPlayer} eggs left.");
            //    Console.WriteLine($"Player two has {secondPlayer} eggs left.");
            //}


            //zada4a Barkod generator
            //          string num1 = Console.ReadLine();
            //string num2 = Console.ReadLine();

            //int val1 = (int)Char.GetNumericValue(num1[0]);
            //int val2 = (int)Char.GetNumericValue(num1[1]);
            //int val3 = (int)Char.GetNumericValue(num1[2]);
            //int val4 = (int)Char.GetNumericValue(num1[3]);
            //int val11 = (int)Char.GetNumericValue(num2[0]);
            //int val21 = (int)Char.GetNumericValue(num2[1]);
            //int val31 = (int)Char.GetNumericValue(num2[2]);
            //int val41 = (int)Char.GetNumericValue(num2[3]);
            ////int hj = num1[1];
            //for (int i = val1; i <= val11; i++)
            //{

            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    for (int j = val2; j <= val21; j++)
            //    {
            //        if (j % 2 == 0)
            //        {
            //            continue;
            //        }

            //        for (int t = val3; t <= val31; t++)
            //        {

            //            if (t % 2 == 0)
            //            {
            //                continue;
            //            }
            //            for (int f = val4; f <= val41; f++)
            //            {
            //                if (f % 2 == 0)
            //                {
            //                    continue;
            //                }
            //                Console.Write($"{i}{j}{t}{f} ");
            //            }

            //        }

            //    }

            //}

            //zada4a ku4e kote

            //int days = int.Parse(Console.ReadLine());
            //double food = double.Parse(Console.ReadLine());

            //double dogFood = 0;
            //double catFood = 0;
            //double dayDogFood = 0;
            //double dayCatFood = 0;
            //double biscuits = 0;
            //for (int i = 1; i <= days; i++)
            //{
            //    dayDogFood = double.Parse(Console.ReadLine());
            //    dayCatFood = double.Parse(Console.ReadLine());
            //    if (i % 3 == 0)
            //    {
            //        biscuits += (dayDogFood + dayCatFood) / 10;
            //    }
            //    dogFood += dayDogFood;
            //    catFood += dayCatFood;

            //}

            //int num=1234

            //num%10=>poslednata cifra ot 4isloto
            //num/10=>num=123 %10=>3
            //num/100=>num=12 %10=>2
            //num/100=>100 dava parvata cifra na na6eto 4etiricifreno 4islo

            //Point myPoint = new Point(2, 3);
            //double myPointXCoor = myPoint.X;
            //double myPointYCoor = myPoint.Y;
            //Console.WriteLine($"{myPointXCoor} and {myPointYCoor}");

            //zada4a 12
            //int isHowMuch = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int isThat = isHowMuch;
            //while (isThat > 0)
            //{
            //    sum += isThat % 10;
            //    isThat = isThat / 10;
            //}
            //bool isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
            //Console.WriteLine("{0} -> {1}", isHowMuch, isSpecialNum);


            //zada4a 7 i 12
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    int sumOffDigits = 0;
            //    int digits = i;
            //    while (digits > 0)
            //    {
            //        sumOffDigits += digits % 10;
            //        digits /= 10;
            //    }
            //    if (sumOffDigits == 5 || sumOffDigits == 7 || sumOffDigits == 11)
            //    {
            //        Console.WriteLine($"{i} -> True");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i} -> False");
            //    }
            //}


            //int[] str =Console.ReadLine().Split().Select(int.Parse).ToArray();

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


            //int[] numbers = new int[5] { 7, 7, 3, 10, 4 };
            //int[] condensed = new int[9] { 3, 5, 6, 2, 6, 6, 7, 9, 9 };

            //numbers = condensed;
            //for (int i = 0; i <= numbers.Length - 1; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



           



























        }

        //class Point
        //{
        //    private double x;
        //    private double y;

        //    public Point (int x, int y)
        //    {
        //        this.x = x;
        //        this.y = y;
        //    }

        //    public double X
        //    {
        //        get { return this.x; }
        //        set { this.x = value;}
        //    }
        //    public double Y
        //    {
        //        get { return this.y; }
        //        set { this.y = value; }
        //    }

        //}

        //class Rectangle
        //{
        //    private float height;
        //    private float width;

        //    public Rectangle(float height, float width)
        //    {
        //        this.height = height;
        //        this.width = width;
        //    }
        //    public float Area
        //    {
        //        get { return this.height * this.width; }
        //    }
        //}

    }
}
