using System.Runtime.Serialization;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace ExerciciosLogicaDb1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            # Lista de Exercícios de Programação
            Os exercícios abaixo avaliam o conhecimento e potencial em lógico de programação e uso de estruturas básicas de linguagens de programa.
            Leia atentamente a proposta de cada exercício. Se possível, crie testes unitários
            */

            /*
            # Exercício 1: Calculadora Simples
            Crie um programa que receba dois números e uma operação (+, -, *, /) e retorne o resultado.
            Trate possíveis erros como divisão por zero.
            

            Console.WriteLine("Informe qual operação você quer utilizar: +, -, * ou /");
            string operacao = Console.ReadLine();

            Console.WriteLine("Informe primeiro número para realizar a operação: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número para realizar a operação: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (operacao == "+")
            {
                int soma = numero1 + numero2;
                Console.WriteLine("Resultado: " + soma);
            } else if (operacao == "-")
            {
                int subtracao = numero1 - numero2;
                Console.WriteLine("Resultado: " + subtracao);
            } else if (operacao == "*")
            {
                int multiplicacao = numero1 * numero2;
                Console.WriteLine("Resultado: " + multiplicacao);
            } else if(operacao == "/" && numero2 != 0)
            {
                int divisao = numero1 / numero2;
                Console.WriteLine("Resultado: " + divisao);
            } else if(operacao == "/" && numero2 == 0)
            {
                Console.WriteLine("Não é possível realizar divisão por zero");
            } else
            {
                Console.WriteLine("Operação inválida");
            }
            */

            /*
            # Exercício 2: Verificador de Números Primos
            Crie um programa que verifique se um número é primo.
            Um número primo é um número natural maior que 1 que só pode ser dividido por 1 e por ele mesmo sem deixar resto. Por exemplo, 2, 3, 5, 7, 11, 13, 17, 19, 23, etc.
            

            Console.WriteLine("Informe o número para verificar se é um número primo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero %2  == 0 && numero < 0 || numero > 0)
            {
                Console.WriteLine("O número é primo");
            } else
            {
                Console.WriteLine("O número não é primo");
            }
            */

            /*
            ## Exercício 3: Fibonacci -> REVER COM CALMA
            A sequência de Fibonacci é uma famosa sequência matemática onde cada número é a soma dos dois números anteriores. A sequência começa 
            com 0 e 1, e os próximos termos são calculados somando os dois valores anteriores.
            Se o usuário digitar 8, o programa vai exibir: 0 1 1 2 3 5 8 13
            Implemente um programa que gere os N primeiros números da sequência de Fibonacci.
            

            static int Fibonacci(int n)
            {
                if (n == 0) return 0;
                if (n == 1) return 1;
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("A sequência de Fibonacci é: ");
            */

            /*
            ## Exercício 4: Ordenação de Array -> REVER COM CALMA
            Implemente um programa que ordene um array de inteiros em ordem crescente usando o algoritmo Bubble Sort.
            Como o Bubble Sort funciona:

            O algoritmo percorre o array várias vezes
            Em cada passagem, compara elementos adjacentes (um par de cada vez)
            Se um elemento for maior que o próximo, eles são trocados de posição
            Esse processo continua até que não sejam necessárias mais trocas
 
            Exemplo de execução:
            Se o usuário criar um array [5, 3, 8, 1, 2]:
 
            Compara 5 e 3 → troca → [3, 5, 8, 1, 2]
            Compara 5 e 8 → não troca → [3, 5, 8, 1, 2]
            Compara 8 e 1 → troca → [3, 5, 1, 8, 2]
            Compara 8 e 2 → troca → [3, 5, 1, 2, 8]
            Continua com novas passagens até ordenar completamente: [1, 2, 3, 5, 8]

            int[] array = { 5, 3, 8, 1, 2 };

            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Laço para percorrer os elementos do array e comparar pares adjacentes
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Comparando os elementos adjacentes
                    if (array[j] > array[j + 1])
                    {
                        // Trocando os elementos se o anterior for maior que o próximo
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            */

            /*
            ## Exercício 5: Palíndromo
            Crie um programa que verifique se uma palavra ou frase é um palíndromo (lê-se igual de trás para frente).
            Utilize como exemplo a palavra RADAR

            Console.WriteLine("Informe uma palavra: ");
            string palavra = Console.ReadLine().ToLower();

            char[] charArray = palavra.ToCharArray(); // Transforma a variável palavra de char para array
            Array.Reverse(charArray); // Inverte a ordem da variável charArray
            string palavraInvertida = new string(charArray); // Instância charArray e o transforma em uma string, depois atribui a string palavraInvertida

            if (palavra ==  palavraInvertida)
            {
                Console.WriteLine("A palavra é um palíndromo");
            }
            else
            {
                Console.WriteLine("A palavra não é um palíndromo");
            }
            */

            /*
            ## Exercício 6: Contagem de Vogais e Consoantes
            Crie um programa que conte o número de vogais e consoantes em uma string.
            
            Console.Write("Informe uma palavra: ");
            string palavra = Console.ReadLine().ToLower();

            int contador = 0;
            int contador2 = 0;
            foreach (char letra in palavra)
            {
                if (("aeiou").Contains(letra))
                {
                    contador++;
                } else if (("bcdfghjklmnpqrstvwxyz").Contains(letra))
                {
                    contador2++;
                }
            }

            Console.WriteLine("A palavra possui: " + contador + " vogais e " + contador2 + " consoantes");
            */

            /*
            ## Exercício 7: Conversão de Temperatura
            Crie um programa que converta temperaturas entre Celsius, Fahrenheit e Kelvin.

            Conversões de Temperaturas entre três escalas comuns:

            Celsius (°C) - Escala usada no sistema métrico
            Fahrenheit (°F) - Escala comum nos EUA
            Kelvin (K) - Escala usada em ciência, começa no zero absoluto

            Fórmulas de Conversão:

            Celsius para Fahrenheit:
            °F = (°C × 9/5) + 32

            Celsius para Kelvin:
            K = °C + 273.15

            Fahrenheit para Celsius:
            °C = (°F - 32) × 5/9

            Fahrenheit para Kelvin:
            K = (°F - 32) × 5/9 + 273.15

            Kelvin para Celsius:
            °C = K - 273.15

            Kelvin para Fahrenheit:
            °F = (K - 273.15) × 9/5 + 32

            Console.WriteLine("Informe qual é a escala de temperatura atual (1, 2, ou 3): ");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.WriteLine("3. Kelvin");
            int escalaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe qual é a escala de temperatura para qual será convertida (1, 2, ou 3): ");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.WriteLine("3. Kelvin");
            int escalaConvertida = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a temperatura: ");
            double temperatura = double.Parse(Console.ReadLine());

            if (escalaInicial == 1 && escalaConvertida == 2)
            {
                double celsiusParaFahrenheit = (temperatura * 9 / 5) + 32;
                Console.Write("A temperatura de Celsius para Fahrenheit é: " + celsiusParaFahrenheit);
            }
            else if (escalaInicial == 1 && escalaConvertida ==3)
            {
                double celsiusParaKelvin = temperatura + 273.15;
                Console.Write("A temperatura de Celsius para Kelvin é: " + celsiusParaKelvin);
            } else if (escalaInicial == 2 && escalaConvertida == 1)
            {
                double fahrenheitParaCelsius = (temperatura - 32) * 5/9;
                Console.Write("A temperatura de Fahrenheit para Celsius é: " + fahrenheitParaCelsius);
            }
            else if (escalaInicial == 2 && escalaConvertida == 3)
            {
                double fahrenheitParaKelvin = (temperatura - 32) * 5/9 + 273.15;
                Console.Write("A temperatura de Fahrenheit para Kelvin é: " + fahrenheitParaKelvin);
            }
            else if (escalaInicial == 3 && escalaConvertida == 1)
            {
                double kelvinParaCelsius = temperatura - 273.15;
                Console.Write("A temperatura de Kelvin para Celsius é: " + kelvinParaCelsius);
            }
            else if (escalaInicial == 3 && escalaConvertida == 2)
            {
                double kelvinParaFahrenheit = (temperatura - 273.15) * 9 / 5 + 32;
                Console.Write("A temperatura de Kelvin para Fahrenheit é: " + kelvinParaFahrenheit);
            } else
            {
                Console.WriteLine("Informe a opção númerica");
            }
            */

            /*
            ## Exercício 8: Jogo de Adivinhação
            Crie um jogo onde o computador escolhe um número aleatório entre 0 e 10 e o jogador deve adivinhar, depois mostre a quantidade de tentativas 
            utilizadas pelo usuário até conseguir adivinhar.
            */

            //Console.WriteLine("Escolha um número aleatório entre 0 e 10")



            /*
            ## Exercício 9: Gerenciador de Lista de Tarefas
            Crie um programa que permita adicionar, listar e remover tarefas de uma lista.

            List<string> list = new List<string>();

            Console.WriteLine("GERENCIADOR DE TAREFAS");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para adicionar tarefa");
            Console.WriteLine("Digite 2 para listar tarefa");
            Console.WriteLine("Digite 3 para remover tarefa");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome da tarefa: ");
                    string tarefa = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(tarefa))
                    {
                        list.Add(tarefa);
                        Console.WriteLine("Tarefa adicionada com sucesso!");
                    } else
                    {
                        Console.WriteLine("A tarefa não pode estar vazia.");
                    }
                    break;

                case 2:
                    if (list.Count == 0)
                    {
                        Console.WriteLine("Não existem tarefas cadastradas");
                    } else
                    {
                        Console.WriteLine("Lista de tarefas: ");
                        for (int i = 1; i <= list.Count; i++)
                        {
                            Console.WriteLine($"{i}. {list[i]}");
                        }
                    }   
                    break;

                case 3:
                    if (list.Count == 0)
                    {
                        Console.WriteLine("Não existem tarefas cadastradas");
                    } else if (list.Count > 0)
                    {
                        Console.WriteLine("Informe o número da tarefa que deseja remover: ");
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Tarefa '{list[index - 1]}' removida");
                        list.RemoveAt(index - 1);
                    } else
                    {
                        Console.WriteLine("Número inválido.");
                    }
                    break;
            }
            */

            /*
            ## Exercício 10: Calculadora de IMC
            Crie um programa que calcule o Índice de Massa Corporal (IMC) e classifique o resultado.
            A fórmula do IMC é:
            IMC = peso (kg) / [altura (m)]²

            Exemplo prático:

            Para uma pessoa com 70 kg e 1,75 m de altura:
            IMC = 70 / (1,75 × 1,75)
            IMC = 70 / 3,0625
            IMC = 22,86
            

            Console.WriteLine("Informe seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double IMC = peso / (altura * altura);

            Console.WriteLine("O seu IMC é: " + IMC.ToString("F2", CultureInfo.InvariantCulture));
            */
        }
    }
}
