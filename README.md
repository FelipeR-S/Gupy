# Gupy
<h1 align="center">Exercícios para a plataforma Gupy</h1>

'''

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
    }

'''

<p align="center">Para realizar os exercícios foi utilizado .NET e C#. que retornam resultados no console.</p><br>
<p align="center">
<a href="#exercicio-01"><b>Exercício-01</b></a> •
<a href="#exercicio-02"><b>Exercício-02</b></a> •
<a href="#exercicio-03"><b>Exercício-03</b></a> •
<a href="#exercicio-04"><b>Exercício-04</b></a> •
<a href="#exercicio-05"><b>Exercício-05</b></a> •
</p><br>

# **Exercicio-01**
<p>Foi utilizado o método criado "SomaIndiceGupy01();" para retornar automaticamente a soma de um valor.</p><br>

'''

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
        
'''

# **Exercicio-02**
<p>Criado o método: "FibonacciGupy02(numero);" que verifica se o numero inserido pertence a sequência Fibonacci.</p><br>

'''

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

'''

# **Exercicio-03**
<p>Metodo "FaturamentoGupy03(entradaArquivo);" que recebe arquivo JSON e trata para retornar resultados como menor valor, maior valor e quantidade de valores acima da média.</p><br>

'''

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

'''

# **Exercicio-04**
<p>Método "PorcentagemGupy04();" que retorna a porcentagem de cada faturamento dos estados.</p><br>

'''

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

'''

# **Exercicio-05**
<p>Método "InverteStringGupy05(entradaString);" que inverte a string de entrada.</p><br>

'''

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

'''
