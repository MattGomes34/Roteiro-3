class Aluno
{
    private string nome = "";
    private double nota1;
    private double nota2;

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

    public double Nota1
    {
        get { return nota1; }
        set { nota1 = ValidarNota(value); }
    }

    public double Nota2
    {
        get { return nota2; }
        set { nota2 = ValidarNota(value); }
    }

    public double Media => (Nota1 + Nota2) / 2;

    private static double ValidarNota(double nota)
    {
        if (nota < 0 || nota > 10)
            throw new ArgumentException("A nota deve estar entre 0 e 10.");
        return nota;
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();
        aluno.Nome = "Maria";
        aluno.Nota1 = 8;
        aluno.Nota2 = 6;
        Console.WriteLine($"Média: {aluno.Media}");   

        aluno.Nota2 = 10;
        Console.WriteLine($"Média: {aluno.Media}");   

        try
        {
            aluno.Nota1 = 11;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}