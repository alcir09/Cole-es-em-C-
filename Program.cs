using System;
using System.Collections;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes{

    class Program{

        static void Main(string[] args){

            int[] arrayNumeros = new int[10] { 100, 1, 4, 8, 0, 15, 19, 19, 4, 100};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();

            
            System.Console.WriteLine($"minimo: {minimo}");
            System.Console.WriteLine($"maximo: {maximo}");
            System.Console.WriteLine($"medio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($" Array original: {string.Join(" , ", arrayNumeros)}");
            System.Console.WriteLine($" Array original: {string.Join(" , ", arrayUnico)}");

            // var numerosPares =

            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     orderby num
            //     select num;

            // var numerosParesMetodos = arrayNumeros.Where( x => x % 2 == 0).OrderBy( x => x).ToList();

            // System.Console.WriteLine("Números pares Query: " + string.Join(" , ", numerosPares));
            // System.Console.WriteLine("Números pares método: " + string.Join(" , ", numerosParesMetodos));

            // Dictionary<string,string> estados = new Dictionary<string, string>();

            // estados.Add("PE", "Pernambuco");
            // estados.Add("BA", "Bahia");
            // estados.Add("MA", "Maranhão");
            // System.Console.WriteLine("Valor original");
            // System.Console.WriteLine(estados[valorProcurado]);

            // System.Console.WriteLine("Valor alterado");
            // estados[valorProcurado] = "BA - TESTE";

            // System.Console.WriteLine(estados[valorProcurado]);

            // System.Console.WriteLine($"Removendo o valor: {valorProcurado}");

            //  foreach (KeyValuePair<string, string> item in estados)
            //  {
            //     //  System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
            //     //  estados.Remove(valorProcurado);
            //  }

             
            // string valorProcurado = "ZZ";

            // if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else{
            //     System.Console.WriteLine($"Estado {valorProcurado} não encontrado");
            // }


            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DVD");
            // pilhaLivros.Push("Código limpo");

            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count()}");

            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso!");
            // }

            //  System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count()}");

            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("Alcir");
            // fila.Enqueue("Katy");
            // fila.Enqueue("Pedro");
            
            // System.Console.WriteLine($"Pessoa na fila: {fila.Count}");

            // while (fila.Count > 0)
            // {
            //      System.Console.WriteLine($"Vez de:  {fila.Peek}");
            //      System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }
            
            // OperacoesLista opLista = new OperacoesLista();

            // List<string> estados = new List<string>();

            // string[] estadosArray = new string[2] {"SC", "MT" };

            // estados.Add("PE");
            // estados.Add("BA");
            // estados.Add("PB");

            // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count()}");

            // // opLista.ImprimirListaString(estados);

            // // System.Console.WriteLine("Removendo o elemento");
            // // estados.Remove("BA");

            // // estados.AddRange(estadosArray);

            // estados.Insert(1,"RJ");
            
            // opLista.ImprimirListaString(estados);

            // OperacoesArray op = new OperacoesArray();
            
            // int[] array = new int[5] {6,3,8,1,9};
            // int[] arrayCopia = new int[10];
            // string[] arrayString = op.ConverterParaArrayString(array);

            // System.Console.WriteLine("Array de interos: ");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array de string: ");
            // op.ImprimirArrayString(arrayString);

            // int valorProcurado = 90;

            // int indice = op.ObterIndice(array, valorProcurado);

            // System.Console.WriteLine($"Capacidade atual do Array: {array.Length}");

            // op.RedimensionarArreu( ref array, array.Length * 2);

            // System.Console.WriteLine($"Capacidade atual do Array após redimensionar: {array.Length}");

            // if( indice > 0){

            //     System.Console.WriteLine("O índice do elemento {0} é: {1}",valorProcurado, indice);
            // }
            // else{
            //     System.Console.WriteLine("O índice para o valor {0} não foi encontrado.",valorProcurado);
            // }

            // int valorAchado = op.ObterValor(array, valorProcurado);

            // if( valorAchado > 0){

            //     System.Console.WriteLine("Foi encontrado o valor {0}", valorProcurado);
            // }
            // else{

            //     System.Console.WriteLine("Não encontrei o valor {0}", valorProcurado);
            // }

            // bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if(TodosMaiorQue){

            //     System.Console.WriteLine("Todo os valores são maiores que: {0}", valorProcurado);
            // }

            // else{
            //     System.Console.WriteLine("Existem valores maiores que: {0}",valorProcurado);
            // }

            // bool existe = op.Existe(array, valorProcurado);

            // if(existe){
                
            //     System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            // }
            // else{

            //     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            // }

            // System.Console.WriteLine("Array original");
            // op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);

            //op.Ordenar(ref array);

            // System.Console.WriteLine("Array ordenado");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);

            // System.Console.WriteLine("Array depois da cópia");
            // op.ImprimirArray(arrayCopia);

            // int[,] matriz = new int[4,2]{

            //     { 8 , 8   },
            //     { 10, 20  },
            //     { 50, 100 },
            //     {90 , 200 }
            // }; 

            // for(int i = 0; i < matriz.GetLength(0); i++){

            //     for (int l = 0; l < matriz.GetLength(1); l++){

            //       System.Console.WriteLine(matriz[i,l]);

            //     }
            // }

            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30");

            // //
            // arrayInteiros[3] = 30;

            //  for(int i = 0; i < arrayInteiros.Length; i++){

            //      System.Console.WriteLine(arrayInteiros[i]);
            //  }
        }
    }

}
