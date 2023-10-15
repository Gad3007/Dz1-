Console.Write("Введите число ");
string? num_str = Console.ReadLine();
int num = Convert.ToInt32(num_str);
if (num != 0)
{
    int result = num % 2;
    if(result > 0)
    {
        Console.Write("Нет");
    }
    else
    {
        Console.Write("Да");
    }
}