// using System;
// using System.IO;//input oustream библиотека которая служит для ввода и вывода информации из определенных файлов, предоставляет доступ к класса для работы с файлами
// namespace project
// {
//     class stroki
//     {
//         static void Main()
//         {
//             // string word = "Hello";
//             //    word += "!!";
//             //    System.Console.WriteLine(word[1]);//выводим третий элемент из массива типа стринг это будет бука l
//             //System.Console.WriteLine(word.Length);//колво символов строки
//             //    word = String.Concat(word, "world");//класс String функция Concat добавляют символы к переменной и все это значение присваиваем переменной, добавляем подстроку
//             //     System.Console.WriteLine(word);
//             //сравниваем массивы строк
//             //      System.Console.WriteLine(String.Compare(word, "Hello--hello"));//сравниваем переменную word с текстом в кавычках, элементов в слове в кавычках будет меньше, то результат будет в виде цифры 1, если больше то цифра -1,  если совпадет то 0
//             //  string ludi = "alex,jhon,ivan"; //это не масссив а строка имена через запятую
//             //разобьем строки на массив строк где каждое имя это имя пользователя
//             //создаем массив names, и строку можно разбить строку на массив строк, где каждое имя это элемент массива, разбивка идет по символу ,
//             //     string[] names = ludi.Split(new char[] { ',' });//массиву names присвоили разбитый массив из строки ludi по запятой, то есть эта функция разбивает строку по определенному символу на массив и записываем ее в другой массив
//             //     foreach (string el in names)
//             //    {
//             //        System.Console.Write("сука " + el + " ");//вывели массив через цикл foreach
//             //   }

//             //функция преобразования массива в строку
//             //   string people = String.Join(" ", names);     //класс String, метод Join, в скобках в кавычках сначала указывается через какой символ будет объединение, далее указываем массив с которым работаем и все это присваиваем в какую либо переменную
//             //   System.Console.WriteLine(" ");
//             //    System.Console.WriteLine(people);
//             //функция Trim удаляет лишние пробелы до и после какой либо отдельной строки 
//             //    string re = "         far        ";
//             //    System.Console.WriteLine(re.Trim());
//             //функция Substring указывает с какого элемента по какой будем обрезать строку
//             //     string asd = "Jonnantan";
//             //    System.Console.WriteLine(asd.Substring(2));//первые 2 элемента удалены
//             //    System.Console.WriteLine(asd.Substring(0, asd.Length - 1));//0 означает что в начале строки ничего не удаляем, asd.Length - 1 означает что удалили 1 элемент с конца
//             //функция StartsWith если строка начинается с таких же символов то будет результат тру иначе фолз
//             //функция Tolower переводит весь текст к нижнему регистру, ToUpper к верхнему регистру

//             //           работа с файлами
//             //директива using позволяет создать изолированный код где можно закрыть и открыть файл
//             //создаем строку которую запишем внутри файла
//             // System.Console.WriteLine("Введи буквы");
//             //    string bukvi = Console.ReadLine();
//             //    using (FileStream nazvanieObjekta = new FileStream("info.txt", FileMode.OpenOrCreate))//откроем файл для записи. Обращаемся к классу FileStream(он открывает файл для чтения или для записи), потом пишем название объекта, потом выделяем память new FileStream, в скобках пишем название файл внутри проекта, чтобы он создался пишем FileMode (перечисление), потом выбираем как откроем файл (для добавления инфы или создания, создать файл если его нет и другие там выбор) мы выбираем OpenOrCreate это открыть или создать
//             //    {
//             //переводим текст в байты, чтобы записать текст в файл, он должен быть преобразован в байты(0 и 1)
//             //      byte[] massiv = System.Text.Encoding.Default.GetBytes(bukvi);//создаем массив типа byte и пишем название массива, пишем =, потом обращаемся к библиоткеке System, пишем Text, потом пишем класс Encoding, Default - по умлочанию, потом пишем метод GetBytes и в скобках пишем переменную текста в которую записали данные от пользователя. Теперь этот массив в байтах можно записать. Если проще переводим буквы в байты

//             //обращаемся к объекту nazvanieObjekta, который мы ранее создали, и пишему функцию Write, она позволяет записать данные внутрь файла, в скобках пишем массив, потом указываем возможный отступ, потом указываем до какого элемента будет это записывать, если нужно полностью записать, то пишем всю длинну массива massiv.Length
//             //nazvanieObjekta.Write(massiv, 0, massiv.Length);




//             //          СЧИТЫВАНИЕ ДАННЫХ ИЗ ФАЙЛА
//             using (FileStream object2 = File.OpenRead("info.txt"))//изолированный код, можно писать те же названия переменных что и в предыдущем using. Пишем класс FileStream, потом пишем название объекта, выделение памяти тут не надо, потом обращаемся к файлу и пишем метод OpenRead, в скобках пишем название файла, 
//             {
//                 //инфу из файла получаем также в байтах, и записываем в массив
//                 byte[] massiv = new byte[object2.Length];//устанавливаем длинну для массива
//                 object2.Read(massiv, 0, massiv.Length);   //обращаемся к объекту object2, метод Read, в скобках пишем в какой массив запишем, пропуск 0, 
//                 string strokaIsFaila = System.Text.Encoding.Default.GetString(massiv); //преобразовываем байты в строки
//                 System.Console.WriteLine(strokaIsFaila + " СУКА");
//             }
//         }

//     }
// }

