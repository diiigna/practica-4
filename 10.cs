using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString = Interaction.InputBox("Введите число:", "Число", "");
            int number = Convert.ToInt32(numberString);
            MessageBox.Show("Последовательность: " + (number - 1) + ", " + number + ", " + (number + 1), "Результат"); Console.ReadLine();
        }
    }
};//namespace NumberSequence
  //{//    class Program
  //    {//        static void Main(string[] args)
  //        {//            Console.Write("Введите число: ");
  //            int number = Convert.ToInt32(Console.ReadLine());
  //            Console.WriteLine("Последовательность: " + (number - 1) + ", " + number + ", " + (number + 1));//            Console.ReadLine();
  //        }//    }
  //}
