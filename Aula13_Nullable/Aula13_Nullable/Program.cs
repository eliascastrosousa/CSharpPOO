namespace Aula13_Nullable {
    internal class Program {
        static void Main(string[] args) {
            Nullable<double> x = null;
            double? y = null; // forma simplificada
            double? z = 10; // forma simplificada
            Console.WriteLine("\nMostrar valores: ");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //mostrar valor ou valor padrao do tipo
            Console.WriteLine("\nmostrar valor ou valor padrao do tipo: ");
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(z.GetValueOrDefault());

            //mostrar se tem valor 
            Console.WriteLine("\nmostrar se tem valor: ");
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            Console.WriteLine(z.HasValue);

            //mostrar o valor
            Console.WriteLine("\nmostrar o valor:");
            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X é igual a null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("y é igual a null");

            if (z.HasValue)
                Console.WriteLine(z.Value);
            else
                Console.WriteLine("Z é igual a null");

            //Operador de coalescencia nula "??"
            double xx = x ?? 0.0; //se o conteudo de x for um valor, irá copiar ele ou jogara o valor padrao de 0.0
            double yy = y ?? 0.0;
            double zz = z ?? 0.0;
            Console.WriteLine("\nOperador de coalescencia nula '??'");
            Console.WriteLine(xx);
            Console.WriteLine(yy);
            Console.WriteLine(zz);


            //bom para o caso em que eu conectar ao banco, e tiver a opção de nao informar algum dado, usar essa função para subir um dado padrao para estes casos
        }
    }
}