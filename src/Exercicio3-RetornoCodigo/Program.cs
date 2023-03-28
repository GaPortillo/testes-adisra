int ff(int n)
{
    if (n == 1) return 1;
    if (n % 2 == 0) return ff(n / 2);
    return ff((n - 1) / 2) + ff((n + 1) / 2);
}

Console.WriteLine(ff(7));
//Resposta : 3
