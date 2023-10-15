Console.Write("Введите первое число ");
string? num1_str = Console.ReadLine();
int num1 = Convert.ToInt32(num1_str);
Console.Write("Введите второе число ");
string? num2_str = Console.ReadLine();
int num2 = Convert.ToInt32(num2_str);
Console.Write("Введите третье число ");
string? num3_str = Console.ReadLine();
int num3 = Convert.ToInt32(num3_str);
int max = num1;

if(max < num2)
{
    max = num2; 
}
if (max < num3)
{
    max = num3;
}
Console.Write(max);
