//Числа Фибонначи

double Fibona(int n)
{
    if(n==1 || n==2) return 1;
    else return Fibona(n-1)+ Fibona(n-2);
}

for (int i = 1; i < 50; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibona(i)}");
}

