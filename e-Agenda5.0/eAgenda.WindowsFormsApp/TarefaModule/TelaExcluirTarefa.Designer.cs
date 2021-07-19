
namespace eAgenda.WindowsFormsApp.TarefaModule
{
    partial class TelaExcluirTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaExcluirTarefa));
            this.labelEditarTarefa = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.numericUpDownPercentual = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBoxDataCriacao = new System.Windows.Forms.MaskedTextBox();
            this.labelDataCriacao = new System.Windows.Forms.Label();
            this.labelPercentual = new System.Windows.Forms.Label();
            this.comboBoxTarefas = new System.Windows.Forms.ComboBox();
            this.labelTarefa = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentual)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditarTarefa
            // 
            this.labelEditarTarefa.AutoSize = true;
            this.labelEditarTarefa.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarTarefa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEditarTarefa.Location = new System.Drawing.Point(62, 9);
            this.labelEditarTarefa.Name = "labelEditarTarefa";
            this.labelEditarTarefa.Size = new System.Drawing.Size(118, 21);
            this.labelEditarTarefa.TabIndex = 28;
            this.labelEditarTarefa.Text = "Excluir Tarefa";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(161, 199);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluir.Location = new System.Drawing.Point(12, 199);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // numericUpDownPercentual
            // 
            this.numericUpDownPercentual.Enabled = false;
            this.numericUpDownPercentual.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPercentual.Location = new System.Drawing.Point(114, 133);
            this.numericUpDownPercentual.Name = "numericUpDownPercentual";
            this.numericUpDownPercentual.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownPercentual.TabIndex = 38;
            // 
            // maskedTextBoxDataCriacao
            // 
            this.maskedTextBoxDataCriacao.Enabled = false;
            this.maskedTextBoxDataCriacao.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDataCriacao.Location = new System.Drawing.Point(114, 165);
            this.maskedTextBoxDataCriacao.Mask = "00/00/0000";
            this.maskedTextBoxDataCriacao.Name = "maskedTextBoxDataCriacao";
            this.maskedTextBoxDataCriacao.Size = new System.Drawing.Size(51, 20);
            this.maskedTextBoxDataCriacao.TabIndex = 37;
            this.maskedTextBoxDataCriacao.ValidatingType = typeof(System.DateTime);
            // 
            // labelDataCriacao
            // 
            this.labelDataCriacao.AutoSize = true;
            this.labelDataCriacao.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataCriacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDataCriacao.Location = new System.Drawing.Point(12, 165);
            this.labelDataCriacao.Name = "labelDataCriacao";
            this.labelDataCriacao.Size = new System.Drawing.Size(82, 13);
            this.labelDataCriacao.TabIndex = 36;
            this.labelDataCriacao.Text = "Data de Criação";
            // 
            // labelPercentual
            // 
            this.labelPercentual.AutoSize = true;
            this.labelPercentual.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPercentual.Location = new System.Drawing.Point(12, 135);
            this.labelPercentual.Name = "labelPercentual";
            this.labelPercentual.Size = new System.Drawing.Size(56, 13);
            this.labelPercentual.TabIndex = 35;
            this.labelPercentual.Text = "Percentual";
            // 
            // comboBoxTarefas
            // 
            this.comboBoxTarefas.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTarefas.FormattingEnabled = true;
            this.comboBoxTarefas.Location = new System.Drawing.Point(114, 33);
            this.comboBoxTarefas.Name = "comboBoxTarefas";
            this.comboBoxTarefas.Size = new System.Drawing.Size(81, 21);
            this.comboBoxTarefas.TabIndex = 34;
            this.comboBoxTarefas.SelectedIndexChanged += new System.EventHandler(this.comboBoxTarefas_SelectedIndexChanged);
            // 
            // labelTarefa
            // 
            this.labelTarefa.AutoSize = true;
            this.labelTarefa.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarefa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTarefa.Location = new System.Drawing.Point(12, 36);
            this.labelTarefa.Name = "labelTarefa";
            this.labelTarefa.Size = new System.Drawing.Size(48, 13);
            this.labelTarefa.TabIndex = 33;
            this.labelTarefa.Text = "Id Tarefa";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.Location = new System.Drawing.Point(114, 67);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(122, 20);
            this.textBoxTitulo.TabIndex = 32;
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrioridade.Enabled = false;
            this.comboBoxPrioridade.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Normal",
            "Alta"});
            this.comboBoxPrioridade.Location = new System.Drawing.Point(114, 100);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(81, 21);
            this.comboBoxPrioridade.TabIndex = 31;
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.AutoSize = true;
            this.labelPrioridade.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrioridade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrioridade.Location = new System.Drawing.Point(12, 103);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(55, 13);
            this.labelPrioridade.TabIndex = 30;
            this.labelPrioridade.Text = "Prioridade";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitulo.Location = new System.Drawing.Point(12, 70);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 29;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResultado.Location = new System.Drawing.Point(94, 233);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 13);
            this.labelResultado.TabIndex = 39;
            // 
            // TelaExcluirTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(248, 255);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.numericUpDownPercentual);
            this.Controls.Add(this.maskedTextBoxDataCriacao);
            this.Controls.Add(this.labelDataCriacao);
            this.Controls.Add(this.labelPercentual);
            this.Controls.Add(this.comboBoxTarefas);
            this.Controls.Add(this.labelTarefa);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.comboBoxPrioridade);
            this.Controls.Add(this.labelPrioridade);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelEditarTarefa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaExcluirTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaExcluirTarefa";
            this.Load += new System.EventHandler(this.TelaExcluirTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEditarTarefa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentual;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataCriacao;
        private System.Windows.Forms.Label labelDataCriacao;
        private System.Windows.Forms.Label labelPercentual;
        private System.Windows.Forms.ComboBox comboBoxTarefas;
        private System.Windows.Forms.Label labelTarefa;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelResultado;
    }
}