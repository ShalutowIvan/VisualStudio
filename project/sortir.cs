// using System;
// using System.Collections.Generic;

// namespace project
// {
//     class sortir
//     {
//         static void Main()
//         {

//             int[] mas = new int[12];
//             //int[] mas2 = new int[];
//             Random gen = new Random();//создали переменную для функции рандом
//             for (int i = 0; i < mas.Length; i++)
//             {
//                 mas[i] = Convert.ToInt32(gen.Next(0, 100));//с помощью переменной рандом создали рандомные числа массива
//                 System.Console.WriteLine(" " + mas[i]);
//             }

//             int razmer = nechet(mas);
//             int[] mas2 = new int[razmer];//посчитали размерность нового массива нечетных чисел
//             int razmer3 = chet(mas);
//             int[] mas3 = new int[razmer3];

//             int k = 0;
//             for (int j = 0; j < mas.Length; j++)
//             {

//                 if (mas[j] % 2 == 1)
//                 {
//                     mas2[k] = mas[j];
//                     //   System.Console.WriteLine("нечетные " + mas2[k]);
//                     k++;
//                 }
//             }
//             int temp;
//             for (int j = 0; j < mas2.Length - 1; j++)
//             {
//                 for (int i = 0; i < mas2.Length - 1 - j; i++)
//                 {
//                     if (mas2[i] > mas2[i + 1])
//                     {
//                         temp = mas2[i];
//                         mas2[i] = mas2[i + 1];
//                         mas2[i + 1] = temp;
//                     }

//                 }
//             }
//             System.Console.WriteLine("Нечетные:");
//             Print(mas2);//функция для вывода массива в консоль




//             int z = 0;

//             for (int a = 0; a < mas.Length; a++)
//             {

//                 if (mas[a] % 2 == 0)
//                 {
//                     mas3[z] = mas[a];
//                     // System.Console.WriteLine("четные " + mas3[z]);
//                     z++;
//                 }

//             }

//             for (int j = 0; j < mas3.Length - 1; j++)
//             {
//                 for (int i = 0; i < mas3.Length - 1 - j; i++)
//                 {
//                     if (mas3[i] > mas3[i + 1])
//                     {
//                         temp = mas3[i];
//                         mas3[i] = mas3[i + 1];
//                         mas3[i + 1] = temp;
//                     }
//                 }
//             }
//             System.Console.WriteLine("Четные:");
//             Print(mas3);



//             // for (int i = 0; i < mas.Length; i++)
//             // {
//             //     if (mas[i] % 2 == 1)
//             //     {
//             //         mas2[i] = mas[i];

//             //     }



//             // }



//             // for (int i = 0; i < 6; i++)
//             // {
//             //     mas2[i] = mas[i];

//             // }

//             //подсчет четных и нечетных чисел
//             // for (int k = 0; k < M.Length; k++)
//             // {
//             //    if (M[k] % 2 == 1)
//             //    {
//             //       M1[k1] = M[k];
//             //       k1++;
//             //    }
//             //    else
//             //    {
//             //       M2[k2] = M[k];
//             //       k2++;
//             //    }
//             // }


//         }

//         public static int nechet(int[] perv)//функция для подсчета размерности нечетного массива
//         {
//             int count = 0;
//             for (int i = 0; i < perv.Length; i++)
//             {
//                 if (perv[i] % 2 == 1)
//                 {
//                     //last[i] = perv[i];
//                     count += 1;
//                 }
//             }
//             return count;

//         }

//         public static int chet(int[] vtor)//функция для подсчета размерности четного массива
//         {
//             int count1 = 0;
//             for (int i1 = 0; i1 < vtor.Length; i1++)
//             {
//                 if (vtor[i1] % 2 == 0)
//                 {
//                     count1 += 1;
//                 }
//             }
//             return count1;

//         }



//         public static void Print(int[] pechat)
//         {

//             for (int i = 0; i < pechat.Length; i++)
//             {
//                 System.Console.WriteLine("Элемент " + pechat[i]);
//             }

//         }


//     }
// }