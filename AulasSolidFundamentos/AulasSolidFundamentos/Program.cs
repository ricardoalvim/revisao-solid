using AulasSolidFundamentos;

ClienteAnemico clienteAnemico = new ClienteAnemico();
clienteAnemico.Id = -1;
clienteAnemico.Nome = "Ricardo";
clienteAnemico.Endereco = "Teste";

try
{
    ClienteRico clienteRico = new ClienteRico(1, "", "");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine(clienteAnemico);
