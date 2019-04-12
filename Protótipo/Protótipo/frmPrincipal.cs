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
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void elementos()
        {
            try
            {
                ComboBox tarefa = (ComboBox)comboBox2.Items[comboBox2.SelectedIndex];
                ComboBox algoritmo = (ComboBox)comboBox3.Items[comboBox3.SelectedIndex];
                if (String.Empty != tarefa.ToString() && String.Empty != algoritmo.ToString())
                {
                    if (tarefa.ToString() == "Labirinto" && algoritmo.ToString() == "Dijkstra")
                    {
                        comboBox4.Items.Add(labri.valores());
                        comboBox5.Items.Add(labri.valores());
                    }
                }
            }catch(Exception e)
            {

            }
           
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labri.tarefa = sender.ToString();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
