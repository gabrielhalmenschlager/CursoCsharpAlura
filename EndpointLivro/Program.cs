
using EndpointLivro.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var livros = JsonSerializer.Deserialize<List<Livro>>(resposta)!;
        livros[0].ExibirDetalhesDoLivro();
        livros[2].ExibirDetalhesDoLivro();
        livros[3].ExibirDetalhesDoLivro();
        livros[4].ExibirDetalhesDoLivro();
        livros[5].ExibirDetalhesDoLivro();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

}