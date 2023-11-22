//6 задание 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace AgeToBirthYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш возраст: "); int age = Convert.ToInt32(Console.ReadLine());
            //Определяем текущий год
            int currentYear = DateTime.Now.Year;
            // Вычисляем год рождения
            int birthYear = currentYear - age;
            Console.WriteLine("Ваш год рождения: " + birthYear);
            Console.ReadLine();
        }
    }
}
