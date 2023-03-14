using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    У колекцію ArrayList, через виклик методу Add додайте елементи структурного та засланого типу, 
    переберіть дану колекцію за допомогою, циклу for. З якою проблемою ви зіткнулися?
     */
    class MyClass //Создание класса
    {
        public int MyIntProperty { get; set; } //Автоматическое свойство
        public string MyStringProperty { get; set; }
    }

    class Program
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList(); //Коллекция может хранить в себе разнотипные значения (гетерогенная коллекция)
            arrayList.Add(0); //Добавление нового элемента в коллекцию
            arrayList.Add(0.67);
            arrayList.Add('a');
            arrayList.Add("elem");
            arrayList.Add(new MyClass()); //Добаление в коллекцию нового элемента - экземпляра класса MyClass

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]); //Отображение элементов коллекции
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
