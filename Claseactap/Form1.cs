using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Claseactap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }
        //Metodo para agregar los valores al lbox
        private void agregar()
        {
            //Variables
            double valor;

            valor = Convert.ToDouble(textBox1.Text);

            listBox1.Items.Add(valor);//Agregamos las notas del estudiante al listbox
            textBox1.Text = string.Empty;
            textBox1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Instancia de la clase
            Calculos ca = new Calculos();
            //Variable
            int suma = 0, con = listBox1.Items.Count; //Obtener cantidad de elementos de listbox
            string valor;
            // ciclo for para la sumatoria
            for(int i = 0; i < con; i++) 
            {
                valor = listBox1.Items[i].ToString();
                suma = suma + Convert.ToInt32(valor);
            }
            textBox2.Text = suma.ToString();
            //Generar una instancia al metodo
            textBox3.Text = (ca.promedio(con,suma)).ToString();
            label7.Text = ca.resultado(con,suma);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        //Metodo para limpiar los cuadros de texto

        private void Limpiar()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox1.Focus();
            listBox1.Items.Clear();
            label7.Text = "Aprobado/Reprobado";
        }
    }
}
