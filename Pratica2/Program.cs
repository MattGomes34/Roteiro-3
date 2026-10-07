class Pessoa
{
    public string Nome { get; set; } = "";
    public int Idade { get; set; }
    public string Email { get; set; } = "";
}

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();

        pessoa.Nome = "Maria";
        pessoa.Idade = 20;
        pessoa.Email = "maria@email.com";

        Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade} anos, {pessoa.Email}");

        pessoa.Idade = 21;
        Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade} anos, {pessoa.Email}");
    }
}