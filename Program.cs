using System;

namespace App39
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int found = 0;
            for (int i = text.Length - 1; i >= 0; i--)
                if (text[i] == text[text.Length - i - 1])
                {
                    found++;
                }
                else
                {
                    break;
                }

            Console.WriteLine(found);
        }
    }
}
