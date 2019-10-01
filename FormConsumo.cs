using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoDeEnergia
{
    public partial class FormConsumo : Form
    {
        private IList<Leitura> leituras = new BindingList<Leitura>(); //cria uma lista do tipo Leitura
        private BindingSource leituraSource = new BindingSource();

        public FormConsumo()
        {
            InitializeComponent();
            leituraSource.DataSource = leituras;
            dgvLeituras.DataSource = leituraSource;
        }   

        public void RegistraConsumo(string casa, double consumo)
        {
            Leitura leitura = new Leitura(casa, consumo);
            if (leituras.Contains(leitura)) //verifica se os valores de leitura já existe na lista leituras.
            {
                MessageBox.Show("Aleitura para esta casa já foi registrada.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                leituras.Add(leitura);
                inicializaFormulario();
            }
        }

        private void inicializaFormulario()
        {
            txtCasa.Clear();
            txtConsumo.Clear();
            txtCasa.Focus();
        }

        private void processarLeituras(DataGridView dgv)
        {
            DataGridViewCell cell = dgvLeituras.Rows[0].Cells[0];
            this.leituras.Add(new Leitura("Total", 0));

            for (int i = 0; i < 3; i++)
            {
                                    //linhas.ultima linha
                dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.BackColor = Color.Blue;
                dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Yellow;
                dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.Font = new Font(cell.InheritedStyle.Font, FontStyle.Bold);
            }

            double totalConsumo = 0;
            double totalDesconto = 0;
            
            //cria a variavel leitura do tipo leituras
            foreach (var leitura in leituras)//leitura comtem casa, consumo e desconto.
            {
                totalConsumo += leitura.Consumo;
                totalDesconto += leitura.Desconto;
            }

            dgv[0, dgv.Rows.Count - 1].Value = "Total";
            dgv[1, dgv.Rows.Count - 1].Value = totalConsumo.ToString();
            dgv[2, dgv.Rows.Count - 1].Value = totalDesconto.ToString();
            lblResultado.Text = "Total consumo sem desconto" + (totalConsumo + totalDesconto).ToString();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            RegistraConsumo(txtCasa.Text, Convert.ToDouble(txtConsumo.Text));
        }

        private void BtnProcessar_Click(object sender, EventArgs e)
        {
            processarLeituras(dgvLeituras);
        }
    }       
 }
