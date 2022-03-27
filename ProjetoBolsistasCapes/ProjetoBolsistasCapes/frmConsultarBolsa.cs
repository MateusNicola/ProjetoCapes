using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBolsistasCapes
{
    public partial class frmConsultarBolsa : Form
    {
        public frmConsultarBolsa()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Mensagem de erro quando o campo de ano nao estiver preenchido
            if (string.IsNullOrEmpty(txtAno.Text))
            {
                MessageBox.Show("Informe o campo de ano para realizar o filtro!");
                return;
            }

            // Mensagem de erro quando o campo do arquivo nao estiver preenchido
            if (string.IsNullOrEmpty(txtCaminho.Text))
            {
                MessageBox.Show("Informe o caminho do arquivo!");
                return;
            }

            ConsultarCsv(txtAno.Text);
            CalcularMedia();
        }

        private void ConsultarCsv(string filtro)
        {
            try
            {                  
                DataTable dt = new DataTable();
                dt.Clear();
                StreamReader dados = new StreamReader(txtCaminho.Text);
                string linha;
                string[] campos;
                int i = 0;

                while ((linha = dados.ReadLine()) != null)
                {
                    campos = linha.Split(';');

                    //Verificando se é a primeira linha do arquivo
                    if (i == 0)
                    {
                        // pegando cada coluna e incluida como coluna no grid
                        foreach (string coluna in campos)
                        {
                            dt.Columns.Add(coluna);
                        }
                    }
                    else
                    {
                        if (campos.Contains(filtro))
                        {
                            dt.Rows.Add(campos);
                        }
                    }

                    //incremento para saber em qual linha estamos
                    i++;
                }

                //Incluindo as informações do datatable para o datagridview
                gridDados.DataSource = dt;

                //Alterando os nomes dos cabeçalhos das colunas
                gridDados.Columns["NM_BOLSISTA"].HeaderText = "Nome";
                gridDados.Columns["CPF_BOLSISTA"].HeaderText = "CPF";
                gridDados.Columns["NM_ENTIDADE_ENSINO"].HeaderText = "Entidade de Ensino";
                gridDados.Columns["VL_BOLSISTA_PAGAMENTO"].HeaderText = "Valor da Bolsa";

                //Removendo as colunas desnecessárias
                gridDados.Columns.Remove("ME_REFERENCIA");
                gridDados.Columns.Remove("AN_REFERENCIA");
                gridDados.Columns.Remove("SG_DIRETORIA");
                gridDados.Columns.Remove("SG_SISTEMA_ORIGEM");
                gridDados.Columns.Remove("CD_MODALIDADE_SGB");
                gridDados.Columns.Remove("DS_MODALIDADE_PAGAMENTO");
                gridDados.Columns.Remove("CD_MOEDA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Abrindo a janela para seleção do arquivo
            DialogResult result = janelaArquivos.ShowDialog();

            //Validação para pegar o caminho do arquivo selecionado
            if (result == DialogResult.OK)
            {
                txtCaminho.Text = janelaArquivos.FileName;
                btnRanking.Enabled = true;
            }
        }

        private void txtAno_KeyUp(object sender, KeyEventArgs e)
        {
            //Chamando o evento de clique do botão filtrar
            if (e.KeyCode == Keys.Enter)
            {
                btnFiltrar_Click(null, null);
            }
        }

        private string CodificarNomes(string nome)
        {
            try
            {
                string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
                string palavraCodificada = string.Empty;

                //Invertendo a palavra e colando em maiusculo
                nome = new string(nome.Reverse().ToArray()).ToUpper();

                //Transformando a palavra para um array para poder percorrer cada letra
                char[] charArr = nome.ToCharArray();

                //Foreach percorrendo cada letra da palavra
                foreach (char letra in charArr)
                {
                    //Pegando o indice da letra do nome no alfabeto
                    int index = alfabeto.IndexOf(letra, 0);

                    //Verificando se é a ultima letra do alfabeto para pegar do inicio de novo
                    if (index == 24)
                        index = 0;

                    //Pegando a próxima letra na alfabeto
                    string proximaLetra = alfabeto.Substring(index + 1, 1);

                    //Criando a palavra codificado
                    palavraCodificada += proximaLetra;
                }

                return palavraCodificada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
        }

        private void CalcularMedia()
        {
            double valorTotal = 0;
            double valorMedia = 0;

            //Percorrendo as linhas do grid
            foreach (DataGridViewRow col in gridDados.Rows)
            {
                //pegando a coluna 3 e fazendo a soma
                valorTotal += Convert.ToDouble(col.Cells[3].Value);
            }

            //calculando a média
            valorMedia = valorTotal / gridDados.RowCount;

            //Formantando o valor da média.
            lblMediaTotal.Text = string.Format("Média anual de valores de bolsa: R$ {0:C}", valorMedia.ToString("0.00", CultureInfo.InvariantCulture));
            lblMediaTotal.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRankingBolsa frmRankingBolsa = new frmRankingBolsa();
            frmRankingBolsa.CaminhoArquivoCsv = txtCaminho.Text;
            frmRankingBolsa.Show();
        }
    }
}
