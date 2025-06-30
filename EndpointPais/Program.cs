using EndpointPais.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta)!;
        paises[0].ExibirDetalhesDoPais();
        paises[1].ExibirDetalhesDoPais();
        paises[2].ExibirDetalhesDoPais();
        paises[3].ExibirDetalhesDoPais();
        paises[4].ExibirDetalhesDoPais();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}