using System;

namespace Chapter_0010
{
    class Program
    {
        static void Main(string[] args)
        {
            var body = File.ReadAllText("/Users/kurodayuuki/Desktop/text.txt");
            var ss = body.Split(" ");
            var count = 0;

            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].Contains("a"))
                {
                    Console.WriteLine(ss[i]);
                    count++;
                }
            }
            Console.WriteLine(count + "文字ありました！！！");

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }
    }
}