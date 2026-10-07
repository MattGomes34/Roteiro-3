class Conta
{
    public decimal Saldo { get; private set; }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Erro: o depósito deve ser maior que zero.");
            return;
        }

        Saldo += valor;
    }
}

class Program
{
    static void Main()
    {
        Conta conta = new Conta();
        conta.Depositar(500);
        Console.WriteLine(conta.Saldo);  

   
    }
}