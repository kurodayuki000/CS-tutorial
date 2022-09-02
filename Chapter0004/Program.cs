using System;

namespace Chapter_0004
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new Int32[5];
            numberList[0] = 3;
            numberList[1] = 7;
            numberList[2] = 8;
            numberList[3] = 10;
            numberList[4] = 12;

            //for文
            for (int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine("たけのこの数は" + numberList[i]);
            }

            //foreach文
            foreach (var item in numberList)
            {
                Console.WriteLine("たけのこの数は" + item + "です。");
            }

            //while文(1)
            var index = 0;
            while (index < numberList.Length)
            {
                Console.WriteLine("たけのこの数は" + numberList[index] + "です。");
                index++;

            }

            //while文(2)
            index = 0;
            while (true)
            {
                Console.WriteLine("たけのこの数は" + numberList[index] + "です。");
                index++;
                if (index == numberList.Length) break;

            }

            Console.ReadLine();
        }
    }
}
