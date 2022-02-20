// using System;

// namespace project
// {
//     class kot_murzik : robot //еще один наследник класса robot
//     {


//         public kot_murzik()//пустой конструтор тоже нужен
//         {

//         }

//         public kot_murzik(int ves) : base(ves)
//         {
//         }

//         public kot_murzik(string name, int ves, byte[] coordinates) : base(name, ves, coordinates)
//         {
//             //конструктор срабатывает также как в классе родителе, то есть берет функционал из родителя
//         }

//         public override void printZnach()
//         {
//             //throw new NotImplementedException();//эта строка означает ошибку в момент когда код не реализован
//             System.Console.WriteLine(this.Name + " вес " + this.Ves + ". Координаты: ");//для вывода можно обращаться к аксессору, чтобы был доступ, так как в robot модификатор доступа private у переменных. В аксессоре мы прописали что получать свойство можно, а записывать значения нельзя новое в переменную. Аксессоры значокм ключа отображаются
//             foreach (byte el in this.Coordinates)
//             {
//                 System.Console.Write(el + " ");

//             }
//         }
//     }
// }