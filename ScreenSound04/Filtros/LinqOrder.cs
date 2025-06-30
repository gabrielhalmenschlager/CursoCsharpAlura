using ScreenSound04.Modelos;

namespace ScreenSound04.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => 
            musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("\nLista de Artistas Ordenados:");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
