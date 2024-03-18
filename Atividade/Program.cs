// using Atividade.Models;

using Atividade;
using Atividade.Models;

Menu menu = new Menu();

menu.Inicial();
byte opcao = Convert.ToByte(Console.ReadLine()!);

menu.InformacoesBasicas();
Console.Write("\nInformar Nome: ");
string nome = Console.ReadLine()!;
Console.Write("\nInformar Endereço: ");
string endereco = Console.ReadLine()!;

switch (opcao)
{
    case 1:
        menu.Fisica();
        Console.Write("\nInformar CPF: ");
        string cpf = Console.ReadLine()!;
        Console.Write("\nInformar RG: ");
        string rg = Console.ReadLine()!;
        Console.Write("\nInformar Valor de Compra: ");
        float valorPago = float.Parse(Console.ReadLine()!);
        PessoaFisica fisica = new PessoaFisica(nome, endereco, cpf, rg);
        fisica.PagarImposto(valorPago);
        fisica.ExibirNota();
        break;

    case 2:
        menu.Juridica();
        Console.Write("\nInformar CNJP: ");
        string cnjp = Console.ReadLine()!;
        Console.Write("\nInformar IE: ");
        string ie = Console.ReadLine()!;
        Console.Write("\nInformar Valor de Compra: ");
        float valorPagoJuridico = float.Parse(Console.ReadLine()!);
        PessoaJuridica juridica = new PessoaJuridica(nome, endereco, cnjp, ie);
        juridica.PagarImposto(valorPagoJuridico);
        juridica.ExibirNota();
        break;
    default: Console.WriteLine("\n\nErro - Por Favor Digite (1) ou (2)"); break;
}
