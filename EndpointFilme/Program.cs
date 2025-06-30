using EndpointFilme.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
        filmes[0].ExibirDetalhesDoFilme();
        filmes[1].ExibirDetalhesDoFilme();
        filmes[2].ExibirDetalhesDoFilme();
        filmes[3].ExibirDetalhesDoFilme();
        filmes[4].ExibirDetalhesDoFilme();
        filmes[5].ExibirDetalhesDoFilme();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}