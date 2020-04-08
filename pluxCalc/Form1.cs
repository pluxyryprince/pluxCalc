using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pluxCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double a;
        public double b;
        public int count;
        public double x;

        private void plus_Click(object sender, EventArgs e)//сложение
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
        }

        private void minus_Click(object sender, EventArgs e)//вычитание

        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
        }

        private void delenie_Click(object sender, EventArgs e)//деление
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
        }

        private void umnozhenie_Click(object sender, EventArgs e)//умножение
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
        }

        private void delete_Click(object sender, EventArgs e)//кнопка "Clear"
        {
            textBox1.Clear();
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)//кнопка 1
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void two_Click(object sender, EventArgs e)//конпка 2
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void three_Click(object sender, EventArgs e)//кнопка 3
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void four_Click(object sender, EventArgs e)//кнопка 4
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void five_Click(object sender, EventArgs e)//конпка 5
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void six_Click(object sender, EventArgs e)//конпка 6
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void seven_Click(object sender, EventArgs e)//кнопка 7
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void eight_Click(object sender, EventArgs e)//кнопка 8
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void nine_Click(object sender, EventArgs e) //кнопка 9
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void zero_Click(object sender, EventArgs e) //кнопка 0
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void ravno_Click(object sender, EventArgs e) //конпка равно
        {
            calculate();
            label1.Text = "";
        }


        /*   public void Except(string box1)
            {
                try
                {
                    double i = Convert.ToDouble(box1);
                    box1 = Convert.ToString(i);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введено нечисловое значение!", "Ошибка");// исключение на ввод букв
                }
                finally
                {
                    label1.Text = "Нажмите С, чтобы стереть.";
                }
            }
            */

        private void calculate() //метод калькулятор
        {
            switch (count)
            {
                case 1:
                    b = a + double.Parse(textBox1.Text);//сложение
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - double.Parse(textBox1.Text);//вычитание
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * double.Parse(textBox1.Text);//умножение
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / double.Parse(textBox1.Text);//деление
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = Math.Sin(a);//синус
                    textBox1.Text = b.ToString();
                    break;
                case 6:
                    b = Math.Cos(a);//косинус
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    b = Math.Tan(a);//тангенс
                    textBox1.Text = b.ToString();
                    break;
                case 8:
                    b = 1 / Math.Tan(a);//котангенс
                    textBox1.Text = b.ToString();
                    break;
                case 9:
                    b = Math.Pow(a, 2);//возведение в квадрат
                    textBox1.Text = b.ToString();
                    break;
                case 10:
                    b = Math.Sqrt(a);//квадратный корень
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }
        }

        private void Calculator_Click(object sender, EventArgs e)
        {

        }

        private void Tangens_Click(object sender, EventArgs e) //тангенс
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 7;
            label1.Text = a.ToString() + "Tan";
        }

        private void Sinus_Click(object sender, EventArgs e)//синус
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label1.Text = a.ToString() + "Sin";
        }

        private void Cosinus_Click(object sender, EventArgs e)//косинус
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 6;
            label1.Text = a.ToString() + "Cos";
        }

        private void Cotangens_Click(object sender, EventArgs e)//котангенс
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 8;
            label1.Text = a.ToString() + "Ctg";
        }

        private void squareofnum_Click(object sender, EventArgs e)//возведение в квадрат
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 9;
            label1.Text = a.ToString() + "Squaring";
        }

        private void Binary_Click(object sender, EventArgs e)
        {
          //  int i = Convert.ToInt32(textBox1.Text);
            //textBox1.Text = Convert.ToString(i, 2);
        }

        private void squareroot_Click(object sender, EventArgs e)//квадратный корень
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 10;
            label1.Text = a.ToString() + "Sqrt";
        }
    }
}
