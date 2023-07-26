using ComInterface;

var registrarNoConsole = new RegistrarNoConsole();
registrarNoConsole.RegistrarOcorrencia("Registro no console");

var registrarNoArquivo = new RegistrarNoArquivo(@"D:\log.txt");
registrarNoArquivo.RegistrarOcorrencia("Registro no arquivo");
