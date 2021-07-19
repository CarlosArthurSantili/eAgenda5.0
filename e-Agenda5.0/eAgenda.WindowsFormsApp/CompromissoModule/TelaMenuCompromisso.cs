using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsFormsApp.CompromissoModule
{
    public partial class TelaMenuCompromisso : Form
    {
        public TelaMenuCompromisso()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Eventos
        /// </summary>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadastrarCompromisso telaSelecionada = new TelaCadastrarCompromisso();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaEditarCompromisso telaSelecionada = new TelaEditarCompromisso();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisualizarCompromisso telaSelecionada = new TelaVisualizarCompromisso();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaExcluirCompromisso telaSelecionada = new TelaExcluirCompromisso();
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
