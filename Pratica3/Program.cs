class Produto
{
    private decimal preco;
    private string nome = "";

    public decimal Preco
    {
        get { return preco; }
        set
        {
            if (value < 0)
                throw new ArgumentException("O preço não pode ser negativo.");
            preco = value;
        }
    }

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome não pode ser vazio.");
            nome = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto();

        try
        {
            produto.Nome = "Teclado";
            produto.Preco = 100;
            Console.WriteLine($"Preço: {produto.Preco}");

            produto.Preco = 250;
            Console.WriteLine($"Preço: {produto.Preco}");

            produto.Preco = -50;  
            Console.WriteLine("Esta linha não será executada.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        Console.WriteLine($"Preço final (continua válido): {produto.Preco}");

        try
        {
            produto.Nome = ""; 
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}