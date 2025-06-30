using System.Text.Json.Serialization;

namespace EndpointFilme.Modelos;

internal class Filme
{
    [JsonPropertyName("title")]
    public string Titulo { get; set; }

    [JsonPropertyName("year")]
    public string Ano { get; set; }

    [JsonPropertyName("crew")]
    public string Diretor { get; set; }

    [JsonPropertyName("image")]
    public string Imagem { get; set; }

    public void ExibirDetalhesDoFilme()
    {
        Console.WriteLine($"\nTítulo: {Titulo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Diretor: {Diretor}");
        Console.WriteLine($"Imagem: {Imagem}");
    }
}
