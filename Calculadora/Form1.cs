using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
                if (txtaños.Text == "") {
                double ganancia = double.Parse(txtcantidad.Text) * (double.Parse(txtpmes.Text) / 100);
                lblganancia.Text = Convert.ToString(ganancia);

                double total = double.Parse(txtcantidad.Text) + double.Parse(lblganancia.Text);
                lbltotal.Text = Convert.ToString(total);

                double cuotas = double.Parse(lbltotal.Text) / double.Parse(txtmeses.Text);
                lblcuotas.Text = Convert.ToString(cuotas);

                lblmensual.Text = "Cuota Mensual: $";
                label13.Text = "Total a pagar: $";
                label2.Text = "Ganancias del banco: $";

            }
            else
            {
                double ganancia1 = double.Parse(txtcantidad.Text) * (double.Parse(txtpaño.Text) / 100);
                lblganancia.Text = Convert.ToString(ganancia1);

                double total1 = double.Parse(txtcantidad.Text) + double.Parse(lblganancia.Text);
                lbltotal.Text = Convert.ToString(total1);

                double cuotas1 = double.Parse(lbltotal.Text) / double.Parse(txtaños.Text);
                lblcuotas.Text = Convert.ToString(cuotas1);

                lblmensual.Text = "Cuota anual: $";
                label13.Text = "Total a pagar: $";
                label2.Text = "Ganancias del banco: $";
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcantidad.Text = "";
            txtmeses.Text = "";
            txtpmes.Text = "";
            txtpaño.Text = "";
            txtaños.Text = "";
            label12.Text = "";
            label13.Text = "";
            lblmensual.Text = "";
            lbltotal.Text = "";
            lblcuotas.Text = "";
            lblganancia.Text = "";

        }
       
    }
}
