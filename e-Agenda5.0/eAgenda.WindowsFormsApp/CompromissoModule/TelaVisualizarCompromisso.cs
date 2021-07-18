using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
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
    public partial class TelaVisualizarCompromisso : Form
    {
        ControladorCompromisso controladorCompromisso = new ControladorCompromisso();

        public TelaVisualizarCompromisso()
        {
            InitializeComponent();
        }

        private void TelaVisualizarCompromisso_Load(object sender, EventArgs e)
        {
            PreencherDataGridTodosCompromissos();
        }

        private void PreencherDataGridTodosCompromissos()
        {
            dtCompromissos.Clear();
            List<Compromisso> Compromissos = controladorCompromisso.SelecionarTodos();
            PreencherDataGridCompromissos(Compromissos);
        }

        private void PreencherDataGridCompromissosFuturos()
        {
            dtCompromissos.Clear();
            List<Compromisso> Compromissos = controladorCompromisso.SelecionarCompromissosFuturos(DateTime.Now, DateTime.MaxValue);
            PreencherDataGridCompromissos(Compromissos);
        }

        private void PreencherDataGridCompromissosPassados()
        {
            dtCompromissos.Clear();
            List<Compromisso> Compromissos = controladorCompromisso.SelecionarCompromissosPassados(DateTime.Now);
            PreencherDataGridCompromissos(Compromissos);
        }

        private void PreencherDataGridCompromissos(List<Compromisso> Compromissos)
        {
            foreach (Compromisso compromisso in Compromissos)
            {
                DataRow registro = dtCompromissos.NewRow();

                registro["Id"] = compromisso.Id;
                registro["Assunto"] = compromisso.Assunto;
                registro["Local"] = compromisso.Local;
                registro["Link"] = compromisso.Link;
                registro["Data"] = compromisso.Data;
                registro["HoraInicio"] = compromisso.HoraInicio;
                registro["HoraFim"] = compromisso.HoraTermino;
                if (compromisso.Contato != null)
                    registro["Contato"] = compromisso.Contato.Id;

                dtCompromissos.Rows.Add(registro);
                dataGridViewCompromissos.DataMember = "Compromissos";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnTodosCompromissos_Click(object sender, EventArgs e)
        {
            PreencherDataGridTodosCompromissos();
        }

        private void btnCompromissosPassados_Click(object sender, EventArgs e)
        {
            PreencherDataGridCompromissosPassados();
        }

        private void btnCompromissosFuturos_Click(object sender, EventArgs e)
        {
            PreencherDataGridCompromissosFuturos();
        }
    }
}
