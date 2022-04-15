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
            if(BoxOperador.Text != "")
            {
                lblResultado.Text = Operar(this.txtNumeroUno.Text, this.txtNumeroDos.Text, this.BoxOperador.Text).ToString();
                listOperaciones.Items.Add($"{txtNumeroUno.Text} {BoxOperador.Text} {txtNumeroDos.Text} = {lblResultado.Text}");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un operador", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
    }
}
