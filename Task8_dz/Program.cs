Console.Write("Введите число ");
string? N_str = Console.ReadLine();
int N = Convert.ToInt32(N_str);
for(int i = 1;i < N+1;i++)
{
    int result = i % 2;
    if(result == 0)
    {
    Console.Write(i + " "); 
    }
}    
