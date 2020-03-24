namespace CalendarioSignos
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
            this.lbl_Dia = new System.Windows.Forms.Label();
            this.lbl_Mes = new System.Windows.Forms.Label();
            this.txt_Dia = new System.Windows.Forms.TextBox();
            this.txt_Mes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Executar = new System.Windows.Forms.Button();
            this.txt_Resultado2 = new System.Windows.Forms.RichTextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.AutoSize = true;
            this.lbl_Dia.Location = new System.Drawing.Point(13, 39);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(103, 13);
            this.lbl_Dia.TabIndex = 0;
            this.lbl_Dia.Text = "Dia de Nascimento: ";
            // 
            // lbl_Mes
            // 
            this.lbl_Mes.AutoSize = true;
            this.lbl_Mes.Location = new System.Drawing.Point(13, 93);
            this.lbl_Mes.Name = "lbl_Mes";
            this.lbl_Mes.Size = new System.Drawing.Size(92, 13);
            this.lbl_Mes.TabIndex = 1;
            this.lbl_Mes.Text = "Mês Nascimento: ";
            // 
            // txt_Dia
            // 
            this.txt_Dia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Dia.Location = new System.Drawing.Point(122, 37);
            this.txt_Dia.MaxLength = 2;
            this.txt_Dia.Name = "txt_Dia";
            this.txt_Dia.Size = new System.Drawing.Size(50, 20);
            this.txt_Dia.TabIndex = 1;
            // 
            // txt_Mes
            // 
            this.txt_Mes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mes.Location = new System.Drawing.Point(122, 91);
            this.txt_Mes.MaxLength = 2;
            this.txt_Mes.Name = "txt_Mes";
            this.txt_Mes.Size = new System.Drawing.Size(50, 20);
            this.txt_Mes.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Resultado2);
            this.groupBox1.Location = new System.Drawing.Point(16, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 239);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // btn_Executar
            // 
            this.btn_Executar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Executar.Location = new System.Drawing.Point(16, 128);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(75, 23);
            this.btn_Executar.TabIndex = 3;
            this.btn_Executar.Text = "&EXECUTAR";
            this.btn_Executar.UseVisualStyleBackColor = false;
            this.btn_Executar.Click += new System.EventHandler(this.btn_Executar_Click);
            // 
            // txt_Resultado2
            // 
            this.txt_Resultado2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Resultado2.Location = new System.Drawing.Point(10, 19);
            this.txt_Resultado2.Name = "txt_Resultado2";
            this.txt_Resultado2.ReadOnly = true;
            this.txt_Resultado2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txt_Resultado2.Size = new System.Drawing.Size(435, 214);
            this.txt_Resultado2.TabIndex = 4;
            this.txt_Resultado2.Text = "";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Limpar.BackColor = System.Drawing.Color.Red;
            this.btn_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Limpar.Location = new System.Drawing.Point(97, 128);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpar.TabIndex = 4;
            this.btn_Limpar.Text = "&LIMPAR";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 423);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Executar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Mes);
            this.Controls.Add(this.txt_Dia);
            this.Controls.Add(this.lbl_Mes);
            this.Controls.Add(this.lbl_Dia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendário Signos";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Dia;
        private System.Windows.Forms.Label lbl_Mes;
        private System.Windows.Forms.TextBox txt_Dia;
        private System.Windows.Forms.TextBox txt_Mes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Executar;
        private System.Windows.Forms.RichTextBox txt_Resultado2;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

