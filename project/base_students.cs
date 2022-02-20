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
        protected string fio;
        protected string gruppa;
        protected int[] matematika;
        // private int[] informatika;
        protected int[] enlgish;
        protected int[] russian;
        protected int[] litra;
        protected int[] obg;
        //   private int[] history;

        protected int[] fizra;
        protected int[] biologia;
        //  private int[] ekonomika;
        //  private int[] buh_uchet;
        protected int[] pravo;

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
            private set
            {

            }
        }

        public int[] Matematika
        {
            get
            {
                return matematika;
            }
            private set
            {

            }
        }
        // public int[] Informatika
        // {
        //     get
        //     {
        //         return informatika;
        //     }
        //     private set
        //     {

        //     }
        // }

        public int[] Enlgish
        {
            get
            {
                return enlgish;
            }
            private set
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
            private set
            {

            }
        }

        public int[] Obg
        {
            get
            {
                return obg;
            }
            private set
            {

            }
        }

        // public int[] History
        // {
        //     get
        //     {
        //         return history;
        //     }
        //     private set
        //     {

        //     }
        // }
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
        // public int[] Ekonomika
        // {
        //     get
        //     {
        //         return ekonomika;
        //     }
        //     private set
        //     {

        //     }
        // }
        // public int[] Buh_uchet
        // {
        //     get
        //     {
        //         return buh_uchet;
        //     }
        //     private set
        //     {

        //     }
        // }
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



        public void assign_value(string fio, string gruppa, int[] matematika, int[] enlgish, int[] russian, int[] litra, int[] obg, int[] fizra, int[] biologia, int[] pravo)
        {
            this.fio = fio;
            this.gruppa = gruppa;
            this.matematika = matematika;
            //   this.informatika = informatika;
            this.enlgish = enlgish;
            this.russian = russian;
            this.litra = litra;
            this.obg = obg;
            //   this.history = history;
            this.fizra = fizra;
            this.biologia = biologia;
            //   this.ekonomika = ekonomika;
            //    this.buh_uchet = buh_uchet;
            this.pravo = pravo;
        }




        public base_students(string fio, string gruppa, int[] matematika, int[] enlgish, int[] russian, int[] litra, int[] obg, int[] fizra, int[] biologia, int[] pravo)
        {
            this.assign_value(fio, gruppa, matematika, enlgish, russian, litra, obg, fizra, biologia, pravo);
        }




    }

}

