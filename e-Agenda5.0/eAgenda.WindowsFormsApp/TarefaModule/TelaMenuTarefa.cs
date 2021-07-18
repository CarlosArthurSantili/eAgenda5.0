using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsFormsApp.TarefaModule
{
    public partial class TelaMenuTarefa : Form
    {
        public TelaMenuTarefa()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadastrarTarefa telaSelecionada = new TelaCadastrarTarefa();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaEditarTarefa telaSelecionada = new TelaEditarTarefa();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }


        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisualizarTarefa telaSelecionada = new TelaVisualizarTarefa();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaExcluirTarefa telaSelecionada = new TelaExcluirTarefa();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
