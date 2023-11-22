using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace SumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1String = Interaction.InputBox("Введите первое число:", "Число 1", "");
            string number2String =Interaction.InputBox("Введите второе число:", "Число 2", "");
            double number1 = Convert.ToDouble(number1String); double number2 = Convert.ToDouble(number2String);
            double sum = number1 + number2;
            MessageBox.Show("Сумма: " + sum, "Результат");
            Console.ReadLine();
        }
    }
}

//namespace SumCalculator//{
//    class Program//    {
//        static void Main(string[] args)//        {
//            Console.Write("Введите первое число: ");//            double number1 = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Введите второе число: ");
//            double number2 = Convert.ToDouble(Console.ReadLine());
//            double sum = number1 + number2;
//            Console.WriteLine("Сумма: " + sum);//            Console.ReadLine();
//        }//    }
//}