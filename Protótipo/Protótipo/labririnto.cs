using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protótipo.iadpter;
using System.IO;
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
            "q","r","s","v","u","t","w","x"};
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
        public int distancia { get; set; }
        public List<String> procurar_caminho(string inicia,string destino)
        {
            List<string> caminho_inicial = new List<string>();
            List<string> rastro = new List<string>();
           
            object anterior = null;
            object proxima = null;
            int o = 0;
            if (inicia == "m") throw new Exception("armario");
            else if (inicia == "o") throw new Exception("dragão");
            else if (inicia == "p") throw new Exception("tesouro");
            else if (inicia == "r") throw new Exception("armario");
            else if (inicia == "v") throw new Exception("sem saida");
            List<string> list = valores();
            rastro.Add(inicia);
                foreach(KeyValuePair<int,string> y in posicao)
                {
                if (destino != list[y.Key]) ;
                }

            posicao.Clear();
            return rastro;
        }
        private Dictionary<int,string> posicao = new Dictionary<int, string>();
        public void grafo(string item,int distancia)
        {
            if (item == "a") posicao.Add(0, "a");
            else posicao.Add(distancia, "a");

        }
        
       
        public int somar_com_vizinhos(object u, object v)
        {
            if (v.ToString() == "a") return 0;
            int p = Convert.ToInt32(u)+1;
            
            return p;
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
