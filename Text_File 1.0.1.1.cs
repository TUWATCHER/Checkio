using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Text_File
{
    class Program
    {
        static void Main()
        {
            string longestWord = ""; /// Самое длинное слово

            StreamReader file = new StreamReader(@"C:\1.txt"); // Считывание текстового файла
            string line = file.ReadToEnd();
            Console.WriteLine(line); // Вывод текстового файла

            /// Количество строк
            int strCount = File.ReadAllLines(@"C:\1.txt").Length;
            Console.WriteLine("\nКоличество строк: " + strCount);

            /// Количество слов
            line = line.Trim(',', '.'); // Удаление точек и запятых в тексте
            string[] lineArray = line.Split(' ');
            int wordCount = lineArray.Length;
            Console.WriteLine("Количество слов: " + wordCount);

            int[] length = new int[lineArray.Length]; // Статистика по словам

            /// Вывод статистики по количеству букв в словах
            for (int i = 0; i < lineArray.Length; i++)
            {
                length[i] = lineArray[i].Length;
            }
            foreach(var i in Distinct(length))
            {
                Console.WriteLine("Слово из {0} букв - встречается {1} раз(а)", i, DigitCount(length, i));
            }

            ///Самое длинное слово
            foreach (string str in lineArray)
            {
                if(str.Length >= longestWord.Length)
                {
                    longestWord = str;
                }
            }

            Console.WriteLine("Самое длинное слово: " + longestWord);

            /// Количество символов
            int symCount = File.ReadAllText(@"C:\1.txt").Length;
            Console.WriteLine("Количество символов: " + symCount);

            /// Количество пробелов
            line = File.ReadAllText(@"C:\1.txt");
            char[] textChr = line.ToCharArray();
            char[] spaces = Array.FindAll(textChr, Predicat); // Количество пробелов
            var spaceCounter = spaces.Length;
            Console.WriteLine("Количество пробелов: " + spaceCounter);

            Console.ReadKey();

            }


        /// Функция опеределия пробелов в символьных массивах
        static bool Predicat(char chr)
        {
            return chr == ' ';
        }

        /// Функция создания набора элементов из массива
        static int[] Distinct(int[] a)
        {
            HashSet<int> list = new HashSet<int>(a);
            int[] b = new int[list.Count];
            list.CopyTo(b);

            return b;
        }

        /// Функция поиска одинаковых элементов массива
        static int DigitCount(int[] a, int b)
        {
            return a.Count(i => i == b);
        }
   }

}
