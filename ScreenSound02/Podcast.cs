
public class Podcast
{
    private List<Episodios> episodios = new();

    public Podcast(string host, string nome)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodios episodio)
    {
        episodios.Add(episodio);
        Console.WriteLine($"Adicionando o episódio {Nome}");
    }

    public void ExibirDetalhesPodcast()
    {
        Console.WriteLine($"\nPodcast: {Nome}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
        Console.WriteLine("Episódios:");
        foreach (Episodios episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"- {episodio.Resumo}");
        }
        Console.WriteLine($"\n Esse podcast possui {TotalEpisodios} episódios");
    }

}
