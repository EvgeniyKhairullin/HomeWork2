void Zadacha9()
{
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Random rand = new Random();
int number  = rand.Next(100, 1000);
Console.WriteLine(number);
//int ones = number % 10;
//int hanth = number / 100;
int tens = number/10 % 10;
Console.WriteLine(tens);
}


void Zadacha13()
{
/*Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа
или сообщает, что третьей цифры нет */
Random rand = new Random();
int number  = rand.Next(1, 100000000);  //Почему нельзя проверить числа до 1000000000000000000000? выдает ошибку
Console.WriteLine(number);
if (number < 100)
{
    Console.WriteLine("Отсутствует третья цифра");
}
else
{
    while (number > 999)
    {
        number/=10;
    }
    Console.WriteLine(number%10);
}
}



void Zadacha15()
{
       //Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
Random rand = new Random();
int day  = rand.Next(1, 8);  
Console.WriteLine(day);

if (day == 1)
{
    Console.WriteLine ("Понедельник. Не является выходным ");
}
if (day == 2)
{
    Console.WriteLine ("Вторник. Не является выходным ");
}
if (day == 3)
{
    Console.WriteLine ("Среда. Не является выходным ");
}
if (day == 4)
{
    Console.WriteLine ("Четверг. Не является выходным ");
}
if (day == 5)
{
    Console.WriteLine ("Пятница. Не является выходным ");
}
if (day == 6)
{
    Console.WriteLine ("Суббота. Выходной день ");
}
if (day == 7)
{
    Console.WriteLine ("Воскресенье. Выходной день ");
}

}


  




//Zadacha9();
//Zadacha15();
//Zadacha13();