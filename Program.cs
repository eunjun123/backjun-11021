Case #1: 2
Case #2: 5
Case #3: 7
Case #4: 17
Case #5: 7
using System;
using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] s = Console.ReadLine().Split();
                stringBuilder.Append($"Case #{i + 1}: {int.Parse(s[0]) + int.Parse(s[1])}" + "\n");
            }
            Console.WriteLine(stringBuilder);
        }
    }