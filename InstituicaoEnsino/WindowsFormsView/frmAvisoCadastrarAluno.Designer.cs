namespace WindowsFormsView
{
    partial class frmAvisoCadastrarAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltarCad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno cadastrado com sucesso !!";
            // 
            // btnVoltarCad
            // 
            this.btnVoltarCad.Location = new System.Drawing.Point(125, 117);
            this.btnVoltarCad.Name = "btnVoltarCad";
            this.btnVoltarCad.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarCad.TabIndex = 1;
            this.btnVoltarCad.Text = "Voltar";
            this.btnVoltarCad.UseVisualStyleBackColor = true;
            this.btnVoltarCad.Click += new System.EventHandler(this.btnVoltarCad_Click);
            // 
            // frmAvisoCadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 185);
            this.Controls.Add(this.btnVoltarCad);
            this.Controls.Add(this.label1);
            this.Name = "frmAvisoCadastrarAluno";
            this.Text = "frmAvisoCadastrarAluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarCad;
    }
}