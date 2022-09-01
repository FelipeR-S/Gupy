using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GupyExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01
            SomaIndiceGupy01();
            //Exercício 02
            var numero = Convert.ToInt32(Console.ReadLine());
            FibonacciGupy02(numero);
            //Exercício 03
            var entradaArquivo = Console.ReadLine();
            FaturamentoGupy03(entradaArquivo);
            //Exercício 04
            PorcentagemGupy04();
            //Exercício 05
            var entradaString = Console.ReadLine();
            InverteStringGupy05(entradaString);

            Console.ReadLine();
        }
        static void SomaIndiceGupy01()
        {
            var indice = 13;
            var soma = 0;
            var k = 0;
            while (k < indice)
            {
                k++;
                soma += k;
            }
            Console.WriteLine($"{soma}\n");
        }
        static void FibonacciGupy02(int numero)
        {
            var contador = 0;
            var saida = "";
            var fiboLista = new List<int>() { 0, 1 };
            while (contador < numero)
            {
                var fibo = fiboLista[fiboLista.Count - 2] + fiboLista[fiboLista.Count - 1];
                fiboLista.Add(fibo);
                contador = fibo;
            }
            if (fiboLista.Contains(numero))
                Console.WriteLine("Número existe na sequência de Fibonacci!\n");
            else
                Console.WriteLine("Número não existe na sequência de Fibonacci!\n");
        }
        static void FaturamentoGupy03(string arquivo)
        {
            List<ItemJson> itens = new List<ItemJson>();
            using (StreamReader reader = new StreamReader(arquivo))
            {
                string arquivoJson = reader.ReadToEnd();
                itens = JsonSerializer.Deserialize<List<ItemJson>>(arquivoJson);
            }
            var media = 0.0;
            var contadorMedia = 0;
            var listaValores = new List<double>();
            foreach (var item in itens)
            {
                listaValores.Add(item.valor);
                if (item.valor > 0)
                {
                    contadorMedia++;
                    media += item.valor;
                }
            }
            media /= contadorMedia;
            var menorValor = listaValores.Min();
            var maiorValor = listaValores.Max();
            var contadorDiasMedia = 0;
            foreach (var val in listaValores)
            {
                if (val > media)
                    contadorDiasMedia++;
            }
            Console.WriteLine($"Valor Mínimo: {menorValor}\n" +
                $"Valor Máximo: {maiorValor}\n" +
                $"Dias Acima da Média: {contadorDiasMedia}\n");
        }
        public class ItemJson 
        { 
            public int dia { get; set; }
            public double valor { get; set; }
        }
        static void PorcentagemGupy04()
        {
            var SP = 67836.43;
            var RJ = 36678.66;
            var MG = 29229.88;
            var ES = 27165.48;
            var Outros = 19849.53;
            var total = SP+RJ+MG+ES+Outros;
            Console.WriteLine($"Porcentagem de faturamento por Estado:\n" +
                $"SP: {(SP * 100 / total).ToString("F4")}%\n" +
                $"RJ: {(RJ * 100 / total).ToString("F4")}%\n" +
                $"MG: {(MG * 100 / total).ToString("F4")}%\n" +
                $"ES: {(ES * 100 / total).ToString("F4")}%\n" +
                $"Outros: {(Outros * 100 / total).ToString("F4")}%\n");
        }
        static void InverteStringGupy05(string entrada)
        {
            var novaString = "";
            var tamanho = entrada.Length - 1;
            while (tamanho >= 0)
            {
                novaString += entrada[tamanho];
                tamanho--;
            }
            Console.WriteLine(novaString);
        }
    }
}
