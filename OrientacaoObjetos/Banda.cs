
public class Banda
{
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
        Console.WriteLine($"\nAdicionando o álbum '{album.Nome}' à banda '{Nome}'.");
    }

    public void ExibirAlbumsDaBanda()
    {
        Console.WriteLine($"\nLista de álbuns da banda {Nome}");
        foreach (var album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}
