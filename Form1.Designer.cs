namespace CALCULADORA_SIMPLES
{
    partial class FormCalcular
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbnum1 = new System.Windows.Forms.Label();
            this.tBNum1 = new System.Windows.Forms.TextBox();
            this.lBNum2 = new System.Windows.Forms.Label();
            this.tBNum2 = new System.Windows.Forms.TextBox();
            this.TbResultado = new System.Windows.Forms.Label();
            this.lBResposta = new System.Windows.Forms.Label();
            this.bTsair = new System.Windows.Forms.Button();
            this.bTResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnum1
            // 
            this.lbnum1.AutoSize = true;
            this.lbnum1.Location = new System.Drawing.Point(23, 23);
            this.lbnum1.Name = "lbnum1";
            this.lbnum1.Size = new System.Drawing.Size(56, 13);
            this.lbnum1.TabIndex = 0;
            this.lbnum1.Text = "Número 1:";
            // 
            // tBNum1
            // 
            this.tBNum1.Location = new System.Drawing.Point(85, 20);
            this.tBNum1.Name = "tBNum1";
            this.tBNum1.Size = new System.Drawing.Size(100, 20);
            this.tBNum1.TabIndex = 1;
            this.tBNum1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lBNum2
            // 
            this.lBNum2.AutoSize = true;
            this.lBNum2.Location = new System.Drawing.Point(23, 71);
            this.lBNum2.Name = "lBNum2";
            this.lBNum2.Size = new System.Drawing.Size(56, 13);
            this.lBNum2.TabIndex = 2;
            this.lBNum2.Text = "Número 2:";
            // 
            // tBNum2
            // 
            this.tBNum2.Location = new System.Drawing.Point(85, 64);
            this.tBNum2.Name = "tBNum2";
            this.tBNum2.Size = new System.Drawing.Size(100, 20);
            this.tBNum2.TabIndex = 3;
            // 
            // TbResultado
            // 
            this.TbResultado.AutoSize = true;
            this.TbResultado.Location = new System.Drawing.Point(24, 115);
            this.TbResultado.Name = "TbResultado";
            this.TbResultado.Size = new System.Drawing.Size(55, 13);
            this.TbResultado.TabIndex = 4;
            this.TbResultado.Text = "Resultado";
            // 
            // lBResposta
            // 
            this.lBResposta.AutoSize = true;
            this.lBResposta.Location = new System.Drawing.Point(97, 115);
            this.lBResposta.Name = "lBResposta";
            this.lBResposta.Size = new System.Drawing.Size(13, 13);
            this.lBResposta.TabIndex = 5;
            this.lBResposta.Text = "0";
            // 
            // bTsair
            // 
            this.bTsair.Location = new System.Drawing.Point(191, 110);
            this.bTsair.Name = "bTsair";
            this.bTsair.Size = new System.Drawing.Size(75, 23);
            this.bTsair.TabIndex = 6;
            this.bTsair.Text = "Sair";
            this.bTsair.UseVisualStyleBackColor = true;
            this.bTsair.Click += new System.EventHandler(this.BTsair_Click);
            // 
            // bTResultado
            // 
            this.bTResultado.Location = new System.Drawing.Point(191, 62);
            this.bTResultado.Name = "bTResultado";
            this.bTResultado.Size = new System.Drawing.Size(75, 23);
            this.bTResultado.TabIndex = 7;
            this.bTResultado.Text = "Resultado";
            this.bTResultado.UseVisualStyleBackColor = true;
            this.bTResultado.Click += new System.EventHandler(this.BTResultado_Click);
            // 
            // FormCalcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 148);
            this.Controls.Add(this.bTResultado);
            this.Controls.Add(this.bTsair);
            this.Controls.Add(this.lBResposta);
            this.Controls.Add(this.TbResultado);
            this.Controls.Add(this.tBNum2);
            this.Controls.Add(this.lBNum2);
            this.Controls.Add(this.tBNum1);
            this.Controls.Add(this.lbnum1);
            this.Name = "FormCalcular";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnum1;
        private System.Windows.Forms.TextBox tBNum1;
        private System.Windows.Forms.Label lBNum2;
        private System.Windows.Forms.TextBox tBNum2;
        private System.Windows.Forms.Label TbResultado;
        private System.Windows.Forms.Label lBResposta;
        private System.Windows.Forms.Button bTsair;
        private System.Windows.Forms.Button bTResultado;
    }
}

