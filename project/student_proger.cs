// using System;
// using System.Collections.Generic;
// namespace project
// {
//     class student_proger : base_students
//     {
//         public student_proger(string fio, string gruppa, int[] matematika, int[] enlgish, int[] russian, int[] litra, int[] obg, int[] fizra, int[] biologia, int[] pravo) : base(fio, gruppa, matematika, enlgish, russian, litra, obg, fizra, biologia, pravo)
//         {
//         }

//         protected int[] informatika;
//         public int[] Informatika
//         {
//             get
//             {
//                 return informatika;
//             }
//             set
//             {

//             }
//         }

//         public student_proger(string fio, string gruppa, int[] matematika, int[] enlgish, int[] russian, int[] litra, int[] obg, int[] fizra, int[] biologia, int[] pravo, int[] informatika) : base(fio, gruppa, matematika, enlgish, russian, litra, obg, fizra, biologia, pravo)
//         {
//             this.Informatika = informatika;
//         }




//     }
// }


// // public void Print()
// // {
// //     System.Console.WriteLine("ФИО: " + fio);
// //     System.Console.WriteLine("Группа: " + gruppa);
// //     System.Console.WriteLine("Оценки по математике: ");
// //     for (int i = 0; i < 5; i++)
// //     {
// //         System.Console.WriteLine(matematika[i] + " ");
// //     }
// //     System.Console.WriteLine("Оценки по информатике: ");
// //     for (int i = 0; i < 5; i++)
// //     {
// //         System.Console.WriteLine(informatika[i] + " ");
// //     }
// //     System.Console.WriteLine("Оценки по английскому: ");
// //     for (int i = 0; i < 5; i++)
// //     {
// //         System.Console.WriteLine(enlgish[i] + " ");
// //     }
// //     System.Console.WriteLine("Оценки по русскому: ");
// //     for (int i = 0; i < 5; i++)
// //     {
// //         System.Console.WriteLine(russian[i] + " ");
// //     }
// //     System.Console.WriteLine("Оценки по литературе: ");
// //     for (int i = 0; i < 5; i++)
// //     {
// //         System.Console.WriteLine(litra[i] + " ");
// //     }
// //     System.Console.WriteLine("Оценки по ОБЖ: ");
// //     for (int i = 0; i < 5; i++)
// //     {
// //         System.Console.WriteLine(OBG[i] + " ");
// //     }
// //     System.Console.WriteLine("Оценки по истории: ");
// //     for (int i = 0; i < 5; i++)
// //     {
// //         System.Console.WriteLine(history[i] + " ");
// //     }
// //     System.Console.WriteLine("Оценки по физре: ");
// //     for (int i = 0; i < 5; i++)
// //     {
// //         System.Console.WriteLine(fizra[i] + " ");
// //     }
// //     System.Console.WriteLine("Оценки по биологии: ");
// //     for (int i = 0; i < 5; i++)
// //     {
// //         System.Console.WriteLine(biologia[i] + " ");
// //     }
// //     System.Console.WriteLine("Оценки по экономике: ");
// //     for (int i = 0; i < 5; i++)
// //     {
// //         System.Console.WriteLine(ekonomika[i] + " ");
// //     }
// //     System.Console.WriteLine("Оценки по бухучету: ");
// //     for (int i = 0; i < 5; i++)
// //     {
// //         System.Console.WriteLine(buh_uchet[i] + " ");
// //     }
// //     System.Console.WriteLine("Оценки по праву: ");
// //     for (int i = 0; i < 5; i++)
// //     {
// //         System.Console.Write(pravo[i] + " ");
// //     }
// // }