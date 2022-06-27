using dotbank;

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Eduardo Ximenes";
conta1.conta = "12345-x";
conta1.numero_agencia = 17;
conta1.nome_agencia = "Santander";
conta1.saldo = 1000;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Rodolfo";
conta2.conta = "3235-x";
conta2.numero_agencia = 17;
conta2.nome_agencia = "Santander";
conta2.saldo = 100;


Console.WriteLine("Bem vindo ao DotBank!!");

Console.WriteLine("Conta do Eduardo saldo atual: " + conta1.saldo);
Console.WriteLine("Conta do Rodolfo saldo atual: " + conta2.saldo);

Titular titular = new Titular();
titular.nome = "Eduardo";
titular.cpf = "12345678";
titular.profissao = "carry";



Console.ReadKey();
