
public class Episodios
{
    private List<string> convidados = new();

    public Episodios(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => $"Episódio {Ordem}: {Titulo} ({Duracao} minutos) - {string.Join(", ", convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
        Console.WriteLine($"Convidado {convidado} adicionado ao episódio {Titulo}.");
    }
}
