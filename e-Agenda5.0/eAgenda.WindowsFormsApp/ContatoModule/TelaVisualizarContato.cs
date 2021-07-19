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
    public partial class TelaVisualizarContato : Form
    {
        ControladorContato controladorContato = new ControladorContato();        
        public TelaVisualizarContato()
        
        {
            InitializeComponent();
        }

        #region Eventos
        private void btnTodosContatos_Click(object sender, EventArgs e)
        {
            labelVisualizarContatos.Text = "Visualizando Todos Contatos";
            PreencherDataGridTodosContatos();
        }

        private void TelaVisualizarContato_Load(object sender, EventArgs e)
        {
            PreencherDataGridTodosContatos();
            PreencherComboBoxCargos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void comboBoxCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherDataGridContatosPorCargo();
        }

        private void btnVisualizarTodos_Click(object sender, EventArgs e)
        {
            PreencherDataGridTodosContatos();
        }
        #endregion

        #region Métodos Privados
        private void PreencherDataGridTodosContatos()
        {
            dtContatos.Clear();
            List<Contato> Contatos = controladorContato.SelecionarTodos();

            foreach (Contato contato in Contatos)
            {
                DataRow registro = dtContatos.NewRow();

                registro["Id"] = contato.Id;
                registro["Nome"] = contato.Nome;
                registro["Email"] = contato.Email;
                registro["Telefone"] = contato.Telefone;
                registro["Empresa"] = contato.Empresa;
                registro["Cargo"] = contato.Cargo;

                dtContatos.Rows.Add(registro);
                dataGridViewContatos.DataMember = "Contatos";
            }
        }

        private void PreencherComboBoxCargos()
        {
            comboBoxCargos.Items.Clear();
            List<Contato> Contatos = controladorContato.SelecionarTodos();

            foreach (Contato contato in Contatos)
            {
                if (!comboBoxCargos.Items.Contains(contato.Cargo))
                    comboBoxCargos.Items.Add(contato.Cargo);
            }
        }

        private void PreencherDataGridContatosPorCargo()
        {
            dtContatos.Clear();
            List<Contato> Contatos = controladorContato.SelecionarTodos();

            foreach (Contato contato in Contatos)
            {
                if (contato.Cargo.Equals(comboBoxCargos.SelectedItem.ToString()))
                {
                    DataRow registro = dtContatos.NewRow();

                    registro["Id"] = contato.Id;
                    registro["Nome"] = contato.Nome;
                    registro["Email"] = contato.Email;
                    registro["Telefone"] = contato.Telefone;
                    registro["Empresa"] = contato.Empresa;
                    registro["Cargo"] = contato.Cargo;

                    dtContatos.Rows.Add(registro);
                }
            }
            dataGridViewContatos.DataMember = "Contatos";
        }
        #endregion
    }
}
