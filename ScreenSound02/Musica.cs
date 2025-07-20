
public class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string Genero { get; set; }
    public string DescricaoResumida => $"\nA musica {Nome} pertence à banda {Artista} e tem a duração de {Duracao} segundos";

    public void ExibirFichaTecnia()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("A música está disponível.");
        }
        else
        {
            Console.WriteLine("A música não está disponível.");
        }
    }
}

