namespace Trabalho_2C
{
    partial class FormInicial
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnResponder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(28, 27);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(195, 58);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnResponder
            // 
            this.btnResponder.Location = new System.Drawing.Point(262, 27);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(195, 58);
            this.btnResponder.TabIndex = 1;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 122);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.btnInserir);
            this.Name = "FormInicial";
            this.Text = "InitForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnResponder;
    }
}