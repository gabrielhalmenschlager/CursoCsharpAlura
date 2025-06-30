
using System.Text.Json.Serialization;

namespace EndpointPais.Modelos;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("capital")]
    public string Capital { get; set; }

    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }

    [JsonPropertyName("continente")]
    public string Continente { get; set; }

    [JsonPropertyName("idioma")]
    public string Idioma { get; set; }

    public void ExibirDetalhesDoPais()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"População: {Populacao:N0} habitantes");
        Console.WriteLine($"Continente: {Continente}");
        Console.WriteLine($"Idioma: {Idioma}");
    }
}
