using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace InputDialogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, fam;
            Console.Title = "Имя и фамилия" ;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            fam = Console.ReadLine();
            Console.Title = "Ваша имя и фамилия";
            string txt = "Ваша имя: " + name + " Ваша фамилия: " + fam;
            Console.WriteLine(txt);
            Console.ReadKey();
        }
    }
}
