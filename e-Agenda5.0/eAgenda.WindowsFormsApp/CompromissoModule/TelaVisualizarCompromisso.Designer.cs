
namespace eAgenda.WindowsFormsApp.CompromissoModule
{
    partial class TelaVisualizarCompromisso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVisualizarCompromisso));
            this.btnTodosCompromissos = new System.Windows.Forms.Button();
            this.dataGridViewCompromissos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetCompromissos = new System.Data.DataSet();
            this.dtCompromissos = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.labelVisualizarCompromissos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCompromissosPassados = new System.Windows.Forms.Button();
            this.btnCompromissosFuturos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompromissos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompromissos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompromissos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTodosCompromissos
            // 
            this.btnTodosCompromissos.Location = new System.Drawing.Point(12, 251);
            this.btnTodosCompromissos.Name = "btnTodosCompromissos";
            this.btnTodosCompromissos.Size = new System.Drawing.Size(126, 23);
            this.btnTodosCompromissos.TabIndex = 17;
            this.btnTodosCompromissos.TabStop = false;
            this.btnTodosCompromissos.Text = "Todos Compromissos";
            this.btnTodosCompromissos.UseVisualStyleBackColor = true;
            this.btnTodosCompromissos.Click += new System.EventHandler(this.btnTodosCompromissos_Click);
            // 
            // dataGridViewCompromissos
            // 
            this.dataGridViewCompromissos.AutoGenerateColumns = false;
            this.dataGridViewCompromissos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(84)))), ((int)(((byte)(104)))));
            this.dataGridViewCompromissos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompromissos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.assuntoDataGridViewTextBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.linkDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaInicioDataGridViewTextBoxColumn,
            this.horaFimDataGridViewTextBoxColumn,
            this.contatoDataGridViewTextBoxColumn});
            this.dataGridViewCompromissos.DataMember = "Compromissos";
            this.dataGridViewCompromissos.DataSource = this.dataSetCompromissos;
            this.dataGridViewCompromissos.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewCompromissos.Name = "dataGridViewCompromissos";
            this.dataGridViewCompromissos.ReadOnly = true;
            this.dataGridViewCompromissos.Size = new System.Drawing.Size(844, 188);
            this.dataGridViewCompromissos.TabIndex = 16;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assuntoDataGridViewTextBoxColumn
            // 
            this.assuntoDataGridViewTextBoxColumn.DataPropertyName = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.HeaderText = "Assunto";
            this.assuntoDataGridViewTextBoxColumn.Name = "assuntoDataGridViewTextBoxColumn";
            this.assuntoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            this.localDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // linkDataGridViewTextBoxColumn
            // 
            this.linkDataGridViewTextBoxColumn.DataPropertyName = "Link";
            this.linkDataGridViewTextBoxColumn.HeaderText = "Link";
            this.linkDataGridViewTextBoxColumn.Name = "linkDataGridViewTextBoxColumn";
            this.linkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaInicioDataGridViewTextBoxColumn
            // 
            this.horaInicioDataGridViewTextBoxColumn.DataPropertyName = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.HeaderText = "HoraInicio";
            this.horaInicioDataGridViewTextBoxColumn.Name = "horaInicioDataGridViewTextBoxColumn";
            this.horaInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaFimDataGridViewTextBoxColumn
            // 
            this.horaFimDataGridViewTextBoxColumn.DataPropertyName = "HoraFim";
            this.horaFimDataGridViewTextBoxColumn.HeaderText = "HoraFim";
            this.horaFimDataGridViewTextBoxColumn.Name = "horaFimDataGridViewTextBoxColumn";
            this.horaFimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contatoDataGridViewTextBoxColumn
            // 
            this.contatoDataGridViewTextBoxColumn.DataPropertyName = "Contato";
            this.contatoDataGridViewTextBoxColumn.HeaderText = "Contato";
            this.contatoDataGridViewTextBoxColumn.Name = "contatoDataGridViewTextBoxColumn";
            this.contatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSetCompromissos
            // 
            this.dataSetCompromissos.DataSetName = "NewDataSet";
            this.dataSetCompromissos.Tables.AddRange(new System.Data.DataTable[] {
            this.dtCompromissos});
            // 
            // dtCompromissos
            // 
            this.dtCompromissos.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dtCompromissos.TableName = "Compromissos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Assunto";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Local";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Link";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Data";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "HoraInicio";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "HoraFim";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Contato";
            // 
            // labelVisualizarCompromissos
            // 
            this.labelVisualizarCompromissos.AutoSize = true;
            this.labelVisualizarCompromissos.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisualizarCompromissos.Location = new System.Drawing.Point(359, 20);
            this.labelVisualizarCompromissos.Name = "labelVisualizarCompromissos";
            this.labelVisualizarCompromissos.Size = new System.Drawing.Size(203, 21);
            this.labelVisualizarCompromissos.TabIndex = 15;
            this.labelVisualizarCompromissos.Text = "Visualizar Compromissos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(781, 251);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCompromissosPassados
            // 
            this.btnCompromissosPassados.Location = new System.Drawing.Point(261, 251);
            this.btnCompromissosPassados.Name = "btnCompromissosPassados";
            this.btnCompromissosPassados.Size = new System.Drawing.Size(131, 23);
            this.btnCompromissosPassados.TabIndex = 18;
            this.btnCompromissosPassados.TabStop = false;
            this.btnCompromissosPassados.Text = "Compromissos Passados";
            this.btnCompromissosPassados.UseVisualStyleBackColor = true;
            this.btnCompromissosPassados.Click += new System.EventHandler(this.btnCompromissosPassados_Click);
            // 
            // btnCompromissosFuturos
            // 
            this.btnCompromissosFuturos.Location = new System.Drawing.Point(517, 251);
            this.btnCompromissosFuturos.Name = "btnCompromissosFuturos";
            this.btnCompromissosFuturos.Size = new System.Drawing.Size(126, 23);
            this.btnCompromissosFuturos.TabIndex = 19;
            this.btnCompromissosFuturos.TabStop = false;
            this.btnCompromissosFuturos.Text = "Compromissos Futuros";
            this.btnCompromissosFuturos.UseVisualStyleBackColor = true;
            this.btnCompromissosFuturos.Click += new System.EventHandler(this.btnCompromissosFuturos_Click);
            // 
            // TelaVisualizarCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(884, 283);
            this.Controls.Add(this.btnCompromissosFuturos);
            this.Controls.Add(this.btnCompromissosPassados);
            this.Controls.Add(this.btnTodosCompromissos);
            this.Controls.Add(this.dataGridViewCompromissos);
            this.Controls.Add(this.labelVisualizarCompromissos);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaVisualizarCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaVisualizarCompromisso";
            this.Load += new System.EventHandler(this.TelaVisualizarCompromisso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompromissos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompromissos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCompromissos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTodosCompromissos;
        private System.Windows.Forms.DataGridView dataGridViewCompromissos;
        private System.Data.DataSet dataSetCompromissos;
        private System.Data.DataTable dtCompromissos;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.Label labelVisualizarCompromissos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCompromissosPassados;
        private System.Windows.Forms.Button btnCompromissosFuturos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contatoDataGridViewTextBoxColumn;
    }
}