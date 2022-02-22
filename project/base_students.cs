using System;
using System.Collections.Generic;
namespace project
{
    class base_students
    {
        // Задача 23. Дано: информация о студенте вуза содержит следующие элементы:
        // а) фамилия, имя;
        // б) шифр группы;
        // в) массив оценок по каждой дисциплине за семестр (от 2 до 5).
        // Информация о студенте является элементом массива М[ ].
        // Требуется определить фамилии студентов, которые будут включены в приказ на отчисление по результатам сессии (условие – по трем или более дисциплинам каждая оценка — двойка).
        private string fio;
        private string gruppa;
        private int[] matematika;
        private int[] informatika;
        private int[] english;
        private int[] russian;
        private int[] litra;
        private int[] obg;
        private int[] history;

        private int[] fizra;
        private int[] biologia;
        private int[] ekonomika;
        private int[] buh_uchet;
        private int[] pravo;

        public string Fio
        {
            get
            {
                System.Console.WriteLine("Студент поступил");
                return this.fio;
            }
            private set
            {

            }
        }

        public string Gruppa
        {
            get
            {
                return this.gruppa;
            }
            set
            {

            }
        }

        public int[] Matematika
        {
            get
            {
                return matematika;
            }
            set
            {

            }
        }
        public int[] Informatika
        {
            get
            {
                return informatika;
            }
            set
            {

            }
        }

        public int[] English
        {
            get
            {
                return english;
            }
            set
            {

            }
        }

        public int[] Russian
        {
            get
            {
                return russian;
            }
            private set
            {

            }
        }

        public int[] Litra
        {
            get
            {
                return litra;
            }
            set
            {

            }
        }

        public int[] Obg
        {
            get
            {
                return obg;
            }
            set
            {

            }
        }

        public int[] History
        {
            get
            {
                return history;
            }
            set
            {

            }
        }
        public int[] Fizra
        {
            get
            {
                return fizra;
            }
            private set
            {

            }
        }
        public int[] Biologia
        {
            get
            {
                return biologia;
            }
            private set
            {

            }
        }
        public int[] Ekonomika
        {
            get
            {
                return ekonomika;
            }
            set
            {

            }
        }
        public int[] Buh_uchet
        {
            get
            {
                return buh_uchet;
            }
            set
            {

            }
        }
        public int[] Pravo
        {
            get
            {
                return pravo;
            }
            private set
            {

            }
        }


//функция присвоения значений для студента прогера
        public void assign_proger(string fio, string gruppa, int[] matematika, int[] english, int[] russian, int[] litra, int[] obg, int[] fizra, int[] biologia, int[] pravo, int[] informatika)
        {
            this.fio = fio;
            this.gruppa = gruppa;
            this.matematika = matematika;
            this.english = english;
            this.russian = russian;
            this.litra = litra;
            this.obg = obg;
            this.fizra = fizra;
            this.biologia = biologia;
            this.pravo = pravo;
            this.informatika = informatika;
        }

//функция присвоения значений для студента эконома
public void assign_ekonom(string fio, string gruppa, int[] matematika, int[] english, int[] russian, int[] obg, int[] fizra, int[] biologia, int[] pravo, int[] ekonomika)
        {
            this.fio = fio;
            this.gruppa = gruppa;
            this.matematika = matematika;
            this.english = english;
            this.russian = russian;
            this.obg = obg;
            this.fizra = fizra;
            this.biologia = biologia;
            this.pravo = pravo;
            this.ekonomika = ekonomika;
        }

//функция присвоения значений для студента бухучета
public void assign_buhuchet(string fio, string gruppa, int[] matematika, int[] russian, int[] obg, int[] fizra, int[] biologia, int[] pravo, int[] buh_uchet)
        {
            this.fio = fio;
            this.gruppa = gruppa;
            this.matematika = matematika;
            this.russian = russian;
            this.obg = obg;
            this.fizra = fizra;
            this.biologia = biologia;
            this.pravo = pravo;
            this.buh_uchet = buh_uchet;
        }

//функция присвоения значений для студента историка
public void assign_historical(string fio, string gruppa, int[] russian, int[] litra, int[] fizra, int[] biologia, int[] pravo, int[] history)
        {
            this.fio = fio;
            this.gruppa = gruppa;
            this.russian = russian;
            this.litra = litra;
            this.fizra = fizra;
            this.biologia = biologia;
            this.pravo = pravo;
            this.history = history;
        }





//конструктор прогер
        public base_students(string fio, string gruppa, int[] matematika, int[] english, int[] russian, int[] litra, int[] obg, int[] fizra, int[] biologia, int[] pravo, int[] informatika)
        {
            if(gruppa == "1ПРОГР1"){
            System.Console.WriteLine("Программисты: ");
            }
            this.assign_proger(fio, gruppa, matematika, english, russian, litra, obg, fizra, biologia, pravo, informatika);
            // ничего не удалял
        }


//конструктор эконом
        public base_students(string fio, string gruppa, int[] matematika, int[] english, int[] russian, int[] obg, int[] fizra, int[] biologia, int[] pravo, int[] ekonomika)
        {
            if(gruppa == "1ЭКОНОМ1"){
            System.Console.WriteLine("Экономисты: ");
            }
            this.assign_ekonom(fio, gruppa, matematika, english, russian, obg, fizra, biologia, pravo, ekonomika);
            //убрал литру
        }

//конструктор бухучет
        public base_students(string fio, string gruppa, int[] matematika, int[] russian, int[] obg, int[] fizra, int[] biologia, int[] pravo, int[] buh_uchet)
        {
           if(gruppa == "1БУХ1"){
            System.Console.WriteLine("Бухгалтера: ");
            }
            this.assign_buhuchet(fio, gruppa, matematika, russian, obg, fizra, biologia, pravo, buh_uchet);
            //убрал литру и англ
        }

//конструктор исторический
        public base_students(string fio, string gruppa, int[] russian, int[] litra, int[] fizra, int[] biologia, int[] pravo, int[] history)
        {
           if(gruppa == "1ИСТ1"){
            System.Console.WriteLine("Историки: ");
            }
            this.assign_historical(fio, gruppa, russian, litra, fizra, biologia, pravo, history);
//убрал математику и англ и обж
        }



    }

}

