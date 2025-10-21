Console.WriteLine($"Digite seu nome");
string nome = Console.ReadLine();
Console.WriteLine($"Digite seu sobrenome");
string sobrenome = Console.ReadLine();

Console.WriteLine($"Ok, {nome}! Agora vamos dar as boas vindas a voce!!");

Console.WriteLine($"por favor escolha uma opcao abaixo:");
Console.WriteLine($"1 - Saudar com nome");
Console.WriteLine($"2 - Saudar com sobrenome");
Console.WriteLine($"3 - Saudar com nome e sobrenome");
Console.WriteLine($"4 - Apenas saudacao generica");
Console.Clear();

int opcao = 0;

switch (opcao)
{
    case 0:
        SaudacaoGenerica();
        break;
    case 1:
        SaudarComNome(nome);
        break;
    case 3:
        string nomeCompleto = DevolveNomeCompleto(nome, sobrenome);
        Console.WriteLine($"Seja bem-vindo {nomeCompleto}");
        break;
    default:
        break;
}

void SaudarComSobrenome(string sobrenomeRecebido)
{
    Console.WriteLine($"Ola, seja bem-vindo {sobrenomeRecebido}");
}

void SaudacaoGenerica()
{
    Console.WriteLine($"Ola, seja bem vindo ao nosso programa, tenha um otimo dia :)");
}

void SaudarComNome(string nomeRecebido)
{
    Console.WriteLine($"Seja bem-vindo, {nomeRecebido}");
}

string DevolveNomeCompleto (string nomeRecebido, string sobrenomeRecebido)
{

    return $"{nomeRecebido} {sobrenomeRecebido}";
}