/*      Universidad Autonoma de Zacatecas
    Unidad Academica de Ingenieria Electrica
Ingenieria en Computación

Materia : Programacion Visual Y Por Eventos
Docente : Carlos Miles Duron del Villar
Alumno : Kevin Sanchez Robles 4 "A"

            Tarea #4 Windows Forms

 Enero - Junio 2022               Fecha : 29 / Marzo / 2022

*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = textBox3.Visible = false;
            label4.Visible = textBox4.Visible = false;
        }

        private void Operacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Figuras.Text == "Cuadrado" && (Operacion.Text=="Area"||Operacion.Text =="Perimetro"))
            {
                label1.Text = "Lado";
                label1.Visible = textBox1.Visible = true;
                label2.Visible = textBox2.Visible = false;
                label3.Visible = textBox3.Visible = false;
                label4.Visible = textBox4.Visible = false;
            }
            if (Figuras.Text == "Triangulo" && Operacion.Text == "Area")
            {
                label1.Text = "Base";
                label2.Text = "Altura";
                label1.Visible = textBox1.Visible = true;
                label2.Visible = textBox2.Visible = true;
                label3.Visible = textBox3.Visible = false;
                label4.Visible = textBox4.Visible = false;
            }
            if (Figuras.Text == "Triangulo" && Operacion.Text == "Perimetro")
            {
                label1.Text = "Lado 1";
                label2.Text = "Lado 2";
                label2.Text = "Lado 3";
                label1.Visible = textBox1.Visible = true;
                label2.Visible = textBox2.Visible = true;
                label3.Visible = textBox3.Visible = true;
                label4.Visible = textBox4.Visible = false;
            }
            if (Figuras.Text == "Rectangulo" && (Operacion.Text == "Area" || Operacion.Text == "Perimetro"))
            {
                label1.Text = "Base";
                label2.Text = "Altura";
                label1.Visible = textBox1.Visible = true;
                label2.Visible = textBox2.Visible = true;
                label3.Visible = textBox3.Visible = false;
                label4.Visible = textBox4.Visible = false;
            }  
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //------------AREAS----------------
            if (Figuras.Text == "Cuadrado" && Operacion.Text == "Area")
            {
                Double x = Convert.ToDouble(textBox1.Text); 
                txtResultado.Text = (x*x).ToString();
            }

            if (Figuras.Text == "Triangulo" && Operacion.Text == "Area")
            {
                Double b = Convert.ToDouble(textBox1.Text);
                Double a = Convert.ToDouble(textBox2.Text);
                txtResultado.Text = ((a * b) / 2).ToString();
            }
            if (Figuras.Text == "Rectangulo" && Operacion.Text == "Area")
            {
                Double b = Convert.ToDouble(textBox1.Text);
                Double a = Convert.ToDouble(textBox2.Text);
                txtResultado.Text = (a * b).ToString();
            }
            //-----------Perimetros-------------
            if (Figuras.Text == "Triangulo" && Operacion.Text == "Perimetro")
            {
                Double b = Convert.ToDouble(textBox1.Text);
                Double a = Convert.ToDouble(textBox2.Text);
                Double c = Convert.ToDouble(textBox3.Text);
                txtResultado.Text = (a+b+c).ToString();
            }
            if (Figuras.Text == "Rectangulo" && Operacion.Text == "Perimetro")
            {
                Double b = Convert.ToDouble(textBox1.Text);
                Double a = Convert.ToDouble(textBox2.Text);
                txtResultado.Text = ((a + b)*2).ToString();
            }

        }
    }
}
