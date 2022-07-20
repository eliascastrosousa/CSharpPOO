using System.Globalization;
namespace Aula14_Vetores {
    internal class Program {
        static void Main(string[] args) {
            int opc = 0;
            do
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("Aula 14 - Vetores \nEscolha a opção de acordo com o que deseja: ");
                Console.WriteLine("=============================================");

                Console.WriteLine("\n[1]: Media de alturas utilizando Vetor");
                Console.WriteLine("[2]: Media de Preços utilizando Vetor e classe Produto");
                Console.WriteLine("[3]: Aluguel em Pensionato");
                Console.WriteLine("[4]: Modificador de parametro 'PARAMS'");
                Console.WriteLine("[5]: Triplicar valor usando REF");

                Console.Write("[0] Sair \nDigite: ");

                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        Console.WriteLine("\nSaindo...");
                        break;
                    case 1:
                        Console.WriteLine("\nMedia de alturas utilizando Vetor");
                        Alturas alt = new Alturas();
                        alt.Altura();
                        break;

                    case 2:
                        Console.WriteLine("\nOpção 2: Media de Preços utilizando Vetor e classe Produto");
                        MediaProdutos md = new MediaProdutos();
                        md.MediaProduto();
                        break;

                    case 3:
                        Console.WriteLine("\nOpção 3: Aluguel em Pensionato");

                        RegistrarAluguel RA = new RegistrarAluguel();
                        RA.RegistrarAlugueis();
                        break;
                    case 4:
                        Console.WriteLine("Opção 4: Modificador de parametro 'PARAMS'");
                        ModificadorParametroMain mp = new ModificadorParametroMain();
                        mp.Calculadora();
                        break;
                    case 5:
                        Console.WriteLine("Opção 5: Triplicar valor usando REF");
                        ModificadorParametroMain mp2 = new ModificadorParametroMain();
                        mp2.TriplicarValor();
                        break;
                    case 6:
                        Console.WriteLine("Opção 6: Triplicar valor usando OUT ");
                        ModificadorParametroMain mp3 = new ModificadorParametroMain();
                        mp3.TriplicarValorOut();
                        break;


                    default:
                        Console.WriteLine("\nOpção invalida");
                        break;
                }

            } while (opc != 0);



           

        }
    }
}