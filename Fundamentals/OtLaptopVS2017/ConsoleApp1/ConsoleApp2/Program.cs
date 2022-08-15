using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Numerics;
using System.Net;
using System.Text.RegularExpressions;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());           
            //Family fam = new Family();
            //for (int i = 0; i < n; i++)
            //{
            //    string[] input = Console.ReadLine().Split(' ').ToArray();
            //    Person chovek = new Person();
            //    chovek.Name = input[0];
            //    chovek.Age = int.Parse(input[1]);
            //      fam.AddMember(chovek);             
            //}        
            //fam.GetOldestMember(fam.listOfPeople);



            //zada4a 4etene ot WEB sait i sortirane s regex
            Dictionary<string, List<int>> pricesByArea = new Dictionary<string, List<int>>();
            Console.OutputEncoding = Encoding.UTF8;

            using (WebClient client = new WebClient { Encoding = System.Text.Encoding.UTF8 })
            {
                for (int i = 1; i <= 7; i++)
                {

                    string htmlCode = GetHtmlCode(client, i);
                    string pattern = @"<div class=""price"">(?:<img.*?>)?(?<price>.*?)<.*?<a.*?<.*?<.*?<.*?>(?<area>.*?)<";
                    Regex regex = new Regex(pattern, RegexOptions.Singleline);
                    MatchCollection matches = regex.Matches(htmlCode);
                    foreach (Match match in matches)
                    {
                        //    Console.WriteLine(match.Groups["price"]);
                        //    Console.WriteLine(match.Groups["area"]);
                        //Re6ena po drug na4in
                        string[] tokens = match.Groups["price"].Value.Split(new string[] { "EUR" }, StringSplitOptions.RemoveEmptyEntries);
                        string priceStr = tokens[0].Trim().Replace(" ", "");
                        if (int.TryParse(priceStr, out int price))
                        {
                            string area = match.Groups["area"].Value;
                            if (!pricesByArea.ContainsKey(area))
                            {
                                pricesByArea.Add(area, new List<int>());
                            }
                            pricesByArea[area].Add(price);
                        }

                        Console.WriteLine($"Area: {match.Groups["area"].Value}, Price: {match.Groups["price"].Value}");
                    }

                }
                foreach (var item in pricesByArea)
                {
                    Console.WriteLine($"Area: {item.Key}, Average price: {item.Value.Average()}, Count: {item.Value.Count()}");
                }
                
            }

        }
        //zada4a 4etene ot WEB sait i sortirane s regex
        static string GetHtmlCode(WebClient client, int index)
        {
            byte[] content = client.DownloadData($@"https://www.imot.bg/pcgi/imot.cgi?act=3&slink=88o5rs&f1={index}");
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding1251 = Encoding.GetEncoding("windows-1251");
            var convertBytes = Encoding.Convert(encoding1251, Encoding.UTF8, content);
            string htmlCode = Encoding.UTF8.GetString(convertBytes);
            return htmlCode;
        }

    }
    //class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}
    //class Family
    //{
    //    public Family()
    //    {
    //        this.listOfPeople = new List<Person>();
    //    }
    //    public List<Person> listOfPeople { get; set; }
    //    public void AddMember(Person people)
    //    {
    //        listOfPeople.Add(people);

    //    }
    //    public void GetOldestMember(List<Person> listofpeople)
    //    {
    //        Person nm = new Person();
    //        nm = listofpeople.OrderByDescending(x => x.Age).First();
    //        Console.WriteLine($"{nm.Name} {nm.Age}");
    //    }
    //}
}


