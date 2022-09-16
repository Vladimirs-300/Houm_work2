int Prompt(string message)

{
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    int Value = int.Parse(strValue);
    return Value;
}

string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

int value = Prompt("Введите день недели > ");
if (value < 0 || value > 7)
{
    System.Console.Write("Нет такого дня");
}
else
{

    int daysValue = value - 1;
    System.Console.WriteLine($"{value} -> {days[daysValue]}");
}
if (value == 6 || value == 7)
{
    Console.WriteLine("(этот день выходной) -> да");
}