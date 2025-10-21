double salario = 0.0, gasto = 0.0;

Console.WriteLine("Informe o salário recebido");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o total gasto");
gasto = double.Parse(Console.ReadLine());

if(salario > gasto)
{
    Console.WriteLine("Gastos dentro do orçamento");
} else
{
    Console.WriteLine("Orçamento estourado");
}