//// Screen Sound

string welcomeMessage = "Boas Vindas ao Screen Sound";
//List<string> groupList = new List<string>();

Dictionary<string, List<int>> registeredGroups = new Dictionary<string, List<int>>();

registeredGroups.Add("Fundo de Quintal", new List<int> { 10, 10, 10 });
registeredGroups.Add("Revelação", new List<int> { 10, 09, 10 });


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
            EvaluatingGroup();
            break;
        case 4:
            GroupAverage();
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
    DisplayTheOptionTitle("Registro de grupo de samba | pagode");
    Console.Write("Digite o nome do grupo que você deseja registrar: ");

    string nameGroup = Console.ReadLine()!;
    registeredGroups.Add(nameGroup, new List<int>());
    Console.WriteLine($"O Grupo {nameGroup} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    DisplayMenuOptions();
}

void ShowRegisteredGroups()
{
    Console.Clear();
    DisplayTheOptionTitle("Exibindo todos os grupos registrados");

    //for(int i = 0; i < group.Count; i++ ) 
    //{
    //    Console.WriteLine($"Grupo: {group[i]}");
    //}

    foreach (string group in registeredGroups.Keys)
    {
        Console.WriteLine($"Grupo: {group}");
    }

    ActionBackMenu();
}

void EvaluatingGroup()
{
    // digite qual grupo deseja avaliar
    // se a banda existir no dicionario >> atribuir uma nota
    // senão, volta ao menu principal

    Console.Clear();
    DisplayTheOptionTitle("Avaliar grupo");

    Console.Write("Digite o nome do grupo que irá avaliar: ");
    string nameGroup = Console.ReadLine()!;

    if (registeredGroups.ContainsKey(nameGroup))
    {
        Console.Write($"Qual a nota que o grupo {nameGroup} merece: ");
        int note = int.Parse(Console.ReadLine()!);
        registeredGroups[nameGroup].Add(note);
        Console.WriteLine($"\nA nota {note} foi registrada com sucesso para o grupo {nameGroup}");
        Thread.Sleep(4000);
        Console.Clear();
        DisplayMenuOptions();
    }
    else
    {
        Console.WriteLine($"O grupo {nameGroup} não foi encontrado!");
        ActionBackMenu();
    }
}

void GroupAverage()
{
    Console.Clear();
    DisplayTheOptionTitle("Média do Grupo");

    Console.Write("Qual grupo você deseja saber a média: ");
    string nameGroup = Console.ReadLine()!;
    if (registeredGroups.ContainsKey(nameGroup))
    {
        List<int> notesGroup = registeredGroups[nameGroup];
        Console.WriteLine($"\n A média do grupo {nameGroup} é {notesGroup.Average()}.");
        ActionBackMenu();
    }
    else
    {
        Console.WriteLine($"O grupo {nameGroup} não foi encontrado!");
        ActionBackMenu();
    }


    // Como fiz, usei minha lógica antes de ver a resolução
    //if (registeredGroups.ContainsKey(nameGroup))
    //{
    //    List<int> notesGroup = registeredGroups[nameGroup];
    //    foreach(int avarege in notesGroup)
    //    {
    //        int sum = 0;
    //        for (int i = 0; i < avarege; i++)
    //        {
    //            sum += group;
    //        }
    //        double media = sum / avarege;
    //        Console.WriteLine($"\nMédia do {nameGroup}: {avarege}");
    //    }

    //}
    //else
    //{
    //    Console.WriteLine($"O grupo {nameGroup} não foi encontrado!");
    //    ActionBackMenu();
    //}
}

void DisplayTheOptionTitle(string title)
{
    int numberOfLetters = title.Length;
    string asterisks = string.Empty.PadLeft(numberOfLetters, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");

}

void ActionBackMenu()
{
    Console.WriteLine("\nDigite uma tecla para voltar a menu principal");
    Console.ReadKey();
    Console.Clear();
    DisplayMenuOptions();
}

DisplayMenuOptions();


