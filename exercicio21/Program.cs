        int numero, soma = 0;

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Digite o {i}º número inteiro:");
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        }

        Console.WriteLine($"A soma dos números eh: {soma}");