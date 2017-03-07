using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leituraDeArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX1
            /* TextReader texto = new StreamReader("nomes_telefones.txt");
             string linha = texto.ReadLine();
             while (linha != null)
             {
                 Console.WriteLine(linha);
                 linha = texto.ReadLine();

             }

             Console.ReadKey();
        
            TextReader texto = new StreamReader("nomes_telefones.txt");
            string linha = texto.ReadLine();
            while (linha != null)
            {
                var resultado1 = linha.Replace("(", "").Replace(")", "").Replace("-", "");
                Console.WriteLine(resultado1);
                linha = texto.ReadLine();


            }

            Console.ReadKey();
            */

            //EX2
            /*
            TextReader texto = new StreamReader("nomes_telefones.txt");
            string linha = texto.ReadLine();
            while (linha != null)
            {
                int pos = linha.IndexOf("(");
                var resultado2 = linha.Substring(0,pos).Replace(" ", "");
                int qtd = resultado2.Length;
                if (qtd > 12)
                {
                    resultado2 = resultado2.ToUpper();
                    Console.WriteLine(resultado2);
                }
                linha = texto.ReadLine();


            }
            EX 3

            TextReader texto = new StreamReader("datas.txt");
            string linha = texto.ReadLine();
            while (linha != null)
            {

                var resultado3 = linha.Substring(6, 4);
                Console.WriteLine(resultado3);
                linha = texto.ReadLine();
            }

            Console.ReadKey();

        }
            
        }
        EX04

            TextReader texto = new StreamReader("marcas_carros.txt");
            string linha = texto.ReadLine();
            while (linha != null)
            {
                int pos = linha.IndexOf("@");
                var resultado4 = linha.Substring(0,pos);
                Console.WriteLine(resultado4);
                linha = texto.ReadLine();
            }

            Console.ReadKey();

        }

    }*/
        //EX5

            TextReader texto = new StreamReader("produtos_estoque.txt");
            string linha = texto.ReadLine();
            while (linha != null)
            {
                int pos = linha.IndexOf("$");
                int fim = linha.Length;
                int result = fim - pos;
                var resultado4 = linha.Substring(pos, result);
                Console.WriteLine(resultado4);
                linha = texto.ReadLine();
            }

            Console.ReadKey();

        }

    }
}
