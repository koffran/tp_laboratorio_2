using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Franco Zarate del curso 2°A"; // Título

            txtNumero1.TabIndex = 1;
            txtNumero1.TabStop = true;
            cmbOperador.TabIndex = 2;
            cmbOperador.TabStop = true;
            txtNumero2.TabIndex = 3;
            txtNumero2.TabStop = true;

            btnOperar.Text = "Operar";
            btnOperar.TabIndex = 4;
            btnOperar.TabStop = true;

            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TabIndex = 5;
            btnLimpiar.TabStop = true;

            btnCerrar.Text = "Cerrar";
            btnCerrar.TabIndex = 6;
            btnCerrar.TabStop = true;

            btnConvertirABinario.Text = "Convertir a Binario";
            btnConvertirABinario.TabIndex = 7;
            btnConvertirABinario.TabStop = true;
            btnConvertirADecimal.Text = "Convertir a Decimal";
            btnConvertirADecimal.TabIndex = 8;
            btnConvertirADecimal.TabStop = true;

            //cmbOperador
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("*");

            lblResultado.Text = "";

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text)).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero num = new Numero();
            lblResultado.Text = num.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero num = new Numero();
            lblResultado.Text = num.BinarioDecimal(lblResultado.Text);
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private double Operar(string numero1, string numero2, string operador)
        {
            double retorno;
            Calculadora calc = new Calculadora();
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            retorno = calc.Operar(num1, num2, operador);

            return retorno;
        }
    }
}
