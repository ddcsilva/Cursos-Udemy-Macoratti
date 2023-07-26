namespace ComInterface;

public class RegistrarNoArquivo : IRegistro
{
    private readonly string _caminho;

    public RegistrarNoArquivo(string caminho)
    {
        _caminho = caminho;
    }

    public void RegistrarOcorrencia(string mensagem)
    {
        Log(mensagem);
    }

    private void Log(string mensagem)
    {
        using (var streamWriter = new StreamWriter(_caminho, true))
        {
            streamWriter.WriteLine(mensagem);
        }
    }
}