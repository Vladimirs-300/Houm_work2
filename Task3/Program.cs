// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

int Number = Prompt("Введите трёхзначное число > ");
if (Number < 1000 && Number > 99)
{
    int result = Number % 10;
    System.Console.WriteLine(result);

}
else
{
    System.Console.WriteLine("Ввели не трехзначное число!!!");
}