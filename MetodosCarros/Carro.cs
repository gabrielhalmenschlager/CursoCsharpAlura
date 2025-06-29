
public class Carro
{
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public int QuantidadesPortas { get; set; }
    public int Velocidade { get; set; } = 0;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nFabricante: {Fabricante}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Quantidade de Portas: {QuantidadesPortas}");
    }

    public void Acelerar()
    {
        Console.WriteLine("\nAcelerando...");

        if (Velocidade < 100)
        {
            Velocidade += 10;
        }
        
        Console.WriteLine($"\nO carro acelerou para {Velocidade} km/h.");
    }

    public void Frear()
    {
        if (Velocidade > 0)
        {
            Velocidade -= 10;
            Console.WriteLine($"\nO carro freou para {Velocidade} km/h.");
        }
        else
        {
            Console.WriteLine("\nO carro já está parado.");
        }
    }

    public void Buzinar()
    {
        Console.WriteLine("\nBi Bi...");
    }
}
