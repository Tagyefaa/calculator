using System;
using System.Windows.Forms;

namespace tapsiriq_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Result düyməsi (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            // Ədədlərin düzgün daxil edilib-edilmədiyini yoxlayırıq
            if (!double.TryParse(textBox1.Text, out double number1) || !double.TryParse(textBox2.Text, out double number2))
            {
                MessageBox.Show("Zəhmət olmasa düzgün ədədlər daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result = 0;
            string command = comboBox1.Text.Trim();

            if (command == "+")
            {
                result = number1 + number2;
            }
            else if (command == "-")
            {
                result = number1 - number2;
            }
            else if (command == "*")
            {
                result = number1 * number2;
            }
            else if (command == "/")
            {
                if (number2 != 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    MessageBox.Show("Sıfıra bölmək olmaz!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa əməliyyat seçin (+, -, *, /)", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cavabı "Answer:  " şəklində label4-ə yazdırırıq
            label4.Text = "Answer:   " + result.ToString();
        }

        // Clear düyməsi (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            label4.Text = "Answer:   0";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}