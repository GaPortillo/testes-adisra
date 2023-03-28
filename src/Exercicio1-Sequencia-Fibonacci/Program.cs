int num1 = 0;
int num2 = 1;
int aux;
var fibonacci = new List<int> {num1, num2};

Console.WriteLine("Digite o numero da sequencia");
int resposta = Int32.Parse(Console.ReadLine()!);

for (int i = 1; i < resposta - 1; i++)
{
    aux = fibonacci[i - 1];
    num1 = fibonacci[i];
    num2 = num1 + aux;
    fibonacci.Add(num2);

}

Console.WriteLine(fibonacci.LastOrDefault());