// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int num1 = ReadInt("Введите первое число: ");
int num2 = ReadInt("Введите первое число: ");
int res = num1 % num2;
if (res== 0) 
{
    System.Console.WriteLine("Второе число кратно первому");
}
else
{
    System.Console.WriteLine($"остаток от деления {res}");
}

