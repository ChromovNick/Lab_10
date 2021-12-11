using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            grad grad = new grad ();
            Console.WriteLine("Добро пожаловать в калькулятор тригонометрических функций");
            Console.WriteLine("Введите целочисленное значение угла а:");
            grad.Angle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите целочисленное значение минут угла а");
            grad.Minutes= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите целочисленное значение секунд угла а:");
            grad.Seconds= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Угол а: {0}°{1}'{2}''",grad.Angle,grad.Minutes,grad.Seconds);
            grad.ToRadians();
            Console.ReadLine();
           
        }
    }
    class grad
    {
        double angle;
        double minutes;
        double seconds;


        public double Angle
        {
            set
            {
                if (value % 1 == 0)
                {
                    angle = value;
                }
                else
                {
                    Console.WriteLine("Вы ввели нецелое значение угла");
                }
            }
            get
            {
                return angle;
            }
        }

        public double Minutes
        {
            set
            {
                if (value < 60 && value > 0&& value % 1 == 0)
                {
                    minutes = value;
                }
                else
                {
                    Console.WriteLine("В одном угле 60 минут!");
                }
            }
            get
            {
                return minutes;
            }
        }
        public double Seconds
        {
            set
            {
                if (value < 60 && value > 0 && value % 1 == 0)
                {
                    seconds = value;
                }
                else
                {
                    Console.WriteLine("В одной минуте 60 секунд!");
                }
            }
            get
            {
                return seconds;
            }
        }

        public void ToRadians()
        {
            double rad = (angle * (Math.PI / 180) + (minutes * (Math.PI / (180 * 60))) + (seconds * (Math.PI / (180 * 60 * 60))));
            Console.WriteLine("Угол а в радианах: {0:f4}", rad);
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1- sin");
            Console.WriteLine("2- cos");
            Console.WriteLine("3- tan");
            Console.WriteLine("4- ctg");
            Console.WriteLine("5- arcsin");
            Console.WriteLine("6- arccos");
            Console.WriteLine("7- arctan");
            Console.WriteLine("8- arcctg");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш выбор: {0}", f);
            if (f == 1 || f == 2 || f == 3 || f == 4 || f == 5 || f == 6 || f == 7 || f == 8)
            {

                switch (f)
                {
                    case 1:
                        {
                            Console.WriteLine("Синус угла а: {0:f4}", Math.Sin(rad));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Косинус угла а: {0:f4}", Math.Cos(rad));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Тангенс угла а: {0:f4}", Math.Tan(rad));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Котангенс угла а: {0:f4}", 1 / Math.Tan(rad));
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Арксинус угла а: {0:f4}", Math.Asin(rad));
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Арккосинус угла а: {0:f4}", Math.Acos(rad));
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Арктангенс угла а: {0:f4}", Math.Atan(rad));
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Арккотангенс угла а: {0:f4}", Math.PI / 2 - Math.Atan(rad));
                            break;
                        }
                }

            }
            else
            {
                Console.WriteLine("нет операции с указанным номером");
            }
        }

    }



}

