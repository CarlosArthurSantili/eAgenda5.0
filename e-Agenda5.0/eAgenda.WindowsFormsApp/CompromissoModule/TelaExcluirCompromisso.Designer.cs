
namespace eAgenda.WindowsFormsApp.CompromissoModule
{
    partial class TelaExcluirCompromisso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaExcluirCompromisso));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCompromissos = new System.Windows.Forms.ComboBox();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.maskedTextBoxHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxContatos = new System.Windows.Forms.ComboBox();
            this.labelHoraTermino = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.labelHoraInicio = new System.Windows.Forms.Label();
            this.labelExcluirCompromisso = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.labelAssunto = new System.Windows.Forms.Label();
            this.rbLink = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.cbContato = new System.Windows.Forms.CheckBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 117;
            this.label1.Text = "Compromisso";
            // 
            // comboBoxCompromissos
            // 
            this.comboBoxCompromissos.FormattingEnabled = true;
            this.comboBoxCompromissos.Location = new System.Drawing.Point(91, 37);
            this.comboBoxCompromissos.Name = "comboBoxCompromissos";
            this.comboBoxCompromissos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCompromissos.TabIndex = 1;
            this.comboBoxCompromissos.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompromisso_SelectedIndexChanged);
            // 
            // textBoxLink
            // 
            this.textBoxLink.Enabled = false;
            this.textBoxLink.Location = new System.Drawing.Point(91, 146);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(121, 20);
            this.textBoxLink.TabIndex = 115;
            // 
            // maskedTextBoxHoraFim
            // 
            this.maskedTextBoxHoraFim.Enabled = false;
            this.maskedTextBoxHoraFim.Location = new System.Drawing.Point(91, 252);
            this.maskedTextBoxHoraFim.Mask = "00:00";
            this.maskedTextBoxHoraFim.Name = "maskedTextBoxHoraFim";
            this.maskedTextBoxHoraFim.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxHoraFim.TabIndex = 114;
            this.maskedTextBoxHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHoraInicio
            // 
            this.maskedTextBoxHoraInicio.Enabled = false;
            this.maskedTextBoxHoraInicio.Location = new System.Drawing.Point(91, 217);
            this.maskedTextBoxHoraInicio.Mask = "00:00";
            this.maskedTextBoxHoraInicio.Name = "maskedTextBoxHoraInicio";
            this.maskedTextBoxHoraInicio.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxHoraInicio.TabIndex = 113;
            this.maskedTextBoxHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Enabled = false;
            this.maskedTextBoxData.Location = new System.Drawing.Point(91, 182);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxData.TabIndex = 112;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxContatos
            // 
            this.comboBoxContatos.Enabled = false;
            this.comboBoxContatos.FormattingEnabled = true;
            this.comboBoxContatos.Location = new System.Drawing.Point(91, 284);
            this.comboBoxContatos.Name = "comboBoxContatos";
            this.comboBoxContatos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxContatos.TabIndex = 110;
            // 
            // labelHoraTermino
            // 
            this.labelHoraTermino.AutoSize = true;
            this.labelHoraTermino.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHoraTermino.Location = new System.Drawing.Point(20, 255);
            this.labelHoraTermino.Name = "labelHoraTermino";
            this.labelHoraTermino.Size = new System.Drawing.Size(71, 13);
            this.labelHoraTermino.TabIndex = 109;
            this.labelHoraTermino.Text = "Hora Termino";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelData.Location = new System.Drawing.Point(20, 185);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 108;
            this.labelData.Text = "Data";
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Enabled = false;
            this.textBoxLocal.Location = new System.Drawing.Point(91, 110);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(121, 20);
            this.textBoxLocal.TabIndex = 106;
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Enabled = false;
            this.textBoxAssunto.Location = new System.Drawing.Point(91, 74);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(121, 20);
            this.textBoxAssunto.TabIndex = 104;
            // 
            // labelHoraInicio
            // 
            this.labelHoraInicio.AutoSize = true;
            this.labelHoraInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHoraInicio.Location = new System.Drawing.Point(20, 220);
            this.labelHoraInicio.Name = "labelHoraInicio";
            this.labelHoraInicio.Size = new System.Drawing.Size(56, 13);
            this.labelHoraInicio.TabIndex = 103;
            this.labelHoraInicio.Text = "Hora Inicio";
            // 
            // labelExcluirCompromisso
            // 
            this.labelExcluirCompromisso.AutoSize = true;
            this.labelExcluirCompromisso.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExcluirCompromisso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelExcluirCompromisso.Location = new System.Drawing.Point(30, 8);
            this.labelExcluirCompromisso.Name = "labelExcluirCompromisso";
            this.labelExcluirCompromisso.Size = new System.Drawing.Size(171, 21);
            this.labelExcluirCompromisso.TabIndex = 101;
            this.labelExcluirCompromisso.Text = "Excluir Compromisso";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(137, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 100;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluir.Location = new System.Drawing.Point(23, 320);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 99;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // labelAssunto
            // 
            this.labelAssunto.AutoSize = true;
            this.labelAssunto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAssunto.Location = new System.Drawing.Point(20, 77);
            this.labelAssunto.Name = "labelAssunto";
            this.labelAssunto.Size = new System.Drawing.Size(44, 13);
            this.labelAssunto.TabIndex = 102;
            this.labelAssunto.Text = "Assunto";
            // 
            // rbLink
            // 
            this.rbLink.AutoSize = true;
            this.rbLink.Enabled = false;
            this.rbLink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbLink.Location = new System.Drawing.Point(22, 149);
            this.rbLink.Name = "rbLink";
            this.rbLink.Size = new System.Drawing.Size(45, 17);
            this.rbLink.TabIndex = 119;
            this.rbLink.TabStop = true;
            this.rbLink.Text = "Link";
            this.rbLink.UseVisualStyleBackColor = true;
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Enabled = false;
            this.rbLocal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbLocal.Location = new System.Drawing.Point(23, 113);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(49, 17);
            this.rbLocal.TabIndex = 118;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            // 
            // cbContato
            // 
            this.cbContato.AutoSize = true;
            this.cbContato.Enabled = false;
            this.cbContato.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbContato.Location = new System.Drawing.Point(22, 286);
            this.cbContato.Name = "cbContato";
            this.cbContato.Size = new System.Drawing.Size(65, 17);
            this.cbContato.TabIndex = 120;
            this.cbContato.Text = "Contato";
            this.cbContato.UseVisualStyleBackColor = true;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelResultado.Location = new System.Drawing.Point(12, 348);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 13);
            this.labelResultado.TabIndex = 121;
            // 
            // TelaExcluirCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(233, 367);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.cbContato);
            this.Controls.Add(this.rbLink);
            this.Controls.Add(this.rbLocal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCompromissos);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.maskedTextBoxHoraFim);
            this.Controls.Add(this.maskedTextBoxHoraInicio);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.comboBoxContatos);
            this.Controls.Add(this.labelHoraTermino);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.textBoxAssunto);
            this.Controls.Add(this.labelHoraInicio);
            this.Controls.Add(this.labelAssunto);
            this.Controls.Add(this.labelExcluirCompromisso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaExcluirCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaExcluirCompromisso";
            this.Load += new System.EventHandler(this.TelaExcluirCompromisso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCompromissos;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraFim;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.ComboBox comboBoxContatos;
        private System.Windows.Forms.Label labelHoraTermino;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.Label labelHoraInicio;
        private System.Windows.Forms.Label labelExcluirCompromisso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label labelAssunto;
        private System.Windows.Forms.RadioButton rbLink;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.CheckBox cbContato;
        private System.Windows.Forms.Label labelResultado;
    }
}