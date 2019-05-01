using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protótipo.iadpter;
using System.Runtime.InteropServices;
namespace Protótipo
{
    public class mapa : Deutschland_interface
    {
        public List<string> Deutschland()
        {
            string[] nomes =
             {
                "Frankfurt","Mannheim",
                "Würzburg","Stuttgart",
                "Kassel","Karlsruhe","Erfurt",
                "Nürnberg","Augsburg","München"
            };
            List<string> lista = new List<string>();
            lista.AddRange(nomes);
            return lista.ToList();
        }
        
        private List<object> vetor = new List<object>(); 
        public void distancia()
        {
            
            adicionar_caminho("Frankfurt", "Mannheim", 85);
            adicionar_caminho("Frankfurt", "Kassel", 173);
            adicionar_caminho("Frankfurt", "Würzburg", 217);
            adicionar_caminho("Würzburg", "Erfurt", 186);
            adicionar_caminho("Würzburg", "Nürnberg", 103);
            adicionar_caminho("Nürnberg", "Stuttgart", 183);
            adicionar_caminho("Nürnberg", "München", 167);
            adicionar_caminho("Mannheim", "Karlsruhe", 80);
            adicionar_caminho("Karlsruhe", "Augsburg", 250);
            adicionar_caminho("Augsburg", "München", 84);
            adicionar_caminho("Kassel", "München", 520);
        }
        private static int o = 0;

        public List<int> kilo = new List<int>();
        public List<string> cidade_x = new List<string>();
        public List<string> cidade_y = new List<string>();

        public void adicionar_caminho(string x, string y, int valor)
        {

            cidade_x.Add(x);
            cidade_y.Add(y);
                kilo.Add(valor);            
        }

        public void caminho(string inicia, string destino)
        {
            
            unsafe
            {
                List<string> rasta = new List<string>();
                string cidade_selecionada = null;
                string cidade_destino = null;
                int quilometra_inicial = 0;
                List<string> cidades = Deutschland();
                for(int i = 0; i < cidades.Count; i++)
                {
                    if (inicia == cidades[i]) cidade_selecionada = cidades[i];
                    else if (destino == cidades[i]) cidade_destino = cidades[i];
                }
                if (cidade_destino != null && cidade_selecionada != null)
                {
                    for (int q = 0; q < cidade_x.Count; q++)
                    {
                        if (Convert.ToString(cidade_x[q]) == inicia && Convert.ToString(cidade_y[q]) == destino)
                        {
                            quilometra_inicial = kilo[q];
                            rasta.Add(Convert.ToString(cidade_x[q]));

                        }
                        else if (quilometra_inicial != 0)
                        {
                            int kilometro = somar_quilometragem(kilo[q], kilo[q - 1],"-") < quilometra_inicial ?
                                quilometra_inicial : 0;

                            if (kilometro == quilometra_inicial)
                            {
                                rasta.Add(Convert.ToString(cidade_y[q-1]));
                                labririnto.distancia_1 = kilometro;
                                break;
                            }
                           
                            
                        }
                        else
                        {
                            if (q > 0)
                            {
                                int somar_distancia = somar_quilometragem(kilo[q], kilo[q - 1], "-");
                                if (somar_distancia < kilo[q])
                                {
                                    rasta.Add(Convert.ToString(cidade_x[q]));
                                    rasta.Add(Convert.ToString(cidade_y[q]));
                                    labririnto.distancia_1 = somar_distancia;

                                }
                                
                            }
                            

                        }
                    }

                }
                for(int i = 0; i < rasta.Count; i++){
                    labririnto.texto = labririnto.texto +rasta[i] + ",";
                }
            }
        }
        private int somar_quilometragem(int inicial, int final, string operacao)
        {
            int k = 0;
            if (operacao == "-") k = final - inicial;
            else if (operacao == "+") k = final + inicial;
            return k;
        }
    }
}
