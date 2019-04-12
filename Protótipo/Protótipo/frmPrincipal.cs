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
            int anty = 1;
            int ultimo = 0; int primeira = 0;
            string v = comboBox5.Items[comboBox5.SelectedIndex].ToString();
            string u = comboBox4.Items[comboBox4.SelectedIndex].ToString();
            List<string> procurar = labri.valores();
            for(int i = 0; i < procurar.Count; i++)
            {
                if (procurar[i] == v)
                {
                    ultimo = i;
                    anty = anty + 1;
                }
                if (procurar[i] == u)
                {
                    primeira = i;
                    anty = anty + 1;
                }
            }

          int valor =  labri.esquerta(anty);
            labri.direita(valor);
            
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
