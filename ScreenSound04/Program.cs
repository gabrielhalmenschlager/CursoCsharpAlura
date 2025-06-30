using ScreenSound04.Filtros;
using ScreenSound04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
	try
	{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
		var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

		//musicas[0].ExibirDetalhesDaMusica();

		//LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
		//LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
		//LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "Rock");
		//LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
		//LinqFilter.FiltrarMusicasEmCSharp(musicas);
;
		//var muscasPreferidasDoGabriel = new MusicasPreferidas("Gabriel");
		//muscasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[1]);
		//muscasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[10]);
		//muscasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[50]);
		//muscasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[100]);
		//muscasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[200]);

		//muscasPreferidasDoGabriel.ExibirMusicasfavoritas();

        //var muscasPreferidasDoPedro = new MusicasPreferidas("Pedro");
        //muscasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[500]);
        //muscasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[600]);
        //muscasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[700]);
        //muscasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[800]);
        //muscasPreferidasDoPedro.AdicionarMusicasFavoritas(musicas[900]);

        //muscasPreferidasDoPedro.ExibirMusicasfavoritas();

        //muscasPreferidasDoPedro.GerarArquivoJson();
    }
	catch (Exception ex)
	{
        Console.WriteLine($"Temos um problema: {ex.Message}");
	}
}

