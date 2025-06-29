
public class Conta
{
    public string Titular { get; set; }
    public Guid IdConta { get; set; }
    public float Saldo { get; set; }
    public int Senha { get; set; }

    public void ExibirDadosConta()
    {
        Console.WriteLine("=================");
        Console.WriteLine("Dados da Conta:");
        Console.WriteLine("=================");
        Console.WriteLine($"\nTitular: {Titular}");
        Console.WriteLine($"ID da Conta: {IdConta}");
        Console.WriteLine($"Saldo: {Saldo:C}");
    }
}

