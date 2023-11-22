using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Interaction.InputBox("Введите ваше имя:", "Имя", ""); 
            string yearOfBirthString = Interaction.InputBox("Введите год рождения:", "Год рождения", "");
            int yearOfBirth = Convert.ToInt32(yearOfBirthString);            // Определяем текущий год
            int currentYear = DateTime.Now.Year;
            // Вычисляем возраст
            int age = currentYear - yearOfBirth;
            MessageBox.Show("Имя: " + name + "\nВозраст: " + age, "Информация");    
            Console.ReadLine();    
        }    
    }
}
