using System;

namespace Chapter_0003
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;
            int point = 100;
            while (true)
            {
                Console.WriteLine("好きな食べ物はなんでしょう？ 1. たこ焼き 2.ピザ 3.オムライス 4. タコライス 5.リゾット");
                var text = Console.ReadLine();
                if (text == "3")
                {
                    Console.WriteLine("正解！！！");
                    Console.WriteLine("あなたの点数は" + point + "点です。");
                    break;
                }
                else
                {
                    Console.WriteLine("不正解...");
                    Count++;
                }
                point = 100 - (25 * Count);

                //if (point <= 0) point = 0;
                point = point <= 0 ? 0 : point;
     
                
                Console.WriteLine("あなたの点数は" + point + "点です。");
                if (text == "3")
                {
                    Console.ReadLine();
                }
                    
            }
        }
    }
}