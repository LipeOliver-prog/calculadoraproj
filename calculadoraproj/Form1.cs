using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraproj
{
    

    public partial class Calculadora : Form

    {
       

        public decimal Resultado {  get; set; }
        public decimal Valor { get; set; }


        private Operaçao OperaçaoSelecionada { get; set; }

        private enum Operaçao
        {
            Adiçao,
            Subtraçao,
            Multiplicaçao,
            Divisao
        }

        public Calculadora()
        {
            InitializeComponent();
        }


        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "0";

        }

        private void btndois_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5";
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";
        }

        private void btnsete_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";
        }

        private void btnoito_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";
        }

        private void btnnove_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";
        }

        private void btnum_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
        }

        private void btnquatro_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            OperaçaoSelecionada = Operaçao.Adiçao;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text= "";
            lbl1.Text = "+";
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            OperaçaoSelecionada = Operaçao.Subtraçao;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            lbl1.Text = "-";
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            OperaçaoSelecionada = Operaçao.Multiplicaçao;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            lbl1.Text = "*";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            OperaçaoSelecionada = Operaçao.Divisao;
            Valor = Convert.ToDecimal(txtresultado.Text);
            txtresultado.Text = "";
            lbl1.Text = "/";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            switch (OperaçaoSelecionada)
            {
                case Operaçao.Adiçao:
                    Resultado = Valor + Convert.ToDecimal(txtresultado.Text);   
                    break;
                case Operaçao.Subtraçao:
                    Resultado = Valor - Convert.ToDecimal(txtresultado.Text);
                    break;
                case Operaçao.Multiplicaçao:
                    Resultado = Valor * Convert.ToDecimal(txtresultado.Text);
                    break;
                case Operaçao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtresultado.Text);
                    break;
               
            }
         txtresultado.Text =Convert.ToString(Resultado);
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            if (!txtresultado.Text.Contains(","))
            txtresultado.Text += ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            lbl1.Text = "";
        }
    }


}
