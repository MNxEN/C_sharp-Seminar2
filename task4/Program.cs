//4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

int ReadInt(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int num = ReadInt("Введите число: ");

if (num % 7 == 0 && num % 23 == 0) 
{
    System.Console.WriteLine("Число кратно одновременно 7 и 23");
}
else
{
    System.Console.WriteLine("Число не кратно 7 и 23");
}
