
Conta conta = new Conta
{
    Titular = "João da Silva",
    IdConta = Guid.NewGuid(),
    Saldo = 1000,
    Senha = 1234
};

conta.ExibirDadosConta();
