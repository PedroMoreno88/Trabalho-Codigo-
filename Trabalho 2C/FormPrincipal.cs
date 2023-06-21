using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Atenção: o arquivo executável (.exe) contendo o seu programa compilado assim como a pasta de Questões podem ser encontrados na pasta /bin
// Confira a pasta /bin

namespace Trabalho_2C
{

    public partial class FormPrincipal : Form
    {
        string gabarito;
        int j = 0;
        // Questão atual
        Questão questao;
        // diretorio atual
        string diretorioAtual;
        int acertos = 0;


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
            for (int i = 0; i < diretorios.Length; i++)
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
            string diretorioMateria = diretorioAtual + cmbDisciplinas.Text;
            string[] arquivos = Directory.GetFiles(diretorioMateria, "*.txt");
            if (arquivos.Length > 0 && Path.GetFileName(arquivos[0]) == "config.txt")
            {
                cmbDisciplinas.Text = ""; // Limpa a seleção da disciplina
                rdbA.Checked = false; rdbB.Checked = false;
                rdbC.Checked = false; rdbD.Checked = false;
                rdbE.Checked = false;
                rdbA.Text = null; rdbB.Text = null;
                rdbC.Text = null; rdbD.Text = null;
                rdbE.Text = null;
                lblAcertos.Text = acertos + "% de acertos";
                txtEnunciado.Text = "";
                cmbDisciplinas.Enabled = true;
                cmbDisciplinas.Text = "";
                btnResponder.Enabled = false;
                btnProximaPergunta.Enabled = false;
                return; // Sai do método sem executar o restante do código
            }

            //Ir ao direitorio da pasta quantidadeAcertos
            string acertoPath = diretorioAtual + cmbDisciplinas.Text + @"\quantidadeAcertos" + ".txt";
            //Acessar o arquivo quantidadeAcertos
            using (StreamReader ler = new StreamReader(acertoPath))
            {
                //Ler o que esta dentro dele
                string conteudo = ler.ReadLine();
                //guarda oque esta nele na lbl acertos
                lblAcertos.Text = conteudo + "% de acertos";


                if (cmbDisciplinas.Text == null)
                {
                    // se nao tiver nada no cmb ele zera os acertos
                    acertos = 0;
                    // e atualiza o label
                    lblAcertos.Text = acertos + "% de acertos";
                }

            }
            //J = 0 para que ele acesse o primeiro arquivo
            j = 0;
            //desativar os radionButton
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
            rdbE.Checked = false;
            //limpar pontuação do user
            acertos = 0;
            // atualizar label
            lblAcertos.Text = acertos + "% de acertos";

            // Define o diretório da matéria selecionada na comboBox1

            // Obtém um vetor de strings contendo o diretório para todos os arquivos

            string[] linhas = File.ReadAllLines(arquivos[j]);

            // Caso não haja nenhum arquivo no diretorio da matéria selecionada, mostrar uma mensagem ao usuário
            if (arquivos.Length == 0)
            {
                questao = new Questão();
                //ele ira mostra um popup de aviso
                MostrarPopup();
                // e não ira puxar nenhum informação 
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

                // Habilitar btn
                btnProximaPergunta.Enabled = true;
                btnResponder.Enabled = true;
                leitor.Close();
            }
        }

