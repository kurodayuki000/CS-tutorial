using System;

namespace Chapter_0002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("私はサイクリングが好きか？1.Yes 2.No");
            var text = Console.ReadLine();
            if(text == "1")
            {
                Console.WriteLine("正解！！！");
            }
            else if(text == "2")
            {
                Console.WriteLine("不正解...");
            }
            else
            {
                Console.WriteLine("入力が間違っています。");
            }
            Console.WriteLine("neterキーで終了します。");
            Console.ReadLine();
        }
    }
}