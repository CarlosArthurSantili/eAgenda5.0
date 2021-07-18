using eAgenda.WindowsFormsApp.CompromissoModule;
using eAgenda.WindowsFormsApp.ContatoModule;
using eAgenda.WindowsFormsApp.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsFormsApp
{
    public partial class TelaMenuPrincipal : Form
    {
        public TelaMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaMenuTarefa telaSelecionada = new TelaMenuTarefa();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaMenuContato telaSelecionada = new TelaMenuContato();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaMenuCompromisso telaSelecionada = new TelaMenuCompromisso();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void TelaMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
