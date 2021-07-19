
namespace eAgenda.WindowsFormsApp.TarefaModule
{
    partial class TelaCadastrarTarefa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarTarefa));
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelCadastrarTarefa = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTitulo.Location = new System.Drawing.Point(76, 46);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(121, 20);
            this.textBoxTitulo.TabIndex = 41;
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrioridade.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPrioridade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Normal",
            "Alta"});
            this.comboBoxPrioridade.Location = new System.Drawing.Point(76, 81);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrioridade.TabIndex = 40;
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.AutoSize = true;
            this.labelPrioridade.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrioridade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrioridade.Location = new System.Drawing.Point(18, 84);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(55, 13);
            this.labelPrioridade.TabIndex = 39;
            this.labelPrioridade.Text = "Prioridade";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitulo.Location = new System.Drawing.Point(18, 49);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(33, 13);
            this.labelTitulo.TabIndex = 38;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelCadastrarTarefa
            // 
            this.labelCadastrarTarefa.AutoSize = true;
            this.labelCadastrarTarefa.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastrarTarefa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCadastrarTarefa.Location = new System.Drawing.Point(49, 9);
            this.labelCadastrarTarefa.Name = "labelCadastrarTarefa";
            this.labelCadastrarTarefa.Size = new System.Drawing.Size(148, 21);
            this.labelCadastrarTarefa.TabIndex = 37;
            this.labelCadastrarTarefa.Text = "Cadastrar Tarefa";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(131, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(19, 131);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 35;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResultado.Location = new System.Drawing.Point(18, 162);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 15);
            this.labelResultado.TabIndex = 42;
            // 
            // TelaCadastrarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(232, 184);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.comboBoxPrioridade);
            this.Controls.Add(this.labelPrioridade);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelCadastrarTarefa);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadastrarTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastrarTarefa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastrarTarefa_FormClosed);
            this.Load += new System.EventHandler(this.TelaCadastrarTarefa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCadastrarTarefa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label labelResultado;
    }
}