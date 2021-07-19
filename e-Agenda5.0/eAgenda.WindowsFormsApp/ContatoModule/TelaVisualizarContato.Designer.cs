
namespace eAgenda.WindowsFormsApp.ContatoModule
{
    partial class TelaVisualizarContato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisualizarContato));
            this.dataGridViewContatos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetContato = new System.Data.DataSet();
            this.dtContatos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.labelVisualizarContatos = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.comboBoxCargos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualizarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewContatos
            // 
            this.dataGridViewContatos.AutoGenerateColumns = false;
            this.dataGridViewContatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(84)))), ((int)(((byte)(104)))));
            this.dataGridViewContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn});
            this.dataGridViewContatos.DataMember = "Contatos";
            this.dataGridViewContatos.DataSource = this.dataSetContato;
            this.dataGridViewContatos.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewContatos.Name = "dataGridViewContatos";
            this.dataGridViewContatos.ReadOnly = true;
            this.dataGridViewContatos.Size = new System.Drawing.Size(643, 123);
            this.dataGridViewContatos.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSetContato
            // 
            this.dataSetContato.DataSetName = "NewDataSet";
            this.dataSetContato.Tables.AddRange(new System.Data.DataTable[] {
            this.dtContatos});
            // 
            // dtContatos
            // 
            this.dtContatos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dtContatos.TableName = "Contatos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Id";
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Nome";
            this.dataColumn2.ColumnName = "Nome";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Email";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Telefone";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Empresa";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Cargo";
            // 
            // labelVisualizarContatos
            // 
            this.labelVisualizarContatos.AutoSize = true;
            this.labelVisualizarContatos.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisualizarContatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVisualizarContatos.Location = new System.Drawing.Point(211, 9);
            this.labelVisualizarContatos.Name = "labelVisualizarContatos";
            this.labelVisualizarContatos.Size = new System.Drawing.Size(240, 21);
            this.labelVisualizarContatos.TabIndex = 10;
            this.labelVisualizarContatos.Text = "Visualizando Todos Contatos";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Location = new System.Drawing.Point(580, 171);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // comboBoxCargos
            // 
            this.comboBoxCargos.FormattingEnabled = true;
            this.comboBoxCargos.Location = new System.Drawing.Point(54, 173);
            this.comboBoxCargos.Name = "comboBoxCargos";
            this.comboBoxCargos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCargos.TabIndex = 13;
            this.comboBoxCargos.SelectedIndexChanged += new System.EventHandler(this.comboBoxCargos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cargo";
            // 
            // btnVisualizarTodos
            // 
            this.btnVisualizarTodos.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarTodos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVisualizarTodos.Location = new System.Drawing.Point(300, 171);
            this.btnVisualizarTodos.Name = "btnVisualizarTodos";
            this.btnVisualizarTodos.Size = new System.Drawing.Size(91, 23);
            this.btnVisualizarTodos.TabIndex = 15;
            this.btnVisualizarTodos.TabStop = false;
            this.btnVisualizarTodos.Text = "Visualizar Todos";
            this.btnVisualizarTodos.UseVisualStyleBackColor = true;
            this.btnVisualizarTodos.Click += new System.EventHandler(this.btnVisualizarTodos_Click);
            // 
            // TelaVisualizarContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(666, 204);
            this.Controls.Add(this.btnVisualizarTodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCargos);
            this.Controls.Add(this.dataGridViewContatos);
            this.Controls.Add(this.labelVisualizarContatos);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaVisualizarContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaVisualizarContato";
            this.Load += new System.EventHandler(this.TelaVisualizarContato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewContatos;
        private System.Windows.Forms.Label labelVisualizarContatos;
        private System.Windows.Forms.Button btnVoltar;
        private System.Data.DataSet dataSetContato;
        private System.Data.DataTable dtContatos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.ComboBox comboBoxCargos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisualizarTodos;
    }
}