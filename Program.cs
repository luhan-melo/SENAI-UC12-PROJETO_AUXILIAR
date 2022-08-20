// See https://aka.ms/new-console-template for more information
using ER3_EC1;

Console.WriteLine(@$"
*************************************************************************************
*************************************************************************************
*                                                                                   *
*                  Seja bem vindo ao Sistema de Controle Financeiro                 *
*                                                                                   *
*************************************************************************************
*************************************************************************************
");

List<Corrente> listaCC = new List<Corrente>();
List<Poupanca> listaCP = new List<Poupanca>();

BarraCarregamento("Carregando", 200);
Console.Clear();


Console.BackgroundColor = ConsoleColor.DarkGray;

Console.Write("Carregando ");

for (var contador = 0; contador < 10; contador++)
{
    Console.Write(". ");
    Thread.Sleep(300);
}

Console.ResetColor();

Console.Clear();

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
*************************************************************************************
*************************************************************************************
*                                                                                   *
*                       Escolha uma das opções a seguir:                            *
*                                                                                   *
*                               1 - Conta Corrente                                  *
*                               2 - Conta Poupança                                  *
*                               0 - Sair                                            *
*                                                                                   *
*                                                                                   *
*************************************************************************************
*************************************************************************************
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            string? opcaoCC;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
*************************************************************************************
*************************************************************************************
*                                                                                   *
*                       Escolha uma das opções a seguir:                            *
*                                                                                   *
*                               1 - Cadastrar Conta Corrente                        *
*                               2 - Mostrar Contas Correntes                        *
*                               0 - Voltar ao Menu Anterior                         *
*                                                                                   *
*                                                                                   *
*************************************************************************************
*************************************************************************************
");

                opcaoCC = Console.ReadLine();

                switch (opcaoCC)
                {
                    case "1":
                        Console.WriteLine($"Digite o número da conta corrente");
                        string numero = Console.ReadLine();

                        Console.WriteLine($"Digite o número da agencia");
                        string agencia = Console.ReadLine();


                        Console.WriteLine($"Digite o número do limite");
                        double limite = Double.Parse(Console.ReadLine());



                        Corrente obj_cc = new Corrente(numero, agencia, limite);

                        listaCC.Add(obj_cc);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                        Console.ResetColor();

                        Console.WriteLine($"Aperte 'Enter' para continuar");
                        Console.ReadLine();
                        // Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        if (listaCC.Count > 0)
                        {
                            foreach (Corrente cadaCC in listaCC)
                            {
                                Console.Clear();
                                Console.WriteLine($"{cadaCC.ToString()}");
                                Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                            }
                        }

                        else
                        {
                            Console.WriteLine($"A lista está vazia!!!");
                            Thread.Sleep(3000);
                        }

                        break;


                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, por favor digite outra opção");
                        Thread.Sleep(3000);
                        break;
                }


            } while (opcaoCC != "0");

            /*
                Corrente obj_cc = new Corrente("3030-0", "1988", 101);
                Console.WriteLine($"{obj_cc.ToString()}");
                Console.WriteLine($"Aperte 'Enter' para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
                */
            break;

        case "2":
            //conta poupança

            string? opcaoCP;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
*************************************************************************************
*************************************************************************************
*                                                                                   *
*                       Escolha uma das opções a seguir:                            *
*                                                                                   *
*                               1 - Cadastrar Conta Poupança                        *
*                               2 - Mostrar Contas Poupanças                        *
*                               0 - Voltar ao Menu Anterior                         *
*                                                                                   *
*                                                                                   *
*************************************************************************************
*************************************************************************************
");

                opcaoCP = Console.ReadLine();

                switch (opcaoCP)
                {
                    case "1":
                        Console.WriteLine($"Digite o número da conta poupança:");
                        string numero = Console.ReadLine();

                        Console.WriteLine($"Digite o número da agencia: ");
                        string agencia = Console.ReadLine();


                        Console.WriteLine($"Digite o aniversário: ");
                        int aniversario = Int32.Parse(Console.ReadLine());



                        Poupanca obj_cp = new Poupanca(numero, agencia, aniversario);

                        listaCP.Add(obj_cp);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                        Console.ResetColor();

                        Console.WriteLine($"Aperte 'Enter' para continuar");
                        Console.ReadLine();
                        // Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        if (listaCP.Count > 0)
                        {
                            foreach (Poupanca cadaCP in listaCP)
                            {
                                Console.Clear();
                                Console.WriteLine($"{cadaCP.ToString()}");
                                Console.WriteLine($"Aperte 'Enter' para continuar");
                                Console.ReadLine();
                            }
                        }

                        else
                        {
                            Console.WriteLine($"A lista está vazia!!!");
                            Thread.Sleep(3000);
                        }

                        break;


                    case "0":
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, por favor digite outra opção");
                        Thread.Sleep(3000);
                        break;
                }


            } while (opcaoCP != "0");
            break;


        /*  
                    Corrente obj_cpp = new Corrente("1010-0", "1978", 3);
                    Console.WriteLine($"{obj_cpp.ToString()}");
                    Console.WriteLine($"Aperte 'Enter' para continuar");
                    Console.ReadLine();
                    Console.Clear();
        */



        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema");
            BarraCarregamento("Finalizando", 200);
            Console.WriteLine($"Voce entrou na opção 0");
            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opcao invalida, por favor digite outra opção");
            Thread.Sleep(2000);
            Console.Clear();
            break;


    }


} while (opcao != "0");


static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{texto}");

    for (var contador = 0; contador < 10; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();
}


/*
Conta obj_conta = new Conta ("7", "8898"); 

//obj_conta.numero = "7800-8";
// obj_conta.setNumero("7800-8");
// obj_conta.agencia = "8898";
//obj_conta.saldo = 1000;
// obj_conta.setSaldo(1000);

Console.WriteLine($"Agencia: {obj_conta.agencia}");
Console.WriteLine($"Numero: {obj_conta.numero}");
Console.WriteLine($"Saldo: {obj_conta.getSaldo()}");


Corrente obj_cc = new Corrente ("3030-0","1988", 101);

//
string ret;
 ret = obj_cc.ToString();
 Console.WriteLine($"{ret}");
 //
 Console.WriteLine($"{obj_cc.ToString()}");
 Console.WriteLine($"***************************************");
//  obj_cc.Depositar(100);
Console.WriteLine($"{obj_cc.Depositar(100)}");
Console.WriteLine($"{obj_cc.ToString()}");
 Console.WriteLine($"***************************************");
Console.WriteLine($"{obj_cc.Sacar(300)}");
Console.WriteLine($"{obj_cc.ToString()}");
*/

