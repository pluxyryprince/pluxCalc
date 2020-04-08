namespace pluxCalc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        ///д, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab = new System.Windows.Forms.TabControl();
            this.Calculator = new System.Windows.Forms.TabPage();
            this.squareofnum = new System.Windows.Forms.Button();
            this.Hexadecimal = new System.Windows.Forms.Button();
            this.Cotangens = new System.Windows.Forms.Button();
            this.squareroot = new System.Windows.Forms.Button();
            this.Tangens = new System.Windows.Forms.Button();
            this.Cosinus = new System.Windows.Forms.Button();
            this.Sinus = new System.Windows.Forms.Button();
            this.octopus = new System.Windows.Forms.Button();
            this.Binary = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.ravno = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.delenie = new System.Windows.Forms.Button();
            this.umnozhenie = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.String = new System.Windows.Forms.TabPage();
            this.Convert = new System.Windows.Forms.TabPage();
            this.tab.SuspendLayout();
            this.Calculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.Calculator);
            this.tab.Controls.Add(this.String);
            this.tab.Controls.Add(this.Convert);
            this.tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab.Location = new System.Drawing.Point(-5, -3);
            this.tab.Margin = new System.Windows.Forms.Padding(4);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(836, 876);
            this.tab.TabIndex = 0;
            // 
            // Calculator
            // 
            this.Calculator.BackColor = System.Drawing.Color.Plum;
            this.Calculator.Controls.Add(this.squareofnum);
            this.Calculator.Controls.Add(this.Hexadecimal);
            this.Calculator.Controls.Add(this.Cotangens);
            this.Calculator.Controls.Add(this.squareroot);
            this.Calculator.Controls.Add(this.Tangens);
            this.Calculator.Controls.Add(this.Cosinus);
            this.Calculator.Controls.Add(this.Sinus);
            this.Calculator.Controls.Add(this.octopus);
            this.Calculator.Controls.Add(this.Binary);
            this.Calculator.Controls.Add(this.textBox1);
            this.Calculator.Controls.Add(this.label1);
            this.Calculator.Controls.Add(this.delete);
            this.Calculator.Controls.Add(this.zero);
            this.Calculator.Controls.Add(this.ravno);
            this.Calculator.Controls.Add(this.nine);
            this.Calculator.Controls.Add(this.eight);
            this.Calculator.Controls.Add(this.seven);
            this.Calculator.Controls.Add(this.six);
            this.Calculator.Controls.Add(this.five);
            this.Calculator.Controls.Add(this.four);
            this.Calculator.Controls.Add(this.three);
            this.Calculator.Controls.Add(this.two);
            this.Calculator.Controls.Add(this.one);
            this.Calculator.Controls.Add(this.delenie);
            this.Calculator.Controls.Add(this.umnozhenie);
            this.Calculator.Controls.Add(this.minus);
            this.Calculator.Controls.Add(this.plus);
            this.Calculator.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Calculator.Location = new System.Drawing.Point(4, 30);
            this.Calculator.Margin = new System.Windows.Forms.Padding(4);
            this.Calculator.Name = "Calculator";
            this.Calculator.Padding = new System.Windows.Forms.Padding(4);
            this.Calculator.Size = new System.Drawing.Size(828, 842);
            this.Calculator.TabIndex = 0;
            this.Calculator.Text = "Основной";
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // squareofnum
            // 
            this.squareofnum.BackColor = System.Drawing.Color.Plum;
            this.squareofnum.Cursor = System.Windows.Forms.Cursors.No;
            this.squareofnum.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.squareofnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareofnum.ForeColor = System.Drawing.SystemColors.InfoText;
            this.squareofnum.Location = new System.Drawing.Point(362, 278);
            this.squareofnum.Margin = new System.Windows.Forms.Padding(4);
            this.squareofnum.Name = "squareofnum";
            this.squareofnum.Size = new System.Drawing.Size(82, 67);
            this.squareofnum.TabIndex = 28;
            this.squareofnum.Text = "x^2";
            this.squareofnum.UseVisualStyleBackColor = false;
            this.squareofnum.Click += new System.EventHandler(this.squareofnum_Click);
            // 
            // Hexadecimal
            // 
            this.Hexadecimal.BackColor = System.Drawing.Color.Plum;
            this.Hexadecimal.Cursor = System.Windows.Forms.Cursors.No;
            this.Hexadecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hexadecimal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Hexadecimal.Location = new System.Drawing.Point(362, 573);
            this.Hexadecimal.Margin = new System.Windows.Forms.Padding(4);
            this.Hexadecimal.Name = "Hexadecimal";
            this.Hexadecimal.Size = new System.Drawing.Size(81, 66);
            this.Hexadecimal.TabIndex = 22;
            this.Hexadecimal.Text = "Hexad";
            this.Hexadecimal.UseVisualStyleBackColor = false;
            // 
            // Cotangens
            // 
            this.Cotangens.BackColor = System.Drawing.Color.Plum;
            this.Cotangens.Cursor = System.Windows.Forms.Cursors.No;
            this.Cotangens.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cotangens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cotangens.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Cotangens.Location = new System.Drawing.Point(272, 278);
            this.Cotangens.Margin = new System.Windows.Forms.Padding(4);
            this.Cotangens.Name = "Cotangens";
            this.Cotangens.Size = new System.Drawing.Size(81, 67);
            this.Cotangens.TabIndex = 27;
            this.Cotangens.Text = "Ctg";
            this.Cotangens.UseVisualStyleBackColor = false;
            this.Cotangens.Click += new System.EventHandler(this.Cotangens_Click);
            // 
            // squareroot
            // 
            this.squareroot.Cursor = System.Windows.Forms.Cursors.No;
            this.squareroot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareroot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.squareroot.Location = new System.Drawing.Point(362, 352);
            this.squareroot.Name = "squareroot";
            this.squareroot.Size = new System.Drawing.Size(81, 67);
            this.squareroot.TabIndex = 26;
            this.squareroot.Text = "Sqrt";
            this.squareroot.UseVisualStyleBackColor = true;
            // 
            // Tangens
            // 
            this.Tangens.Cursor = System.Windows.Forms.Cursors.No;
            this.Tangens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tangens.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Tangens.Location = new System.Drawing.Point(184, 278);
            this.Tangens.Name = "Tangens";
            this.Tangens.Size = new System.Drawing.Size(81, 67);
            this.Tangens.TabIndex = 25;
            this.Tangens.Text = "Tg";
            this.Tangens.UseVisualStyleBackColor = true;
            this.Tangens.Click += new System.EventHandler(this.Tangens_Click);
            // 
            // Cosinus
            // 
            this.Cosinus.Cursor = System.Windows.Forms.Cursors.No;
            this.Cosinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cosinus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cosinus.Location = new System.Drawing.Point(97, 278);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(81, 67);
            this.Cosinus.TabIndex = 24;
            this.Cosinus.Text = "Cos";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.Cosinus_Click);
            // 
            // Sinus
            // 
            this.Sinus.Cursor = System.Windows.Forms.Cursors.No;
            this.Sinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sinus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Sinus.Location = new System.Drawing.Point(10, 278);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(81, 67);
            this.Sinus.TabIndex = 23;
            this.Sinus.Text = "Sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.Sinus_Click);
            // 
            // octopus
            // 
            this.octopus.BackColor = System.Drawing.Color.Plum;
            this.octopus.Cursor = System.Windows.Forms.Cursors.No;
            this.octopus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.octopus.ForeColor = System.Drawing.SystemColors.MenuText;
            this.octopus.Location = new System.Drawing.Point(361, 499);
            this.octopus.Margin = new System.Windows.Forms.Padding(4);
            this.octopus.Name = "octopus";
            this.octopus.Size = new System.Drawing.Size(82, 67);
            this.octopus.TabIndex = 21;
            this.octopus.Text = "Octo";
            this.octopus.UseVisualStyleBackColor = false;
            // 
            // Binary
            // 
            this.Binary.BackColor = System.Drawing.Color.Plum;
            this.Binary.Cursor = System.Windows.Forms.Cursors.No;
            this.Binary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Binary.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Binary.Location = new System.Drawing.Point(361, 426);
            this.Binary.Margin = new System.Windows.Forms.Padding(4);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(81, 67);
            this.Binary.TabIndex = 20;
            this.Binary.Text = "Binary";
            this.Binary.UseVisualStyleBackColor = false;
            this.Binary.Click += new System.EventHandler(this.Binary_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Plum;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(10, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 69);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.No;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.delete.Location = new System.Drawing.Point(10, 572);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(81, 69);
            this.delete.TabIndex = 16;
            this.delete.Text = "Clear";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // zero
            // 
            this.zero.Cursor = System.Windows.Forms.Cursors.No;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zero.Location = new System.Drawing.Point(97, 573);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(81, 67);
            this.zero.TabIndex = 14;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // ravno
            // 
            this.ravno.Cursor = System.Windows.Forms.Cursors.No;
            this.ravno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ravno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ravno.Location = new System.Drawing.Point(184, 573);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(81, 67);
            this.ravno.TabIndex = 13;
            this.ravno.Text = "=";
            this.ravno.UseVisualStyleBackColor = true;
            this.ravno.Click += new System.EventHandler(this.ravno_Click);
            // 
            // nine
            // 
            this.nine.Cursor = System.Windows.Forms.Cursors.No;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nine.Location = new System.Drawing.Point(184, 499);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(81, 67);
            this.nine.TabIndex = 12;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Cursor = System.Windows.Forms.Cursors.No;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eight.Location = new System.Drawing.Point(97, 499);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(81, 67);
            this.eight.TabIndex = 11;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Cursor = System.Windows.Forms.Cursors.No;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.ForeColor = System.Drawing.SystemColors.ControlText;
            this.seven.Location = new System.Drawing.Point(10, 499);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(81, 67);
            this.seven.TabIndex = 10;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // six
            // 
            this.six.Cursor = System.Windows.Forms.Cursors.No;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.ForeColor = System.Drawing.SystemColors.ControlText;
            this.six.Location = new System.Drawing.Point(184, 426);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(81, 67);
            this.six.TabIndex = 9;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Cursor = System.Windows.Forms.Cursors.No;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.ForeColor = System.Drawing.SystemColors.ControlText;
            this.five.Location = new System.Drawing.Point(97, 426);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(81, 67);
            this.five.TabIndex = 8;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Cursor = System.Windows.Forms.Cursors.No;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.ForeColor = System.Drawing.SystemColors.ControlText;
            this.four.Location = new System.Drawing.Point(10, 426);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(81, 67);
            this.four.TabIndex = 7;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.Cursor = System.Windows.Forms.Cursors.No;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.ForeColor = System.Drawing.SystemColors.Desktop;
            this.three.Location = new System.Drawing.Point(184, 353);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(81, 67);
            this.three.TabIndex = 6;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Cursor = System.Windows.Forms.Cursors.No;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.ForeColor = System.Drawing.SystemColors.ControlText;
            this.two.Location = new System.Drawing.Point(97, 353);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(81, 67);
            this.two.TabIndex = 5;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Cursor = System.Windows.Forms.Cursors.No;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.ForeColor = System.Drawing.SystemColors.ControlText;
            this.one.Location = new System.Drawing.Point(10, 353);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(81, 67);
            this.one.TabIndex = 4;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // delenie
            // 
            this.delenie.BackColor = System.Drawing.Color.Plum;
            this.delenie.Cursor = System.Windows.Forms.Cursors.No;
            this.delenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delenie.ForeColor = System.Drawing.SystemColors.MenuText;
            this.delenie.Location = new System.Drawing.Point(272, 573);
            this.delenie.Margin = new System.Windows.Forms.Padding(4);
            this.delenie.Name = "delenie";
            this.delenie.Size = new System.Drawing.Size(81, 67);
            this.delenie.TabIndex = 3;
            this.delenie.Text = "/";
            this.delenie.UseVisualStyleBackColor = false;
            this.delenie.Click += new System.EventHandler(this.delenie_Click);
            // 
            // umnozhenie
            // 
            this.umnozhenie.BackColor = System.Drawing.Color.Plum;
            this.umnozhenie.Cursor = System.Windows.Forms.Cursors.No;
            this.umnozhenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.umnozhenie.ForeColor = System.Drawing.SystemColors.MenuText;
            this.umnozhenie.Location = new System.Drawing.Point(272, 499);
            this.umnozhenie.Margin = new System.Windows.Forms.Padding(4);
            this.umnozhenie.Name = "umnozhenie";
            this.umnozhenie.Size = new System.Drawing.Size(81, 67);
            this.umnozhenie.TabIndex = 2;
            this.umnozhenie.Text = "*";
            this.umnozhenie.UseVisualStyleBackColor = false;
            this.umnozhenie.Click += new System.EventHandler(this.umnozhenie_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.Plum;
            this.minus.Cursor = System.Windows.Forms.Cursors.No;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.ForeColor = System.Drawing.SystemColors.MenuText;
            this.minus.Location = new System.Drawing.Point(272, 428);
            this.minus.Margin = new System.Windows.Forms.Padding(4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(81, 67);
            this.minus.TabIndex = 1;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Plum;
            this.plus.Cursor = System.Windows.Forms.Cursors.No;
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.ForeColor = System.Drawing.SystemColors.InfoText;
            this.plus.Location = new System.Drawing.Point(272, 353);
            this.plus.Margin = new System.Windows.Forms.Padding(4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(81, 67);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // String
            // 
            this.String.BackColor = System.Drawing.Color.Plum;
            this.String.ForeColor = System.Drawing.SystemColors.ControlText;
            this.String.ImeMode = System.Windows.Forms.ImeMode.On;
            this.String.Location = new System.Drawing.Point(4, 30);
            this.String.Margin = new System.Windows.Forms.Padding(4);
            this.String.Name = "String";
            this.String.Padding = new System.Windows.Forms.Padding(4);
            this.String.Size = new System.Drawing.Size(828, 842);
            this.String.TabIndex = 1;
            this.String.Text = "Строковый";
            // 
            // Convert
            // 
            this.Convert.BackColor = System.Drawing.Color.Plum;
            this.Convert.Location = new System.Drawing.Point(4, 30);
            this.Convert.Margin = new System.Windows.Forms.Padding(4);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(828, 842);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "Конверторы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 679);
            this.Controls.Add(this.tab);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Gavrilin\'s calculator";
            this.tab.ResumeLayout(false);
            this.Calculator.ResumeLayout(false);
            this.Calculator.PerformLayout();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage Calculator;
        private System.Windows.Forms.TabPage String;
        private System.Windows.Forms.TabPage Convert;
        private System.Windows.Forms.Button delenie;
        private System.Windows.Forms.Button umnozhenie;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button ravno;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button squareroot;
        private System.Windows.Forms.Button Tangens;
        private System.Windows.Forms.Button Cosinus;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Hexadecimal;
        private System.Windows.Forms.Button octopus;
        private System.Windows.Forms.Button Binary;
        private System.Windows.Forms.Button squareofnum;
        private System.Windows.Forms.Button Cotangens;
    }
}

