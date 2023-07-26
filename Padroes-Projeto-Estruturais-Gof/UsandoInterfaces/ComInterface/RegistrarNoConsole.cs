namespace ComInterface;

public class RegistrarNoConsole : IRegistro
{
    public void RegistrarOcorrencia(string mensagem)
    {
        Console.WriteLine($"Informação registrada no console: {mensagem}");
    }
}