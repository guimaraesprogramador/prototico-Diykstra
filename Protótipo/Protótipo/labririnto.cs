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

        public string[] valores()
        {
            string[] array = { "a", "b", "c", "d", "e",
            "f","g","h","i","j","k","l","m","n","o","p",
            "q","r","s","v","u","t","x"};
            return array;
        }

        public string[] relaciomento_de_aresta(string[] l)
        {
            throw new NotImplementedException();
        }

      
    }
}
