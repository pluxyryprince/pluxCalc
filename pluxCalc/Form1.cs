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

        private void Binary_Click(object sender, EventArgs e) //кнопка перевода в двоичную систему счисления
        {
            int i = int.Parse(textBox1.Text);
            label1.Text = $"bin{i}";
            //textBox1.Text = Convert.ToString(i,2);
            label1.Text = textBox1.Text;
        } 

        private void squareroot_Click(object sender, EventArgs e)//квадратный корень
        {
            a = double.Parse(textBox1.Text);
            textBox1.Clear();
            count = 10;
            label1.Text = a.ToString() + "Sqrt";
        }

        private void octopus_Click(object sender, EventArgs e)//конпка перевода в восьмеричную систему счисления
        {
            int i = int.Parse(textBox1.Text);
            label1.Text = $"bin{i}";
            //textBox1.Text = Convert.ToString(i,8);
            label1.Text = textBox1.Text;
        }

        private void Hexadecimal_Click(object sender, EventArgs e)//кнопка перевода в шестнадцатеричную систему счисления
        {
            int i = int.Parse(textBox1.Text);
            label1.Text = $"bin{i}";
            //textBox1.Text = Convert.ToString(i,16);
            label1.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//чекбокс "определить длину строки"
        {
            string l = textBox2.Text.Length.ToString();
            textBox3.Text = $"Длина строки: {l}";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void upper_CheckedChanged(object sender, EventArgs e)//верхний регистр
        {
            string up = textBox2.Text.ToUpper();
            textBox3.Text = $"{up}";
        }

        private void lower_CheckedChanged(object sender, EventArgs e)//нижний регистр
        {
            string low = textBox2.Text.ToLower();
            textBox3.Text = $"{low}";
        }

        private void stats_CheckedChanged(object sender, EventArgs e)//статистика
        {
            int count = 0;
            //подсчет цифр
            foreach (char ch in textBox2.Text)
            {
                if (Char.IsDigit(ch))
                    count++;
            }
            //подсчет гласных и согласных
            string gl = "уеыаоэяиёюУЕЫАОЭЯИЁЮaeiouAEIOU";
            string sogl = "цкнгшщзхфвпрлджчсмтбЦКНГШЩЗХФВПРЛДЖЧСМТБbcdfghjklmnpqrstvwxyzBCDFGHJKLMNQRSTVWXYZ";
            int i = 0, j = 0;
            //общее кол-во
            textBox2.Text.ToCharArray().All(z =>
            {
                if (gl.ToCharArray().Contains(z)) i++;
                else if
            (sogl.ToCharArray().Contains(z)) j++; return true;
            });
            //вывод
            textBox3.Text = $"Кол-во строк: { ((string[])textBox2.Lines).Length.ToString()} \n" +
                $"Кол-во слов: { textBox2.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length } \n" +
                $"Кол-во цифр: {count} \n" +
                $"Кол-во ласных: {i} \n" +
                $"Кол-во согласных: {j}";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)//исправление ошибок в тексте
        {
            string text = textBox2.Text;
            string[] trues = new string[] { "жи", "ши", "ча", "ща", "чу", "щу" };
            string[] errors = new string[] { "жы", "шы", "чя", "щя", "чю", "щю" };
            for (int i = 0; i < textBox2.Text.Length; i++)//перебираем введенные данные
            {
                for (int j = 0; j < errors.Length; j++) //перебираем ошибки
                {
                    if (textBox2.Text.Contains(errors[j])) //проверка на наличие ошибок
                        text = textBox2.Text.Replace(errors[j], trues[j]); //если они есть, заменяем их
                    textBox3.Text = text;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e)//конвертер
        {

        }
    }
}
