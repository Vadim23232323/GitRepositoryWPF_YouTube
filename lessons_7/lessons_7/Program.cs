using System;
using System.IO;
using System.Text;


namespace lessons_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_name = @"D:\GitRepositoryWPF_YouTube\lessons_7\text.txt";
            string new_text = "Hello Tatia";


            // Работа с файлами через File (работа с файлами без потоков)

            Console.WriteLine("Creat txt file : {0}", file_name);

            File.WriteAllText(file_name, "Hello \nSome new");

            foreach (string line in File.ReadAllLines(file_name))
            {
                Console.WriteLine($"All lines : {line} ");
            }

            // Работа с файлами через FileStream (потоковая работа с файлами (приходится конвертировать данные в byte))

            FileStream fs = File.Open(file_name, FileMode.Create);

            byte[] writeStrByte = Encoding.Default.GetBytes(new_text);

            fs.Write(writeStrByte, 0, writeStrByte.Length);

            fs.Position = 0;

            byte[] readStrByte = new byte[writeStrByte.Length];

            for (int i = 0; i < writeStrByte.Length; i++)
                readStrByte[i] =(byte)fs.ReadByte();

            Console.WriteLine(Encoding.Default.GetString(readStrByte));

            fs.Close();

            // Работа с файлами через StreamWrite (потоковая работа с файлами (без конвертации данных в byte))

            StreamWriter sw = File.CreateText(file_name);

            sw.WriteLine(new_text);
            sw.WriteLine("new line");

            sw.Close();

            StreamReader sr = File.OpenText(file_name);
            Console.WriteLine(sr.ReadToEnd());
            sw.Close();

            // Работа с исключениями

            byte number = 0;

            Console.Write("Enter numbers in 0 to 255: ");

            try
            {
                number = Convert.ToByte(Console.ReadLine());
            } catch (OverflowException)
            {
                Console.WriteLine("value range exceeded");
            } catch (FormatException)
            {
                Console.WriteLine("invalid data format");
            } finally
            {
                Console.WriteLine("programs finish");
            }

            int[] arr = { 3, 6 };

            try
            {
                Console.WriteLine($"Element arr : {arr[2]}");
            } catch (IndexOutOfRangeException)
            {
                Console.WriteLine("item does not exist");
            }

            Console.WriteLine($"Number : {number}");

            Console.ReadKey();
        }
    }
}
