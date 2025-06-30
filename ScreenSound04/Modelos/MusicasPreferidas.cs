using System.Text.Json;

namespace ScreenSound04.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }

    public List<Musica> ListaDeMusicaFavoritas;

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicaFavoritas = new List<Musica>();
    }
    
    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicaFavoritas.Add(musica);
    }

    public void ExibirMusicasfavoritas()
    {
        Console.WriteLine($"\nLista de Músicas Favoritas -> {Nome}:");
        foreach (var musica in ListaDeMusicaFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicaFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}

