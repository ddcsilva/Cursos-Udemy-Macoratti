namespace DesignPatterns;

/*
    Acoplamento é o nível de dependência que pode existir entre os módulos/classes do sistema.
    Quanto maior o acoplamento, maior a dependência entre os módulos/classes e maior a dificuldade de manutenção do sistema.
    Existem dois tipos de acoplamento: Acoplamento Forte e Acoplamento Fraco.
*/

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