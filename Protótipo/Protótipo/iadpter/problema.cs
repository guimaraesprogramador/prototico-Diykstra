using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo.iadpter
{
    interface problema:labririnto_interface
    {
       void relaciomento_de_aresta(int u,int v, int anty);
       
    }
    public interface labririnto_interface
    {
        List<string> valores();
    }
   public interface Deutschland_interface
    {
       List<string> Deutschland();
        void distancia();
        void caminho(string inicia, string destino);
       
    }
}
