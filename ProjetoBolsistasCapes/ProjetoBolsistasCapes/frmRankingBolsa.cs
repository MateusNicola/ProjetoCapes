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

namespace ProjetoBolsistasCapes
{
    public partial class frmRankingBolsa : Form
    {
        public string CaminhoArquivoCsv
        {
            get;
            set;
        }

        public frmRankingBolsa()
        {
            InitializeComponent();
        }

        private void frmRankingBolsa_Load(object sender, EventArgs e)
        {
            //Chamando os métodos para popular os grid
            PopularGridAltos();
            PopularGridBaixos();
        }

        private void PopularGridAltos()
        {
            gridAltos.Rows.Clear();
            gridAltos.Columns.Clear();
            gridAltos.Refresh();

            DataTable dt = new DataTable();
            StreamReader dados = new StreamReader(CaminhoArquivoCsv);
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
                        //Se a coluna começar com VL o tipo dela vai ser decimal
                        if(coluna.StartsWith("VL"))
                            dt.Columns.Add(coluna,typeof(decimal));
                        else
                            dt.Columns.Add(coluna);
                    }
                }
                else
                {
                    dt.Rows.Add(campos);
                }

                //incremento para saber em qual linha estamos
                i++;
            }

            //Ordenando o datatable pela coluna VL_BOLSISTA_PAGAMENTO
            dt.DefaultView.Sort = "VL_BOLSISTA_PAGAMENTO DESC";
            //Incluindo as informações do datatable para o datagridview
            gridAltos.DataSource = dt;

            //Alterando os nomes dos cabeçalhos das colunas
            gridAltos.Columns["NM_BOLSISTA"].HeaderText = "Nome";
            gridAltos.Columns["CPF_BOLSISTA"].HeaderText = "CPF";
            gridAltos.Columns["NM_ENTIDADE_ENSINO"].HeaderText = "Entidade de Ensino";
            gridAltos.Columns["VL_BOLSISTA_PAGAMENTO"].HeaderText = "Valor da Bolsa";

            // Removendo as colunas desnecessárias
            gridAltos.Columns.Remove("ME_REFERENCIA");
            gridAltos.Columns.Remove("AN_REFERENCIA");
            gridAltos.Columns.Remove("SG_DIRETORIA");
            gridAltos.Columns.Remove("SG_SISTEMA_ORIGEM");
            gridAltos.Columns.Remove("CD_MODALIDADE_SGB");
            gridAltos.Columns.Remove("DS_MODALIDADE_PAGAMENTO");
            gridAltos.Columns.Remove("CD_MOEDA");
        }

        private void PopularGridBaixos()
        {
            gridBaixos.Rows.Clear();
            gridBaixos.Columns.Clear();
            gridBaixos.Refresh();

            DataTable dt = new DataTable();
            StreamReader dados = new StreamReader(CaminhoArquivoCsv);
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
                        //Se a coluna começar com VL o tipo dela vai ser decimal
                        if (coluna.StartsWith("VL"))
                            dt.Columns.Add(coluna, typeof(decimal));
                        else
                            dt.Columns.Add(coluna);
                    }
                }
                else
                {
                    dt.Rows.Add(campos);
                }

                //incremento para saber em qual linha estamos
                i++;
            }

            //Ordenando o datatable pela coluna VL_BOLSISTA_PAGAMENTO
            dt.DefaultView.Sort = "VL_BOLSISTA_PAGAMENTO ASC";

            //Incluindo as informações do datatable para o datagridview
            gridBaixos.DataSource = dt;

            //Alterando os nomes dos cabeçalhos das colunas
            gridBaixos.Columns["NM_BOLSISTA"].HeaderText = "Nome";
            gridBaixos.Columns["CPF_BOLSISTA"].HeaderText = "CPF";
            gridBaixos.Columns["NM_ENTIDADE_ENSINO"].HeaderText = "Entidade de Ensino";
            gridBaixos.Columns["VL_BOLSISTA_PAGAMENTO"].HeaderText = "Valor da Bolsa";

            // Removendo as colunas desnecessárias
            gridBaixos.Columns.Remove("ME_REFERENCIA");
            gridBaixos.Columns.Remove("AN_REFERENCIA");
            gridBaixos.Columns.Remove("SG_DIRETORIA");
            gridBaixos.Columns.Remove("SG_SISTEMA_ORIGEM");
            gridBaixos.Columns.Remove("CD_MODALIDADE_SGB");
            gridBaixos.Columns.Remove("DS_MODALIDADE_PAGAMENTO");
            gridBaixos.Columns.Remove("CD_MOEDA");
        }
    }
}
