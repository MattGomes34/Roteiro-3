class ContaBancaria
{
    private decimal saldo;

    public decimal Saldo
    {
        get { return saldo; }
    }

  
    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Erro: o depósito deve ser maior que zero.");
            return;
        }

        saldo += valor;
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria();

        Console.WriteLine(conta.Saldo);

        conta.Depositar(500);
        Console.WriteLine(conta.Saldo); 

    }
}