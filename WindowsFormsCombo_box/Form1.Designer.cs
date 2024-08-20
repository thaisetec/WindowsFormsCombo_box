namespace WindowsFormsCombo_box
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblqtde = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(224, 29);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(431, 20);
            this.txtTexto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(224, 81);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(181, 51);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir no combo";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ordenar o combo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboLista
            // 
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Location = new System.Drawing.Point(228, 164);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(427, 21);
            this.cboLista.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exibir dados do combo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblqtde
            // 
            this.lblqtde.AutoSize = true;
            this.lblqtde.Location = new System.Drawing.Point(167, 264);
            this.lblqtde.Name = "lblqtde";
            this.lblqtde.Size = new System.Drawing.Size(102, 13);
            this.lblqtde.TabIndex = 6;
            this.lblqtde.Text = "Quantidade de itens";
            this.lblqtde.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 370);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(427, 20);
            this.textBox2.TabIndex = 7;
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(228, 403);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(427, 20);
            this.txtConteudo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Índice do combo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Texto do combo";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(356, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 30);
            this.button4.TabIndex = 12;
            this.button4.Text = "Remover do combo";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblqtde);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboLista;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblqtde;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
    }
}

