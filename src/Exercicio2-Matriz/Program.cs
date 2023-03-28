static void OcorrenciasMatriz(int[,] minhaMatriz)
{
    int impar = 0, par = 0;

    foreach (var i in minhaMatriz)
    {
        if (i % 2 == 0)
        {
            par++;
        }
        else
        {
            impar++;
        }

    }

    if (par > impar)
    {
        Console.WriteLine($"Par obteve o maior numero de ocorrencias: {par}");
    }
    else if (par < impar)
    {
        Console.WriteLine($"Impar obteve o maior numero de ocorrencias: {impar}");
    }
    else
    {
        Console.WriteLine($"Ambos obtiveram o mesmo numero de ocorrencias: {par}");
    }
}

var minhaMatriz = new int[,] {{1,2},{1,3},{1,4}};

OcorrenciasMatriz(minhaMatriz);