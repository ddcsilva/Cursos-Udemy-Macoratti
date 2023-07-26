namespace ComInterface;

public class RegistraOcorrencia : IRegistro
{
    private readonly IRegistro _registro;

    public RegistraOcorrencia(IRegistro registro)
    {
        _registro = registro;
    }

    public void RegistrarOcorrencia(string mensagem)
    {
        _registro.RegistrarOcorrencia($"{DateTime.Now} - {mensagem}");
    }
}