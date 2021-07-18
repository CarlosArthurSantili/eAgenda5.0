
namespace eAgenda.WindowsFormsApp.TarefaModule
{
    partial class TelaVisualizarTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisualizarTarefa));
            this.btnTarefasConcluidas = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labelVisualizarTarefas = new System.Windows.Forms.Label();
            this.btnTarefasPendentes = new System.Windows.Forms.Button();
            this.dataGridViewTarefas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataConclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetTarefa = new System.Data.DataSet();
            this.dtTarefasPendentes = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dtTarefasConcluidas = new System.Data.DataTable();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dtTarefas = new System.Data.DataTable();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.btnTodasTarefas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefasPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefasConcluidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTarefasConcluidas
            // 
            this.btnTarefasConcluidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTarefasConcluidas.Location = new System.Drawing.Point(202, 213);
            this.btnTarefasConcluidas.Name = "btnTarefasConcluidas";
            this.btnTarefasConcluidas.Size = new System.Drawing.Size(126, 23);
            this.btnTarefasConcluidas.TabIndex = 1;
            this.btnTarefasConcluidas.TabStop = false;
            this.btnTarefasConcluidas.Text = "Tarefas Concluídas";
            this.btnTarefasConcluidas.UseVisualStyleBackColor = true;
            this.btnTarefasConcluidas.Click += new System.EventHandler(this.btnTarefasConcluidas_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(580, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labelVisualizarTarefas
            // 
            this.labelVisualizarTarefas.AutoSize = true;
            this.labelVisualizarTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisualizarTarefas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelVisualizarTarefas.Location = new System.Drawing.Point(274, 18);
            this.labelVisualizarTarefas.Name = "labelVisualizarTarefas";
            this.labelVisualizarTarefas.Size = new System.Drawing.Size(157, 24);
            this.labelVisualizarTarefas.TabIndex = 4;
            this.labelVisualizarTarefas.Text = "Visualizar Tarefas";
            // 
            // btnTarefasPendentes
            // 
            this.btnTarefasPendentes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTarefasPendentes.Location = new System.Drawing.Point(399, 213);
            this.btnTarefasPendentes.Name = "btnTarefasPendentes";
            this.btnTarefasPendentes.Size = new System.Drawing.Size(120, 23);
            this.btnTarefasPendentes.TabIndex = 5;
            this.btnTarefasPendentes.TabStop = false;
            this.btnTarefasPendentes.Text = "Tarefas Pendentes";
            this.btnTarefasPendentes.UseVisualStyleBackColor = true;
            this.btnTarefasPendentes.Click += new System.EventHandler(this.btnTarefasPendentes_Click);
            // 
            // dataGridViewTarefas
            // 
            this.dataGridViewTarefas.AutoGenerateColumns = false;
            this.dataGridViewTarefas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(84)))), ((int)(((byte)(104)))));
            this.dataGridViewTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarefas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.prioridadeDataGridViewTextBoxColumn,
            this.percentualDataGridViewTextBoxColumn,
            this.dataCriacaoDataGridViewTextBoxColumn,
            this.dataConclusaoDataGridViewTextBoxColumn});
            this.dataGridViewTarefas.DataMember = "TarefasConcluidas";
            this.dataGridViewTarefas.DataSource = this.dataSetTarefa;
            this.dataGridViewTarefas.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewTarefas.Name = "dataGridViewTarefas";
            this.dataGridViewTarefas.ReadOnly = true;
            this.dataGridViewTarefas.Size = new System.Drawing.Size(643, 141);
            this.dataGridViewTarefas.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prioridadeDataGridViewTextBoxColumn
            // 
            this.prioridadeDataGridViewTextBoxColumn.DataPropertyName = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.HeaderText = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.Name = "prioridadeDataGridViewTextBoxColumn";
            this.prioridadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percentualDataGridViewTextBoxColumn
            // 
            this.percentualDataGridViewTextBoxColumn.DataPropertyName = "Percentual";
            this.percentualDataGridViewTextBoxColumn.HeaderText = "Percentual";
            this.percentualDataGridViewTextBoxColumn.Name = "percentualDataGridViewTextBoxColumn";
            this.percentualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCriacaoDataGridViewTextBoxColumn
            // 
            this.dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.HeaderText = "DataCriacao";
            this.dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
            this.dataCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataConclusaoDataGridViewTextBoxColumn
            // 
            this.dataConclusaoDataGridViewTextBoxColumn.DataPropertyName = "DataConclusao";
            this.dataConclusaoDataGridViewTextBoxColumn.HeaderText = "DataConclusao";
            this.dataConclusaoDataGridViewTextBoxColumn.Name = "dataConclusaoDataGridViewTextBoxColumn";
            this.dataConclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSetTarefa
            // 
            this.dataSetTarefa.DataSetName = "NewDataSet";
            this.dataSetTarefa.Tables.AddRange(new System.Data.DataTable[] {
            this.dtTarefasPendentes,
            this.dtTarefasConcluidas,
            this.dtTarefas});
            // 
            // dtTarefasPendentes
            // 
            this.dtTarefasPendentes.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn9,
            this.dataColumn10});
            this.dtTarefasPendentes.TableName = "TarefasPendentes";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Título";
            this.dataColumn2.ColumnName = "Titulo";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Prioridade";
            this.dataColumn3.ColumnName = "Prioridade";
            // 
            // dataColumn9
            // 
            this.dataColumn9.Caption = "Percentual";
            this.dataColumn9.ColumnName = "Percentual";
            // 
            // dataColumn10
            // 
            this.dataColumn10.Caption = "Data de Criação";
            this.dataColumn10.ColumnName = "DataCriacao";
            // 
            // dtTarefasConcluidas
            // 
            this.dtTarefasConcluidas.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn11});
            this.dtTarefasConcluidas.TableName = "TarefasConcluidas";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Id";
            this.dataColumn4.ColumnName = "Id";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Título";
            this.dataColumn5.ColumnName = "Titulo";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Prioridade";
            this.dataColumn6.ColumnName = "Prioridade";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Percentual";
            this.dataColumn7.ColumnName = "Percentual";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "Data de Criação";
            this.dataColumn8.ColumnName = "DataCriacao";
            // 
            // dataColumn11
            // 
            this.dataColumn11.Caption = "Data de Conclusão";
            this.dataColumn11.ColumnName = "DataConclusao";
            // 
            // dtTarefas
            // 
            this.dtTarefas.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17});
            this.dtTarefas.TableName = "Tarefas";
            // 
            // dataColumn12
            // 
            this.dataColumn12.Caption = "ID";
            this.dataColumn12.ColumnName = "Id";
            // 
            // dataColumn13
            // 
            this.dataColumn13.Caption = "Título";
            this.dataColumn13.ColumnName = "Titulo";
            // 
            // dataColumn14
            // 
            this.dataColumn14.Caption = "Prioridade";
            this.dataColumn14.ColumnName = "Prioridade";
            // 
            // dataColumn15
            // 
            this.dataColumn15.Caption = "Percentual";
            this.dataColumn15.ColumnName = "Percentual";
            // 
            // dataColumn16
            // 
            this.dataColumn16.Caption = "Data de Criação";
            this.dataColumn16.ColumnName = "DataCriacao";
            // 
            // dataColumn17
            // 
            this.dataColumn17.Caption = "Data de Conclusão";
            this.dataColumn17.ColumnName = "DataConclusao";
            // 
            // btnTodasTarefas
            // 
            this.btnTodasTarefas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTodasTarefas.Location = new System.Drawing.Point(12, 213);
            this.btnTodasTarefas.Name = "btnTodasTarefas";
            this.btnTodasTarefas.Size = new System.Drawing.Size(126, 23);
            this.btnTodasTarefas.TabIndex = 7;
            this.btnTodasTarefas.TabStop = false;
            this.btnTodasTarefas.Text = "Todas as Tarefas";
            this.btnTodasTarefas.UseVisualStyleBackColor = true;
            this.btnTodasTarefas.Click += new System.EventHandler(this.btnTodasTarefas_Click);
            // 
            // TelaVisualizarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(669, 248);
            this.Controls.Add(this.btnTodasTarefas);
            this.Controls.Add(this.dataGridViewTarefas);
            this.Controls.Add(this.btnTarefasPendentes);
            this.Controls.Add(this.labelVisualizarTarefas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnTarefasConcluidas);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaVisualizarTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaVisualizarTarefa";
            this.Load += new System.EventHandler(this.TelaVisualizarTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefasPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefasConcluidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTarefasConcluidas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelVisualizarTarefas;
        private System.Windows.Forms.Button btnTarefasPendentes;
        private System.Windows.Forms.DataGridView dataGridViewTarefas;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataTable dtTarefasConcluidas;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataTable dtTarefasPendentes;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataSet dataSetTarefa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataConclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTodasTarefas;
        private System.Data.DataTable dtTarefas;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
    }
}