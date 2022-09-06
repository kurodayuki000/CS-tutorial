using System;

namespace Chapter_0010
{
    class Program
    {
        static void Main(string[] args)
        {
            var body = File.ReadAllText("/Users/kurodayuuki/Desktop/text.txt");
            var ss = body.Split(' ');

            for (int i = 0; i < ss.Length; i++)
            {
                var index = ss[i].IndexOf('a');
                if (index == -1) continue;

                Console.WriteLine("--------------------");
                Console.WriteLine(ss[i]);
                Console.WriteLine( (index + 1) + "文字目にaがあるよ！");
            }

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }

        private static void Sample_Cointains()
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
            Console.WriteLine(count + "単語ありました！！！");

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }

        private void Sample_StartWith()
        {
            var body = File.ReadAllText("/Users/kurodayuuki/Desktop/text.txt");
            var ss = body.Split(" ");
            var count = 0;

            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].StartsWith("y"))
                {
                    Console.WriteLine(ss[i]);
                    count++;
                }
            }
            Console.WriteLine(count + "単語ありました！！！");

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }

        private void Sample_Equals()
        {
            var body = File.ReadAllText("/Users/kurodayuuki/Desktop/text.txt");
            var ss = body.Split(" ");
            var count = 0;

            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i].Equals("are"))
                {
                    Console.WriteLine(ss[i]);
                    count++;
                }
            }
            Console.WriteLine(count + "単語ありました！！！");

            Console.WriteLine("Enterキーで終了");
            Console.ReadLine();
        }
    }
}