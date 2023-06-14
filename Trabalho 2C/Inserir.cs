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

namespace Trabalho_2C
{
    public partial class Inserir : Form
    {
        int i = 0;
        Questão questao;
        string diretorioAtual;
        private Dictionary<string, int> valoresI = new Dictionary<string, int>();

        public Inserir()
        {
            InitializeComponent();

            questao = new Questão();
            diretorioAtual = Directory.GetCurrentDirectory();
            diretorioAtual += @"\..\..\..\Questões\";
            string[] diretorios = Directory.GetDirectories(diretorioAtual);
            for (int i = 0; i < diretorios.Length; i++)
            {
                string nomeDaDisciplina = diretorios[i].Remove(0, diretorioAtual.Length);
                cmbDisciplinas.Items.Add(nomeDaDisciplina);
            }

            foreach (string diretorio in diretorios)
            {
                string nomeDaDisciplina = diretorio.Remove(0, diretorioAtual.Length);
                int SalvarI = 0;

                // Verificar se existe um arquivo de configuração para a pasta atual
                string configFilePath = Path.Combine(diretorio, "config.txt");
                if (File.Exists(configFilePath))
                {
                    string[] lines = File.ReadAllLines(configFilePath);
                    if (int.TryParse(lines[0], out SalvarI))
                    {
                        // Salvar o valor de 'i' correspondente à pasta atual no dicionário
                        valoresI[nomeDaDisciplina] = SalvarI;
                    }
                }
                string acertoPathFile = Path.Combine(diretorio, "pasta.txt");
                if (File.Exists(acertoPathFile))
                {
                    Directory.CreateDirectory(acertoPathFile);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbDisciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomeDaDisciplina = cmbDisciplinas.Text;
            i = valoresI.ContainsKey(nomeDaDisciplina) ? valoresI[nomeDaDisciplina] : 0;
            i += 1;
            valoresI[nomeDaDisciplina] = i;

            // Resto do código...

            // Salvar o valor atualizado de 'i' no arquivo de configuração da pasta atual
            string configFilePath = Path.Combine(diretorioAtual, nomeDaDisciplina, "config.txt");
            File.WriteAllText(configFilePath, i.ToString());
            string acertosFilePath = Path.Combine(diretorioAtual, nomeDaDisciplina, "quantidadeAcertos.txt");
            File.WriteAllText(acertosFilePath, "0");
            // Salvar o valor atualizado de 'i' no arquivo de configuração da pasta atual
            FileStream local = new FileStream(diretorioAtual + cmbDisciplinas.Text + @"\arquivo" + i + ".txt", FileMode.Create, FileAccess.Write);
            StreamWriter gravar = new StreamWriter(local);
            gravar.WriteLine(txb_Enunciado.Text);
            gravar.WriteLine(txb_OpcA.Text);
            gravar.WriteLine(txb_OpcB.Text);
            gravar.WriteLine(txb_OpcC.Text);
            gravar.WriteLine(txb_OpcD.Text);
            gravar.WriteLine(txb_OpcE.Text);
            gravar.WriteLine(txb_Solucao.Text);
            gravar.WriteLine(txb_acertos.Text);

            gravar.Close();
        }

        private void Inserir_Load(object sender, EventArgs e)
        {

        }
    }
}