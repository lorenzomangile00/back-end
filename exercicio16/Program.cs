string cargo;
double salario, salario_reajustado, aumento;

Console.WriteLine("Digite seu cargo");
cargo = Console.ReadLine();
Console.WriteLine("Digite seu salario");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao")
{
    aumento = salario * (6.5/100);
    salario_reajustado = salario + aumento;
        Console.WriteLine("Seu salario reajustado eh:" + salario_reajustado);
}
else if (cargo == "administrativo")
{
    aumento = salario * (7.5 / 100);
    salario_reajustado = salario + aumento;
    Console.WriteLine("Seu salario reajustado eh:" + salario_reajustado);
}
else
{
    aumento = salario * (12 / 100);
    salario_reajustado = salario + aumento;
    Console.WriteLine("Seu salario reajstado eh:" + salario_reajustado);
}