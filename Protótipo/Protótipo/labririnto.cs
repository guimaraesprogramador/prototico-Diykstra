using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protótipo.iadpter;
namespace Protótipo
{
  public  class labririnto : problema
    {
        public string tarefa { get; set; }
        public string[] Deutschland()
        {
            throw new NotImplementedException();
        }
       
        public List<string> valores()
        {
            string[] array = { "a", "b", "c", "d", "e",
            "f","g","h","i","j","k","l","m","n","o","p",
            "q","r","s","v","u","t","x"};
            List<string> alfaberto = new List<string>();
            alfaberto.AddRange(array);

            return alfaberto.ToList();
        }
       public string algortimo { get; set; }
        public List<string> elementos( string tarefa, string algoritmo)
        {
            try
            {

                 if (String.Empty !=tarefa && String.Empty != algoritmo)
                   {
                       if (tarefa.ToString() == "Labirinto" && algoritmo == "Dijkstra")
                       {
                        return valores();
                       }
                    if (tarefa == "Labirinto" && algoritmo == "A*") return null;
                   }
            }
            catch (Exception e)
            {
                
            }
            return null;

        }
        public List<string> caminho = new List<string>();
        public int esquerta( int anty)
        {
            int anterior = anty+1;
            for (int i = 0; i < anty; i++)
            {
                caminho.Add(i.ToString());
                anterior = anterior + i;
            }
            caminho.Add(anterior.ToString());
            return anterior;
        }
        public void direita(int anty)
        {
            int proximo = 0;
            for (int i = 0; i < caminho.Count; i++)
            {
                if (Convert.ToInt32(caminho[i]) < anty)
                {
                    anty = anty - Convert.ToInt32(caminho[i]);
                    if (Convert.ToInt32(caminho[i]) > 1) proximo = anty + 1;
                }
                else
                {
                    anty = anty - 1;
                }
            }
            caminho.Add(proximo.ToString());
            caminho.Add(anty.ToString());
        }
        public void relaciomento_de_aresta(int u, int v, int anty)
        {
           
        }

      
    }
}
