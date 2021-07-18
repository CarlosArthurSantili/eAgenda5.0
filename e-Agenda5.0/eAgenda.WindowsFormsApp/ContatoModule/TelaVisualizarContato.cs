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
        ControladorContato controladorContato = new ControladorContato();        public TelaVisualizarContato()
        
        {
            InitializeComponent();
        }

        private void btnTodosContatos_Click(object sender, EventArgs e)
        {
            labelVisualizarContatos.Text = "Visualizando Todos Contatos";
            PreencherDataGridTodosContatos();
        }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void TelaVisualizarContato_Load(object sender, EventArgs e)
        {
            PreencherDataGridTodosContatos();
        }
    }
}
