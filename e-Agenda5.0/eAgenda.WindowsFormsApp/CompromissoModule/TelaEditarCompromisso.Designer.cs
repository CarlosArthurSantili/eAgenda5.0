
namespace eAgenda.WindowsFormsApp.CompromissoModule
{
    partial class TelaEditarCompromisso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditarCompromisso));
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.maskedTextBoxHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxContatos = new System.Windows.Forms.ComboBox();
            this.labelHoraFim = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.labelHoraInicio = new System.Windows.Forms.Label();
            this.labelEditarCompromisso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.labelCompromisso = new System.Windows.Forms.Label();
            this.comboBoxCompromissos = new System.Windows.Forms.ComboBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbLink = new System.Windows.Forms.RadioButton();
            this.labelAssunto = new System.Windows.Forms.Label();
            this.checkBoxContato = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(89, 147);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(121, 20);
            this.textBoxLink.TabIndex = 96;
            // 
            // maskedTextBoxHoraFim
            // 
            this.maskedTextBoxHoraFim.Location = new System.Drawing.Point(89, 253);
            this.maskedTextBoxHoraFim.Mask = "00:00";
            this.maskedTextBoxHoraFim.Name = "maskedTextBoxHoraFim";
            this.maskedTextBoxHoraFim.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxHoraFim.TabIndex = 95;
            this.maskedTextBoxHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHoraInicio
            // 
            this.maskedTextBoxHoraInicio.Location = new System.Drawing.Point(89, 218);
            this.maskedTextBoxHoraInicio.Mask = "00:00";
            this.maskedTextBoxHoraInicio.Name = "maskedTextBoxHoraInicio";
            this.maskedTextBoxHoraInicio.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxHoraInicio.TabIndex = 94;
            this.maskedTextBoxHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(89, 183);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxData.TabIndex = 93;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxContatos
            // 
            this.comboBoxContatos.Enabled = false;
            this.comboBoxContatos.FormattingEnabled = true;
            this.comboBoxContatos.Location = new System.Drawing.Point(89, 285);
            this.comboBoxContatos.Name = "comboBoxContatos";
            this.comboBoxContatos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxContatos.TabIndex = 91;
            this.comboBoxContatos.SelectedIndexChanged += new System.EventHandler(this.comboBoxContatos_SelectedIndexChanged);
            // 
            // labelHoraFim
            // 
            this.labelHoraFim.AutoSize = true;
            this.labelHoraFim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHoraFim.Location = new System.Drawing.Point(18, 256);
            this.labelHoraFim.Name = "labelHoraFim";
            this.labelHoraFim.Size = new System.Drawing.Size(50, 13);
            this.labelHoraFim.TabIndex = 90;
            this.labelHoraFim.Text = "Hora Fim";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelData.Location = new System.Drawing.Point(18, 186);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 89;
            this.labelData.Text = "Data";
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(89, 111);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(121, 20);
            this.textBoxLocal.TabIndex = 87;
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Location = new System.Drawing.Point(89, 75);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(121, 20);
            this.textBoxAssunto.TabIndex = 85;
            // 
            // labelHoraInicio
            // 
            this.labelHoraInicio.AutoSize = true;
            this.labelHoraInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHoraInicio.Location = new System.Drawing.Point(18, 221);
            this.labelHoraInicio.Name = "labelHoraInicio";
            this.labelHoraInicio.Size = new System.Drawing.Size(56, 13);
            this.labelHoraInicio.TabIndex = 84;
            this.labelHoraInicio.Text = "Hora Inicio";
            // 
            // labelEditarCompromisso
            // 
            this.labelEditarCompromisso.AutoSize = true;
            this.labelEditarCompromisso.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarCompromisso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEditarCompromisso.Location = new System.Drawing.Point(31, 9);
            this.labelEditarCompromisso.Name = "labelEditarCompromisso";
            this.labelEditarCompromisso.Size = new System.Drawing.Size(170, 21);
            this.labelEditarCompromisso.TabIndex = 82;
            this.labelEditarCompromisso.Text = "Editar Compromisso";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(135, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 81;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(22, 321);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 80;
            this.btnEditar.TabStop = false;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // labelCompromisso
            // 
            this.labelCompromisso.AutoSize = true;
            this.labelCompromisso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCompromisso.Location = new System.Drawing.Point(18, 41);
            this.labelCompromisso.Name = "labelCompromisso";
            this.labelCompromisso.Size = new System.Drawing.Size(68, 13);
            this.labelCompromisso.TabIndex = 98;
            this.labelCompromisso.Text = "Compromisso";
            // 
            // comboBoxCompromissos
            // 
            this.comboBoxCompromissos.FormattingEnabled = true;
            this.comboBoxCompromissos.Location = new System.Drawing.Point(89, 38);
            this.comboBoxCompromissos.Name = "comboBoxCompromissos";
            this.comboBoxCompromissos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCompromissos.TabIndex = 1;
            this.comboBoxCompromissos.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompromissos_SelectedIndexChanged);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResultado.Location = new System.Drawing.Point(12, 348);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 13);
            this.labelResultado.TabIndex = 99;
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbLocal.Location = new System.Drawing.Point(22, 111);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(49, 17);
            this.rbLocal.TabIndex = 100;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.rbLocal_CheckedChanged);
            // 
            // rbLink
            // 
            this.rbLink.AutoSize = true;
            this.rbLink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbLink.Location = new System.Drawing.Point(21, 147);
            this.rbLink.Name = "rbLink";
            this.rbLink.Size = new System.Drawing.Size(45, 17);
            this.rbLink.TabIndex = 101;
            this.rbLink.TabStop = true;
            this.rbLink.Text = "Link";
            this.rbLink.UseVisualStyleBackColor = true;
            this.rbLink.CheckedChanged += new System.EventHandler(this.rbLink_CheckedChanged);
            // 
            // labelAssunto
            // 
            this.labelAssunto.AutoSize = true;
            this.labelAssunto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAssunto.Location = new System.Drawing.Point(18, 78);
            this.labelAssunto.Name = "labelAssunto";
            this.labelAssunto.Size = new System.Drawing.Size(44, 13);
            this.labelAssunto.TabIndex = 102;
            this.labelAssunto.Text = "Assunto";
            // 
            // checkBoxContato
            // 
            this.checkBoxContato.AutoSize = true;
            this.checkBoxContato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxContato.Location = new System.Drawing.Point(21, 287);
            this.checkBoxContato.Name = "checkBoxContato";
            this.checkBoxContato.Size = new System.Drawing.Size(65, 17);
            this.checkBoxContato.TabIndex = 103;
            this.checkBoxContato.Text = "Contato";
            this.checkBoxContato.UseVisualStyleBackColor = true;
            this.checkBoxContato.CheckedChanged += new System.EventHandler(this.cbContato_CheckedChanged);
            // 
            // TelaEditarCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(233, 367);
            this.Controls.Add(this.checkBoxContato);
            this.Controls.Add(this.labelAssunto);
            this.Controls.Add(this.rbLink);
            this.Controls.Add(this.rbLocal);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelCompromisso);
            this.Controls.Add(this.comboBoxCompromissos);
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
            this.Controls.Add(this.labelEditarCompromisso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaEditarCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaEditarCompromisso";
            this.Load += new System.EventHandler(this.TelaEditarCompromisso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraFim;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.ComboBox comboBoxContatos;
        private System.Windows.Forms.Label labelHoraFim;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.Label labelHoraInicio;
        private System.Windows.Forms.Label labelEditarCompromisso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label labelCompromisso;
        private System.Windows.Forms.ComboBox comboBoxCompromissos;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.RadioButton rbLink;
        private System.Windows.Forms.Label labelAssunto;
        private System.Windows.Forms.CheckBox checkBoxContato;
    }
}