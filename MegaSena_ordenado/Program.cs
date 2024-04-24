int[] mega = new int[6];
int aux = 0;


Console.WriteLine("Numeros da mega:");
for (int i = 0; i < 6; i++)
{
    mega[i] = new Random().Next(1, 61);
    Console.WriteLine($"{i + 1} - {mega[i]}");

    for (int j = 0; j < 6; j++)
    {
        //GERANDO NOVO VALOR CASO JA EXISTA ALGUM IGUAL NO VETOR
        if (mega[i] == mega[j] && (i != j))
        {
            mega[j] = new Random().Next(1, 61);
            Console.WriteLine($"Valor trocado -> {mega[j]}");
        }
    }

}

Console.WriteLine("--------");
//ORDENANDO
for (int r = 0; r < 6; r++)
{
    for (int c = r + 1; c < 6; c++)
    {
        if (mega[r] > mega[c])
        {
            aux = mega[r];
            mega[r] = mega[c];
            mega[c] = aux;
        }
    }

    Console.WriteLine($"{r + 1} - {mega[r]}");
}