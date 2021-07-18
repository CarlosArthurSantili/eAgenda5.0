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
    public partial class TelaEditarTarefa : Form
    {
        ControladorTarefa controladorTarefa = new ControladorTarefa();
        public TelaEditarTarefa()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void TelaEditarTarefa_Load(object sender, EventArgs e)
        {
            List<Tarefa> tarefas = controladorTarefa.SelecionarTodos();
            foreach (Tarefa tarefa in tarefas)
            {
                comboBoxTarefas.Items.Add(tarefa.Id);
            }
        }

        private void comboBoxTarefas_SelectedIndexChanged(object sender, EventArgs e)
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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idTarefaSelecionada = Convert.ToInt32(comboBoxTarefas.SelectedItem);
            Tarefa tarefaSelecionada = controladorTarefa.SelecionarPorId(idTarefaSelecionada);


            tarefaSelecionada.Titulo = textBoxTitulo.Text;
            int prioridade = Convert.ToInt32(comboBoxPrioridade.SelectedIndex);
            tarefaSelecionada.Prioridade = new Prioridade((PrioridadeEnum)prioridade);
            tarefaSelecionada.Percentual = Convert.ToInt32(numericUpDownPercentual.Value);
            

            string resultado = controladorTarefa.Editar(idTarefaSelecionada, tarefaSelecionada);
            if (resultado == "ESTA_VALIDO")
            {
                labelResultado.ForeColor = Color.Green;
                labelResultado.Text = "Tarefa editada com sucesso!";
            }
            else
            {
                labelResultado.ForeColor = Color.Red;
                labelResultado.Text = "Erro ao editar tarefa! Tente novamente";
            }
        }
    }
}
