
namespace eAgenda.WindowsFormsApp.CompromissoModule
{
    partial class TelaCadastrarCompromisso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarCompromisso));
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.labelHoraInicio = new System.Windows.Forms.Label();
            this.labelAssunto = new System.Windows.Forms.Label();
            this.labelCadastrarCompromisso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.labelHoraFim = new System.Windows.Forms.Label();
            this.comboBoxContatos = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbLink = new System.Windows.Forms.RadioButton();
            this.checkBoxContato = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelData.Location = new System.Drawing.Point(16, 151);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 67;
            this.labelData.Text = "Data";
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLocal.Location = new System.Drawing.Point(96, 76);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(121, 20);
            this.textBoxLocal.TabIndex = 3;
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAssunto.Location = new System.Drawing.Point(96, 40);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(121, 20);
            this.textBoxAssunto.TabIndex = 1;
            // 
            // labelHoraInicio
            // 
            this.labelHoraInicio.AutoSize = true;
            this.labelHoraInicio.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHoraInicio.Location = new System.Drawing.Point(16, 186);
            this.labelHoraInicio.Name = "labelHoraInicio";
            this.labelHoraInicio.Size = new System.Drawing.Size(56, 13);
            this.labelHoraInicio.TabIndex = 62;
            this.labelHoraInicio.Text = "Hora Inicio";
            // 
            // labelAssunto
            // 
            this.labelAssunto.AutoSize = true;
            this.labelAssunto.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssunto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAssunto.Location = new System.Drawing.Point(16, 43);
            this.labelAssunto.Name = "labelAssunto";
            this.labelAssunto.Size = new System.Drawing.Size(44, 13);
            this.labelAssunto.TabIndex = 61;
            this.labelAssunto.Text = "Assunto";
            // 
            // labelCadastrarCompromisso
            // 
            this.labelCadastrarCompromisso.AutoSize = true;
            this.labelCadastrarCompromisso.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastrarCompromisso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCadastrarCompromisso.Location = new System.Drawing.Point(16, 9);
            this.labelCadastrarCompromisso.Name = "labelCadastrarCompromisso";
            this.labelCadastrarCompromisso.Size = new System.Drawing.Size(201, 21);
            this.labelCadastrarCompromisso.TabIndex = 60;
            this.labelCadastrarCompromisso.Text = "Cadastrar Compromisso";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(146, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 288);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 58;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // labelHoraFim
            // 
            this.labelHoraFim.AutoSize = true;
            this.labelHoraFim.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraFim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHoraFim.Location = new System.Drawing.Point(16, 221);
            this.labelHoraFim.Name = "labelHoraFim";
            this.labelHoraFim.Size = new System.Drawing.Size(50, 13);
            this.labelHoraFim.TabIndex = 72;
            this.labelHoraFim.Text = "Hora Fim";
            // 
            // comboBoxContatos
            // 
            this.comboBoxContatos.Enabled = false;
            this.comboBoxContatos.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContatos.FormattingEnabled = true;
            this.comboBoxContatos.Location = new System.Drawing.Point(96, 250);
            this.comboBoxContatos.Name = "comboBoxContatos";
            this.comboBoxContatos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxContatos.TabIndex = 10;
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxData.Location = new System.Drawing.Point(96, 148);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxData.TabIndex = 6;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHoraInicio
            // 
            this.maskedTextBoxHoraInicio.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxHoraInicio.Location = new System.Drawing.Point(96, 183);
            this.maskedTextBoxHoraInicio.Mask = "00:00";
            this.maskedTextBoxHoraInicio.Name = "maskedTextBoxHoraInicio";
            this.maskedTextBoxHoraInicio.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxHoraInicio.TabIndex = 7;
            this.maskedTextBoxHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHoraFim
            // 
            this.maskedTextBoxHoraFim.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxHoraFim.Location = new System.Drawing.Point(96, 218);
            this.maskedTextBoxHoraFim.Mask = "00:00";
            this.maskedTextBoxHoraFim.Name = "maskedTextBoxHoraFim";
            this.maskedTextBoxHoraFim.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxHoraFim.TabIndex = 8;
            this.maskedTextBoxHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxLink
            // 
            this.textBoxLink.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLink.Location = new System.Drawing.Point(96, 112);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(121, 20);
            this.textBoxLink.TabIndex = 5;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResultado.Location = new System.Drawing.Point(9, 316);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 13);
            this.labelResultado.TabIndex = 80;
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLocal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbLocal.Location = new System.Drawing.Point(19, 77);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(49, 17);
            this.rbLocal.TabIndex = 2;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.rbLocal_CheckedChanged);
            // 
            // rbLink
            // 
            this.rbLink.AutoSize = true;
            this.rbLink.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbLink.Location = new System.Drawing.Point(20, 113);
            this.rbLink.Name = "rbLink";
            this.rbLink.Size = new System.Drawing.Size(45, 17);
            this.rbLink.TabIndex = 4;
            this.rbLink.TabStop = true;
            this.rbLink.Text = "Link";
            this.rbLink.UseVisualStyleBackColor = true;
            this.rbLink.CheckedChanged += new System.EventHandler(this.rbLink_CheckedChanged);
            // 
            // checkBoxContato
            // 
            this.checkBoxContato.AutoSize = true;
            this.checkBoxContato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxContato.Location = new System.Drawing.Point(19, 254);
            this.checkBoxContato.Name = "checkBoxContato";
            this.checkBoxContato.Size = new System.Drawing.Size(63, 17);
            this.checkBoxContato.TabIndex = 9;
            this.checkBoxContato.Text = "Contato";
            this.checkBoxContato.UseVisualStyleBackColor = true;
            this.checkBoxContato.CheckedChanged += new System.EventHandler(this.checkBoxContato_CheckedChanged);
            // 
            // TelaCadastrarCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(233, 332);
            this.Controls.Add(this.checkBoxContato);
            this.Controls.Add(this.rbLink);
            this.Controls.Add(this.rbLocal);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.maskedTextBoxHoraFim);
            this.Controls.Add(this.maskedTextBoxHoraInicio);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.comboBoxContatos);
            this.Controls.Add(this.labelHoraFim);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.textBoxAssunto);
            this.Controls.Add(this.labelHoraInicio);
            this.Controls.Add(this.labelAssunto);
            this.Controls.Add(this.labelCadastrarCompromisso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastrarCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastrarCompromisso";
            this.Load += new System.EventHandler(this.TelaCadastrarCompromisso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.Label labelHoraInicio;
        private System.Windows.Forms.Label labelAssunto;
        private System.Windows.Forms.Label labelCadastrarCompromisso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label labelHoraFim;
        private System.Windows.Forms.ComboBox comboBoxContatos;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraFim;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.RadioButton rbLink;
        private System.Windows.Forms.CheckBox checkBoxContato;
    }
}