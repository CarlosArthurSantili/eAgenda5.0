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
    public partial class TelaEditarCompromisso : Form
    {
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        ControladorContato controladorContato = new ControladorContato();
        public TelaEditarCompromisso()
        {
            InitializeComponent();
        }

        #region Eventos

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idCompromissoSelecionado = Convert.ToInt32(comboBoxCompromissos.SelectedItem);
            if (comboBoxCompromissos.SelectedItem != null)
            {
                Compromisso compromissoSelecionado = controladorCompromisso.SelecionarPorId(idCompromissoSelecionado);
                ObterValoresCompromisso(compromissoSelecionado);

                string resultado = controladorCompromisso.Editar(idCompromissoSelecionado, compromissoSelecionado);
                if (resultado == "ESTA_VALIDO")
                {
                    labelResultado.ForeColor = Color.Green;
                    labelResultado.Text = "Compromisso editado com sucesso!";
                    LimparCampos();
                }
                else
                {
                    labelResultado.ForeColor = Color.Red;
                    labelResultado.Text = resultado;
                }
            }
            else
            {
                labelResultado.ForeColor = Color.Red;
                labelResultado.Text = "Erro ao editar compromisso! Selecione um compromisso válido.";
            }
        }

        private void TelaEditarCompromisso_Load(object sender, EventArgs e)
        {
            ListarComboBoxCompromissos();

            ListarComboBoxContatos();

            rbLocal.Checked = true;
        }

        private void comboBoxCompromissos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCompromissoSelecionada = Convert.ToInt32(comboBoxCompromissos.SelectedItem);
            Compromisso compromissoSelecionado = controladorCompromisso.SelecionarPorId(idCompromissoSelecionada);
            MostrarValoresCompromisso(compromissoSelecionado);
            btnEditar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void rbLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLocal.Checked)
            {
                textBoxLocal.Text = "";
                textBoxLocal.Enabled = true;

                textBoxLink.Text = "Presencial";
                textBoxLink.Enabled = false;
            }
        }

        private void rbLink_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLink.Checked)
            {
                textBoxLocal.Text = "Remoto";
                textBoxLocal.Enabled = false;

                textBoxLink.Text = "";
                textBoxLink.Enabled = true;
            }
        }

        private void cbContato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContato.Checked)
            {
                comboBoxContatos.SelectedIndex = 0;
                comboBoxContatos.Enabled = true;
            }
            else
            {
                comboBoxContatos.SelectedItem = null;
                comboBoxContatos.Enabled = false;
            }
                
        }

        private void comboBoxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxContatos.SelectedItem != null)
                checkBoxContato.Checked = true;
            else
                checkBoxContato.Checked = false;
        }

        #endregion

        #region Métodos Privados

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

        private void ObterValoresCompromisso(Compromisso compromissoSelecionado)
        {
            compromissoSelecionado.Assunto = textBoxAssunto.Text;
            compromissoSelecionado.Local = textBoxLocal.Text;
            compromissoSelecionado.Link = textBoxLink.Text;
            compromissoSelecionado.Data = Convert.ToDateTime(maskedTextBoxData.Text);

            string[] strHoraInicio = maskedTextBoxHoraInicio.Text.Split(':');
            compromissoSelecionado.HoraInicio = new TimeSpan(int.Parse(strHoraInicio[0]), int.Parse(strHoraInicio[1]), 0);

            string[] strHoraFim = maskedTextBoxHoraFim.Text.Split(':');
            compromissoSelecionado.HoraTermino = new TimeSpan(int.Parse(strHoraFim[0]), int.Parse(strHoraFim[1]), 0);

            compromissoSelecionado.Contato = null;
            if (comboBoxContatos.SelectedItem != null)
            {
                int idContato = Convert.ToInt32(comboBoxContatos.SelectedItem);
                compromissoSelecionado.Contato = controladorContato.SelecionarPorId(idContato);
            }
        }

        private void LimparCampos()
        {
            comboBoxCompromissos.SelectedIndex = 0;
            textBoxAssunto.Text = "";
            rbLink.Checked = false;
            rbLocal.Checked = false;
            textBoxLocal.Text = "";
            textBoxLink.Text = "";
            maskedTextBoxData.Text = "";
            maskedTextBoxHoraInicio.Text = "";
            maskedTextBoxHoraFim.Text = "";
            comboBoxContatos.SelectedIndex = 0;
        }

        private void ListarComboBoxCompromissos()
        {
            List<Compromisso> compromissos = controladorCompromisso.SelecionarTodos();
            foreach (Compromisso compromisso in compromissos)
            {
                comboBoxCompromissos.Items.Add(compromisso.Id);
            }
        }

        private void ListarComboBoxContatos()
        {
            List<Contato> contatos = controladorContato.SelecionarTodos();
            foreach (Contato contato in contatos)
            {
                comboBoxContatos.Items.Add(contato.Id);
            }
        }
        #endregion
    }
}
