﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;
            //Leo el telegrama 
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (rbUrgente.Checked)
            {
                rbOrdinario.Checked = false;
                tipoTelegrama = 'u';

            }
            else if (rbOrdinario.Checked)
            {
                rbUrgente.Checked = false;
                tipoTelegrama = 'o';
            }
            //Obtengo el número de palabras que forma el telegrama 
            string[] numpalabras = textoTelegrama.Split(' ');
            numPalabras = numpalabras.Length;

            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else
            //Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 3;
                    }
                    else
                    {
                        coste = 6;
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void btnCalcularPrecio_Click_1(object sender, EventArgs e)
        {

        }
    }
}
