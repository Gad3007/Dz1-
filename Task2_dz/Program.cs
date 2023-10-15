Console.WriteLine("Введите первое число ");
string? num1_str = Console.ReadLine();
int num1 = Convert.ToInt32(num1_str);
Console.WriteLine("Введите второе число ");
string? num2_str = Console.ReadLine();
int num2 = Convert.ToInt32(num2_str);
if(num1 > num2)
{
    Console.Write("max = " + num1);
}
else
{
    Console.Write("max = " + num2);
}