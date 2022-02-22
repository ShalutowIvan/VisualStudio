using System;
using System.Collections.Generic;
namespace project
{
    class students
    {
        static void Main()
        {
            // Задача 23. Дано: информация о студенте вуза содержит следующие элементы:
            // а) фамилия, имя;
            // б) шифр группы;
            // в) массив оценок по каждой дисциплине за семестр (от 2 до 5).
            // Информация о студенте является элементом массива М[ ].
            // Требуется определить фамилии студентов, которые будут включены в приказ на отчисление по результатам сессии (условие – по трем или более дисциплинам каждая оценка — двойка).


            List<base_students> Students = new List<base_students>();
            Students.Add(new base_students("Вася Пупкин", "1ПРОГР1", new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }));

            Students.Add(new base_students("Анатолий Павлович Негодяев", "1БУХ1", new int[] { 2, 2, 2 }, new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }, new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 }));

            Students.Add(new base_students("Иракли Пирцхалава", "1ИСТ1", new int[] { 4, 4, 4 }, new int[] { 5, 5, 5 }, new int[] { 5, 5, 3 }, new int[] { 3, 5, 5 }, new int[] { 3, 3, 3 }, new int[] { 4, 4, 4 }, new int[] { 3, 4, 5 }, new int[] { 5, 3, 4 }));

            Students.Add(new base_students("Жорик Вартанов", "1ЭКОНОМ1", new int[] { 5, 2, 5 }, new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 }, new int[] { 5, 2, 5 }, new int[] { 5, 2, 5 }, new int[] { 5, 2, 5 }));

            foreach (base_students student in Students)
            {
                System.Console.WriteLine("Фамилия студента: " + student.Fio);
                System.Console.WriteLine("Группа: " + student.Gruppa);
                System.Console.Write("Оценки по математике: ");
                foreach (int el in student.Matematika)
                {
                   if (student.Matematika == null){
                    break;
                   }
                    System.Console.Write(el + " ");
                }
                System.Console.WriteLine();
                System.Console.Write("Оценки по биологии: ");
                foreach (int el in student.Biologia)
                {
                    System.Console.Write(el + " ");
                }
                System.Console.WriteLine();
                
                

                System.Console.Write("Оценки по английскому языку: ");
                foreach (int el in student.English)
                {
                   if (student.English == null){
                    break;
                   }
                    System.Console.Write(el + " ");
                }
                System.Console.WriteLine();

                System.Console.Write("Оценки по физре: ");
                foreach (int el in student.Fizra)
                {
                    System.Console.Write(el + " ");
                }
                System.Console.WriteLine();

                

                System.Console.Write("Оценки по русскому языку: ");
                foreach (int el in student.Russian)
                {
                    System.Console.Write(el + " ");
                }
                System.Console.WriteLine();

                System.Console.Write("Оценки по ОБЖ: ");
                foreach (int el in student.Obg)
                {
                   if (student.Obg == null){
                    break;
                   }
                    System.Console.Write(el + " ");
                }
                System.Console.WriteLine();

                System.Console.Write("Оценки по праву: ");
                foreach (int el in student.Pravo)
                {
                    System.Console.Write(el + " ");
                }
                System.Console.WriteLine();
                System.Console.Write("Оценки по литературе: ");
                foreach (int el in student.Litra)
                {
                    if (student.Litra == null){
                    break;
                   }
                    System.Console.Write(el + " ");
                }
                System.Console.WriteLine();
                System.Console.Write("Оценки по информатике: ");
                foreach (int el in student.Informatika)
                {
                     if (student.Informatika == null){
                    break;
                   }
                    System.Console.Write(el + " ");
                }
                System.Console.WriteLine();

                System.Console.Write("Оценки по бухучету: ");
                foreach (int el in student.Buh_uchet)
                {
                   if (student.Buh_uchet == null){
                    break;
                   }
                    System.Console.Write(el + " ");
                }
                System.Console.WriteLine();

                System.Console.Write("Оценки по экономике: ");
                foreach (int el in student.Ekonomika)
                {
                    if (student.Ekonomika == null){
                    break;
                   }
                    System.Console.Write(el + " ");
                }
                System.Console.WriteLine();

                System.Console.Write("Оценки по истории: ");
                foreach (int el in student.History)
                {
                    if (student.History == null){
                    break;
                   }
                    System.Console.Write(el + " ");
                }
                System.Console.WriteLine();

            }







        }


    }
}