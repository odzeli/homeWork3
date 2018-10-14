//Odzeli
//*Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
//Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, 
//демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи. Все программы сделать в одном решении.
//** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
using System;


namespace homeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.Write("Введите числитель 1: ");
            int chislitel = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель 1: ");
            int znamenatel = int.Parse(Console.ReadLine());
            Fraction drob1 = new Fraction(chislitel, znamenatel);
            Console.Write("Введите числитель 2: ");
            int chislitel2 = int.Parse(Console.ReadLine());
            Console.Write("Введите знаменатель 2: ");
            int znamenatel2 = int.Parse(Console.ReadLine());
            Fraction drob2 = new Fraction(chislitel2, znamenatel2);

            var result = Fraction.SumDrob(drob1, drob2);
            Console.WriteLine($"Результат суммы: {result.Chislitel}/{result.Znamenatel}");
            result = Fraction.SubstractFraction(drob1, drob2);
            Console.WriteLine($"Результат вычитания: {result.Chislitel}/{result.Znamenatel}");
            result = Fraction.MultiplyFraction(drob1, drob2);
            Console.WriteLine($"Результат умножения: {result.Chislitel}/{result.Znamenatel}");
            result = Fraction.DivisionFraction(drob1, drob2);
            Console.WriteLine($"Результат деления: {result.Chislitel}/{result.Znamenatel}");
            Console.ReadKey();
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
