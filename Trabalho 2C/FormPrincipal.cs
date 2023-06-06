using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Atenção: o arquivo executável (.exe) contendo o seu programa compilado assim como a pasta de Questões podem ser encontrados na pasta /bin
// Confira a pasta /bin

namespace Trabalho_2C
{
    
    public partial class FormPrincipal : Form
    {
        int j = 0;
        // Questão atual
        Questão questao;
        // diretorio atual
        string diretorioAtual;


        public FormPrincipal()
        {

            // Não precisa se preocupar aqui -----------------------

            // Inicializa os componentes do formulário (método interno que "arruma" os controles na tela de acordo com o que foi desenhado no Designer
            InitializeComponent();

            // Recebe o diretório em que o programa propriamente (arquivo .exe) está sendo executado
            diretorioAtual = Directory.GetCurrentDirectory();

            // Dado o diretório atual, cria um caminho que aponta para a pasta Questões
            diretorioAtual += @"\..\..\..\Questões\";

            // Método que retorna um vetor de strings contendo o diretório de todas as pastas que estão dentro da pasta Questões
            string[] diretorios = Directory.GetDirectories(diretorioAtual);

            // Percorre cada string dentro do vetor de strings
            for(int i = 0; i < diretorios.Length; i++)
            {
                // Para cada caminho, quero obter apenas o nome da disciplina
                string nomeDaDisciplina = diretorios[i].Remove(0, diretorioAtual.Length);
                // Vou adicionar o nome da disciplina aos itens da comboBox1
                cmbDisciplinas.Items.Add(nomeDaDisciplina);
            }
            // Não precisa se preocupar aqui -----------------------

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
            rdbE.Checked = false;


            // Não precisa se preocupar aqui -----------------------
            // Define o diretório da matéria selecionada na comboBox1
            string diretorioMateria = diretorioAtual + cmbDisciplinas.Text;
            // Obtém um vetor de strings contendo o diretório para todos os arquivos
            string[] arquivos = Directory.GetFiles(diretorioMateria, "*.txt");
            // Não precisa se preocupar aqui -----------------------

            // Caso não haja nenhum arquivo no diretorio da matéria selecionada, mostrar uma mensagem ao usuário
            if (arquivos.Length == 0)
            {
                questao = new Questão();
                MostrarPopup();

                questao.enunciado = null;
                questao.altA = null;
                questao.altB = null;
                questao.altC = null;
                questao.altD = null;
                questao.altE = null;
                txtEnunciado.Text = questao.enunciado;
                rdbA.Text = questao.altA;
                rdbB.Text = questao.altB;
                rdbD.Text = questao.altC;
                rdbC.Text = questao.altD;
                rdbE.Text = questao.altE;


            }
            // Caso haja algum arquivo no diretorio da matéria selecionada, o enunciado do primeiro exercício é carregado como exemplo
            else
            {
                // Cria objeto da classe Questão
                questao = new Questão();

                // Cria um leitor para ler as informações da questão
                StreamReader leitor = new StreamReader(arquivos[0]);

                // Preenche os atriburos de questão com as informações lidas do arquivo
                questao.enunciado = leitor.ReadLine();
                questao.altA = leitor.ReadLine();
                questao.altB = leitor.ReadLine();
                questao.altC = leitor.ReadLine();
                questao.altD = leitor.ReadLine();
                questao.altE = leitor.ReadLine();

                // Preenche os controles do formulário usando o objeto questão
                txtEnunciado.Text = questao.enunciado;
                rdbA.Text = questao.altA;
                rdbB.Text = questao.altB;
                rdbD.Text = questao.altC;
                rdbC.Text = questao.altD;
                rdbE.Text = questao.altE;
                leitor.Close();
            }
        }

        private void btnProximaPergunta_Click(object sender, EventArgs e)
        {
            j += 1;
            string diretorioMateria = diretorioAtual + cmbDisciplinas.Text;
            string[] arquivos = Directory.GetFiles(diretorioMateria, "*.txt");
            try
            {
                StreamReader leitor = new StreamReader(arquivos[j]);
                MessageBox.Show(arquivos[j]);
                questao.enunciado = leitor.ReadLine();
                questao.altA = leitor.ReadLine();
                questao.altB = leitor.ReadLine();
                questao.altC = leitor.ReadLine();
                questao.altD = leitor.ReadLine();
                questao.altE = leitor.ReadLine();

                // Preenche os controles do formulário usando o objeto questão
                txtEnunciado.Text = questao.enunciado;
                rdbA.Text = questao.altA;
                rdbB.Text = questao.altB;
                rdbD.Text = questao.altC;
                rdbC.Text = questao.altD;
                rdbE.Text = questao.altE;
            }
            catch (Exception ex)
            {

            }
        }
        private void MostrarPopup()
        {
            string title = "Aviso";
            string message = "A diciplina que você escolheu não \n possui questões!";
            int duration = 5000; // 5 segundos

            PopupNotification popup = new PopupNotification(title, message, duration);
            popup.Show();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            string diretorioMaterias = diretorioAtual + cmbDisciplinas.Text;
            string[] arquivos = Directory.GetFiles(diretorioMaterias, "*.txt");
            string[] linhas = File.ReadAllLines(arquivos[j]);
            

                string gabarito = linhas[6];
                string respostaUser = "";
            if (linhas.Length >= 7)
            {
                if (rdbA.Checked)
                {
                    respostaUser = lblA.Text;
                }
                if (rdbB.Checked)
                {
                    respostaUser = lblB.Text;
                }
                if (rdbC.Checked)
                {
                    respostaUser = lblC.Text;
                }
                if (rdbD.Checked)
                {
                    respostaUser = lblD.Text;
                }
                if (rdbE.Checked)
                {
                    respostaUser = lblE.Text;
                }

            }
            if (gabarito == respostaUser.ToLower())
            {
                MessageBox.Show("cer");
            }
            else
            {

            }
        }
    }
}
