using System;

namespace Chapter_0007
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowTakenokoList("きのこ");
        }

        private static void ShowTakenokoList(String name)
        {
            var numberList = GetNumberList_pattern1();

            for (int i = 0; i < numberList.Length; i++)
            {
                Console.WriteLine(name + "の数は" + numberList[i] + "です。");
            }
            Console.ReadLine();
        }

        private static String ReturnText()
        {
            return "Mari";
        }
        private static Int32[] GetNumberList_pattern1()
        {
            var numberList = new Int32[5];
            numberList[0] = 3;
            numberList[1] = 5;
            numberList[2] = 7;
            numberList[3] = 12;
            numberList[4] = 11;

            return numberList;
        }
    }
}
