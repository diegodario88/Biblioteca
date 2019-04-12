namespace turma05
{
    partial class Devolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucao));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.txtEmprestimo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLeitor = new System.Windows.Forms.Label();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o Nome do Leitor";
            // 
            // txtLeitor
            // 
            this.txtLeitor.Location = new System.Drawing.Point(33, 64);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.Size = new System.Drawing.Size(397, 32);
            this.txtLeitor.TabIndex = 1;
            this.txtLeitor.TextChanged += new System.EventHandler(this.txtLeitor_TextChanged);
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(450, 64);
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(66, 32);
            this.txtIdLeitor.TabIndex = 2;
            // 
            // txtEmprestimo
            // 
            this.txtEmprestimo.Location = new System.Drawing.Point(540, 64);
            this.txtEmprestimo.Mask = "##/##/####";
            this.txtEmprestimo.Name = "txtEmprestimo";
            this.txtEmprestimo.Size = new System.Drawing.Size(175, 32);
            this.txtEmprestimo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de Empréstimo";
            // 
            // lblLeitor
            // 
            this.lblLeitor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLeitor.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeitor.Location = new System.Drawing.Point(33, 99);
            this.lblLeitor.Name = "lblLeitor";
            this.lblLeitor.Size = new System.Drawing.Size(397, 37);
            this.lblLeitor.TabIndex = 6;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(450, 174);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(66, 32);
            this.txtIdLivro.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Livro";
            // 
            // lblLivro
            // 
            this.lblLivro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLivro.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivro.Location = new System.Drawing.Point(33, 171);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(397, 37);
            this.lblLivro.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "#";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(536, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Data de Devolução";
            // 
            // txtDevolucao
            // 
            this.txtDevolucao.Location = new System.Drawing.Point(540, 176);
            this.txtDevolucao.Mask = "##/##/####";
            this.txtDevolucao.Name = "txtDevolucao";
            this.txtDevolucao.Size = new System.Drawing.Size(175, 32);
            this.txtDevolucao.TabIndex = 11;
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(33, 229);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 28;
            this.data.Size = new System.Drawing.Size(682, 150);
            this.data.TabIndex = 13;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VerificaLivros);
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::turma05.Properties.Resources.btn_salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(33, 385);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(191, 100);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Cadastrar Devolução";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(393, 454);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(126, 32);
            this.txtDias.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Dias de Atraso";
            // 
            // txtMulta
            // 
            this.txtMulta.Location = new System.Drawing.Point(598, 453);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(117, 32);
            this.txtMulta.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(594, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Multa";
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 540);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDevolucao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.txtIdLivro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLeitor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmprestimo);
            this.Controls.Add(this.txtIdLeitor);
            this.Controls.Add(this.txtLeitor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Devolucao";
            this.Text = "Sistema de Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.MaskedTextBox txtEmprestimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLeitor;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtDevolucao;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.Label label10;
    }
}