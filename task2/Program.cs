// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

  int num = Random().Next(10,100);  

Console.Writeline("Ваше число: ");

int Max (int number)

{    
    if (number % 10 > number / 10)
            return true;
    
    System.Console.WriteLine("Число не трехзначное");
    return false;
}