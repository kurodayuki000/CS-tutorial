using System;
using System.IO;
using System.Text;

//パソコンとは → 画面,ハードディスク,メモリ, CPU
//プログラム → パソコンを操作する



namespace Chapter_0009
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadCsvAndCreateNowListCSV();
        }

        private static void CreateCSVFile()
        {
            //ファイルを生成するプログラム
            EncodingProvider provider = System.Text.CodePagesEncodingProvider.Instance;
            var encoding = provider.GetEncoding(932);

            var body = "名前,年齢,性別,学部,役職";
            body = body + Environment.NewLine + "新井,19,女,工学部,なし";
            System.IO.File.WriteAllText("/Users/kurodayuuki/Desktop/MyText.csv", body, encoding);
            Console.WriteLine("保存しました");

            Console.WriteLine("Enterキーで終了します。");
            Console.ReadLine();
        }

        private static void ReadCsvAndCreateNameListCSV()
        {
            var body = System.IO.File.ReadAllText("/Users/kurodayuuki/Desktop/MyText2.csv");

            var sr = new StringReader(body);
            var nameList = new String[14];
            var index = 0;
            while (sr.Peek() != -1)
            {
                var line = sr.ReadLine();
                if (index == 0)
                {
                    index++;
                    continue;
                }
                var nameCount = line.IndexOf(',');
                nameList[index - 1] = line.Substring(0, nameCount);
                index++;
                Console.WriteLine(line);
            }
            var newBody = "";
            for (int i = 0; i < nameList.Length; i++)
            {
                newBody = newBody + nameList[i] + Environment.NewLine;
            }
            EncodingProvider provider = System.Text.CodePagesEncodingProvider.Instance;
            var encoding = provider.GetEncoding(932);
            System.IO.File.WriteAllText("/Users/kurodayuuki/Desktop/nameList.csv", newBody, encoding);

            Console.WriteLine("Enterで終了します。");
            Console.ReadLine();
        }

        private static void ReadCsvAndCreateNowListCSV()
        {
            var body = System.IO.File.ReadAllText("/Users/kurodayuuki/Desktop/MyText2.csv");

            var sr = new StringReader(body);
            var nameList = new String[14];
            var gakubuList = new String[14];
            var index = 0;
            while (sr.Peek() != -1)
            {
                var line = sr.ReadLine();
                if (index == 0)
                {
                    index++;
                    continue;
                }
                var ss = line.Split(',');
                
                nameList[index - 1] = ss[0];
                gakubuList[index - 1] = ss[3];
                index++;
                Console.WriteLine(line);
            }
            var newBody = "";
            for (int i = 0; i < nameList.Length; i++)
            {
                newBody = newBody + nameList[i] + "," + gakubuList[i] + Environment.NewLine;
            }
            EncodingProvider provider = System.Text.CodePagesEncodingProvider.Instance;
            var encoding = provider.GetEncoding(932);
            System.IO.File.WriteAllText("/Users/kurodayuuki/Desktop/nameAndGakubu_List.csv", newBody, encoding);

            Console.WriteLine("Enterで終了します。");
            Console.ReadLine();
        }
    }
}