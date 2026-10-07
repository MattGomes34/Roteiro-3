class Produto
{
    private string nome = "";
    private string codigo = "";
    private decimal preco;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome é obrigatório.");
            nome = value;
        }
    }

    public string Codigo
    {
        get { return codigo; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O código é obrigatório.");
            codigo = value;
        }
    }

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

    public int QuantidadeEstoque { get; private set; }

    public bool EstoqueBaixo => QuantidadeEstoque <= 5;

    public Produto(string nome, string codigo, decimal preco)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;
        QuantidadeEstoque = 0;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade <= 0)
            throw new ArgumentException("A quantidade a adicionar deve ser maior que zero.");

        QuantidadeEstoque += quantidade;
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade <= 0)
            throw new ArgumentException("A quantidade a remover deve ser maior que zero.");

        if (quantidade > QuantidadeEstoque)
            throw new ArgumentException("Não há estoque suficiente para remover essa quantidade.");

        QuantidadeEstoque -= quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto("Mouse Gamer", "MS-001", 120m);

        produto.AdicionarEstoque(20);
        Console.WriteLine(produto.QuantidadeEstoque);   

        produto.RemoverEstoque(10);
        Console.WriteLine(produto.QuantidadeEstoque); 
        Console.WriteLine(produto.EstoqueBaixo);     

        produto.RemoverEstoque(5);
        Console.WriteLine(produto.EstoqueBaixo);        

        try
        {
            produto.RemoverEstoque(100);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }

        
    }
}