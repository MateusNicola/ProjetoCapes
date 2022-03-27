namespace ProjetoBolsistasCapes
{
    partial class frmRankingBolsa
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridAltos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gridBaixos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAltos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBaixos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Os três alunos com os valores da bolsa mais altos;";
            // 
            // gridAltos
            // 
            this.gridAltos.AllowUserToAddRows = false;
            this.gridAltos.AllowUserToDeleteRows = false;
            this.gridAltos.AllowUserToOrderColumns = true;
            this.gridAltos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAltos.Location = new System.Drawing.Point(16, 29);
            this.gridAltos.Name = "gridAltos";
            this.gridAltos.ReadOnly = true;
            this.gridAltos.Size = new System.Drawing.Size(558, 150);
            this.gridAltos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Os três alunos com os valores da bolsa mais baixos;";
            // 
            // gridBaixos
            // 
            this.gridBaixos.AllowUserToAddRows = false;
            this.gridBaixos.AllowUserToDeleteRows = false;
            this.gridBaixos.AllowUserToOrderColumns = true;
            this.gridBaixos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBaixos.Location = new System.Drawing.Point(12, 234);
            this.gridBaixos.Name = "gridBaixos";
            this.gridBaixos.ReadOnly = true;
            this.gridBaixos.Size = new System.Drawing.Size(562, 150);
            this.gridBaixos.TabIndex = 3;
            // 
            // frmRankingBolsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 395);
            this.Controls.Add(this.gridBaixos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridAltos);
            this.Controls.Add(this.label1);
            this.Name = "frmRankingBolsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRankingBolsa";
            this.Load += new System.EventHandler(this.frmRankingBolsa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAltos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBaixos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridAltos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridBaixos;
    }
}