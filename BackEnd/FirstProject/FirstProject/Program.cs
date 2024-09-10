//// Screen Sound

string welcomeMessage = "Boas Vindas ao Screen Sound";

void DisplayWelcomeMessage()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(welcomeMessage);
}

void DisplayMenuOptions()
{
    Console.WriteLine("\nDigite 1 para registar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string optionChosen = Console.ReadLine()!;
    int optionChosenNumerically = int.Parse(optionChosen);

    switch (optionChosenNumerically)
    {
        case 1:
            Console.WriteLine("Você digitou a opção " + optionChosenNumerically);
            break;
        case 2:
            Console.WriteLine("Você digitou a opção " + optionChosen);
            break;
        case 3:
            Console.WriteLine("Você digitou a opção " + optionChosen);
            break;
        case 4:
            Console.WriteLine("Você digitou a opção " + optionChosen);
            break;
        case -1:
            Console.WriteLine("Bye bye :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }


}

DisplayWelcomeMessage();
DisplayMenuOptions();