class ContaBancaria
{
    public string Titular { get; }                   
    public decimal Saldo { get; private set; }    

    public ContaBancaria(string titular)
    {
        Titular = titular;
        Saldo = 0;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Erro: o depósito deve ser maior que zero.");
            return;
        }

        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Erro: o saque deve ser maior que zero.");
            return;
        }

        if (valor > Saldo)
        {
            Console.WriteLine("Erro: saldo insuficiente.");
            return;
        }

        Saldo -= valor;
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria("Carlos");
        conta.Depositar(1000);
        conta.Sacar(250);
        Console.WriteLine(conta.Saldo);  
    }
}