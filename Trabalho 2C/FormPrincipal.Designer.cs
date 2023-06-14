namespace Trabalho_2C
{
    partial class FormPrincipal
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
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.cmbDisciplinas = new System.Windows.Forms.ComboBox();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.grpAlternativas = new System.Windows.Forms.GroupBox();
            this.lblE = new System.Windows.Forms.Label();
            this.rdbE = new System.Windows.Forms.RadioButton();
            this.lblD = new System.Windows.Forms.Label();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.lblC = new System.Windows.Forms.Label();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.lblB = new System.Windows.Forms.Label();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.btnResponder = new System.Windows.Forms.Button();
            this.btnProximaPergunta = new System.Windows.Forms.Button();
            this.txtResolucao = new System.Windows.Forms.TextBox();
            this.lblResolucao = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.prbAcertos = new System.Windows.Forms.ProgressBar();
            this.grpAlternativas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(8, 13);
            this.lblDisciplina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplina.TabIndex = 0;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // cmbDisciplinas
            // 
            this.cmbDisciplinas.FormattingEnabled = true;
            this.cmbDisciplinas.Location = new System.Drawing.Point(63, 11);
            this.cmbDisciplinas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDisciplinas.Name = "cmbDisciplinas";
            this.cmbDisciplinas.Size = new System.Drawing.Size(185, 21);
            this.cmbDisciplinas.TabIndex = 1;
            this.cmbDisciplinas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Location = new System.Drawing.Point(8, 36);
            this.lblEnunciado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(58, 13);
            this.lblEnunciado.TabIndex = 2;
            this.lblEnunciado.Text = "Enunciado";
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(11, 58);
            this.txtEnunciado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(525, 100);
            this.txtEnunciado.TabIndex = 3;
            // 
            // grpAlternativas
            // 
            this.grpAlternativas.Controls.Add(this.lblE);
            this.grpAlternativas.Controls.Add(this.rdbE);
            this.grpAlternativas.Controls.Add(this.lblD);
            this.grpAlternativas.Controls.Add(this.rdbD);
            this.grpAlternativas.Controls.Add(this.lblC);
            this.grpAlternativas.Controls.Add(this.rdbC);
            this.grpAlternativas.Controls.Add(this.lblB);
            this.grpAlternativas.Controls.Add(this.rdbB);
            this.grpAlternativas.Controls.Add(this.lblA);
            this.grpAlternativas.Controls.Add(this.rdbA);
            this.grpAlternativas.Location = new System.Drawing.Point(11, 160);
            this.grpAlternativas.Margin = new System.Windows.Forms.Padding(2);
            this.grpAlternativas.Name = "grpAlternativas";
            this.grpAlternativas.Padding = new System.Windows.Forms.Padding(2);
            this.grpAlternativas.Size = new System.Drawing.Size(524, 159);
            this.grpAlternativas.TabIndex = 4;
            this.grpAlternativas.TabStop = false;
            this.grpAlternativas.Text = "Alternativas";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(6, 135);
            this.lblE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(14, 13);
            this.lblE.TabIndex = 9;
            this.lblE.Text = "E";
            // 
            // rdbE
            // 
            this.rdbE.AutoSize = true;
            this.rdbE.Location = new System.Drawing.Point(26, 134);
            this.rdbE.Margin = new System.Windows.Forms.Padding(2);
            this.rdbE.Name = "rdbE";
            this.rdbE.Size = new System.Drawing.Size(14, 13);
            this.rdbE.TabIndex = 8;
            this.rdbE.TabStop = true;
            this.rdbE.UseVisualStyleBackColor = true;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(6, 105);
            this.lblD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(15, 13);
            this.lblD.TabIndex = 7;
            this.lblD.Text = "D";
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Location = new System.Drawing.Point(26, 103);
            this.rdbD.Margin = new System.Windows.Forms.Padding(2);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(14, 13);
            this.rdbD.TabIndex = 6;
            this.rdbD.TabStop = true;
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(6, 76);
            this.lblC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "C";
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Location = new System.Drawing.Point(26, 75);
            this.rdbC.Margin = new System.Windows.Forms.Padding(2);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(14, 13);
            this.rdbC.TabIndex = 4;
            this.rdbC.TabStop = true;
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(6, 46);
            this.lblB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "B";
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Location = new System.Drawing.Point(26, 45);
            this.rdbB.Margin = new System.Windows.Forms.Padding(2);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(14, 13);
            this.rdbB.TabIndex = 2;
            this.rdbB.TabStop = true;
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(6, 18);
            this.lblA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A";
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Location = new System.Drawing.Point(26, 16);
            this.rdbA.Margin = new System.Windows.Forms.Padding(2);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(14, 13);
            this.rdbA.TabIndex = 0;
            this.rdbA.TabStop = true;
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(11, 322);
            this.btnResponder.Margin = new System.Windows.Forms.Padding(2);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(149, 34);
            this.btnResponder.TabIndex = 5;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // btnProximaPergunta
            // 
            this.btnProximaPergunta.Location = new System.Drawing.Point(164, 322);
            this.btnProximaPergunta.Margin = new System.Windows.Forms.Padding(2);
            this.btnProximaPergunta.Name = "btnProximaPergunta";
            this.btnProximaPergunta.Size = new System.Drawing.Size(371, 34);
            this.btnProximaPergunta.TabIndex = 6;
            this.btnProximaPergunta.Text = "Próxima Pergunta";
            this.btnProximaPergunta.UseVisualStyleBackColor = true;
            this.btnProximaPergunta.Click += new System.EventHandler(this.btnProximaPergunta_Click);
            // 
            // txtResolucao
            // 
            this.txtResolucao.Location = new System.Drawing.Point(11, 390);
            this.txtResolucao.Margin = new System.Windows.Forms.Padding(2);
            this.txtResolucao.Multiline = true;
            this.txtResolucao.Name = "txtResolucao";
            this.txtResolucao.Size = new System.Drawing.Size(525, 100);
            this.txtResolucao.TabIndex = 7;
            // 
            // lblResolucao
            // 
            this.lblResolucao.AutoSize = true;
            this.lblResolucao.Location = new System.Drawing.Point(11, 373);
            this.lblResolucao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResolucao.Name = "lblResolucao";
            this.lblResolucao.Size = new System.Drawing.Size(141, 13);
            this.lblResolucao.TabIndex = 8;
            this.lblResolucao.Text = "Resolução com comentários";
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Location = new System.Drawing.Point(11, 494);
            this.lblAcertos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(74, 13);
            this.lblAcertos.TabIndex = 12;
            this.lblAcertos.Text = "0% de acertos";
            // 
            // prbAcertos
            // 
            this.prbAcertos.Location = new System.Drawing.Point(83, 494);
            this.prbAcertos.Margin = new System.Windows.Forms.Padding(2);
            this.prbAcertos.Name = "prbAcertos";
            this.prbAcertos.Size = new System.Drawing.Size(452, 13);
            this.prbAcertos.TabIndex = 11;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 527);
            this.Controls.Add(this.lblAcertos);
            this.Controls.Add(this.prbAcertos);
            this.Controls.Add(this.lblResolucao);
            this.Controls.Add(this.txtResolucao);
            this.Controls.Add(this.btnProximaPergunta);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.grpAlternativas);
            this.Controls.Add(this.txtEnunciado);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.cmbDisciplinas);
            this.Controls.Add(this.lblDisciplina);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aplicativo de Resolução de Questões CPII";
            this.grpAlternativas.ResumeLayout(false);
            this.grpAlternativas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.ComboBox cmbDisciplinas;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.GroupBox grpAlternativas;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.RadioButton rdbE;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.Button btnProximaPergunta;
        private System.Windows.Forms.TextBox txtResolucao;
        private System.Windows.Forms.Label lblResolucao;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.ProgressBar prbAcertos;
    }
}

