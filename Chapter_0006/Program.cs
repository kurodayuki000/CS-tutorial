using System;

namespace Chapter_0005
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

            //引数。値を引き渡す。
            ShowTakenokoList(numberList, "きのこ");
        }

        private static void ShowTakenokoList(Int32[] numberList , string name)
        {
            for (int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine(name + "の数は" + numberList[i] + "です。");
            }
            Console.ReadLine();
        }
    }
}
