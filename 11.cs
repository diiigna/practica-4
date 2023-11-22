using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1String = Interaction.InputBox("Введите первое число:", "Число 1", "");
            double number1 = Convert.ToDouble(number1String);
            string number2String = Interaction.InputBox("Введите второе число:", "Число 2", ""); double number2 = Convert.ToDouble(number2String);
            double sum = number1 + number2;
            double difference = number1 - number2;
            MessageBox.Show("Сумма: " + sum + "\nРазность: " + difference, "Результат"); Console.ReadLine();
        }
    }
}