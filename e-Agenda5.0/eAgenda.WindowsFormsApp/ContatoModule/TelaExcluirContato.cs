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
    public partial class TelaExcluirContato : Form
    {
        ControladorContato controladorContato = new ControladorContato();
        public TelaExcluirContato()
        {
            InitializeComponent();
        }

        #region Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            if (comboBoxContatos.SelectedItem != null)
            {
                int idContatoSelecionada = Convert.ToInt32(comboBoxContatos.SelectedItem);

                bool resultado = controladorContato.Excluir(idContatoSelecionada);
                if (resultado == true)
                {
                    labelResultado.ForeColor = Color.Green;
                    labelResultado.Text = "Contato excluído com sucesso!";
                    ListarComboBoxContatos();
                    LimparCampos();
                }
                else
                {
                    labelResultado.ForeColor = Color.Red;
                    labelResultado.Text = "Erro ao excluir contato! Tente novamente";
                }
            }
            else
            {
                labelResultado.ForeColor = Color.Red;
                labelResultado.Text = "Erro ao excluir contato! Selecione um contato válido";
            }
            
            btnExcluir.Enabled = true;
        }

        private void TelaExcluirContato_Load(object sender, EventArgs e)
        {
            ListarComboBoxContatos();
        }

        private void comboBoxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idContatoSelecionado = Convert.ToInt32(comboBoxContatos.SelectedItem);
            Contato contatoSelecionado = controladorContato.SelecionarPorId(idContatoSelecionado);
            MostrarValoresContato(contatoSelecionado);
            btnExcluir.Enabled = true;
        }

        #endregion

        #region Métodos Privados
        private void ListarComboBoxContatos()
        {
            comboBoxContatos.Items.Clear();
            List<Contato> contatos = controladorContato.SelecionarTodos();
            foreach (Contato contato in contatos)
            {
                comboBoxContatos.Items.Add(contato.Id);
            }
        }

        private void LimparCampos()
        {
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxEmpresa.Text = "";
            textBoxCargo.Text = "";
            comboBoxContatos.SelectedIndex = 0;
        }

        private void MostrarValoresContato(Contato contatoSelecionado)
        {
            textBoxNome.Text = contatoSelecionado.Nome;
            textBoxEmail.Text = contatoSelecionado.Email;
            maskedTextBoxTelefone.Text = contatoSelecionado.Telefone;
            textBoxEmpresa.Text = contatoSelecionado.Empresa;
            textBoxCargo.Text = contatoSelecionado.Cargo;
        }
        #endregion
    }
}
