using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeArea
{
    public partial class Form1 : Form
    {
        string forma;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            Apagar();
            //Ativando necessário e mudando labels
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label1.Text = "Base:";
            label2.Visible = true;
            label2.Text = "Altura";
            //Desativando desnecessários
            textBox3.Visible = false;
            label3.Visible=false;
            forma = "Triangulo";
            labelTipoForma.Text = "Calculo de área do " + forma;
            exemTriangulo();
        }

        private void btnRetangulo_Click(object sender, EventArgs e)
        {
            Apagar();
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label1.Text = "Base:";
            label2.Visible = true;
            label2.Text = "Altura";
            textBox3.Visible = false;
            label3.Visible = false;
            forma = "Retangulo";
            labelTipoForma.Text = "Calculo de área do " + forma;
            exemRetangulo();
        }

        private void btnLosango_Click(object sender, EventArgs e)
        {
            Apagar();
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label1.Text = "Diagonal maior:";
            label2.Visible = true;
            label2.Text = "Diagonal menor";
            textBox3.Visible = false;
            label3.Visible = false;
            forma = "Losango";
            labelTipoForma.Text = "Calculo de área do " + forma;
            exemLosango();
        }

        private void btnTrapezio_Click(object sender, EventArgs e)
        {
            Apagar();
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Visible = true;
            label1.Text = "Base maior:";
            label2.Visible = true;
            label2.Text = "Base menor";
            label3.Visible = true;
            label3.Text = "Altura";
            forma = "Trapezio";
            labelTipoForma.Text = "Calculo de área do " + forma;
            exemTrapezio();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Apagar();
            textBox1.Visible=true;
            label1.Visible=true;
            label1.Text = "Raio:";
            textBox2.Visible = false;
            label2.Visible = false;
            textBox3.Visible = false;
            label3.Visible = false;
            forma = "Circulo";
            labelTipoForma.Text = "Calculo de área do " + forma;
            exemCirculo();
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            Apagar();
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "Lado:";
            textBox2.Visible = false;
            label2.Visible = false;
            textBox3.Visible = false;
            label3.Visible = false;
            forma = "Quadrado";
            labelTipoForma.Text = "Calculo de área do " + forma;
            exemQuadrado();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        private double calcularQuadrado(double lado)
        {
            return Math.Pow(lado,2);
        }
        private double calcularRetangulo(double bas, double altura)
        {
            return bas * altura;
        }
        private double calcularLosango(double basMn, double basMr)
        {
            return (basMn * basMr) / 2;
        }
        private double calcularTrapezio(double basMn, double basMr, double altura)
        {
            return ((basMn + basMr) * altura) / 2;
        }
        private double calcularCirculo(double raio)
        {
            return Math.PI * raio;
        }
        private double calcularTriangulo(double bas, double altura)
        {
            return (altura * bas)/2;
        }

        private async void btnResultado_Click(object sender, EventArgs e)
        {
            bool contaFeita;
            double txt1, txt2, txt3, resultadoFinal = 0;

            if (forma == "Triangulo")
            {
                txt1 = double.Parse(textBox1.Text);
                txt2 = double.Parse(textBox2.Text);
                if (txt1 > 0 && txt2 > 0)
                {
                    resultadoFinal = calcularTriangulo(txt1, txt2);
                    exemTriangulo();
                    contaFeita = true;
                }
                else
                {
                    labelAviso.Visible = true;
                    System.Media.SystemSounds.Hand.Play();
                    await Task.Delay(4000);
                    labelAviso.Visible = false;
                    contaFeita = false;
                }
            }
            else if (forma == "Retangulo")
            { 
                txt1 = double.Parse(textBox1.Text);
                txt2 = double.Parse(textBox2.Text);
                if (txt1 > 0 && txt2 > 0)
                {
                    resultadoFinal = calcularRetangulo(txt1, txt2);
                    exemRetangulo();
                    contaFeita = true;
                }
                else
                {
                    labelAviso.Visible = true;
                    System.Media.SystemSounds.Hand.Play();
                    await Task.Delay(4000);
                    labelAviso.Visible = false;
                    contaFeita = false;
                }
            }
            else if(forma == "Losango")
            { 
                txt1 = double.Parse(textBox1.Text);
                txt2 = double.Parse(textBox2.Text);
                if (txt1 > 0 && txt2 > 0)
                {
                    resultadoFinal = calcularLosango(txt1, txt2);
                    exemLosango();
                    contaFeita = true;
                }
                else
                {
                    labelAviso.Visible = true;
                    System.Media.SystemSounds.Hand.Play();
                    await Task.Delay(4000);
                    labelAviso.Visible = false;
                    contaFeita = false;
                }
            }
            else if(forma == "Trapezio")
            {
                txt1 = double.Parse(textBox1.Text);
                txt2 = double.Parse(textBox2.Text);
                txt3 = double.Parse(textBox3.Text);
                if (txt1 > 0 && txt2 > 0 && txt3 > 0)
                {
                    resultadoFinal = calcularTrapezio(txt1, txt2, txt3);
                    exemTrapezio();
                    contaFeita = true;
                }
                else
                {
                    labelAviso.Visible = true;
                    System.Media.SystemSounds.Hand.Play();
                    await Task.Delay(4000);
                    labelAviso.Visible = false;
                    contaFeita = false;
                }
            }
            else if (forma == "Circulo")
            { 
                txt1 = double.Parse(textBox1.Text);
                if (txt1 > 0)
                {
                    resultadoFinal = calcularCirculo(txt1);
                    exemCirculo();
                    contaFeita = true;
                }
                else
                {
                    labelAviso.Visible = true;
                    System.Media.SystemSounds.Hand.Play();
                    await Task.Delay(4000);
                    labelAviso.Visible = false;
                    contaFeita = false;
                }
            }
            else
            {
                txt1 = double.Parse(textBox1.Text);
                if (txt1 > 0)
                {
                    resultadoFinal = calcularQuadrado(txt1);
                    exemQuadrado();
                    contaFeita = true;
                }
                else
                {
                    labelAviso.Visible = true;
                    System.Media.SystemSounds.Hand.Play();
                    await Task.Delay(4000);
                    labelAviso.Visible = false;
                    contaFeita = false;
                }
            }
            if(contaFeita)
                txtResultado.Text = resultadoFinal.ToString();
        }

        private void exemRetangulo()
        {
            picboxImg.Image = Properties.Resources.retangulo;
            picboxImg.Visible = true;
            txtMed1.Visible = true;
            txtMed1.Location = new Point (98, 40);
            txtMed1.Text = textBox1.Text;
            txtMed2.Visible = true;
            txtMed2.Location = new Point(220, 88);
            txtMed2.Text = textBox2.Text;
            txtMed3.Visible = false;
            txtVal1.Visible = true;
            txtVal1.Location = new Point(70, 246);
            txtVal1.Text = textBox1.Text;
            txtVal2.Visible = true;
            txtVal2.Location = new Point(170, 246);
            txtVal2.Text = textBox2.Text;
            labelSinal1.Visible = true;
            labelSinal1.Text = "X";
            labelSinal1.Location = new Point(150, 250);
            labelDivisao.Visible = false;
            labelNumeroDiv.Visible = false;
            txtVal3.Visible = false;
            label5.Visible = false;
            labelAuxiliar.Visible = false;
        }
        private void exemLosango()
        {
            picboxImg.Image = Properties.Resources.losango;
            picboxImg.Visible = true;
            txtMed1.Visible = true;
            txtMed1.Location = new Point(185, 52);
            txtMed1.Text = textBox1.Text;
            txtMed2.Visible = true;
            txtMed2.Location = new Point(21, 134);
            txtMed2.Text = textBox2.Text;
            txtVal1.Visible= true;
            txtVal1.Location = new Point(31, 224);
            txtVal1.Text = textBox1.Text;
            txtVal2.Visible = true;
            txtVal2.Location = new Point(220, 224);
            txtVal2.Text = textBox2.Text;
            labelSinal1.Visible = true;
            labelSinal1.Text= "X";
            labelSinal1.Location = new Point(150, 228);
            labelDivisao.Visible = true;
            labelNumeroDiv.Visible = true;
            labelNumeroDiv.Location = new Point(147, 264);
            txtVal3.Visible = false;
            label5.Visible = false;
            labelAuxiliar.Visible = false;
        }
        private void exemTrapezio()
        {
            picboxImg.Image = Properties.Resources.trapezio;
            picboxImg.Visible = true;
            txtMed1.Visible= true;
            txtMed1.Location = new Point(101, 32);
            txtMed1.Text = textBox2.Text;
            txtMed2.Visible= true;
            txtMed2.Location = new Point(101, 159);
            txtMed2.Text = textBox1.Text;
            txtMed3.Visible= true;
            txtMed3.Location = new Point(207, 88);
            txtMed3.Text = textBox3.Text;
            labelSinal1.Visible = true;
            labelSinal1.Text = "+";
            labelSinal1.Location = new Point(105, 225);
            labelDivisao.Visible = true;
            labelNumeroDiv.Visible = true;
            labelNumeroDiv.Location = new Point(147, 264);
            txtVal1.Visible = true;
            txtVal1.Text = textBox1.Text;
            txtVal1.Location = new Point(27, 224);
            txtVal2.Visible = true;
            txtVal2.Location = new Point(155, 224);
            txtVal2.Text = textBox2.Text;
            txtVal3.Visible= true;
            txtVal3.Location = new Point(260, 225);
            txtVal3.Text = textBox3.Text;
            label5.Visible = true;
            labelAuxiliar.Visible = true;
            labelAuxiliar.Location = new Point(233, 226);
            labelAuxiliar.Text = ") X";

        }
        private void exemCirculo()
        {
            picboxImg.Image = Properties.Resources.circulo;
            picboxImg.Visible = true;
            txtMed1.Visible = true;
            txtMed1.Location = new Point(220, 90);
            txtMed1.Text = textBox1.Text;
            txtVal1.Visible = true;
            txtVal1.Location = new Point(27, 225);
            txtVal1.Text = "3,14";
            txtVal2.Visible = true;
            txtVal2.Location = new Point(170, 225);
            txtVal2.Text = textBox1.Text;
            labelAuxiliar.Visible = true;
            labelAuxiliar.Text = " ^    2";
            labelAuxiliar.Location = new Point(260, 230);
            labelSinal1.Visible = true;
            labelSinal1.Location = new Point(130, 225);
            labelSinal1.Text = "X";
            label5.Visible = false;
            labelDivisao.Visible = false;
            labelNumeroDiv.Visible = false;
            txtVal3.Visible = false;
            txtMed2.Visible = false;
            txtMed3.Visible = false;
        }
        private void exemTriangulo()
        {
            picboxImg.Image = Properties.Resources.triangulo;
            picboxImg.Visible = true;
            txtMed1.Visible = true;
            txtMed1.Text = textBox2.Text;
            txtMed1.Location = new Point(207, 81);
            txtMed2.Visible = true;
            txtMed2.Text = textBox1.Text;
            txtMed2.Location = new Point(108, 171);
            txtVal1.Visible = true;
            txtVal1.Text = textBox1.Text;
            txtVal1.Location = new Point(27, 224);
            labelSinal1.Visible = true;
            labelSinal1.Text = "X";
            labelSinal1.Location = new Point(147, 225);
            txtVal2.Visible = true;
            txtVal2.Text = textBox2.Text;
            txtVal2.Location = new Point(220, 225);
            labelDivisao.Visible = true;
            labelNumeroDiv.Visible = true;
            txtVal3.Visible = false;
            label5.Visible = false;
            labelAuxiliar.Visible = false;
            txtMed3.Visible = false;
        }
        private void exemQuadrado()
        {
            picboxImg.Image = Properties.Resources.quadrado;
            picboxImg.Visible = true;
            txtMed1.Visible = true;
            txtMed1.Text = textBox1.Text;
            txtMed1.Location = new Point(207, 81);
            labelSinal1.Visible = true;
            labelSinal1.Text= " ^    2";
            labelSinal1.Location = new Point(160, 225);
            txtVal1.Visible = true;
            txtVal1.Text = textBox1.Text;
            txtVal1.Location = new Point(80, 224);
            labelAuxiliar.Visible= false;
            labelNumeroDiv.Visible= false;
            labelDivisao.Visible= false;
            txtVal2.Visible= false;
            txtVal3.Visible = false;
            label5.Visible = false;
            labelAuxiliar.Visible = false;
            txtMed3.Visible = false;
            txtMed2.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Apagar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            txtResultado.Clear();
            txtVal1.Clear();
            txtVal2.Clear();
            txtVal3.Clear();
            txtMed1.Clear();
            txtMed2.Clear();
            txtMed3.Clear();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
