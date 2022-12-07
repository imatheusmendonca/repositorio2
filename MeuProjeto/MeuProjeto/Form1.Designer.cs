namespace MeuProjeto
{
    partial class Form1
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
            this.botao1 = new System.Windows.Forms.Button();
            this.primeiraMensagem = new System.Windows.Forms.Label();
            this.botao2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chega = new System.Windows.Forms.Button();
            this.ultima = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.BackColor = System.Drawing.Color.Yellow;
            this.botao1.Font = new System.Drawing.Font("Broadway", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao1.ForeColor = System.Drawing.Color.Blue;
            this.botao1.Location = new System.Drawing.Point(12, 12);
            this.botao1.Name = "botao1";
            this.botao1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.botao1.Size = new System.Drawing.Size(482, 237);
            this.botao1.TabIndex = 0;
            this.botao1.Text = "CLIQUE AQUI!";
            this.botao1.UseVisualStyleBackColor = false;
            this.botao1.Click += new System.EventHandler(this.button1_Click);
            // 
            // primeiraMensagem
            // 
            this.primeiraMensagem.AutoSize = true;
            this.primeiraMensagem.Font = new System.Drawing.Font("Old English Text MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primeiraMensagem.Location = new System.Drawing.Point(12, 265);
            this.primeiraMensagem.Name = "primeiraMensagem";
            this.primeiraMensagem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.primeiraMensagem.Size = new System.Drawing.Size(217, 44);
            this.primeiraMensagem.TabIndex = 1;
            this.primeiraMensagem.Text = "Surpresa!!!!";
            this.primeiraMensagem.Click += new System.EventHandler(this.primeiraMensagem_Click);
            // 
            // botao2
            // 
            this.botao2.BackColor = System.Drawing.Color.Yellow;
            this.botao2.Cursor = System.Windows.Forms.Cursors.No;
            this.botao2.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao2.Location = new System.Drawing.Point(407, 216);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(252, 93);
            this.botao2.TabIndex = 2;
            this.botao2.Text = "Saiba Mais";
            this.botao2.UseMnemonic = false;
            this.botao2.UseVisualStyleBackColor = false;
            this.botao2.Click += new System.EventHandler(this.botao2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Clarendon Blk BT", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // chega
            // 
            this.chega.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chega.Location = new System.Drawing.Point(583, 77);
            this.chega.Name = "chega";
            this.chega.Size = new System.Drawing.Size(113, 49);
            this.chega.TabIndex = 4;
            this.chega.Text = "FIMMM";
            this.chega.UseVisualStyleBackColor = true;
            this.chega.Click += new System.EventHandler(this.chega_Click);
            // 
            // ultima
            // 
            this.ultima.AutoSize = true;
            this.ultima.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultima.Location = new System.Drawing.Point(609, 129);
            this.ultima.Name = "ultima";
            this.ultima.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ultima.Size = new System.Drawing.Size(153, 31);
            this.ultima.TabIndex = 5;
            this.ultima.Text = "CHEGAA!!";
            this.ultima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ultima);
            this.Controls.Add(this.chega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.primeiraMensagem);
            this.Controls.Add(this.botao1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Label primeiraMensagem;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chega;
        private System.Windows.Forms.Label ultima;
    }
}

