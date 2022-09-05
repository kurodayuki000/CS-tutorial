using System;

//パソコンとは → 画面,ハードディスク,メモリ, CPU
//プログラム → パソコンを操作する



namespace Chapter_0012
{
    class Program
    {
        static void Main(string[] args)
        {
            //ファイルを生成するプログラム

            var body = "名前,年齢,性別,学部,役職";
            body = body + Environment.NewLine + "新井,19,女,工学部,なし";
            System.IO.File.WriteAllText("/Users/kurodayuuki/Desktop/MyText.csv", body);
            Console.WriteLine("保存しました");

            Console.WriteLine("Enterキーで終了します。");
            Console.ReadLine();
        }
    }
}