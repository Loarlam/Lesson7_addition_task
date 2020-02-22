/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте структуру с именем - Notebook.  
Поля структуры: модель, производитель, цена.  
В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран.  
*/
using System;

namespace Addition_task
{
    struct Notebook
    {
        string _model, _manufacturer;
        double _price;

        public Notebook(string model, string manufacturer, double price)
        {
            _model = model;
            _manufacturer = manufacturer;
            _price = price;
        }

        public void DisplaysTheContentsOfTheFiledsOnTheScreen()
        {
            Console.WriteLine("Информация о ноутбуке:");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"модель {_model}\nпроизводитель {_manufacturer}\nцена {_price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Aspire v3-771g", "Acer", 24500.50);
            notebook.DisplaysTheContentsOfTheFiledsOnTheScreen();

            Console.ReadKey();
        }
    }
}
