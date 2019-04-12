using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protótipo.iadpter
{
    interface problema:labririnto_interface,Deutschland_interface
    {
       string[] relaciomento_de_aresta(string[] l);
       
    }
    public interface labririnto_interface
    {
        string[] valores();
    }
   public interface Deutschland_interface
    {
       string[] Deutschland();
    }
}
