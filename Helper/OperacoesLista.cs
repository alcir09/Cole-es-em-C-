using System.Collections.Generic;

namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista){

            foreach (string item in lista)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}