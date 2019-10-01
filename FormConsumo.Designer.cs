namespace ConsumoDeEnergia
{
    partial class FormConsumo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtCasa = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.dgvLeituras = new System.Windows.Forms.DataGridView();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num Casa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumo:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(174, 268);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(170, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Total de Conosumo sem Desconto";
            // 
            // txtCasa
            // 
            this.txtCasa.Location = new System.Drawing.Point(78, 25);
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.Size = new System.Drawing.Size(100, 20);
            this.txtCasa.TabIndex = 3;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(244, 25);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(100, 20);
            this.txtConsumo.TabIndex = 4;
            // 
            // dgvLeituras
            // 
            this.dgvLeituras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeituras.Location = new System.Drawing.Point(16, 52);
            this.dgvLeituras.Name = "dgvLeituras";
            this.dgvLeituras.Size = new System.Drawing.Size(409, 205);
            this.dgvLeituras.TabIndex = 5;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(16, 263);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(110, 23);
            this.btnProcessar.TabIndex = 6;
            this.btnProcessar.Text = "Processar Dados";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.BtnProcessar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(350, 23);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // FormConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 301);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.dgvLeituras);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtCasa);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConsumo";
            this.Text = "Consumo de Energia de Um Consumidor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtCasa;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.DataGridView dgvLeituras;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}

