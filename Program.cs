using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes{

    class Program{

        static void Main(string[] args){
            
            OperacoesLista opLista = new OperacoesLista();

            List<string> estados = new List<string>();

            string[] estadosArray = new string[2] {"SC", "MT" };

            estados.Add("PE");
            estados.Add("BA");
            estados.Add("PB");

            System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count()}");

            // opLista.ImprimirListaString(estados);

            // System.Console.WriteLine("Removendo o elemento");
            // estados.Remove("BA");

            // estados.AddRange(estadosArray);

            estados.Insert(1,"RJ");
            
            opLista.ImprimirListaString(estados);

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
