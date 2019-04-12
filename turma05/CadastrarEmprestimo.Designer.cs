namespace turma05
{
    partial class CadastrarEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarEmprestimo));
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.lblLeitor = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.txtRetirada = new System.Windows.Forms.MaskedTextBox();
            this.txtDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLeitor
            // 
            this.txtLeitor.Location = new System.Drawing.Point(51, 48);
            this.txtLeitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.Size = new System.Drawing.Size(439, 34);
            this.txtLeitor.TabIndex = 0;
            this.txtLeitor.TextChanged += new System.EventHandler(this.txtLeitor_TextChanged);
            // 
            // txtLivro
            // 
            this.txtLivro.Location = new System.Drawing.Point(51, 182);
            this.txtLivro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(439, 34);
            this.txtLivro.TabIndex = 1;
            this.txtLivro.TextChanged += new System.EventHandler(this.txtLivro_TextChanged);
            // 
            // lblLeitor
            // 
            this.lblLeitor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLeitor.Location = new System.Drawing.Point(51, 87);
            this.lblLeitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeitor.Name = "lblLeitor";
            this.lblLeitor.Size = new System.Drawing.Size(439, 53);
            this.lblLeitor.TabIndex = 2;
            this.lblLeitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLivro
            // 
            this.lblLivro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLivro.Location = new System.Drawing.Point(51, 221);
            this.lblLivro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(439, 53);
            this.lblLivro.TabIndex = 3;
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(518, 48);
            this.txtIdLeitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(82, 34);
            this.txtIdLeitor.TabIndex = 4;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(518, 182);
            this.txtIdLivro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(82, 34);
            this.txtIdLivro.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Leitor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Livro";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(51, 293);
            this.data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 28;
            this.data.Size = new System.Drawing.Size(731, 203);
            this.data.TabIndex = 8;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CadastraCampos);
            // 
            // txtRetirada
            // 
            this.txtRetirada.Location = new System.Drawing.Point(809, 326);
            this.txtRetirada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRetirada.Mask = "##/##/####";
            this.txtRetirada.Name = "txtRetirada";
            this.txtRetirada.Size = new System.Drawing.Size(121, 34);
            this.txtRetirada.TabIndex = 9;
            // 
            // txtDevolucao
            // 
            this.txtDevolucao.Location = new System.Drawing.Point(809, 422);
            this.txtDevolucao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDevolucao.Mask = "##/##/####";
            this.txtDevolucao.Name = "txtDevolucao";
            this.txtDevolucao.Size = new System.Drawing.Size(121, 34);
            this.txtDevolucao.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(804, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Retirada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(804, 391);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Devolução";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::turma05.Properties.Resources.btn_salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(51, 517);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 104);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "#";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "#";
            // 
            // CadastrarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 647);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDevolucao);
            this.Controls.Add(this.txtRetirada);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdLivro);
            this.Controls.Add(this.txtIdLeitor);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.lblLeitor);
            this.Controls.Add(this.txtLivro);
            this.Controls.Add(this.txtLeitor);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CadastrarEmprestimo";
            this.Text = "Sistema de Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.Label lblLeitor;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.MaskedTextBox txtRetirada;
        private System.Windows.Forms.MaskedTextBox txtDevolucao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}