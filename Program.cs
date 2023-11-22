using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите ваш возраст: "); int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: " + name);
            Console.WriteLine("Ваш возраст: " + age);
            Console.Title = "Ваше имя и возраст";
            string txt = "Ваше имя: " + name + " Ваш возраст:  " + age;
            Console.WriteLine(txt);
            Console.ReadKey();
         }
    }
}
//namespace UserInput
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string name = Interaction.InputBox("Введите ваше имя:", "Имя", "");
//            string ageString = Interaction.InputBox("Введите ваш возраст:", "Возраст", ""); 
//            int age = Convert.ToInt32(ageString); 
//            MessageBox.Show("Ваше имя: " + name + " Ваш возраст: " + age, "Информация");
//        }
//    }
//}
