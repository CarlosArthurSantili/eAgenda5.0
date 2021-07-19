using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsFormsApp.TarefaModule
{
    public partial class TelaVisualizarTarefa : Form
    {
        public ControladorTarefa controladorTarefa = new ControladorTarefa();

        public TelaVisualizarTarefa()
        {
            InitializeComponent();
            
        }

        #region Eventos
        private void TelaVisualizarTarefa_Load(object sender, EventArgs e)
        {
            labelVisualizarTarefas.Text = "Visualizando Todas Tarefas";
            PreencherDataGridTodasTarefas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnTarefasConcluidas_Click(object sender, EventArgs e)
        {
            labelVisualizarTarefas.Text = "Visualizando Tarefas Concluídas";
            PreencherDataGridTarefasConcluidas();
        }

        private void btnTarefasPendentes_Click(object sender, EventArgs e)
        {
            labelVisualizarTarefas.Text = "Visualizando Tarefas Pendentes";
            PreencherDataGridTarefasPendentes();
        }

        private void btnTodasTarefas_Click(object sender, EventArgs e)
        {
            labelVisualizarTarefas.Text = "Visualizando Todas Tarefas";
            PreencherDataGridTodasTarefas();
        }
        #endregion

        #region Métodos Privados
        private void PreencherDataGridTarefasConcluidas()
        {
            dtTarefasConcluidas.Clear();
            List<Tarefa> tarefasConcluidas = controladorTarefa.SelecionarTodasTarefasConcluidas();

            foreach (Tarefa tarefa in tarefasConcluidas)
            {
                DataRow registro = dtTarefasConcluidas.NewRow();

                registro["Id"] = tarefa.Id;
                registro["Titulo"] = tarefa.Titulo;
                registro["Prioridade"] = tarefa.Prioridade;
                registro["Percentual"] = tarefa.Percentual;
                registro["DataCriacao"] = tarefa.DataCriacao;
                registro["DataConclusao"] = tarefa.DataConclusao;

                dtTarefasConcluidas.Rows.Add(registro);
                dataGridViewTarefas.DataMember = "TarefasConcluidas";
            }
        }

        private void PreencherDataGridTarefasPendentes()
        {
            dtTarefasPendentes.Clear();
            List<Tarefa> tarefasPendentes = controladorTarefa.SelecionarTodasTarefasPendentes();

            foreach (Tarefa tarefa in tarefasPendentes)
            {
                DataRow registro = dtTarefasPendentes.NewRow();

                registro["Id"] = tarefa.Id;
                registro["Titulo"] = tarefa.Titulo;
                registro["Prioridade"] = tarefa.Prioridade;
                registro["Percentual"] = tarefa.Percentual;
                registro["DataCriacao"] = tarefa.DataCriacao;

                dtTarefasPendentes.Rows.Add(registro);
                dataGridViewTarefas.DataMember = "TarefasPendentes";
            }
        }

        private void PreencherDataGridTodasTarefas()
        {
            dtTarefas.Clear();
            List<Tarefa> Tarefas = controladorTarefa.SelecionarTodos();

            foreach (Tarefa tarefa in Tarefas)
            {
                DataRow registro = dtTarefas.NewRow();

                registro["Id"] = tarefa.Id;
                registro["Titulo"] = tarefa.Titulo;
                registro["Prioridade"] = tarefa.Prioridade;
                registro["Percentual"] = tarefa.Percentual;
                registro["DataCriacao"] = tarefa.DataCriacao;
                registro["DataConclusao"] = tarefa.DataConclusao;

                dtTarefas.Rows.Add(registro);
                dataGridViewTarefas.DataMember = "Tarefas";
            }
        }
        #endregion
    }
}
