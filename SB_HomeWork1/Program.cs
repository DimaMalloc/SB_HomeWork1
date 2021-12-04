using System;

namespace SB_HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Установите IDE Visual Studio. 
            //Создайте новое консольное приложение.
            //Добавьте оператор вывода на экран Console.WriteLine и с помощью метода С помощью метода Console.WriteLine Console.WriteLine выведите надпись: Hello World!!!
            //Добавьте задержку Console.ReadKey, чтобы приложение не закрывалось по завершении выполнения.

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            //Выведите на экран надпись Hello World!!!, используя метод Console.Write.
            //Используйте Console.Write для каждого слова(у вас будет три вызова метода: сначала для слова Hello, потом для слова World, а затем — для трёх восклицательных знаков).
            //Чтобы слова не «слипались», используйте пробелы внутри кавычек.
            //Добавьте задержку Console.ReadLine, чтобы приложение не закрывалось по завершении выполнения.

            Console.Write("Hello ");
            Console.Write("World ");
            Console.Write("!!!");
            Console.ReadKey();
        }
    }
}
