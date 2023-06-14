namespace Sistema_Onibus
{
    partial class TelaPrincipal
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
            this.btnMotoristas = new System.Windows.Forms.Button();
            this.telaPainel = new System.Windows.Forms.Panel();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnOnibus = new System.Windows.Forms.Button();
            this.btnRotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMotoristas
            // 
            this.btnMotoristas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotoristas.Location = new System.Drawing.Point(5, 26);
            this.btnMotoristas.Name = "btnMotoristas";
            this.btnMotoristas.Size = new System.Drawing.Size(102, 40);
            this.btnMotoristas.TabIndex = 0;
            this.btnMotoristas.Text = "Motoristas";
            this.btnMotoristas.UseVisualStyleBackColor = true;
            this.btnMotoristas.Click += new System.EventHandler(this.btnMotoristas_Click);
            // 
            // telaPainel
            // 
            this.telaPainel.Location = new System.Drawing.Point(113, 6);
            this.telaPainel.Name = "telaPainel";
            this.telaPainel.Size = new System.Drawing.Size(719, 522);
            this.telaPainel.TabIndex = 1;
            this.telaPainel.Paint += new System.Windows.Forms.PaintEventHandler(this.telaPainel_Paint);
            // 
            // btnAluno
            // 
            this.btnAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.Location = new System.Drawing.Point(5, 105);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(102, 40);
            this.btnAluno.TabIndex = 2;
            this.btnAluno.Text = "Alunos";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnOnibus
            // 
            this.btnOnibus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnibus.Location = new System.Drawing.Point(5, 181);
            this.btnOnibus.Name = "btnOnibus";
            this.btnOnibus.Size = new System.Drawing.Size(102, 40);
            this.btnOnibus.TabIndex = 3;
            this.btnOnibus.Text = "Ônibus";
            this.btnOnibus.UseVisualStyleBackColor = true;
            this.btnOnibus.Click += new System.EventHandler(this.btnOnibus_Click);
            // 
            // btnRotas
            // 
            this.btnRotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotas.Location = new System.Drawing.Point(5, 266);
            this.btnRotas.Name = "btnRotas";
            this.btnRotas.Size = new System.Drawing.Size(102, 40);
            this.btnRotas.TabIndex = 4;
            this.btnRotas.Text = "Rotas";
            this.btnRotas.UseVisualStyleBackColor = true;
            this.btnRotas.Click += new System.EventHandler(this.btnRotas_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 526);
            this.Controls.Add(this.btnRotas);
            this.Controls.Add(this.btnOnibus);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.telaPainel);
            this.Controls.Add(this.btnMotoristas);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMotoristas;
        private System.Windows.Forms.Panel telaPainel;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnOnibus;
        private System.Windows.Forms.Button btnRotas;
    }
}