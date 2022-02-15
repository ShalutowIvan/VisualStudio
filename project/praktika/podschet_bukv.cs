// using System;
// using System.IO;
// namespace project
// {
//     class praktika
//     {
//         static void Main()
//         {
//             int count = 0;
//             System.Console.WriteLine("Введите слово, в котором нужно посчитать количество нужных тебе символов: ");
//             string slovo = Console.ReadLine();
//             //System.Console.WriteLine(slovo);
//             //System.Console.WriteLine("Введите символ, количество которого вам нужно узнать из текста введенного ранее: ");
//             //string bukva;
//             string bukva = " ";
//             // bukva = Console.ReadLine();
//             // while (bukva.Length != 1)
//             // {
//             //     System.Console.WriteLine("вы ввели слишком много символов, нужно ввести только 1 символ, попробуйте еще раз: ");
//             //     bukva = Console.ReadLine();
//             // }
//             for (int i = 0; i < slovo.Length; i++)
//             {
//                 string b = Convert.ToString(slovo[i]);
//                 if (b == bukva)
//                 {
//                     count++;
//                 }
//             }
//             System.Console.WriteLine("Число нужных вам букв: " + count);
//             Console.ReadKey();
//         }
//     }
// }
