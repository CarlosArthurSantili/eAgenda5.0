using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
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

namespace eAgenda.WindowsFormsApp.CompromissoModule
{
    public partial class TelaExcluirCompromisso : Form
    {
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        ControladorContato controladorContato = new ControladorContato();
        public TelaExcluirCompromisso()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void comboBoxCompromisso_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCompromissoSelecionada = Convert.ToInt32(comboBoxCompromissos.SelectedItem);
            Compromisso compromissoSelecionado = controladorCompromisso.SelecionarPorId(idCompromissoSelecionada);
            MostrarValoresCompromisso(compromissoSelecionado);
        }

        private void MostrarValoresCompromisso(Compromisso compromissoSelecionado)
        {
            if (compromissoSelecionado.Local == "Remoto")
            {
                rbLocal.Checked = false;
                rbLink.Checked = true;
            }
            else
            {
                rbLocal.Checked = true;
                rbLink.Checked = false;
            }

            textBoxAssunto.Text = compromissoSelecionado.Assunto;
            textBoxLocal.Text = compromissoSelecionado.Local;
            textBoxLink.Text = compromissoSelecionado.Link;
            maskedTextBoxData.Text = compromissoSelecionado.Data.ToShortDateString();
            maskedTextBoxHoraInicio.Text = compromissoSelecionado.HoraInicio.ToString();
            maskedTextBoxHoraFim.Text = compromissoSelecionado.HoraTermino.ToString();
            if (compromissoSelecionado.Contato != null)
                comboBoxContatos.SelectedItem = compromissoSelecionado.Contato.Id;
            else
                comboBoxContatos.SelectedItem = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idCompromissoSelecionado = Convert.ToInt32(comboBoxCompromissos.SelectedItem);
            if (comboBoxCompromissos.SelectedItem != null)
            {
                bool conseguiuExcluir = controladorCompromisso.Excluir(idCompromissoSelecionado);
                if (conseguiuExcluir)
                {
                    labelResultado.ForeColor = Color.Green;
                    labelResultado.Text = "Compromisso excluido com sucesso!";
                    LimparCampos();
                    ListarComboBoxCompromissos();
                }
                else
                {
                    labelResultado.ForeColor = Color.Red;
                    labelResultado.Text = "Falha ao excluir o compromisso!";
                }
            }
            else
            {
                labelResultado.ForeColor = Color.Red;
                labelResultado.Text = "Erro ao editar compromisso! Selecione um compromisso válido.";
            }
        }

        private void TelaExcluirCompromisso_Load(object sender, EventArgs e)
        {
            ListarComboBoxCompromissos();
            ListarComboBoxContatos();
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

        private void ListarComboBoxCompromissos()
        {
            comboBoxCompromissos.Items.Clear();
            List<Compromisso> compromissos = controladorCompromisso.SelecionarTodos();
            foreach (Compromisso compromisso in compromissos)
            {
                comboBoxCompromissos.Items.Add(compromisso.Id);
            }
        }

        private void LimparCampos()
        {
            comboBoxCompromissos.SelectedIndex = 0;
            rbLink.Checked = false;
            rbLocal.Checked = false;
            textBoxLocal.Text = "";
            textBoxLink.Text = "";
            maskedTextBoxData.Text = "";
            maskedTextBoxHoraInicio.Text = "";
            maskedTextBoxHoraFim.Text = "";
            comboBoxContatos.SelectedIndex = 0;
        }
    }
}
