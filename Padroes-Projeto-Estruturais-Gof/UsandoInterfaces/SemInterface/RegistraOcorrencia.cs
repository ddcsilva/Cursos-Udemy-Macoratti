namespace SemInterface;

/*
    Neste exemplo está sendo demonstrado o uso de uma classe com alto acoplamento.
    A classe RegistraOcorrencia possui um método que registra uma ocorrência, porém
    o mesmo possui um alto acoplamento, pois o mesmo possui a responsabilidade de
    registrar a ocorrência em um arquivo e em um banco de dados, além de registrar
    a ocorrência em um arquivo.
*/

public class RegistraOcorrencia
{
    public void RegistrarOcorrencia(string mensagem)
    {
        Console.WriteLine($"Ocorrencia registrada: {mensagem}");
    }

    public void RegistrarNoArquivo(string caminho)
    {
        // Código para registrar no arquivo
    }

    public void RegistrarNoBanco(string conexao, string mensagem)
    {
        // Código para registrar no banco
    }
}