using dotbank;
using dotbank.titular;

Titular cliente1 = new Titular();
cliente1.Nome = "Eduardo";

Titular cliente2 = new Titular();
cliente2.Nome = "Rodolfo";

ContaCorrente conta1 = new ContaCorrente(17, "12345-x");
conta1.Titular = cliente1;
conta1.Nome_agencia = "Santander";
conta1.Saldo =1000;

ContaCorrente conta2 = new ContaCorrente(17, "3235-x");
conta2.Titular = cliente2;
conta2.Nome_agencia = "Santander";
conta2.Saldo = 1000;

Console.WriteLine("Bem vindo ao DotBank!!");

Console.WriteLine("Rodolfo: "+ conta2.Titular.Nome);
Console.WriteLine("Saldo Rodolfo " +conta2.Conta);

Console.WriteLine(ContaCorrente.TotalDeContas);

Console.ReadKey();


