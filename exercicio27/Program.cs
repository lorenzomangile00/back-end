int q = 0, i = 1, n = 1;
q = int.Parse(Console.ReadLine());

Console.WriteLine($"Quantos numeros quer digitar?");

while (n <= q)
{
    Console.WriteLine("Digite um numero");
    i = int.Parse(Console.ReadLine());
    if (i % 2 == 0)
    {
        Console.WriteLine($"O numero digitado eh par{i}");
    }
    n++;
}