using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_2C
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPrincipal form1 = new FormPrincipal();

            form1.ShowDialog();

            form1.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Inserir inserir = new Inserir();
            inserir.ShowDialog();
            inserir.Close();
        }
    }
}
