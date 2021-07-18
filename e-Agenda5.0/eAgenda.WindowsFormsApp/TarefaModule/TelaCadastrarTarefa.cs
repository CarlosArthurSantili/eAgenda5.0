using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
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
    public partial class TelaCadastrarTarefa : Form
    {
        private readonly ControladorTarefa controladorTarefa = new ControladorTarefa();
        
        public TelaCadastrarTarefa()
        {
            InitializeComponent();
        }

        private void TelaCadastrarTarefa_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaMenuTarefa.ActiveForm.Visible = true;
            TelaMenuTarefa.ActiveForm.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string titulo = textBoxTitulo.Text;
            int prioridade = Convert.ToInt32(comboBoxPrioridade.SelectedIndex);
            Tarefa novaTarefa = new Tarefa(titulo, DateTime.Now, (PrioridadeEnum)prioridade);

            string resultado = controladorTarefa.InserirNovo(novaTarefa);
            if (resultado == "ESTA_VALIDO")
            {
                labelResultado.ForeColor = Color.Green;
                labelResultado.Text = "Tarefa cadastrada com sucesso!";
            }
            else
            {
                labelResultado.ForeColor = Color.Red;
                labelResultado.Text = "Erro ao cadastrar tarefa! Tente novamente";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void TelaCadastrarTarefa_Load(object sender, EventArgs e)
        {
            comboBoxPrioridade.SelectedIndex = 0;
        }
    }
}
