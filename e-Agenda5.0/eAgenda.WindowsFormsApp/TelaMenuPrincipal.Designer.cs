
namespace eAgenda.WindowsFormsApp
{
    partial class TelaMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenuPrincipal));
            this.labelEAgenda = new System.Windows.Forms.Label();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnCompromissos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEAgenda
            // 
            this.labelEAgenda.AutoSize = true;
            this.labelEAgenda.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEAgenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEAgenda.Location = new System.Drawing.Point(33, 9);
            this.labelEAgenda.Name = "labelEAgenda";
            this.labelEAgenda.Size = new System.Drawing.Size(83, 21);
            this.labelEAgenda.TabIndex = 0;
            this.labelEAgenda.Text = "eAgenda";
            this.labelEAgenda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTarefas
            // 
            this.btnTarefas.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarefas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTarefas.Location = new System.Drawing.Point(32, 38);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(84, 23);
            this.btnTarefas.TabIndex = 1;
            this.btnTarefas.TabStop = false;
            this.btnTarefas.Text = "Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnContatos
            // 
            this.btnContatos.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContatos.Location = new System.Drawing.Point(32, 67);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(84, 23);
            this.btnContatos.TabIndex = 2;
            this.btnContatos.TabStop = false;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // btnCompromissos
            // 
            this.btnCompromissos.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompromissos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCompromissos.Location = new System.Drawing.Point(32, 96);
            this.btnCompromissos.Name = "btnCompromissos";
            this.btnCompromissos.Size = new System.Drawing.Size(84, 23);
            this.btnCompromissos.TabIndex = 3;
            this.btnCompromissos.TabStop = false;
            this.btnCompromissos.Text = "Compromissos";
            this.btnCompromissos.UseVisualStyleBackColor = true;
            this.btnCompromissos.Click += new System.EventHandler(this.btnCompromissos_Click);
            // 
            // TelaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(148, 131);
            this.Controls.Add(this.btnCompromissos);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.btnTarefas);
            this.Controls.Add(this.labelEAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.TelaMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEAgenda;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnCompromissos;
    }
}

