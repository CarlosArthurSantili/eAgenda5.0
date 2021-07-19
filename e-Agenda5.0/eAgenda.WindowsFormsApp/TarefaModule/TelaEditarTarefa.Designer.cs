
namespace eAgenda.WindowsFormsApp.TarefaModule
{
    partial class TelaEditarTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarTarefa));
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelEditarTarefa = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.labelTarefa = new System.Windows.Forms.Label();
            this.comboBoxTarefas = new System.Windows.Forms.ComboBox();
            this.labelPercentual = new System.Windows.Forms.Label();
            this.numericUpDownPercentual = new System.Windows.Forms.NumericUpDown();
            this.labelResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentual)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.Location = new System.Drawing.Point(118, 71);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(122, 20);
            this.textBoxTitulo.TabIndex = 14;
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrioridade.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Normal",
            "Alta"});
            this.comboBoxPrioridade.Location = new System.Drawing.Point(118, 106);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(81, 21);
            this.comboBoxPrioridade.TabIndex = 13;
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.AutoSize = true;
            this.labelPrioridade.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrioridade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrioridade.Location = new System.Drawing.Point(12, 109);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(55, 13);
            this.labelPrioridade.TabIndex = 12;
            this.labelPrioridade.Text = "Prioridade";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitulo.Location = new System.Drawing.Point(12, 74);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 11;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelEditarTarefa
            // 
            this.labelEditarTarefa.AutoSize = true;
            this.labelEditarTarefa.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarTarefa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEditarTarefa.Location = new System.Drawing.Point(70, 9);
            this.labelEditarTarefa.Name = "labelEditarTarefa";
            this.labelEditarTarefa.Size = new System.Drawing.Size(117, 21);
            this.labelEditarTarefa.TabIndex = 10;
            this.labelEditarTarefa.Text = "Editar Tarefa";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(164, 173);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(12, 173);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.TabStop = false;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // labelTarefa
            // 
            this.labelTarefa.AutoSize = true;
            this.labelTarefa.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTarefa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTarefa.Location = new System.Drawing.Point(12, 43);
            this.labelTarefa.Name = "labelTarefa";
            this.labelTarefa.Size = new System.Drawing.Size(48, 13);
            this.labelTarefa.TabIndex = 15;
            this.labelTarefa.Text = "Id Tarefa";
            // 
            // comboBoxTarefas
            // 
            this.comboBoxTarefas.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTarefas.FormattingEnabled = true;
            this.comboBoxTarefas.Location = new System.Drawing.Point(118, 40);
            this.comboBoxTarefas.Name = "comboBoxTarefas";
            this.comboBoxTarefas.Size = new System.Drawing.Size(81, 21);
            this.comboBoxTarefas.TabIndex = 16;
            this.comboBoxTarefas.SelectedIndexChanged += new System.EventHandler(this.comboBoxTarefas_SelectedIndexChanged);
            // 
            // labelPercentual
            // 
            this.labelPercentual.AutoSize = true;
            this.labelPercentual.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPercentual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPercentual.Location = new System.Drawing.Point(12, 145);
            this.labelPercentual.Name = "labelPercentual";
            this.labelPercentual.Size = new System.Drawing.Size(56, 13);
            this.labelPercentual.TabIndex = 17;
            this.labelPercentual.Text = "Percentual";
            // 
            // numericUpDownPercentual
            // 
            this.numericUpDownPercentual.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPercentual.Location = new System.Drawing.Point(118, 138);
            this.numericUpDownPercentual.Name = "numericUpDownPercentual";
            this.numericUpDownPercentual.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownPercentual.TabIndex = 24;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(12, 199);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 15);
            this.labelResultado.TabIndex = 25;
            // 
            // TelaEditarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(251, 219);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.numericUpDownPercentual);
            this.Controls.Add(this.labelPercentual);
            this.Controls.Add(this.comboBoxTarefas);
            this.Controls.Add(this.labelTarefa);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.comboBoxPrioridade);
            this.Controls.Add(this.labelPrioridade);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelEditarTarefa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaEditarTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaEditarTarefa";
            this.Load += new System.EventHandler(this.TelaEditarTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPercentual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelEditarTarefa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label labelTarefa;
        private System.Windows.Forms.ComboBox comboBoxTarefas;
        private System.Windows.Forms.Label labelPercentual;
        private System.Windows.Forms.NumericUpDown numericUpDownPercentual;
        private System.Windows.Forms.Label labelResultado;
    }
}