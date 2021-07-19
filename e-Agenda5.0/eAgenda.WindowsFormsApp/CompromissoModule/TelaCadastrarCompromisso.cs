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
    public partial class TelaCadastrarCompromisso : Form
    {
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        ControladorContato controladorContato = new ControladorContato();
        public TelaCadastrarCompromisso()
        {
            InitializeComponent();
        }

        #region Eventos
        #region Click
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string assunto = textBoxAssunto.Text;
                string local = textBoxLocal.Text;
                string link = textBoxLink.Text;

                DateTime data = Convert.ToDateTime(maskedTextBoxData.Text);

                string[] strHoraInicio = maskedTextBoxHoraInicio.Text.Split(':');
                TimeSpan horaInicio = new TimeSpan(int.Parse(strHoraInicio[0]), int.Parse(strHoraInicio[1]), 0);

                string[] strHoraFim = maskedTextBoxHoraFim.Text.Split(':');
                TimeSpan horaFim = new TimeSpan(int.Parse(strHoraFim[0]), int.Parse(strHoraFim[1]), 0);

                Contato contatoCompromisso = null;
                if (comboBoxContatos.SelectedItem != null)
                {
                    int idContato = Convert.ToInt32(comboBoxContatos.SelectedItem);
                    contatoCompromisso = controladorContato.SelecionarPorId(idContato);
                }

                Compromisso novoCompromisso = new Compromisso(assunto, local, link, data, horaInicio, horaFim, contatoCompromisso);

                string resultado = controladorCompromisso.InserirNovo(novoCompromisso);
                if (resultado == "ESTA_VALIDO")
                {
                    labelResultado.ForeColor = Color.Green;
                    labelResultado.Text = "Compromisso cadastrado com sucesso!";
                    LimparCampos();
                }
                else
                {
                    labelResultado.ForeColor = Color.Red;
                    labelResultado.Text = resultado;
                }
            }
            catch (Exception invalidArguments)
            {
                labelResultado.ForeColor = Color.Red;
                labelResultado.Text = "Erro ao cadastrar compromisso! Valores inválidos.";
            }
        }
        #endregion

        #region Changed
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

        private void checkBoxContato_CheckedChanged(object sender, EventArgs e)
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

        #endregion

        #region Load
        private void TelaCadastrarCompromisso_Load(object sender, EventArgs e)
        {
            List<Contato> contatos = controladorContato.SelecionarTodos();
            foreach (Contato contato in contatos)
            {
                comboBoxContatos.Items.Add(contato.Id);
            }
            rbLocal.Checked = true;
        }
        #endregion

        #endregion

        #region Métodos Privados
        private void LimparCampos()
        {
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
        #endregion
    }
}
