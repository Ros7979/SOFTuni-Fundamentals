using System;
namespace testove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double hesdsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int trashedHeadset = 0;
            int trashedMouse = 0;
            int trashedKeyboard = 0;
            int trashedKeyboard2 = 0;
            int trashedDisplay = 0;
            for (int i = 2; i < lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHeadset++;
                }
                if (i % 3 == 0)
                {
                    trashedMouse++;
                }
                if (i % 2 != 0 || i % 3 != 0)
                {
                    continue;
                }
                else
                {
                    trashedKeyboard++;
                    trashedKeyboard2++;
                }
                if (trashedKeyboard2 % 2 == 0 && trashedKeyboard2 != 0)
                {
                    trashedDisplay++;
                }
                if (trashedKeyboard2 == 2)
                {
                    trashedKeyboard2 = 0;
                }
            }
            Console.WriteLine($"Rage expenses: {(trashedHeadset * hesdsetPrice + trashedMouse * mousePrice + trashedKeyboard * keyboardPrice + trashedDisplay * displayPrice):f2} lv.");
        }
    }
}
