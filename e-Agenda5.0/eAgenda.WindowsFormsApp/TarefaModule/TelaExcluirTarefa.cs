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
    public partial class TelaExcluirTarefa : Form
    {
        ControladorTarefa controladorTarefa = new ControladorTarefa();
        public TelaExcluirTarefa()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void comboBoxTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxTarefas.SelectedIndex!=-1)
            { 
                int idTarefaSelecionada = Convert.ToInt32(comboBoxTarefas.SelectedItem);
                Tarefa tarefaSelecionada = controladorTarefa.SelecionarPorId(idTarefaSelecionada);

                textBoxTitulo.Text = tarefaSelecionada.Titulo;
                switch (tarefaSelecionada.Prioridade.ToString())
                {
                    case "Prioridade Baixa": comboBoxPrioridade.SelectedIndex = 0; break;
                    case "Prioridade Normal": comboBoxPrioridade.SelectedIndex = 1; break;
                    case "Prioridade Alta": comboBoxPrioridade.SelectedIndex = 2; break;
                }
                numericUpDownPercentual.Value = tarefaSelecionada.Percentual;
                maskedTextBoxDataCriacao.Text = tarefaSelecionada.DataCriacao.ToString();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            int idTarefaSelecionada = Convert.ToInt32(comboBoxTarefas.SelectedItem);

            bool resultado = controladorTarefa.Excluir(idTarefaSelecionada);
            if (resultado == true)
            {
                labelResultado.ForeColor = Color.Green;
                labelResultado.Text = "Tarefa excluida com sucesso!";
            }
            else
            {
                labelResultado.ForeColor = Color.Red;
                labelResultado.Text = "Erro ao excluir tarefa! Tente novamente";
            }

            
            ListarTarefasComboBox();
            LimparCampos();
            btnExcluir.Enabled = true;
        }

        private void LimparCampos()
        {
            textBoxTitulo.Text = "";
            comboBoxPrioridade.SelectedIndex = -1;
            numericUpDownPercentual.Value = 0;
            maskedTextBoxDataCriacao.Text = "";
            comboBoxTarefas.SelectedIndex = 0;
        }

        private void TelaExcluirTarefa_Load(object sender, EventArgs e)
        {
            ListarTarefasComboBox();
        }

        private void ListarTarefasComboBox()
        {
            comboBoxTarefas.Items.Clear();
            List<Tarefa> tarefas = controladorTarefa.SelecionarTodos();
            foreach (Tarefa tarefa in tarefas)
            {
                comboBoxTarefas.Items.Add(tarefa.Id);
            }
        }
    }
}
