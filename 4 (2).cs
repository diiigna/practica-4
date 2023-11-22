using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
namespace Zadanie4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageBox.Show("Дата");
            string DayWeek, Month;
            string Day;
            string name;

            DayWeek = Interaction.InputBox(
               "День недели(словом)",
               "День недели",
               Console.ReadLine()
           );

            Month = Interaction.InputBox(
                "Месяц(словом)",
                "Месяц",
                Console.ReadLine()
            ) ;
            Day = Interaction.InputBox(
                "Число"
                
                );

            string txt = "День недели " + DayWeek + " Месяц " + Month + " Число " + Day;
            MessageBox.Show( txt );
        }
    }
}
