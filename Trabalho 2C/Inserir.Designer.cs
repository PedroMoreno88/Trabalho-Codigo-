namespace Trabalho_2C
{
    partial class Inserir
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
            this.txb_Enunciado = new System.Windows.Forms.TextBox();
            this.txb_OpcA = new System.Windows.Forms.TextBox();
            this.txb_OpcC = new System.Windows.Forms.TextBox();
            this.txb_OpcB = new System.Windows.Forms.TextBox();
            this.txb_OpcE = new System.Windows.Forms.TextBox();
            this.txb_OpcD = new System.Windows.Forms.TextBox();
            this.cmbDisciplinas = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txb_Solucao = new System.Windows.Forms.TextBox();
            this.txb_Gabarito = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_Enunciado
            // 
            this.txb_Enunciado.Location = new System.Drawing.Point(51, 83);
            this.txb_Enunciado.Name = "txb_Enunciado";
            this.txb_Enunciado.Size = new System.Drawing.Size(100, 20);
            this.txb_Enunciado.TabIndex = 0;
            // 
            // txb_OpcA
            // 
            this.txb_OpcA.Location = new System.Drawing.Point(51, 109);
            this.txb_OpcA.Name = "txb_OpcA";
            this.txb_OpcA.Size = new System.Drawing.Size(100, 20);
            this.txb_OpcA.TabIndex = 1;
            // 
            // txb_OpcC
            // 
            this.txb_OpcC.Location = new System.Drawing.Point(51, 161);
            this.txb_OpcC.Name = "txb_OpcC";
            this.txb_OpcC.Size = new System.Drawing.Size(100, 20);
            this.txb_OpcC.TabIndex = 3;
            // 
            // txb_OpcB
            // 
            this.txb_OpcB.Location = new System.Drawing.Point(51, 135);
            this.txb_OpcB.Name = "txb_OpcB";
            this.txb_OpcB.Size = new System.Drawing.Size(100, 20);
            this.txb_OpcB.TabIndex = 2;
            // 
            // txb_OpcE
            // 
            this.txb_OpcE.Location = new System.Drawing.Point(51, 213);
            this.txb_OpcE.Name = "txb_OpcE";
            this.txb_OpcE.Size = new System.Drawing.Size(100, 20);
            this.txb_OpcE.TabIndex = 5;
            // 
            // txb_OpcD
            // 
            this.txb_OpcD.Location = new System.Drawing.Point(51, 187);
            this.txb_OpcD.Name = "txb_OpcD";
            this.txb_OpcD.Size = new System.Drawing.Size(100, 20);
            this.txb_OpcD.TabIndex = 4;
            // 
            // cmbDisciplinas
            // 
            this.cmbDisciplinas.FormattingEnabled = true;
            this.cmbDisciplinas.Location = new System.Drawing.Point(51, 57);
            this.cmbDisciplinas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDisciplinas.Name = "cmbDisciplinas";
            this.cmbDisciplinas.Size = new System.Drawing.Size(185, 21);
            this.cmbDisciplinas.TabIndex = 7;
            this.cmbDisciplinas.SelectedIndexChanged += new System.EventHandler(this.cmbDisciplinas_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "gravar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txb_Solucao
            // 
            this.txb_Solucao.Location = new System.Drawing.Point(51, 239);
            this.txb_Solucao.Name = "txb_Solucao";
            this.txb_Solucao.Size = new System.Drawing.Size(100, 20);
            this.txb_Solucao.TabIndex = 9;
            // 
            // txb_Gabarito
            // 
            this.txb_Gabarito.Location = new System.Drawing.Point(51, 265);
            this.txb_Gabarito.Name = "txb_Gabarito";
            this.txb_Gabarito.Size = new System.Drawing.Size(100, 20);
            this.txb_Gabarito.TabIndex = 10;
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_Gabarito);
            this.Controls.Add(this.txb_Solucao);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbDisciplinas);
            this.Controls.Add(this.txb_OpcE);
            this.Controls.Add(this.txb_OpcD);
            this.Controls.Add(this.txb_OpcC);
            this.Controls.Add(this.txb_OpcB);
            this.Controls.Add(this.txb_OpcA);
            this.Controls.Add(this.txb_Enunciado);
            this.Name = "Inserir";
            this.Text = "Inserir";
            this.Load += new System.EventHandler(this.Inserir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Enunciado;
        private System.Windows.Forms.TextBox txb_OpcA;
        private System.Windows.Forms.TextBox txb_OpcC;
        private System.Windows.Forms.TextBox txb_OpcB;
        private System.Windows.Forms.TextBox txb_OpcE;
        private System.Windows.Forms.TextBox txb_OpcD;
        private System.Windows.Forms.ComboBox cmbDisciplinas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txb_Solucao;
        private System.Windows.Forms.TextBox txb_Gabarito;
    }
}