using ScreenSound04.Filtros;
using ScreenSound04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
	try
	{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
		var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
		//LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
		//LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
		//LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "Rock");
		LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
    }
	catch (Exception ex)
	{
        Console.WriteLine($"Temos um problema: {ex.Message}");
	}

}

