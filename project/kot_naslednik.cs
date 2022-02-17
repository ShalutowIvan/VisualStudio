using System;

namespace project
{
    class kot_naslednik : robot //написали название класса kot_naslednik, оно соответсвует названию файла, потом двоеточие и название класса родителя, то есть класса от которого мы все наследуем. 
    //Несколько классов родителей нельзя написать, этого нет в C#, но есть в С++
    //поля с модификаторами доступа private не доступные в классе наследнике, но поля с модификатором доступа protected будут доступны, также public будут доступны везде
    {
        public int Health//создали аксессор, это типа дополнительное свойства объекта, как будто дополнительная переменная для объекта. Но ее можно расписать как функцию. Мы не стали расписывать ее как функцию
        {
            get;
            set;
        }

        public void Lazer()//создали функцию в классе наследнике
        {
            System.Console.WriteLine("мяукание, мяу мяу мяу");
        }
        //конструктор в классе наследнике
        public kot_naslednik() //это конструктор, название конструктора всегда соответствует названию файла и названию класса, то есть название класса файла равно названию конструктора, и доплнительно дописываем скобки как у функций. Так пишется конструктор
        //этот конструктор действует по умолчанию без различных параметров
        {

        }

        public kot_naslednik(string name, int ves, byte[] coordinates, int health) : base(name, ves, coordinates)
        //этот конструктор принимает несколько значений, мы их описываем как обычно как в обычном конструкторе и дополнительно указываем параметр в который присваиваем значения из аксессора дописываем дополнительный значение из аксессора(дополнительный параметр объекта). 
        //потом ставим двоетичие и пишем откуда берется база значений из класса родителя , пишем base(name, ves, coordinates) то есть параметры из класса родителя основных значений берем из класа родителя. base это обращение к классу родителю, там они(параметры) будут переданы в тот конструктор который будет соответствовать списку параметров, то есть будет ему подходить(подоходящий конструктор из класса родителя выберется автоматически). И например если выбрать только ves в качестве парамтра, то выбрался бы конструктор с одним параметров ves из класса родителя
        //В самом конструкторе не нужно писать что будет происходить в конструкторе, так как он возьмет все действия из родителя. Но нужно дописать только действия по дополнительному параметру
        //теперь при создании объекта конструктор будет срабатывать и передавать все параметры через конструктор который мы тут прописали
        {
            this.Health = health;//аксессору присвоили параметр из конструктора
                                 //создали конструктор такой же как в классе родителе
                                 // base.printZnach();//убрали эту функцию, так как мы ее перепишем

            //используем функцию из класса родителя для вывода значений конструкторе наследнике, для прописали base.base.printZnach(); для вызова функции из класса родителя
            //  System.Console.WriteLine("здоровье " + Health);
        }

        public void pasport()
        {
            this.FIO = "saimon";//обратились к переменной с protected и ошибки не было, обращаться можно как через this. и название переменной, так и через base. и название переменной
                                //теперь у нас есть поле которое можно редактировать как в основном классе так и в классе наследнике
            System.Console.WriteLine(FIO);//тут мы вывели свойство объекта как переменную в консоль, когда будем вызывать эту функцию то будет выводиться свойство объекта в консоль. 
        }

        public static void mer()
        {
            robot.dlina = 15;
            System.Console.WriteLine("длиннааааааааааааааааа " + dlina);
        }
        //если переменная с модификатором доступа любым, то эта переменная только для свойства объекта, и вызвать функцию с этой переменной нельзя
        //если переменная с модификатором доступа, то эта переменная только для свойства объекта, и вызвать функцию с этой переменной нельзя. Но если прописать модификатор static, то можно будет обратиться к этому полю через название класса.

        //классов наследников может быть много, например может какой то отдельный клас для подключения к базе данных

        // public override void printZnach()//перезаписываем функцию вывода из родительтского класса
        // {
        //     base.printZnach();//выов функции родителя
        //     System.Console.WriteLine("Health " + this.Health);
        // }
        //теперь при создании объекта на основе класса наследника и выводе через функцию вывода printZnach будет браться перезаписанная функция из класса наследника. при создании объекта на основе класса родителя будет браться метод из родительского класса не перезаписанный без Health
        //код из базовой функции base. и тд можно ставить вначале или в конце, тогда выполнится первым или последним, смотря куда его написать
        //желательно сохранять базовую концепцию, это считается каноном програмирования, то есть так писать принято и так правильно
        //то есть переписанный код должен содержать базовую концепцию, он не должен выполнять функции коордилаьно отличающиеся
        //такое работать будет, но так не правильно. если нужна другая функция, то нужно создать другую функцию

        public override void printZnach()//перезаписываем функцию вывода из родительтского класса
        {

            System.Console.WriteLine(this.Name + " вес " + this.Ves);
            //перезаписали функцию вывода для второго наслденика, но без координат, но со здоровьем
            System.Console.WriteLine("Health " + this.Health);
        }

    }
}