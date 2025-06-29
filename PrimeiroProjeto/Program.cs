
// Screem Sound

string mensagemBoasVindas = "Boas vindas ao Screem Sound";
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("U2", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int> ());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░░███╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░████║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔████╔██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚██╔╝██║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚═╝░██║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░░░░╚═╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\n1 - Registrar uma Banda");
    Console.WriteLine("2 - Mostrar todas as Bandas");
    Console.WriteLine("3 - Avaliar uma Banda");
    Console.WriteLine("4 - Exibir a média de uma Banda");
    Console.WriteLine("0 - Sair");

    Console.Write("\nSelecione uma opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNUmerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNUmerica)
    {
        case 1:
            RegistrarBanda();
            Console.WriteLine("Você escolheu registrar uma banda.");
            break;
        case 2:
            MostrarBandasRegistradas();
            Console.WriteLine("Você escolheu mostrar todas as bandas.");
            break;
        case 3:
            AvaliarUmaBanda();
            Console.WriteLine("Você escolheu avaliar uma banda.");
            break;
        case 4:
            ExibirMediaDaBanda();
            Console.WriteLine("Você escolheu exibir a média de uma banda.");
            break;
        case 0:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            ExibirOpcoesDoMenu();
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Bandas: {listaDasBandas[i]}");
    //}

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    VoltarParaMenuPrincipal();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar uma Banda");
    Console.Write("Digite o nome da banda que deseja avaliar");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Digite a nota de 0 a 10: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A banda {nomeDaBanda} recebeu a nota {nota}");
        Thread.Sleep(5000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não está registrada.");
        VoltarParaMenuPrincipal();
    }
}

void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir a média de uma Banda");
    Console.Write("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda {nomeDaBanda} é: {notasDaBanda.Average():F2}");
        VoltarParaMenuPrincipal();
    }
    else
    {
        Console.WriteLine($"A banda {nomeDaBanda} não está registrada.");
        VoltarParaMenuPrincipal();
    }
}


void ExibirTituloDaOpcao(string titulo)
{
    
    int quantidadeDeLinhas = titulo.Length;
    string iguais = string.Empty.PadLeft(quantidadeDeLinhas, '=');
    Console.WriteLine(iguais);
    Console.WriteLine(titulo);
    Console.WriteLine($"{iguais}\n");
}

void VoltarParaMenuPrincipal()
{
    Console.WriteLine("\nDigite alguma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirOpcoesDoMenu();