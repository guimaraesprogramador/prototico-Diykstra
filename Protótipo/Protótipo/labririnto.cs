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
        public List<object> caminho = new List<object>();
        public List<String> procurar_caminho(string inicia,string destino)
        {
            List<string> caminho_inicial = new List<string>();
            List<string> rastro = new List<string>();
            rastro.Add(inicia);
            string anterior = null;
            string proxima = null;
            object[] a = caminho.ToArray();
        for(int i = 0; i < a.Length; i++)
            {
                for(int y =0;y<caminho.Count;y++)
                {
                    
                }
            }
            
            
            caminho.Clear();
            return rastro;
        }

        public void add_labirinto(string posicao_x,string posicao_y, int valor)
        {
            object[] array =
            {
              posicao_x,posicao_y,valor
            };
            caminho.Add(array);
            
        }
        public void relaciomento_de_aresta(int u, int v, int anty)
        {
           
        }

      
    }
}
