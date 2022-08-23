//10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

//Console.Write("Введите трехзначное число: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int rezult = (number / 10 % 10);

//Console.WriteLine($"Введенное число: {number}, результат: {rezult}");


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Console.WriteLine("Введите число");
//string number = Convert.ToString(Console.ReadLine());

//int n = number.Length;
//Console.WriteLine($"Количество цифр {n}");

//if ((n - 1) > 1) Console.WriteLine($"Третья цифра введенного числа = {number[2]}"); 

//else Console.WriteLine("Третьей цифры нет");


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7) Console.WriteLine("Введенная цифра не соответствует дню недели");

else
   { 
    if (number < 6 ) Console.WriteLine("Этот день не является выходным");

    else Console.WriteLine("Этот день является выходным");
   }
