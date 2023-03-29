
namespace Cálculo_Reajuste_Salarial
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.lblPercentualDoReajuste = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnProcurarArquivos = new System.Windows.Forms.Button();
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.ofdListaFuncioarios = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(152, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 44);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.13084F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.86916F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalSemReajuste, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalComReajuste, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPercentualDoReajuste, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(149, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 44);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalSemReajuste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(3, 0);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(199, 22);
            this.lblTotalSemReajuste.TabIndex = 0;
            this.lblTotalSemReajuste.Text = "Total sem reajuste";
            this.lblTotalSemReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalComReajuste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalComReajuste.Location = new System.Drawing.Point(208, 0);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(215, 22);
            this.lblTotalComReajuste.TabIndex = 1;
            this.lblTotalComReajuste.Text = "Total com reajuste";
            this.lblTotalComReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercentualDoReajuste
            // 
            this.lblPercentualDoReajuste.BackColor = System.Drawing.Color.Yellow;
            this.lblPercentualDoReajuste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPercentualDoReajuste.Location = new System.Drawing.Point(429, 0);
            this.lblPercentualDoReajuste.Name = "lblPercentualDoReajuste";
            this.lblPercentualDoReajuste.Size = new System.Drawing.Size(169, 22);
            this.lblPercentualDoReajuste.TabIndex = 2;
            this.lblPercentualDoReajuste.Text = "Percentual Reajuste";
            this.lblPercentualDoReajuste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "R$";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(208, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "R$";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(429, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "%";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Enabled = false;
            this.txtArquivo.Location = new System.Drawing.Point(149, 27);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(520, 22);
            this.txtArquivo.TabIndex = 2;
            // 
            // btnProcurarArquivos
            // 
            this.btnProcurarArquivos.Location = new System.Drawing.Point(675, 26);
            this.btnProcurarArquivos.Name = "btnProcurarArquivos";
            this.btnProcurarArquivos.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarArquivos.TabIndex = 3;
            this.btnProcurarArquivos.Text = "...";
            this.btnProcurarArquivos.UseVisualStyleBackColor = true;
            this.btnProcurarArquivos.Click += new System.EventHandler(this.btnProcurarArquivos_Click);
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Location = new System.Drawing.Point(149, 150);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.RowHeadersWidth = 51;
            this.dgvLeitura.RowTemplate.Height = 24;
            this.dgvLeitura.Size = new System.Drawing.Size(604, 284);
            this.dgvLeitura.TabIndex = 4;
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "openFileDialog1";
            this.ofdListaFuncionarios.Filter = "Arquivos textos|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção do arquivo com dados de funcionários";
            // 
            // ofdListaFuncioarios
            // 
            this.ofdListaFuncioarios.DefaultExt = "*.txt";
            this.ofdListaFuncioarios.FileName = "openFileDialog1";
            this.ofdListaFuncioarios.Filter = "Arquivos textos|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 535);
            this.Controls.Add(this.dgvLeitura);
            this.Controls.Add(this.btnProcurarArquivos);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.Label lblTotalComReajuste;
        private System.Windows.Forms.Label lblPercentualDoReajuste;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnProcurarArquivos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvLeitura;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncioarios;
    }
}

