using System;
namespace project
{

    class konstruktor_static
    {
        public int num;
        public konstruktor_static()
        {
            System.Console.WriteLine("Васся");
        }
        //         private string name;//имя
        //         private int ves;//вес
        //         private byte[] coordinates;

        //         public void setznach(string name1, int ves1, byte[] coordinates1)
        //         {
        //             //создали функцию для указания полей, в скобках указали параметры
        //             name = name1;
        //             ves = ves1;
        //             coordinates = coordinates1;
        //         }

        //         public void printZnach()
        //         {
        //             System.Console.WriteLine(name + " вес " + ves + ". Координаты: ");
        //             foreach (byte el in coordinates)
        //             {
        //                 System.Console.Write(el + " ");
        //             }
        //         }

        //         //создаем конструктор
        //можно создать конструктор он будет работать как метод или функция и будет срабатывать при создании объекта(например конструктор для подключения к БД)
        //         //конструкторы ничего не возвращают, они проделывают манипуляции, но ничего не возвращают. ТИп данных в них указывать не нужно
        //         //название самого конструктора должно быть такое же как название класса и файла *.cs
        //         //в любом класса и файле он есть, но не видимый и ничего не делает
        //         //код из конструктора срабатывает каждый когда в другой функции создается объект

        //         public robot()
        //         {
        //             System.Console.WriteLine("Объект создан");//при создании объекта будет просто выводиться сообщение "объект создан", конструктор действует на весь проект
        //         }
        // //продолжение про конструктор в файл robot.cs и файле classi_objecti.cs

    }
}