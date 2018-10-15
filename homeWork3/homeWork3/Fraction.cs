//Odzeli
//*Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
//Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, 
//демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи. Все программы сделать в одном решении.
//** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
using System;

namespace homeWork3
{
    class Fraction
    {
        private int _znamenatel;
        public int Chislitel;
        public int Znamenatel
        {
            get => _znamenatel;
            set
            {
                _znamenatel = value != 0 ? value : throw ArgumentException("Знаменатель не может быть равен 0");
            }
        }

        public Fraction(int chislitel, int znamenatel)
        {
            _znamenatel = znamenatel;
            Chislitel = chislitel;
        }

        public static Fraction SumDrob(Fraction drobA, Fraction drobB)
        {
            var resultDrob = new Fraction(0, 0);
            resultDrob.Chislitel = (drobA.Chislitel * drobB.Znamenatel) + (drobB.Chislitel * drobA.Znamenatel);
            resultDrob.Znamenatel = drobB.Znamenatel * drobA.Znamenatel;
            return resultDrob;
        }

        public static Fraction SubstractFraction(Fraction drobA, Fraction drobB)
        {
            var resultDrob = new Fraction(0, 0);
            resultDrob.Chislitel = (drobA.Chislitel * drobB.Znamenatel) - (drobB.Chislitel * drobA.Znamenatel);
            resultDrob.Znamenatel = drobB.Znamenatel * drobA.Znamenatel;
            return resultDrob;
        }

        public static Fraction MultiplyFraction(Fraction drobA, Fraction drobB)
        {
            var resultDrob = new Fraction(0, 0);
            resultDrob.Chislitel = drobA.Chislitel * drobA.Chislitel;
            resultDrob.Znamenatel = drobB.Znamenatel * drobA.Znamenatel;
            return resultDrob;
        }

        public static Fraction DivisionFraction(Fraction drobA, Fraction drobB)
        {
            var resultDrob = new Fraction(0, 0);
            resultDrob.Chislitel = drobA.Chislitel * drobB.Znamenatel;
            resultDrob.Znamenatel = drobA.Znamenatel * drobB.Chislitel;
            return resultDrob;
        }

        private Exception ArgumentException(string v)
        {
            throw new ArgumentException(v);
        }
    }
}
