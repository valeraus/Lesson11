using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Створіть клас Dictionary <TKey, TValue>. 
    Реалізуйте в найпростішому наближенні можливість використання його примірника аналогічно примірнику класу Dictionary 
    з простору імен System.Collections.Generic. Мінімально необхідний інтерфейс взаємодії з екземпляром, 
    повинен включати метод додавання пар елементів, індексатор для отримання значення елемента за вказаною індексу 
    і властивість тільки для читання для отримання загальної кількості пар елементів.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Словарь:");

            var dic = new Dictionary<string, string>(); //Создаем переменную типа Dictionary и закрываем ее типами string и string

            dic.AddToDictionary("table", "стол"); //Добавлаем значения в словарь
            dic.AddToDictionary("apple", "яблоко");
            dic.AddToDictionary("sun", "солнце");
            dic.AddToDictionary("pencil", "карандаш");
            dic.AddToDictionary("cap", "чашка");
            dic.AddToDictionary("tea", "чай");

            Console.WriteLine(dic.ToString()); //Отображаем значения словаря
            Console.WriteLine();
            Console.WriteLine("В словаре {0} записей", dic.Lenght);
            Console.WriteLine(new string('-', 30)); //30 символов "-"

            Console.WriteLine("Введите номер записи в словаре:");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                Console.WriteLine("Вы не ввели номер записив словаре");
            else
            {
                int nomer = Convert.ToInt32(str);
                Console.WriteLine(dic[nomer - 1]); //С помощью индексатора отображаем конкретную запись
            }

            Console.WriteLine("Введите значение для поиска");
            string p = Console.ReadLine();
            Console.WriteLine(dic[p]); //С помощью перегруженого индексатора ищем конкретную запись по ключу

            // Delay.
            Console.ReadKey();
        }
    }
}