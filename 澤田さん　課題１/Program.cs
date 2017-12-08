using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//追加
using System.IO;

namespace 澤田さん_課題１
{
    class Program
    {
        static void Main(string[] args)
        {
            //ファイルを全部読み込む
            string readText = "";
            try
            {
                using (StreamReader reader1 =
                    new StreamReader("data.csv", Encoding.Default))
                {
                    readText = reader1.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(readText);

            Console.WriteLine("\n終了するには何かキーを押してください。");
            Console.Read();
        }
    }
}
