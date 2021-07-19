using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
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
    public partial class TelaCadastrarContato : Form
    {
        ControladorContato controladorContato = new ControladorContato();
        public TelaCadastrarContato()
        {
            InitializeComponent();
        }

        #region Eventos

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string telefone = maskedTextBoxTelefone.Text;
            string empresa = textBoxEmpresa.Text;
            string cargo = textBoxCargo.Text;

            Contato novoContato = new Contato(nome, email, telefone, empresa, cargo);

            string resultado = controladorContato.InserirNovo(novoContato);
            if (resultado == "ESTA_VALIDO")
            {
                labelResultado.ForeColor = Color.Green;
                labelResultado.Text = "Contato cadastrado com sucesso!";
                LimparCampos();
            }
            else
            {
                labelResultado.ForeColor = Color.Red;
                labelResultado.Text = "Erro ao cadastrar contato! Tente novamente";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion

        #region Métodos Privados
        private void LimparCampos()
        {
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxEmpresa.Text = "";
            textBoxCargo.Text = "";
        }
        #endregion
    }
}
