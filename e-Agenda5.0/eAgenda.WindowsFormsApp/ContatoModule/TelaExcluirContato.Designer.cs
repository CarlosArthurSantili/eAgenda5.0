
namespace eAgenda.WindowsFormsApp.ContatoModule
{
    partial class TelaExcluirContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaExcluirContato));
            this.labelContato = new System.Windows.Forms.Label();
            this.comboBoxContatos = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelExcluirContato = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelContato.Location = new System.Drawing.Point(10, 40);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(46, 13);
            this.labelContato.TabIndex = 87;
            this.labelContato.Text = "Contato";
            // 
            // comboBoxContatos
            // 
            this.comboBoxContatos.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContatos.FormattingEnabled = true;
            this.comboBoxContatos.Location = new System.Drawing.Point(68, 37);
            this.comboBoxContatos.Name = "comboBoxContatos";
            this.comboBoxContatos.Size = new System.Drawing.Size(106, 21);
            this.comboBoxContatos.TabIndex = 86;
            this.comboBoxContatos.SelectedIndexChanged += new System.EventHandler(this.comboBoxContatos_SelectedIndexChanged);
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Enabled = false;
            this.maskedTextBoxTelefone.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(68, 146);
            this.maskedTextBoxTelefone.Mask = "00000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(106, 20);
            this.maskedTextBoxTelefone.TabIndex = 85;
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.Enabled = false;
            this.textBoxCargo.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCargo.Location = new System.Drawing.Point(68, 217);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(106, 20);
            this.textBoxCargo.TabIndex = 84;
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Enabled = false;
            this.textBoxEmpresa.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmpresa.Location = new System.Drawing.Point(68, 182);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.Size = new System.Drawing.Size(106, 20);
            this.textBoxEmpresa.TabIndex = 83;
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmpresa.Location = new System.Drawing.Point(10, 185);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(46, 13);
            this.labelEmpresa.TabIndex = 82;
            this.labelEmpresa.Text = "Empresa";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTelefone.Location = new System.Drawing.Point(10, 149);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(45, 13);
            this.labelTelefone.TabIndex = 81;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(68, 110);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(106, 20);
            this.textBoxEmail.TabIndex = 80;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEmail.Location = new System.Drawing.Point(10, 113);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(31, 13);
            this.labelEmail.TabIndex = 79;
            this.labelEmail.Text = "Email";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Enabled = false;
            this.textBoxNome.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(68, 74);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(106, 20);
            this.textBoxNome.TabIndex = 78;
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCargo.Location = new System.Drawing.Point(10, 220);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(36, 13);
            this.labelCargo.TabIndex = 77;
            this.labelCargo.Text = "Cargo";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNome.Location = new System.Drawing.Point(10, 77);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(34, 13);
            this.labelNome.TabIndex = 76;
            this.labelNome.Text = "Nome";
            // 
            // labelExcluirContato
            // 
            this.labelExcluirContato.AutoSize = true;
            this.labelExcluirContato.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExcluirContato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelExcluirContato.Location = new System.Drawing.Point(34, 9);
            this.labelExcluirContato.Name = "labelExcluirContato";
            this.labelExcluirContato.Size = new System.Drawing.Size(131, 21);
            this.labelExcluirContato.TabIndex = 75;
            this.labelExcluirContato.Text = "Excluir Contato";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(106, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluir.Location = new System.Drawing.Point(11, 258);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 73;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResultado.Location = new System.Drawing.Point(51, 284);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 13);
            this.labelResultado.TabIndex = 88;
            // 
            // TelaExcluirContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(193, 299);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelContato);
            this.Controls.Add(this.comboBoxContatos);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.textBoxCargo);
            this.Controls.Add(this.textBoxEmpresa);
            this.Controls.Add(this.labelEmpresa);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelExcluirContato);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaExcluirContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaExcluirContato";
            this.Load += new System.EventHandler(this.TelaExcluirContato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContato;
        private System.Windows.Forms.ComboBox comboBoxContatos;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.TextBox textBoxEmpresa;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelExcluirContato;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label labelResultado;
    }
}