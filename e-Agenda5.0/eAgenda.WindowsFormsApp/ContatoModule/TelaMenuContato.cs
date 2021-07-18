using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsFormsApp.ContatoModule
{
    public partial class TelaMenuContato : Form
    {
        public TelaMenuContato()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCadastrarContato telaSelecionada = new TelaCadastrarContato();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaEditarContato telaSelecionada = new TelaEditarContato();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }


        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaVisualizarContato telaSelecionada = new TelaVisualizarContato();
            telaSelecionada.Closed += (s, args) => this.Show();
            telaSelecionada.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaExcluirContato telaSelecionada = new TelaExcluirContato();
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
