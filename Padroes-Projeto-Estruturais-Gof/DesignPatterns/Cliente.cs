namespace DesignPatterns;

public class Cliente
{
    public Cliente(string nome)
    {
        this.nome = nome;
    }

    public string? nome;

    public void Saudacao()
    {
        Console.WriteLine($"Olá, meu nome é {nome}");
    }
}