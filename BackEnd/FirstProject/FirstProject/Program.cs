//// Screen Sound

string welcomeMessage = "Boas Vindas ao Screen Sound";
List<string> groupList = new List<string> { "Fundo de Quintal", "Encontro de Batuqueiros", "Bom Gosto"};

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
    DisplayWelcomeMessage();
    Console.WriteLine("\nDigite 1 para registar um grupo");
    Console.WriteLine("Digite 2 para mostrar todas os grupos");
    Console.WriteLine("Digite 3 para avaliar um grupo");
    Console.WriteLine("Digite 4 para exibir a média de um grupo");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string optionChosen = Console.ReadLine()!;
    int optionChosenNumerically = int.Parse(optionChosen);

    switch (optionChosenNumerically)
    {
        case 1:
            RegisterGroup();
            break;
        case 2:
            ShowRegisteredGroups();
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

void RegisterGroup() 
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("Registro de grupo de samba | pagode");
    Console.WriteLine("***********************************\n");
    Console.Write("Digite o nome do grupo que você deseja registrar: ");

    string nameGroup =  Console.ReadLine()!;
    groupList.Add(nameGroup);
    Console.WriteLine($"O Grupo {nameGroup} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    DisplayMenuOptions();
}

void ShowRegisteredGroups()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todos os grupos registrados");
    Console.WriteLine("************************************\n");

    //for(int i = 0; i < group.Count; i++ ) 
    //{
    //    Console.WriteLine($"Grupo: {group[i]}");
    //}

    foreach(string group in groupList) {
        Console.WriteLine($"Grupo: {group}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar a menu principal");
    Console.ReadKey();
    Console.Clear();
    DisplayMenuOptions();
}

DisplayMenuOptions();