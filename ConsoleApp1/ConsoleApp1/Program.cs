using System;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение угла в градусах: ");
            double a = double.Parse(Console.ReadLine());

            if (a > 0 && a < 360)
            {
                int pfull = (int)a / 180;
                int ppart = (int)a % 180;//считаем сколько полных "пи" в углу и сколько неполных
                double res = 3.14 * (pfull + (a / 180 - pfull));
                if (pfull == 0 && ppart > 0)
                {
                    Console.WriteLine($"угол равен {res:00} радиан");//значение если угол меньше 180 градусов
                }
                if (pfull > 0 && ppart > 0)
                {
                    Console.WriteLine($"угол равен {res:0.00} радиан");//значение если угол больше 180 градусов и не кратен 180
                }
                if (pfull > 0 && ppart == 0)
                {
                    Console.WriteLine($"угол равен {res:0.00} радиан");//значение если угол больше 180 градусов и кратен 180
                }
            }
            else
            {
                Console.WriteLine($"Вы указали неверное значение. Перезапустите программу и введите значение из диапазона(0;360)");//"проверка на дурака"
            }

        }
    }
}