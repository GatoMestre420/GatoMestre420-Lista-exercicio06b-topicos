class Program
{
    static void Main(string[] args)
    {
        // Criando um vetor de 100 posições
        Console.Clear();
        int[] vetor = new int[100];
        Random aleatorio = new Random();
        //Preencher vetores com valores aleatórios

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = aleatorio.Next(100);
        }
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        Array.Sort(vetor);

        Console.WriteLine("\n\n");

        // imprimir pela segunda vez ordenado
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
        }

    }
}