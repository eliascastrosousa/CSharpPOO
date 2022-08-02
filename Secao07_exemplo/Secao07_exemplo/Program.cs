namespace Secao07_exemplo {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite \n[1] para operação ternaria\n[2] Funções para String: [0] Sair");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 0: 
                    Console.WriteLine("Saindo..");
                    break;
                case 1:
                    Console.WriteLine("operação ternaria!");
                    Console.Write("Digite um valor: ");
                    double valor = double.Parse(Console.ReadLine());

                    double desconto = (valor <= 20) ? valor * 0.1 : valor * 0.05;
                    Console.WriteLine("Desconto: "+ desconto);
                    break;
                case 2:
                    Console.WriteLine("Funções para String!");
                    Console.WriteLine("Digite uma frase: ");
                    var frase = Console.ReadLine();
                    Console.WriteLine("[1] deixar tudo em Maiusculo\n[2] deixar tudo em Minusculo \n[3] Remover espaços em Branco \n[4] Procurar a primeira ocorrencia");
                    int num = int.Parse(Console.ReadLine());
                    if(num == 1)
                    {
                        frase = frase.ToUpper();
                        Console.WriteLine(frase);
                    }else if(num == 2)
                    {
                        frase = frase.ToLower();
                        Console.WriteLine(frase);
                    }else if(num == 3)
                    {
                        frase = frase.Trim();
                        Console.WriteLine(frase);
                    }

                    break;
            }



        }
    }
}