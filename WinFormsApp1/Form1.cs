using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  // Вывод формы по центру экрана
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox1.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // Исключаем запятую в начале и минус
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox1.Text.Contains(",")) && ((ch != '-' || textBox1.Text.Contains("-")))) // Если число, BACKSPACE запятая или минус, то вводим
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox2.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // Исключаем запятую в начале и минус
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox2.Text.Contains(",")) && ((ch != '-' || textBox2.Text.Contains("-")))) // Если число, BACKSPACE запятая или минус, то вводим
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox3.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // Исключаем запятую в начале и минус
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox3.Text.Contains(",")) && ((ch != '-' || textBox3.Text.Contains("-")))) // Если число, BACKSPACE запятая или минус, то вводим
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox4.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // Исключаем запятую в начале и минус
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox4.Text.Contains(",")) && ((ch != '-' || textBox4.Text.Contains("-")))) // Если число, BACKSPACE запятая или минус, то вводим
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
            
            try
            {
                double a, b, y1, y2, x1, x2, xk;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                y1 = Convert.ToDouble(textBox3.Text);
                y2 = Convert.ToDouble(textBox4.Text);

                x1 = (y1 - b) / a;
                x2 = (y2 - b) / a;
                xk = (x1 + x2) / 2;
                if (a == 0)
                {
                    MessageBox.Show("Число \"a\" не может быть равно нулю!", "Ошибка");
                }
                else
                {
                    textBox5.Text = Convert.ToString(xk);
                }
            }
            catch
            {
                MessageBox.Show("Запятая и минус не могут стоять рядом, а также минус в конце!", "Ошибка записи числа/чисел");
            }
        }
    }
}
