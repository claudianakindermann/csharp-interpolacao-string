using System;

namespace Interpolacao
{
    class Program
    {
        static void Main(string[] args)

        {
            var price = 14.8;
            var text = string.Format("O preço do produto é {0} apenas na promoção", price);
            Console.WriteLine(text);

            Console.WriteLine($"O preço do produto é {price} apenas na promoção");

            //Para poder escrever várias linhas use o @ com a interpolação:
            Console.WriteLine($@"O preço do produto 
            é {price}
            apenas na promoção");

            //Quebrando a linha
            Console.WriteLine("O preço do produto é {price} \n apenas na promoção");
            //Usar o @ para caracteres especiais
            Console.WriteLine(@"O preço do produto é {price} \n apenas na promoção");


        }
    }
}