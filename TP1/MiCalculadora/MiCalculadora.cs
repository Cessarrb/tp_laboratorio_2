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

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }



        public void Limpiar()
        {
            this.listOperaciones.Items.Clear();
            this.txtNumeroUno.Text = "";
            this.txtNumeroDos.Text = "";
            this.lblResultado.Text = "";
            this.BoxOperador.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (BoxOperador.Text == "")
            {
                MessageBox.Show("Debe seleccionar un operador", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(this.txtNumeroDos.Text == "0" && BoxOperador.Text == "/")
            {
                MessageBox.Show("No se puede dividir por 0", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            if(double.TryParse(txtNumeroUno.Text, out double num1) && double.TryParse(txtNumeroDos.Text, out double num2))
            {
                lblResultado.Text = Operar(this.txtNumeroUno.Text, this.txtNumeroDos.Text, this.BoxOperador.Text).ToString();
                listOperaciones.Items.Add($"{txtNumeroUno.Text} {BoxOperador.Text} {txtNumeroDos.Text} = {lblResultado.Text}");
            }
            else
            {
                MessageBox.Show("Debe ingresar numeros en los dos campos para operar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;

            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            
            resultado = Calculadora.Operar(operando1, operando2, char.Parse(operador));

            return resultado;
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            string numeroBinario = resultado.DecimalABinario(lblResultado.Text);
            lblResultado.Text = numeroBinario;
            listOperaciones.Items.Add($"{numeroBinario}");
        }

        private void btnConvertirABDecimal_Click(object sender, EventArgs e)
        {
            Operando resultado = new Operando();
            string numeroDecimal= resultado.BinarioADecimal(lblResultado.Text);
            lblResultado.Text = numeroDecimal;
            listOperaciones.Items.Add($"{numeroDecimal}");
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs formClose)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                formClose.Cancel = true;
            }
        }
    }
}
