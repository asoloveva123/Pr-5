using System;

namespace MyLabWork5__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние в сантиметрах:"); //просим пользователя ввести расстояние в сантиметрах
            int a = Int32.Parse(Console.ReadLine()); //задание пременной вещественного типа
            a /= 100; //присваивание переменной значения по формуле, нахождение полного числа метров
            Console.WriteLine($"Полное число метров в нем равно {a}"); //вывод на экран значения переменной
        }
    }
}