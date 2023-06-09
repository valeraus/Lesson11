﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Створіть клас CarCollection <T>. 
    Реалізуйте в найпростішому наближенні можливість використання його примірника для створення парку машин. 
    Мінімально необхідний інтерфейс взаємодії з екземпляром, повинен включати метод додавання машин 
    з назвою машини і року її випуску, індексатор для отримання значення елемента за вказаною індексу 
    і властивість тільки для читання для отримання загальної кількості елементів.
    Створіть метод видалення всіх машин автопарку.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Наш парк машин:");
            var park = new CarCollection<string>(); //Создание коллекции park и присвоение ей ссылки на екземпляр параметризированного класса CarCollection закрытый типом string

            park.AddCar("Жигули", new DateTime(1985, 12, 5)); //Добавление нового элемента в коллекцию
            park.AddCar("Тойота", new DateTime(2000, 4, 7));
            park.AddCar("Форд", new DateTime(2005, 5, 3));
            park.AddCar("Мерседес", new DateTime(2003, 11, 3));

            Console.WriteLine(park.ToString()); //Отображаем содержимое коллекции

            Console.WriteLine("В парке находится: {0} машин", park.Lenght);

            Console.WriteLine("Введите номер интересующей вас машины:");
            string stroka = Console.ReadLine();

            if (string.IsNullOrEmpty(stroka)) //Метод проверяет полученое значение, пустое значение
                Console.WriteLine("Вы не ввели значение. Поиск не выполнен.");
            else
            {
                int nomer = Convert.ToInt32(stroka);
                Console.WriteLine(park[nomer - 1]);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
