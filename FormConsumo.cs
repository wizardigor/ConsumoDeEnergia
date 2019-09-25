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
    }       
 }
