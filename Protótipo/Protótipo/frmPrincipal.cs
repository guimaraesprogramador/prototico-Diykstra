using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Protótipo
{
    public partial class frmPrincipal : Form
    {
        labririnto labri;
        public frmPrincipal()
        {
            
            InitializeComponent();
         labri = new labririnto();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            fazer_labrindo_vertice();
            string v = comboBox5.Items[comboBox5.SelectedIndex].ToString();
            string u = comboBox4.Items[comboBox4.SelectedIndex].ToString();
             labri.procurar_caminho( u,v);
            textBox1.Text = labri.texto;
            textBox3.Text = labri.distancia.ToString();

        }
       
        public void fazer_labrindo_vertice()
        {

            //// horizontais
            //labri.add_labirinto_vertices("a", "b", 1);
            //labri.add_labirinto_vertices("c", "d", 1);
            //labri.add_labirinto_vertices("d", "e", 1);
            //labri.add_labirinto_vertices("e", "f", 1);
            //labri.add_labirinto_vertices("h", "i", 1);
            //labri.add_labirinto_vertices("j", "k", 1);
            //labri.add_labirinto_vertices("o", "p", 1);
            //labri.add_labirinto_vertices("s", "t", 1);
            //labri.add_labirinto_vertices("t", "u", 1);
            //labri.add_labirinto_vertices("w", "x", 1);
            // verticais
            labri.add_labirinto_vertices("a", "g", 1);
             labri.add_labirinto_vertices("g", "m", 1);
             labri.add_labirinto_vertices("m", "s", 1);
             labri.add_labirinto_vertices("b", "h", 1);
             labri.add_labirinto_vertices("h", "n", 1);
             labri.add_labirinto_vertices("n", "t", 1);
             labri.add_labirinto_vertices("c", "i", 1);
             labri.add_labirinto_vertices("i", "o", 1);
             labri.add_labirinto_vertices("o", "u", 1);
             labri.add_labirinto_vertices("d", "j", 1);
             labri.add_labirinto_vertices("j", "p", 1);
             labri.add_labirinto_vertices("p", "v", 1);
             labri.add_labirinto_vertices("e", "k", 1);
             labri.add_labirinto_vertices("k", "q", 1);
             labri.add_labirinto_vertices("q", "w", 1);
             labri.add_labirinto_vertices("f", "l", 1);
             labri.add_labirinto_vertices("l", "r", 1);
             labri.add_labirinto_vertices("r", "x", 1);
             labri.add_labirinto_adjacentes();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labri.tarefa = comboBox2.Items[comboBox2.SelectedIndex].ToString();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            labri.algortimo = comboBox3.Items[comboBox3.SelectedIndex].ToString();
            List<string> valores = labri.elementos(labri.tarefa, labri.algortimo);
            for(int i = 0; i < valores.Count; i++)
            {
                comboBox4.Items.Add(valores[i].ToString());
                comboBox5.Items.Add(valores[i].ToString());
            }
           
            
        }
    }
}
