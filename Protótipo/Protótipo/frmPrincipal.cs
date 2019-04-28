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
            posicao_do_labrindo();
            fazer_labrindo();
            string v = comboBox5.Items[comboBox5.SelectedIndex].ToString();
            string u = comboBox4.Items[comboBox4.SelectedIndex].ToString();
            labri.procurar_caminho(v, u);
            textBox3.Text = labri.distancia.ToString();

        }
        private void posicao_do_labrindo()
        {
            List<string> lista = labri.valores();
            for (int i = 0;i<lista.Count;i++)
            {
                labri.grafo(lista[i],i);
            }

        }
        public void fazer_labrindo()
        {
            // horizontais
            labri.add_labirinto("a", "b", 1);
            labri.add_labirinto("c", "d", 1);
            labri.add_labirinto("d", "e", 1);
            labri.add_labirinto("e", "f", 1);
            labri.add_labirinto("h", "i", 1);
            labri.add_labirinto("j", "k", 1);
            labri.add_labirinto("o", "p", 1);
            labri.add_labirinto("s", "t", 1);
            labri.add_labirinto("t", "u", 1);
            labri.add_labirinto("w", "x", 1);
            // verticais
             labri.add_labirinto("a", "g", 1);
             labri.add_labirinto("g", "m", 1);
             labri.add_labirinto("m", "s", 1);
             labri.add_labirinto("m", "s", 1);
             labri.add_labirinto("m", "s", 1);
             labri.add_labirinto("m", "s", 1);
             labri.add_labirinto("c", "i", 1);
             labri.add_labirinto("i", "o", 1);
             labri.add_labirinto("o", "u", 1);
             labri.add_labirinto("d", "j", 1);
             labri.add_labirinto("j", "p", 1);
             labri.add_labirinto("p", "v", 1);
             labri.add_labirinto("e", "k", 1);
             labri.add_labirinto("k", "q", 1);
             labri.add_labirinto("q", "w", 1);
             labri.add_labirinto("f", "l", 1);
             labri.add_labirinto("l", "r", 1);
             labri.add_labirinto("r", "x", 1);
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
