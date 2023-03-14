using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
     * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Створіть клас ArrayList. 
    Реалізуйте в найпростішому наближенні можливість використання його примірника аналогічно примірнику 
    класу ArrayList з простору імен System.Collections.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArrayList m = new MyArrayList(); //Создание переменной типа MyArrayList

            m.Add(5); //Добавление записей в коллекцию
            m.Add("Hello");
            m.Add('d');
            m.Add(5.78);

            Console.WriteLine("Массив:");
            Console.WriteLine(m.ToString()); //Отображение значений коллекции

            // Delay.
            Console.ReadKey();
        }
    }
}
