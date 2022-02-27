using System;
using System.Text;

namespace ModuloStrings
{
    class Program
    {
        static void Main(string[] args)
        {




            //         GUID
            var id = Guid.NewGuid(); // O método GUID.NEWGUID() gera um hash, ou ID único automaticamente



            id = new Guid("87c73475-15cf-4012-88ec-d97d0a74b4ba"); // posso inserir um GUID também já passando o valor

            Console.WriteLine(id.ToString().Substring(0, 8)); // Dessa forma eu estou dizendo que quero apenas os últimos 8 dígitos

            // ----------------------------------------------------------------------------------------------------------------------------------------

            //          INTERPOLAÇÃO DE STRINGS


            Console.WriteLine("Primeira forma de fazer Interpolação -> ");
            var preco = 10.2;
            var texto = "O preço é: " + preco + "reais !";
            Console.WriteLine(texto);

            Console.WriteLine("Segunda forma de fazer Interpolação -> ");
            var preco = 10.2;
            var texto = string.Format("O preço do produto é {0} apenas na promoção", preco); // com o string.format ele sempre vai buscar primeiro o que está dentro de {}
            Console.WriteLine(texto);

            Console.WriteLine("Terceira forma de fazer Interpolação -> ");
            var preco = 10.2;
            var texto = $"O preço do produto é {preco} apenas na promoção !";
            Console.WriteLine(texto);


            // ----------------------------------------------------------------------------------------------------------------------------------------

            //          COMPARAÇÃO DE STRINGS

            // Forma 1: 
            var texto = "testando";
            Console.WriteLine(texto.CompareTo("testando"));

            //Forma 2:
            var texto = "esse é um teste";
            Console.WriteLine(texto.Contains("teste", StringComparison.OrdinalIgnoreCase)); // O StringComparison.OrdinalIgnoreCase faz com o que o sistema ignore se é maiúsculo ou minusculo na hora de fazer a busca



            // ----------------------------------------------------------------------------------------------------------------------------------------



            //        STARTSWITH    /    ENDSWITH  

            var texto = " Texto teste";
            Console.WriteLine(texto.StartsWith("Este")); // Serve para validar se texto começa com a palavra "Este"

            var texto = " Texto teste";
            Console.WriteLine(texto.EndsWith("Este")); // Serve para validar se texto termina com a palavra "Este"



            // ----------------------------------------------------------------------------------------------------------------------------------------


            //        EQUALS

            var texto = "Texto teste";
            Console.WriteLine(texto.Equals("Este")); // Compara se a variável texto é exatamente igual ao que coloquei aqui, nesse caso seria FALSE
            Console.WriteLine(texto.Equals("Texto teste")); // Compara se a variável texto é exatamente igual ao que coloquei aqui, nesse caso seria TRUE 

            // ----------------------------------------------------------------------------------------------------------------------------------------




            //          INDICES

            var texto = "Esse é um teste";

            Console.WriteLine(texto.IndexOf("é")); // aqui ele me informa que o "é" está na quinta posição
            Console.WriteLine(texto.LastIndexOf("s")); // aqui ele mostra a ultima vez que a letra "s" apareceu


            // ----------------------------------------------------------------------------------------------------------------------------------------




            // TOLOWER  / TOUPPER / INSERT / REMOVE / LENGTH

            var texto = "Esse é um teste";

            Console.WriteLine(texto.ToLower()); //Converte tudo em minúsculo
            Console.WriteLine(texto.ToUpper()); //Converte tudo em maiúsculo
            Console.WriteLine(texto.Insert(5, "AQUI")); // Serve para inserir uma string dentro da outra string e o resultado ficaria como "Esse AQUI é um teste"
            Console.WriteLine(texto.Remove(5, 5)); // Nesse caso ele começaria no caractere 5 e removeria os 5 próximos caracteres
            Console.WriteLine(texto.Length); // Trás a quantidade de caracteres na String


            // ----------------------------------------------------------------------------------------------------------------------------------------

            // REPLACE / SPLIT / SUBSTRING / TRIM

            var texto = " Esse é um teste ";

            Console.WriteLine(texto.Replace("Esse", "Isso")); // Serve para trocar uma coisa por outra


            var divisao = texto.Split(" ");
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);


            /* Serve para dividir o texto por algum caractere, ou seja, ele vai pegar a variavel "texto" e tornar em :
            Esse
            é 
            um
            teste  */



            var resultado = texto.Substring(5, 5); // Serve para pegar e me retornar a partir da posição indicada os caracteres selecionados, nesse caso retornaria "é um "
            Console.WriteLine(resultado);



            Console.WriteLine(texto.Trim()); // Serve para tirar os espaços antes e no fim da string 




            // ----------------------------------------------------------------------------------------------------------------------------------------

            // STRINGBUILDER

            var texto = new StringBuilder();  // Serve para concatenar vários textos sem a necessidade de criar uma variável nova a cada texto
            texto.Append(" Esse é um teste ");
            texto.Append(" e isso é uma continuação do teste, ");
            texto.Append(" aqui ainda é um teste. ");



        }
    }
}
