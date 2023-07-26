using Encapsulamento;

var conta1 = new Conta();
conta1.Saldo = -100;

try
{
    conta1.Saldo = -100;
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}