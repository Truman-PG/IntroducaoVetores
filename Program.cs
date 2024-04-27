// Vetor de nomes
string[] nomes = new string[10];

// Vetor de idades
int[] idades = new int[10];

// Laço de repetição para inserção de nome e idade
for (int index = 0; index < nomes.Length; index++)
{
    // Pergunta o nome
    Console.WriteLine("Coloque o nome:");
    nomes[index] = Console.ReadLine();

    // Pergunta a idade
    Console.WriteLine("Coloque a idade:");
    idades[index] = int.Parse(Console.ReadLine());

    // Limpa a tela
    Console.Clear();
}

// Laço de repetição para verificar os maiores de idade
for(int indice = 0; indice < idades.Length; indice++)
{
    // Condição verificando a idade se é maior de 18
    if (idades[indice] >= 18)
    {
        Console.WriteLine("Pessoas maiores de idade:");

        //Mostra as pessoas maiores de idade
        Console.WriteLine(nomes[indice]);
    }
}