        private void btnProximaPergunta_Click(object sender, EventArgs e)
        {
            txtResolucao.Text = null;
            j += 1;//toda vez que for ativo essa função o J atualiza

            string diretorioMateria = diretorioAtual + cmbDisciplinas.Text;
            string acertoPath = diretorioAtual + cmbDisciplinas.Text + @"\quantidadeAcertos" + ".txt";

            string[] arquivos = Directory.GetFiles(diretorioMateria, "*.txt");
            try
            {
                //puxa as informações da pasta e passa para a classe
                StreamReader leitor = new StreamReader(arquivos[j]);
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
                //novamente ler a pasta quantidadeAcertos
                using (StreamReader ler = new StreamReader(acertoPath))
                {
                    string conteudo = ler.ReadLine();

                    lblAcertos.Text = conteudo + "% de acertos";
                }

            }
            catch (Exception ex)
            {

            }

            int indiceAtual = j;
            while (indiceAtual + 1 < arquivos.Length && Path.GetFileName(arquivos[indiceAtual]) == "config.txt" || indiceAtual + 1 < arquivos.Length && Path.GetFileName(arquivos[indiceAtual + 1]) == "quantidadeAcertos.txt")
            {// verifica se o proximo arquivo está dentro do indice e se seu nome e config ou ele faz a mesma coisa so que com o nome "quantidadeAcertos"


                indiceAtual++; // Incrementar o índice para passar para o próximo arquivo
            }
            if (indiceAtual + 1 >= arquivos.Length)// se a algum arquivo para percorrer 
            {// se for true ele faz tudo isso ai embaixo
                rdbA.Checked = false; rdbB.Checked = false;
                rdbC.Checked = false; rdbD.Checked = false;
                rdbE.Checked = false;
                lblAcertos.Text = acertos + "% de acertos";
                txtEnunciado.Text = "";
                cmbDisciplinas.Enabled = true;
                cmbDisciplinas.Text = "";
                btnResponder.Enabled = false;
                btnProximaPergunta.Enabled = false;

                return; // Sair da função
            }


        }
        private void MostrarPopup()//PopUp
        {
            string title = "Aviso";
            string message = "A diciplina que você escolheu não \n possui questões!";
            int duration = 5000; // 5 segundos

            PopupNotification popup = new PopupNotification(title, message, duration);
            popup.Show();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            string acertoPath = diretorioAtual + cmbDisciplinas.Text + @"\quantidadeAcertos" + ".txt";

            string diretorioMaterias = diretorioAtual + cmbDisciplinas.Text;
            string[] arquivos = Directory.GetFiles(diretorioMaterias, "*.txt");
            string[] linhas = null;// anular linhas para não dar comflito com as respostas anteriores
            int proximoIndice = j + 1; // Próximo índice
            if (proximoIndice <= arquivos.Length) // Verificar se o próximo índice está dentro dos limites do array
            {
                if (proximoIndice == arquivos.Length)// se for igual significa que esta mais q o limite
                {
                    proximoIndice--;//subtraimos para ficar dentro do limite
                }
                string proximoArquivo = arquivos[proximoIndice];//Armazena o caminho da pergunta
                if (File.Exists(proximoArquivo))// verifica se existe
                {
                    // O próximo arquivo existe, você pode acessá-lo aqui
                    linhas = File.ReadAllLines(proximoArquivo);

                }
                else
                {
                    return;// se não exister interrompemos o codigo
                }
                linhas = File.ReadAllLines(arquivos[j]);// carrega linhas do arquivo 
                ; // Use o valor de 'j' atual, usada mais a frente


                string respostaUser = "";// resposta que o user seleciono
                string comentario = "";
                if (linhas.Length >= 7)// ira ver se possui mais de 7 linhas ou igual
                {
                    if (rdbA.Checked)// ira verificar qual opção o user marco
                    {
                        respostaUser = lblA.Text;
                        comentario = respostaUser + rdbA.Text;
                    }
                    if (rdbB.Checked)
                    {
                        respostaUser = lblB.Text;
                        comentario = respostaUser + rdbB.Text;
                    }
                    if (rdbC.Checked)
                    {
                        respostaUser = lblC.Text;
                        comentario = respostaUser + rdbC.Text;
                    }
                    if (rdbD.Checked)
                    {
                        respostaUser = lblD.Text;
                        comentario = respostaUser + rdbD.Text;
                    }
                    if (rdbE.Checked)
                    {
                        respostaUser = lblE.Text;
                        comentario = respostaUser + rdbE.Text;
                    }

                }

                if (linhas[6].ToLower() == respostaUser.ToLower())// ira na linha 6 ver se a resposta do usuario bate com a do gabarito
                {
                    acertos += 10;// Se bater ele adicionar 10
                    lblAcertos.Text = acertos + "% de acertos";
                    txtResolucao.Text = comentario;

                    cmbDisciplinas.Enabled = false;
                    using (StreamWriter guardarRes = new StreamWriter(acertoPath))// entra no quantidade de acertos
                    {
                        guardarRes.WriteLine(acertos);//escreve dentro dele o quão acertamos na questão
                    }
                    using (StreamReader ler = new StreamReader(acertoPath))
                    {
                        string conteudo = ler.ReadLine();

                        lblAcertos.Text = conteudo + "% de acertos";
                    }

                }
                else
                {
                    if (acertos > 0)
                        acertos -= 10;// se não bater ele -10
                    lblAcertos.Text = acertos + "% de acertos";
                    using (StreamWriter guardarRes = new StreamWriter(acertoPath))
                    {
                        guardarRes.WriteLine(acertos);// escreve o quão erramos
                    }
                    using (StreamReader ler = new StreamReader(acertoPath))
                    {
                        string conteudo = ler.ReadLine();

                        lblAcertos.Text = conteudo + "%" + " de " + "acertos";
                    }

                }
            }
        }
    }
}