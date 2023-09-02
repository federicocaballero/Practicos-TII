using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace practico4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BFuncion_Click(object sender, EventArgs e)
        {
            LBNumeros.Items.Clear();
            BorrarCharts();
            if (THasta.Text != "" && TDesde.Text != "")
            {
                int num1 = int.Parse(TDesde.Text);
                int num2 = int.Parse(THasta.Text);

                if ((num1 <= num2))
                {
                    while (num1 <= num2)
                    {
                        LBNumeros.Items.Add(num1);
                        num1++;
                        ChartNumeros.Series["Orden"].Points.AddY(num1);
                    }
                }
            }
            else
            {
                MessageBox.Show("No es posible generar la lista de numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BPares_Click(object sender, EventArgs e)
        {
            LBNumeros.Items.Clear();
            BorrarCharts();
            if (THasta.Text != "" && TDesde.Text != "")
            {
                int numPar1 = int.Parse(TDesde.Text);
                int numPar2 = int.Parse(THasta.Text);

                while (numPar1 <= numPar2)
                {
                    if (numPar1 % 2 == 0)
                    {
                        LBNumeros.Items.Add(numPar1);
                        ChartNumeros.Series["Pares"].Points.AddY(numPar1);
                    }
                    numPar1++;
                }
            }
            else
            {
                MessageBox.Show("No es posible generar la lista de numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BImpares_Click(object sender, EventArgs e)
        {
            LBNumeros.Items.Clear();
            BorrarCharts();
            LBNumeros.ResetText();
            if (THasta.Text != "" && TDesde.Text != "")
            {
                int numImpar1 = int.Parse(TDesde.Text);
                int numImpar2 = int.Parse(THasta.Text);

                while (numImpar1 <= numImpar2)
                {
                    if (numImpar1 % 2 != 0)
                    {
                        LBNumeros.Items.Add(numImpar1);
                        ChartNumeros.Series["Impares"].Points.AddY(numImpar1);

                    }
                    numImpar1++;
                    

                }
            }
            else
            {
                MessageBox.Show("No es posible generar la lista de numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BPrimos_Click(object sender, EventArgs e)
        {
            BorrarCharts();
            LBNumeros.Items.Clear();
            LBNumeros.ResetText();
            bool entro = false;
            if (THasta.Text != "" && TDesde.Text != "")
            {
                int num1 = int.Parse(TDesde.Text);
                int num2 = int.Parse(THasta.Text);

                var iteraciones = 0;
                if (num1 == 0)
                {
                    num1 += 2;
                    if (num2 > 0)
                    {

                        ChartNumeros.Series["Primos"].Points.AddY(1);
                        LBNumeros.Items.Add(1);
                        entro = true;
                    }
                }
                else if (num1 == 1)
                {
                    num1 += 1;
                    LBNumeros.Items.Add(1);
                    ChartNumeros.Series["Primos"].Points.AddY(1);
                    entro = true;
                }
                for (int candidato = num1; candidato <= num2; candidato++)
                {
                    var primo = true;
                    var maximoDivisor = Math.Floor(Math.Sqrt(candidato));
                    for (var divisor = 2; divisor <= maximoDivisor; divisor++)
                    {
                        iteraciones++;
                        if (candidato % divisor == 0)
                        {
                            primo = !primo;
                            break;
                        }
                    }
                    if (primo)
                    {
                        LBNumeros.Items.Add(candidato);
                        ChartNumeros.Series["Primos"].Points.AddY(1);
                        entro = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("No es posible generar la lista de numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrarCharts()
        {
            ChartNumeros.Series["Orden"].Points.Clear();
            ChartNumeros.Series["Pares"].Points.Clear();
            ChartNumeros.Series["Impares"].Points.Clear();
            ChartNumeros.Series["Primos"].Points.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
