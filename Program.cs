using System;

namespace Colecoes{

    class Program{

        static void Main(string[] args){

            int[,] matriz = new int[4,2]{

                { 8 , 8   },
                { 10, 20  },
                { 50, 100 },
                {90 , 200 }
            }; 

            for(int i = 0; i < matriz.GetLength(0); i++){

                for (int l = 0; l < matriz.GetLength(1); l++){

                  System.Console.WriteLine(matriz[i,l]);

                }
            }

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
