using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protótipo.iadpter;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
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
        public void procurar_caminho(string inicia,string destino)
        {
            List<string> rastro = new List<string>();
           
            
            int o = 0;
            if (inicia == "m"|| destino == "m") MessageBox.Show("armario");
            else if (inicia == "o"|| destino =="o") MessageBox.Show("dragão");
            else if (inicia == "p"||destino=="p") MessageBox.Show("tesouro");
            else if (inicia == "r"|| destino=="r") MessageBox.Show("armario");
            else if (inicia == "v" || destino == "v") MessageBox.Show("sem saida");
            else if (destino == "x" || inicia == "x") MessageBox.Show("sem saida");
            else if (destino == "g" || inicia == "g") MessageBox.Show("sem saida");
            else if (destino == "s" || inicia == "s") MessageBox.Show("sem saida");
            else
            {
                unsafe
                {
                    int soma = 0;
                    string proxima_y = null;
                    string proxima_x = null;
                    string anterior_x = null;
                    string anterior_y = null;
                    bool t = false;
                    for (int p = 0; p < a.Length; p++)
                    {
                        if (t == true) break;
                        if (Convert.ToString(a[p]->vertice) == "a")
                        {
                            soma = a[p]->adj;
                            rastro.Add(Convert.ToString(a[p]->vertice));
                        }
                        else
                        {

                            if (Convert.ToString(a[p]->vertice) == destino)
                            {
                                distancia = a[p]->adj + soma;
                                rastro.Add(Convert.ToString(a[p]->vertice));
                                break;
                            }
                            soma = a[p]->adj + 1;
                            for (int i = 0; i < v.Length; i++)
                            {
                                proxima_y = Convert.ToString(v[i + 1]->y);
                                proxima_x = Convert.ToString(v[i + 1]->x);
                                if (verificar_erro(proxima_x, proxima_y))
                                {


                                    if (proxima_x == destino || proxima_y == destino)
                                    {
                                        rastro.Add(proxima_y);
                                        rastro.Add(destino);
                                        distancia = soma;
                                        t = true;
                                        break;
                                    }
                                    anterior_x = Convert.ToString(v[i - 1]->x);
                                    anterior_y = Convert.ToString(v[i - 1]->y);
                                    if (verificar_erro(anterior_x, anterior_y))
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        soma = soma + v[i]->next;
                                        rastro.Add(proxima_x);
                                    }

                                }
                            }
                        }

                    }

                }
                for (int t = 0; t < rastro.Count; t++)
                {
                    texto = texto + rastro[t].ToString() + ",";
                }
            }
            
        }
        public string texto = null; 
            
        public bool verificar_erro(string palavra1,string palavra2)
        {
            if (palavra1 == "m" || palavra2 == "m"
                || palavra1 == "o" && palavra2 == "o"||
                palavra1 == "p"||palavra2=="p"||
                palavra1=="r"|| palavra2=="r")
            {
                return false;
            }
            else if (palavra1 == palavra2) return false;
            return true;
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
            if(letra == "a")
            {
                adjacente* novos = (adjacente*)Marshal.AllocHGlobal(sizeof(adjacente));
                novos->vertice = char.Parse(letra);
                novos->adj = 0;
                return novos;
            }
            else
            {
                adjacente* novo = (adjacente*)Marshal.AllocHGlobal(sizeof(adjacente));
                novo->vertice = char.Parse(letra);
                novo->adj = 1;
                return novo;
            }
            

        }
      
    }
}
