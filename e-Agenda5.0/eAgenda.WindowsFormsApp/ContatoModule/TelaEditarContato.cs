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
    public partial class TelaEditarContato : Form
    {
        ControladorContato controladorContato = new ControladorContato();
        public TelaEditarContato()
        {
            InitializeComponent();
        }

        #region Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idContatoSelecionado = Convert.ToInt32(comboBoxContatos.SelectedItem);
            if (comboBoxContatos.SelectedItem != null)
            {
                Contato contatoSelecionado = controladorContato.SelecionarPorId(idContatoSelecionado);
                ObterValoresContato(contatoSelecionado);

                string resultado = controladorContato.Editar(idContatoSelecionado, contatoSelecionado);
                if (resultado == "ESTA_VALIDO")
                {
                    labelResultado.ForeColor = Color.Green;
                    labelResultado.Text = "Contato editado com sucesso!";
                    LimparCampos();
                }
                else
                {
                    labelResultado.ForeColor = Color.Red;
                    labelResultado.Text = "Erro ao editar contato! Tente novamente";
                }
            }
            else
            {
                labelResultado.ForeColor = Color.Red;
                labelResultado.Text = "Erro ao editar contato! Selecione um contato válido.";
            }
        }

        private void TelaEditarContato_Load(object sender, EventArgs e)
        {
            ListarComboBoxContatos();
        }

        #endregion


        #region Métodos Privados
        private void ObterValoresContato(Contato contatoSelecionado)
        {
            contatoSelecionado.Nome = textBoxNome.Text;
            contatoSelecionado.Email = textBoxEmail.Text;
            contatoSelecionado.Telefone = maskedTextBoxTelefone.Text;
            contatoSelecionado.Empresa = textBoxEmpresa.Text;
            contatoSelecionado.Cargo = textBoxCargo.Text;
        }

        private void LimparCampos()
        {
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxEmpresa.Text = "";
            textBoxCargo.Text = "";
        }

        private void ListarComboBoxContatos()
        {
            comboBoxContatos.Items.Clear();
            List<Contato> contatos = controladorContato.SelecionarTodos();
            foreach (Contato contato in contatos)
            {
                comboBoxContatos.Items.Add(contato.Id);
            }
        }

        private void comboBoxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idContatoSelecionado = Convert.ToInt32(comboBoxContatos.SelectedItem);
            Contato contatoSelecionado = controladorContato.SelecionarPorId(idContatoSelecionado);
            MostrarValoresContato(contatoSelecionado);
            btnEditar.Enabled = true;
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
