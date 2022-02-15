// using System;
// namespace project
// {
//     class masiv2
//     {

//         static void Main()
//         {

//             int[,] dvumMassiv ={
//             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
//             };
//             int i, j;
//             int s = 0;//счетчик
//             int summastrok = 0;
//             int summastolbcov = 0;
//             //цикл для создания массива через счетчик
//             for (i = 0; i < 10; i++)//строки
//             {

//                 System.Console.WriteLine();

//                 for (j = 0; j < 10; j++)//столбцы
//                 {
//                     dvumMassiv[i, j] += s;//счетчик
//                     System.Console.Write(" " + dvumMassiv[i, j]);//вывод массива
//                     s++;
//                 }
//             }


//             int[] max = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

//             //цикл для подсчета суммы по столбцам и строкам
//             for (i = 0; i < 10; i++)
//             {

//                 for (j = 0; j < 10; j++)
//                 {

//                     summastrok += dvumMassiv[i, j];
//                     summastolbcov += dvumMassiv[j, i];
//                     if (j == 9)
//                     {
//                         System.Console.WriteLine(" сумма по строке = " + summastrok);
//                         System.Console.WriteLine(" сумма по столбцу = " + summastolbcov);
//                         summastrok = 0;
//                         summastolbcov = 0;
//                     }

//                 }

//             }

//             int a = 0;

//             for (i = 0; i < 10; i++)
//             {

//                 for (j = 0; j < 10; j++)
//                 {
//                     a = max[j];
//                     if (i == j)
//                     {
//                         max[j] = dvumMassiv[i, j];
//                         System.Console.WriteLine(" " + max[j]);
//                         if (a < max[j])
//                         {
//                             a = max[j];
//                         }
//                     }

//                 }

//             }
//             System.Console.WriteLine("максимум по диаганали " + a);


//         }


//     }
// }