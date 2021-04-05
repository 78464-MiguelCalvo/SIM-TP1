using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_simulacion
{
    public partial class Punto2 : Form
    {
        public Punto2()
        {
            InitializeComponent();
        }

        private void btonGenerar_Click_1(object sender, EventArgs e)
        {
            double acumulador = 0;
            Random rnd = new Random();
            for (int i = 0; i < Convert.ToInt32(TxtTamañoMuestra.Text); i++)
            {
                double numero = 0;
                numero = rnd.NextDouble();
                lstNumeros.Items.Add(numero);

            }

            double valorMin = 0;
            double valorMax = 0;

            for (int i = 0; i < Convert.ToInt32(TxtCantidadIntervalos.Text); i++)
            {
                int contador = 0;

                DataGridViewRow fila = new DataGridViewRow();

                DataGridViewTextBoxCell celdaIntervalo = new DataGridViewTextBoxCell();


                if (i == 0)
                {
                    valorMax = (double)1 / (double)Convert.ToDecimal(TxtCantidadIntervalos.Text);
                    foreach (double item in lstNumeros.Items)
                    {
                        if (item > valorMin && item < valorMax)
                        {
                            contador = contador + 1;
                        }

                    }
                    celdaIntervalo.Value = valorMin + "-" + valorMax;
                    fila.Cells.Add(celdaIntervalo);
                }
                else
                {
                    valorMin = valorMin + ((double)1 / (double)Convert.ToDecimal(TxtCantidadIntervalos.Text));
                    valorMax = valorMax + ((double)1 / (double)Convert.ToDecimal(TxtCantidadIntervalos.Text));
                    foreach (double item in lstNumeros.Items)
                    {
                        if (item > valorMin && item < valorMax)
                        {
                            contador = contador + 1;
                        }
                    }
                    celdaIntervalo.Value = valorMin + "-" + valorMax;
                    fila.Cells.Add(celdaIntervalo);
                }

                DataGridViewTextBoxCell celdaFo = new DataGridViewTextBoxCell();
                Convert.ToString(contador);
                celdaFo.Value = contador;
                fila.Cells.Add(celdaFo);

                DataGridViewTextBoxCell celdaFe = new DataGridViewTextBoxCell();
                celdaFe.Value = Convert.ToDecimal(TxtTamañoMuestra.Text) / Convert.ToDecimal(TxtCantidadIntervalos.Text);
                fila.Cells.Add(celdaFe);

                DataGridViewTextBoxCell celdaC = new DataGridViewTextBoxCell();
                double Fe = Convert.ToDouble(TxtTamañoMuestra.Text) / Convert.ToDouble(TxtCantidadIntervalos.Text);
                double Fo = Convert.ToDouble(contador);
                double resta = Fo - Fe;
                double c = Math.Pow(resta, 2) / Fe;
                celdaC.Value = c;
                fila.Cells.Add(celdaC);

                DataGridViewTextBoxCell celdaCacum = new DataGridViewTextBoxCell();
                if (i == 0)
                {

                    acumulador = c;
                }
                else
                {
                    acumulador = acumulador + c;
                }
                celdaCacum.Value = acumulador;
                fila.Cells.Add(celdaCacum);

                grillaDatos.Rows.Add(fila);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventana = new VentanaPrincipal();

            this.Close();
            ventana.Show();

        }
    }
}
