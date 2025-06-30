using System.Text.Json.Serialization;

namespace ScreenSound04.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string Nome { get; set; }

    [JsonPropertyName("artist")]
    public string Artista{ get; set; }

    [JsonPropertyName("diration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Artista: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000} segundos");
        Console.WriteLine($"Gênero: {Genero}");
    }
}
