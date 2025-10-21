float nota1, nota2, nota3, nota4;


Console.WriteLine("Digite a primeira nota");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota");
nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a quarta nota");
nota4 = float.Parse(Console.ReadLine());

float nota_final = (nota1 + nota2 + nota3 + nota4) / 4;
Console.WriteLine("Sua média é:" + nota_final);

if(nota_final >= 7.0)
{
    Console.WriteLine("APROVADO");
}
else if (nota_final >= 5.0 && nota_final < 7.0)
{
    Console.WriteLine("Recuperacao");
}
else{
    Console.WriteLine("REPROVADO");
}