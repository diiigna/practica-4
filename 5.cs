//задание 5 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
namespace MonthDays
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Interaction.InputBox("Введите название месяца:", "Месяц", "");
            string daysString = Interaction.InputBox("Введите количество дней в этом месяце:", "Дни", "");
            int days = Convert.ToInt32(daysString);
            MessageBox.Show("Месяц " + month + " содержит " + days + " дней", "Информация");
        }
    }
}
