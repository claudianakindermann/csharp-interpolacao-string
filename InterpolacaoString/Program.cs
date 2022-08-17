using System;
using System.Text;

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

            //Convertendo o texto para maiúsculo ou minúsculo
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(text);
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());

            //Inserindo conteúdo no texto
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(text);
            Console.WriteLine(text.Insert(5, "AQUI "));
            Console.WriteLine(text.Remove(5, 5));
            Console.WriteLine(text.Length);

            //Substituindo uma string por outra - case sensitive
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(text);
            Console.WriteLine(text.Replace("texto", "código"));
            Console.WriteLine(text.Replace("e", "W"));

            //Dividindo o texto, resulta em uma lista
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(text);
            var textoDividido = text.Split(" ");
            Console.WriteLine(textoDividido[0]);
            Console.WriteLine(textoDividido[1]);
            Console.WriteLine(textoDividido[2]);
            Console.WriteLine(textoDividido[3]);
            Console.WriteLine(textoDividido[4]);

            //Remove espaços no início e no final do texto
            Console.WriteLine("---------------------------------------------------");
            text = " Este texto é um teste   ";
            Console.WriteLine(text);
            Console.WriteLine(text.Trim());

            //String builder - para copiar/manipular grandes textos
            var texto = new StringBuilder();
            texto.Append("A Itália é um país altamente desenvolvido localizado na Europa. A sua");
            texto.Append("história é caracterizada pela união de diversos povos que habitavam a");
            texto.Append("região na península Itálica por meio da formação de um Estado, que se");
            texto.Append("tornou um país de grande poderio econômico e político.");

            Console.WriteLine(texto);
            texto.ToString(); //Em alguns casos será preciso converter para string para apresentar.
            Console.WriteLine(texto);



        }
    }
}