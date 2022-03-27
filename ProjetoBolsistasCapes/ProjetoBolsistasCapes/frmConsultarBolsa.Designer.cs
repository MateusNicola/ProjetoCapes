namespace ProjetoBolsistasCapes
{
    partial class frmConsultarBolsa
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
            this.gridDados = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.janelaArquivos = new System.Windows.Forms.OpenFileDialog();
            this.grbArquivo = new System.Windows.Forms.GroupBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMediaTotal = new System.Windows.Forms.Label();
            this.btnRanking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).BeginInit();
            this.grbFiltros.SuspendLayout();
            this.grbArquivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDados
            // 
            this.gridDados.AllowUserToAddRows = false;
            this.gridDados.AllowUserToDeleteRows = false;
            this.gridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDados.Location = new System.Drawing.Point(12, 144);
            this.gridDados.Name = "gridDados";
            this.gridDados.ReadOnly = true;
            this.gridDados.Size = new System.Drawing.Size(776, 244);
            this.gridDados.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(679, 14);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Consultar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(41, 16);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(79, 20);
            this.txtAno.TabIndex = 2;
            this.txtAno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAno_KeyUp);
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(6, 19);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 13);
            this.lblAno.TabIndex = 3;
            this.lblAno.Text = "Ano:";
            // 
            // grbFiltros
            // 
            this.grbFiltros.Controls.Add(this.btnFiltrar);
            this.grbFiltros.Controls.Add(this.lblAno);
            this.grbFiltros.Controls.Add(this.txtAno);
            this.grbFiltros.Location = new System.Drawing.Point(12, 92);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(776, 46);
            this.grbFiltros.TabIndex = 4;
            this.grbFiltros.TabStop = false;
            this.grbFiltros.Text = "Filtros";
            // 
            // janelaArquivos
            // 
            this.janelaArquivos.FileName = "janelaArquivos";
            // 
            // grbArquivo
            // 
            this.grbArquivo.Controls.Add(this.txtCaminho);
            this.grbArquivo.Controls.Add(this.btnBuscar);
            this.grbArquivo.Location = new System.Drawing.Point(12, 12);
            this.grbArquivo.Name = "grbArquivo";
            this.grbArquivo.Size = new System.Drawing.Size(488, 60);
            this.grbArquivo.TabIndex = 6;
            this.grbArquivo.TabStop = false;
            this.grbArquivo.Text = "Arquivo CSV";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Enabled = false;
            this.txtCaminho.Location = new System.Drawing.Point(6, 24);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(340, 20);
            this.txtCaminho.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(352, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar arquivo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMediaTotal
            // 
            this.lblMediaTotal.AutoSize = true;
            this.lblMediaTotal.Location = new System.Drawing.Point(12, 413);
            this.lblMediaTotal.Name = "lblMediaTotal";
            this.lblMediaTotal.Size = new System.Drawing.Size(0, 13);
            this.lblMediaTotal.TabIndex = 7;
            // 
            // btnRanking
            // 
            this.btnRanking.Enabled = false;
            this.btnRanking.Location = new System.Drawing.Point(677, 15);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Size = new System.Drawing.Size(111, 60);
            this.btnRanking.TabIndex = 8;
            this.btnRanking.Text = "Consultar Ranking de Bolsas";
            this.btnRanking.UseVisualStyleBackColor = true;
            this.btnRanking.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmConsultarBolsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRanking);
            this.Controls.Add(this.lblMediaTotal);
            this.Controls.Add(this.grbArquivo);
            this.Controls.Add(this.grbFiltros);
            this.Controls.Add(this.gridDados);
            this.Name = "frmConsultarBolsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar bolsa zero/Ano";
            ((System.ComponentModel.ISupportInitialize)(this.gridDados)).EndInit();
            this.grbFiltros.ResumeLayout(false);
            this.grbFiltros.PerformLayout();
            this.grbArquivo.ResumeLayout(false);
            this.grbArquivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDados;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.GroupBox grbFiltros;
        private System.Windows.Forms.OpenFileDialog janelaArquivos;
        private System.Windows.Forms.GroupBox grbArquivo;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblMediaTotal;
        private System.Windows.Forms.Button btnRanking;
    }
}