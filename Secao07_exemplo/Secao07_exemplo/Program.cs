using System;
using System.Globalization;

namespace Secao07_exemplo {
    internal class Program {
        static void Main(string[] args) {


            int n = 0;

            do
            {
                Console.Write("\nDigite \n" +
                "[1] para operação ternaria\n" +
                "[2] Funções para String: \n" +
                "[3] Funções de Time \n" +
                "[4] Funções TimeSpan\n" +
                "[5] Propriedades e Operações com DateTime\n" +
                "[6] Formatação (DateTime -> string)\n" +
                "[7] Operações com Datetime (Add)\n" +
                "[8] Operações e propriedades com Timespan\n" +
                "[9] DateTimeKind e padrão ISO 8601 \n" +
                "[0] Sair: ");

                n = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (n)
                {
                    case 0:
                        Console.WriteLine("Saindo..");
                        break;
                    case 1:
                        Console.WriteLine("====================");
                        Console.WriteLine("operação ternaria!");
                        Console.WriteLine("====================\n");
                        operacaoternaria op = new operacaoternaria();
                        op.opternaria();
                        break;
                    case 2:
                        Console.WriteLine("====================");
                        Console.WriteLine("Funções para String!");
                        Console.WriteLine("====================\n");

                        funcoesString fs = new funcoesString();
                        fs.funcString();

                        break;

                    case 3:
                        Console.WriteLine("====================");
                        Console.WriteLine("Funções de DateTime");
                        Console.WriteLine("====================");

                        funcoesDateTime fdtfunc = new funcoesDateTime();
                        fdtfunc.funcDateTime();

                        break;
                    case 4:
                        funcoesTimeSpan fts = new funcoesTimeSpan();

                        Console.WriteLine("====================");
                        Console.WriteLine("construtores Timespan");
                        Console.WriteLine("====================");
                        fts.ConstructTimeSpan();

                        Console.WriteLine("====================");
                        Console.WriteLine("métodos From");
                        Console.WriteLine("====================");
                        fts.methodFrom();

                        break;
                    case 5:
                        funcoesDateTime fdtprop = new funcoesDateTime();
                        fdtprop.propDateTime();

                        Console.WriteLine("====================");
                        Console.WriteLine("Propriedades com DateTime");
                        Console.WriteLine("====================");
                        break;
                    case 6:
                        Console.WriteLine("====================");
                        Console.WriteLine("Formatação (DateTime -> string)");
                        Console.WriteLine("====================");

                        funcoesDateTime fdtformat = new funcoesDateTime();
                        fdtformat.formatDateTime();
                        break;
                    case 7:
                        Console.WriteLine("====================");
                        Console.WriteLine("Operações com Datetime");
                        Console.WriteLine("====================");
                        funcoesDateTime fdtoperation = new funcoesDateTime();
                        fdtoperation.operationsDateTime();

                        break;
                    case 8:
                        funcoesTimeSpan functs = new funcoesTimeSpan();

                        Console.WriteLine("====================");
                        Console.WriteLine("MaxValue, MinValue, Zero");
                        Console.WriteLine("====================");
                        functs.minMaxZero();

                        Console.WriteLine("====================");
                        Console.WriteLine("Propriedades");
                        Console.WriteLine("====================");
                        functs.propTimeSpan();

                        Console.WriteLine("====================");
                        Console.WriteLine("Operações");
                        Console.WriteLine("====================");
                        functs.operationsTimeSpan();

                        break;

                    case 9:
                        funcoesDateTime fDateTime = new funcoesDateTime();

                        Console.WriteLine("====================");
                        Console.WriteLine("DateTimeKind");
                        Console.WriteLine("====================");
                        fDateTime.DateTimeKinds();

                        Console.WriteLine("====================");
                        Console.WriteLine("padrão ISO 8601");
                        Console.WriteLine("====================");
                        fDateTime.DateTimeISO8601();

                        break;

                }
            } while (n > 0 && n <= 9);
            

            


        }

    }
            
}