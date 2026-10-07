class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

  
    public double Area => Largura * Altura;
}

class Program
{
    static void Main()
    {
        Retangulo r = new Retangulo();
        r.Largura = 10;
        r.Altura = 5;
        Console.WriteLine($"Área: {r.Area}"); 

        r.Largura = 20;
        Console.WriteLine($"Área: {r.Area}");  
    }
}