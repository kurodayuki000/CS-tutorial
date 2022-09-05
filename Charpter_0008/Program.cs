using System;

namespace Chapter_0008
{
    class Program
    {
        static void Main(string[] args)
        {
            var y = GetInputAsNUmber("年はなんですか?");
            var m = GetInputAsNUmber("月はなんですか?");
            var d = GetInputAsNUmber("日はなんですか?");


            var inputDate = new DateTime(y, m, d);
            var today = DateTime.Today;
            var ts = today - inputDate;

            Console.WriteLine(ts.TotalDays.ToString() + "日です。");

        }

        private static Int32 GetInputAsNUmber(String puestionText)
        {
            var XYear = 0;
            while (true)
            {
                Console.WriteLine(puestionText);
                var line = Console.ReadLine();
                if (Int32.TryParse(line, out XYear))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("数値を入力してください。");
                }
            }
            return XYear;
        }
    }
}

