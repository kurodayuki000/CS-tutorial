using System;

namespace Chapter_0008
{
    class Program
    {
        static void Main(string[] args)
        {
            var XYear = 0;
            while (true)
            {
                Console.WriteLine("年はなんですか？");
                var line = Console.ReadLine();
                if(Int32.TryParse(line, out XYear))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("数値を入力してください。");
                }
            }

            var xMonth = 0;
            while (true)
            {
                Console.WriteLine("月はなんですか？");
                var line = Console.ReadLine();
                if (Int32.TryParse(line, out xMonth))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("数値を入力してください。");
                }
            }

            var xDay = 0;
            while (true)
            {
                Console.WriteLine("日はなんですか？");
                var line = Console.ReadLine();
                if (Int32.TryParse(line, out xDay))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("数値を入力してください。");
                }
            }
            var inputDate = new DateTime(XYear, xMonth, xDay);
            var today = DateTime.Today;
            var ts = today - inputDate;

            Console.WriteLine(ts.TotalDays.ToString() + "日です。");

        }
    }
}

