﻿using System;
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
    public partial class Punto_1 : Form
    {
        public VentanaPrincipal ventana{get;set;}
        public Punto_1(VentanaPrincipal ven)
        {
            InitializeComponent();
            ventana = ven;
        }

        int modo;
        int icounter = 0;
        Variables v = new Variables();

        private void Punto_1_Load(object sender, EventArgs e)
        {
            modo = -1;
            btnSiguiente.Enabled = false;
            txtA.Enabled = false;
            txtM.Enabled = false;
        }

        //BOTONES
        private void btnMixto_CheckedChanged_1(object sender, EventArgs e)
        {
            modo = 0;
        }

        private void btnMultiplicativo_CheckedChanged_1(object sender, EventArgs e)
        {
            modo = 1;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            v.X = float.Parse(txtX0.Text);
            v.K = float.Parse(txtK.Text);
            v.G = float.Parse(txtG.Text);
            v.C = float.Parse(txtC.Text);

            generarVeinte();

            btnGenerar.Enabled = false;
            btnSiguiente.Enabled = true;

        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            icounter++;

            if (modo == 0) { metodoMixto(); }
            if (modo == 1) { metodoMulti(); }

            float rand = random(v.X, v.M);

            cargarEnTabla(icounter, rand);
        }    

        private void btonVolver_Click(object sender, EventArgs e)
        {
            ventana.Show();
            this.Close();
            
        }


        //GENERAR 20 NUMEROS
        private void generarVeinte()
        {

            while (icounter < 20)
            {

                icounter++;

                if (modo == 0) { metodoMixto(); }
                if (modo == 1) { metodoMulti(); }



                float rand = random(v.X, v.M);

                cargarEnTabla(icounter, rand);



            }
            txtA.Text = v.A.ToString();
            txtM.Text = v.M.ToString();

        }



        //RANDOM
        private float random(float x, float m)
        {

            float r = (float)Math.Round((x / m), 4);
            //float r = (float)Math.Round((x) / (m - 1), 4);  incluyendo el 1

            return r;
        }


        //METODOS
        private void metodoMixto()
        {
            v.A = 1 + 4 * v.K;

            v.M = (float)(Math.Pow(2, v.G));

            v.Xsig = (v.A * v.X + v.C) % v.M;
            v.X = v.Xsig;
        }

        private void metodoMulti()
        {

            v.A = 3 + 8 * v.K;
            //v.A = 5 + 8 * v.K; alternativo

            v.M = (float)(Math.Pow(2, v.G));

            v.Xsig = (v.A * v.X) % v.M;
            v.X = v.Xsig;

        }


        //LLENAR TABLA
        private void cargarEnTabla(int i, float rand)
        {
            dgTabla.Rows.Add(i, rand);
        }


        //BORRAR TODO Y REINICIAR

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            txtX0.Clear();
            txtK.Clear();
            txtG.Clear();
            txtC.Clear();
            txtA.Clear();
            txtM.Clear();

            btnSiguiente.Enabled = false;
            btnGenerar.Enabled = true;
            icounter = 0;

            dgTabla.Rows.Clear();

        }


    }
}
