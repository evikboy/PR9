using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR9
{
    class trasport
    {
        protected double income;
        virtual public void input()
        {
            Console.Write("Введите чистую прибыль от транспорта: ");
            income = Convert.ToDouble(Console.ReadLine());
        }

        virtual public void output()
        {
            Console.WriteLine("Прибыль от транспорта: {0}", income);
        }
    }

    class freightTransport : trasport
    {
        double lifting;
        double horsepower;
        double volume;

        public override void input()
        {
            Console.Write("Введите грузоподъемность грузового траспорта(тонны): ");
            lifting = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество лошадиных сил: ");
            horsepower = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите объем топливного бака(литры): ");
            volume = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите чистую прибыль от грузового транспорта: ");
            income = Convert.ToDouble(Console.ReadLine());
        }

        public override void output()
        {
            Console.WriteLine("Грузоподъемность грузового траспорта: {0}\nКоличество лошадиных сил: {1}\nОбъем топливного бака: {2}", lifting, horsepower, volume);
            base.output();
        }

    }

    class passengerTrasport : trasport
    {
        int passCapacity;
        int comfort;
        double price;

        public override void input()
        {
            Console.Write("Введите пассажировместимость: ");
            passCapacity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену билета: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите баллы комфорта(1-10): ");
            comfort = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите чистую прибыль от пассажирского транспорта: ");
            income = Convert.ToDouble(Console.ReadLine());
        }

        public override void output()
        {
            Console.WriteLine("Пассажировместимость: {0}\nЦена билета: {1}\nБаллы комфорта: {2}", passCapacity, price, comfort);
            base.output();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            freightTransport freightTransport = new freightTransport();
            Console.WriteLine("Введите все данные про грузовой транспорт");
            freightTransport.input();
            Console.WriteLine("\n================================ГРУЗОВОЙ ТРАНСПОРТ==================================");
            freightTransport.output();

            Console.WriteLine();

            passengerTrasport passengerTrasport = new passengerTrasport();
            Console.WriteLine("Введите все данные про пассажирский транспорт");
            passengerTrasport.input();
            Console.WriteLine("\n================================ПАССАЖИРСКИЙ ТРАНСПОРТ==================================");
            passengerTrasport.output();
        }
    }
}
