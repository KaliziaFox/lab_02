using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_lab02
{
    public class Vehicle
    {
        protected double x, y, price, speed;
        protected int year;

        public Vehicle(double x, double y, double price, double speed, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public virtual void info()
        {
            Console.WriteLine("Координаты: " + "X" + x + "Y" + y);
            Console.WriteLine("Цена: " + price);
            Console.WriteLine("Скорость: " + speed);
            Console.WriteLine("Год выпуска: " + year);
        }
    }

    public class Car : Vehicle
    {
        public Car(double x, double y, double price, double speed, int year) : base(x, y, price, speed, year)
        {

        }
    }

    public class Plane : Vehicle
    {
        protected double high;
        protected int passengers;
        public Plane(double x, double y, double price, double speed, int year, double high, int passengers) : base(x, y, price, speed, year)
        {
            this.high = high;
            this.passengers = passengers;
        }
        public override void info()
        {
            base.info();
            Console.WriteLine("Высота: " + high);
            Console.WriteLine("Количество пассажиров: " + passengers);
        }
    }

    public class Ship : Vehicle
    {
        protected int passengers;
        protected string port;
        public Ship(double x, double y, double price, double speed, int year, int passengers, string port) : base(x, y, price, speed, year)
        {
            this.passengers = passengers;
            this.port = port;
        }
        public override void info()
        {
            base.info();
            Console.WriteLine("Высота: " + port);
            Console.WriteLine("Количество пассажиров: " + passengers);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Car Lexus = new Car(100, 200, 8200000, 320, 2022);
            Ship Yacht = new Ship(300, 400, 94329647, 75, 2021, 6, "Port Well");
            Plane Gulfstream_G500 = new Plane(6987, 8941, 4487031868, 982, 2021, 15500, 12);
            Console.WriteLine("Lexus");
            Lexus.info();
            Console.WriteLine();
            Console.WriteLine("Yacht");
            Yacht.info();
            Console.WriteLine();
            Console.WriteLine("Gulfstream_G500");
            Gulfstream_G500.info();
        }
    }
}
