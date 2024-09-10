// First Game

void GameNumbers()
{
    Random aleatorio = new Random();
    int chosenNumber = aleatorio.Next(1, 101);

    do {
        Console.WriteLine("Digite um número");

        int chute = int.Parse(Console.ReadLine());

        if (chute == chosenNumber)
        {
            Console.WriteLine("Parabéns! Você acertou o número.");
            break;
        }
        else if (chute < chosenNumber)
        {
            Console.WriteLine("O número é maior.");
        }
        else
        {
            Console.WriteLine("O número é menor.");
        }
    } while (true);

    Console.WriteLine("O jogo acabou. Você acertou o número secreto!");
}

GameNumbers();