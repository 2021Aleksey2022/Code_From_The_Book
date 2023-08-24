using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");
            // Создать объект Car по имени Chuck co скоростью 10 миль в час.
            //Car chuck = new Car();
            //chuck.PrintState();
            //Console.WriteLine("===============================================");
            // Создать объект Car по имени Mary co скоростью 0 миль в час.
            //Car mary = new Car("Mary");
            //mary.PrintState();
            //Console.WriteLine("==================================================");
            // Создать объект Car по имени Daisy со скоростью 75 миль в час.
            //Car daisy = new Car("Daisy", 75);
            //daisy.PrintState();
            // Разместить в памяти и сконфигурировать объект Саг.
            //Car chuck = new Car();
            //chuck.PrintState();

            Motorcycle mt = new Motorcycle();
            mt.PopAWheely();
            Console.ReadLine();
        }
    }
    class Car
    {
        // 'Состояние’ объекта Саг.
        public string petName;
        public int currSpeed;

        // Специальный стандартный конструктор.
        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }
        // Здесь currSpeed получает стандартное значение для типа int (0).
        //Конструкторы как члены, сжатые до выражений.
        public Car(string pn) => petName = pn;


        // Позволяет вызывающему коду установить полное состояние объекта Саг.
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        // Функциональность Саг.
        // Использовать синтаксис членов, сжатых до выражений, который появился в C# 6.
        public void PrintState() => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);

        public void SpeedUp(int delta) => currSpeed += delta;
    }
    class Motorcycle
    {
        public int driverIntensity;

        public void PopAWheely()
        {
            for(int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");             
            }
        }
        // Вернуть стандартный конструктор, который будет
        // устанавливать все члены данных в стандартные значения.
        public Motorcycle() { }

        // Специальный конструктор.
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
    }
}
