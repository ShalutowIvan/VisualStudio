//using System;
//using System.IO;
//namespace Project
//{
//  class uslovia
//{
//  static void Main()
//{
//            int a = 5;
//          if (a == 5)
//        {
//System.Console.WriteLine("Номер равен 5");
//    }
// string word = "hello";
//if (word == "hello")
// {
//System.Console.WriteLine(word);
//}
// bool isHappy = true;
//для сравнения пишется знак = 2 раза, то есть ==, другие операторы сравнения : <, >, ==, <=, >=, !=
//для булевых значений не обязательно писать условие, так как там либо тру либо фолз, но можно прописать просто значение переменной
//if (isHappy == true)
//{
//тоже самое можно записать без равенства для булевой переменной, в случает если тру код выполняется
//}
//if (isHappy)
// {
//  }

//if (!isHappy)//тут в случает если не тру то есть false то код выполняется
//{
//множественные условия
//фигурные скобки не обязательные для операторов условий, если после условия if идет одна строчка кода
//  bool isHasCar = true;

//int a = 5;
//if (a != 5)
//    System.Console.WriteLine("Номер не равен 5");

//else if (a == 5)
//{
//   System.Console.WriteLine("номер больше 7");
//  if (isHasCar)
//     System.Console.WriteLine("user has car");
// }
// else
//   System.Console.WriteLine("Номер равен 5");
//двойные условия 
/*
 int a = 5;
 bool ishascar = true;
 if (a == 5 && ishascar)
 { //должны сработать оба условия чтобы условие выполнилось то есть и первое и второе, оператор условный && называется "и"
     System.Console.WriteLine("все отлично");
 }
 else
 {
     System.Console.WriteLine("миша все фуйня давай заново");
 }


    int a = 5;
    bool ishascar = false;
    if (a == 5 || ishascar)
    { //должен сработать хотя бы одно условие чтобы условие выполнилось то есть первое или второе, оператор условный || называется "или"
        System.Console.WriteLine("все отлично");
    }
    else
    {
        System.Console.WriteLine("миша все фуйня давай заново");
    }


   int a = 5;
   bool ishascar = false;
   if ((a == 5 || ishascar) && a > 2)
   {
       System.Console.WriteLine("все отлично");
   }
   else
   {
       System.Console.WriteLine("миша все фуйня давай заново");
   }


//string role;
//write пишет надпись без перехода на следующую строку
string role;
string username;
System.Console.Write("введите роль: ");
role = Console.ReadLine();


if (role == "Admin")
{
    System.Console.Write("Введите имя: ");
    username = Console.ReadLine();
    System.Console.Write("{0} введи возраст", username);
    short age = Convert.ToInt16(Console.ReadLine());

    if (age <= 0 || age > 99)
    {
        Console.Write("{0} введи возраст ", username);
        age = Convert.ToInt16(Console.ReadLine());
    }

    if (age <= 0 || age > 99)
    {
        Console.WriteLine("Error");
        age = 10;

    }
    else
    {
        System.Console.WriteLine("Возвраст пользователя - " + age);
    }


}
else
{
    System.Console.WriteLine("you not admin");
}


//условный оператор switch case
short user_input = Convert.ToInt16(Console.ReadLine());
switch (user_input)
{
    case 5://запись означает если user_input = 5 , то далее код. Кейсов можно написать много, но условие в каждом одно, проверяется только на равенство, другие условия типа > < нельзя проверить 
        System.Console.WriteLine("Number is 5");
        break;// конец условия вместо фигурных скобок
    case 15:
        System.Console.WriteLine("Number is 15");
        break;
    case 25:
        System.Console.WriteLine("Number is 25");
        break;
    case 115:
        System.Console.WriteLine("Number is 115");
        break;
    default: // оператор default работает примерно также как оператор else, если ни один из кейсов не сработал то выполняется default
        System.Console.WriteLine("Дырка");
        break; //завершается также оператором break
               //свитч кейс используется для проверки значений нескольких переменных введенных от пользователя например, в случае с if else будет не удобно




}



}


}

}
*/
