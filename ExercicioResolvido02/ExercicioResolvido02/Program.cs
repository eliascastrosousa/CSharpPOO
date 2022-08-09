using System;
using ExercicioResolvido02.Entities;

namespace ExercicioResolvido02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            Post p1 = new Post();

            p1.Title = ("Viajando pra NY");
            p1.Moment = DateTime.Parse("10/01/2022 14:55");
            p1.Content = ("Foi muito legal conhecer a cidade mais movimentada do mundo. Adorei!");
            p1.Likes = 12;
            Comment c1 = new Comment("Uau, que legal!!");
            Comment c2 = new Comment("Nunca viajei pra fora :(");
            p1.AddComment(c1);
            p1.AddComment(c2);

            Post p2 = new Post();

            p2.Title = ("Minha namorada recebeu a tag livros desse mês");
            p2.Moment = DateTime.Parse("23/03/2022 14:55");
            p2.Content = ("Ela tá bem feliz, ja começou a nova leitura.");
            p2.Likes = 12;
            Comment c3 = new Comment("Show, to querendo assinar também...");
            Comment c4 = new Comment("eu não sei ler");
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine("\n=====================");
            Console.WriteLine("Bem vindo ao FaceBlog");
            Console.WriteLine("=====================\n");
            Console.WriteLine(p1);
            Console.WriteLine(p2);





















            /*
            Console.WriteLine("=========================");
            Console.WriteLine("O que deseja Fazer: ");
            Console.Write("[0] Ver Posts\n" +
                          "[1] Criar um post\n" +
                          "[2] Comentar um post\n" +
                          "[3] Curtir um post\n" +
                          "Digite: ");

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("=========================");


            switch(n){
                case 0:
                    Console.WriteLine(p1);
                    Console.WriteLine(p2);
                    Console.WriteLine(p3);

                    break;

                case 1:
                Post p3 = new Post();
                Console.WriteLine("Novo Post");
                Console.WriteLine("Titulo: ");
                p3.Title = Console.ReadLine();
                Console.WriteLine("Conteúdo: ");
                p3.Content = Console.ReadLine();
                p3.Moment = DateTime.Now;
                p3.Likes = 0;

                Console.WriteLine(p3);

                break;

            }
            */


           

            
            

            
            
        }

        
    }
}