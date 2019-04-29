using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protótipo.iadpter;
using System.IO;
using System.Runtime.InteropServices;

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
            unsafe
            {

                string distancia = null;
               
                    for (int i = 0; i < v.Length; i++)
                    {
                        if (
                            Convert.ToString(v[i]->x) != Convert.ToString(a[i]->vertice))
                        {

                            continue;
                        }
                        else if (Convert.ToString(v[i]->x) == destino)
                        {
                            distancia = Convert.ToString(v[i]->x);
                            break;
                        }
                        else
                        {
                            rastro.Add(Convert.ToString(v[i]->x));
                        }

                    }
                
                

            }


            return rastro;
        }
            
            
        
       public unsafe struct adjacente
        {
            public char vertice;
            public int adj;
           
        }
        static unsafe vertices* grafo(string a,string b,int n)
        {
            unsafe
            {

                vertices* novo = (vertices*) Marshal.AllocHGlobal(sizeof(vertices));
                novo->x = char.Parse(a);
                novo->y = char.Parse(b);
                novo->next = n;
                return novo;
              
            }

        }
       public  string[] horionzal
        {
            get
            {
                string[] h =
                {
                     "a", "b",
                    "c", "d", 
                    "d", "e",
                    "e", "f", 
                    "g",
                    "h", "i", 
                    "j", "k", 
                    "l","m","n",
                    "o", "p", "q",
                    "r", "s","t",
                    "u", "v", 
                    "w", "x"
                };
                return h;
            }
        }
      public  unsafe struct vertices
        {
            public  char x;
            public char y;
            public int  next;
        }
        private unsafe vertices*[] v = new vertices*[30];
        private unsafe adjacente*[] a = new adjacente*[28];
        private static int o = 0;
        public void add_labirinto_vertices(string posicao_x,string posicao_y, int valor)
        {
            unsafe
            {   
                   v[o] = grafo(posicao_x,posicao_y, valor);
                   
                o++;

            }

        }
        public void add_labirinto_adjacentes()
        {
            unsafe
            {
                for(int i = 0; i < horionzal.Length; i++)
                {
                    a[i] = grafo_adjacente(horionzal[i]);
                }
                o = 0;
            }
        }
        public void relaciomento_de_aresta(int u, int v, int anty)
        {
           
        }
       static unsafe adjacente* grafo_adjacente( string letra)
        {
            adjacente* novo = (adjacente*)Marshal.AllocHGlobal(sizeof(adjacente));
            novo->vertice = char.Parse(letra);
            novo->adj = 1;
            return novo;

        }
      
    }
}
