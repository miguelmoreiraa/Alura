
void Number()
{
    Console.Write("Digite o Número A: ");
    string NumberAString = Console.ReadLine()!;
    int NumberA = int.Parse(NumberAString);

    Console.Write("Digite o Número B: ");
    string NumberBString = Console.ReadLine()!;
    int NumberB = int.Parse(NumberBString);

    Console.WriteLine($"\nA soma de A + B é: {NumberA + NumberB}");
    Console.WriteLine($"A subtração de A - B é: {NumberA - NumberB}");
    Console.WriteLine($"A divisão de A / B é: {NumberA / NumberB}");
    Console.WriteLine($"A multiplicação de A * B é: {NumberA * NumberB}");

}

void ListNumber()
{
    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
    int soma = 0;

    foreach (int number in numbers)
    {
        soma += number;
    }

    Console.WriteLine($"A soma dos elementos é: {soma}");
}

ListNumber();
Number();


void Students()
{
    Dictionary<string, List<double>> noteStudents = new Dictionary<string, List<double>>();

    noteStudents["Miguel"] = new List<double> { 8.5, 9.0, 7.5 };
    noteStudents["Mariana"] = new List<double> { 7.0, 8.0, 6.5 };


    foreach (var aluno in noteStudents)
    {
        double sum = 0;
        for (int i = 0; i < aluno.Value.Count; i++)
        {
            sum += aluno.Value[i];
        }

        double media = sum / aluno.Value.Count;
        Console.WriteLine($"Média do {aluno.Key}: {media}");


    }

}

Students();

void Stock()
{
    Dictionary<string, int> productsInStock = new Dictionary<string, int>
    {
        {"Brinco Pagodeiro", 10 },
        {"Argola Cravejada NJR", 10 },
        {"Argola da Fam", 10 },

    };

    string product = "Brinco Pagodeiro";


    if (productsInStock.ContainsKey(product))
    {
        Console.WriteLine($"A quantidade desse produto em estoque ({product} é de {productsInStock[product]})");

    }
    else
    {
        Console.WriteLine("Produto não em encontrado em estoque");
    }


}

Stock();

void Login()
{
    Dictionary<string, string> users = new Dictionary<string, string>
    {
        {"miguel.moreira@gmail.com", "12345678" }
    };

    string user = "miguel.moreira@gmail.com";
    string password = "12345678@";

    if (users.ContainsKey(user) && users[user] == password)
    {
        Console.WriteLine("Login bem-sucedido!");
    }
    else
    {
        Console.WriteLine("Nome do usuário ou senha incorretos.");
    }
}

Login();


void Cars()
{
    Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};
    foreach (var v in vendasCarros) { 
    
        double sum = 0;
        for (int i = 0; i < vendasCarros.Count; i++) {
            sum += v.Value[i];
        }

        double media = sum / v.Value.Count;
        Console.WriteLine($"Média de venda deste carro ({v.Key}) é: {media}");
    }


}

Cars();
