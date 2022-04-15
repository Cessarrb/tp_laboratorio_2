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
            this.BoxLista.Items.Clear();
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
            lblResultado.Text = Operar(this.txtNumeroUno.Text, this.txtNumeroDos.Text, this.BoxOperador.Text).ToString();
            listBox1.Text = Operar(this.txtNumeroUno.Text, this.txtNumeroDos.Text, this.BoxOperador.Text).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;

            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);

            resultado = Calculadora.Operar(operando1, operando2, char.Parse(operador));

            return resultado;
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
