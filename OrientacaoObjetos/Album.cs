
public class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
        Console.WriteLine($"Adicionando a música '{musica.Nome}' ao álbum '{Nome}'.");
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"\nLista de músicas do álbum {Nome}"); 
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nDuração total do álbum: {DuracaoTotal} segundos");
    }
}
