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

            //Comparando string
            text = "Testando";
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(text.CompareTo("Testando"));
            Console.WriteLine(text.CompareTo("testando"));

            //Método que verifica se a string contém um texto, parte ou todo
            Console.WriteLine("---------------------------------------------------");
            text = "Este texto é um teste";
            Console.WriteLine(text.Contains("teste"));
            Console.WriteLine(text.Contains("TESTE"));

            //Ignorar case sensitive
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(text.Contains("Teste", StringComparison.OrdinalIgnoreCase));

            //Verificando se o texto começa com:
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(text);
            Console.WriteLine(text.StartsWith("Este"));
            Console.WriteLine(text.StartsWith("este"));
            Console.WriteLine(text.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(text.StartsWith("Ela"));

            //Verificando se o texto termina com:
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(text);
            Console.WriteLine(text.EndsWith("teste"));
            Console.WriteLine(text.EndsWith("Teste"));
            Console.WriteLine(text.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(text.EndsWith("qualquer"));


            //Verificando se o texto é exatamente igual. Compara outros tipos: string, double, int.
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(text);
            Console.WriteLine(text.Equals("Este texto é um teste"));
            Console.WriteLine(text.Equals("Este texto é um TESTE"));
            Console.WriteLine(text.Equals("Este Texto é um TESTE", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(text.Equals("qualquer"));

            //Obtendo a posição onde inicia o termo/palavra/char pesquisado no array
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(text);
            Console.WriteLine(text.IndexOf("e"));
            Console.WriteLine(text.LastIndexOf("e")); //mostra a última posição



        }
    }
}