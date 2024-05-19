using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RMPOKS_PZ10_LorenzWeightCalculator
{
    public partial class Form1 : Form
    {
        int height = 0;
        int result = 0;
        int sex_koeff = 0;
        int age = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate()
        {

            if (rbmale.Checked==true)
            {
                sex_koeff = 4;
            }
            else if (rbfemale.Checked==true) {
                sex_koeff = 2;
            }
            else
            {
                sex_koeff = 0;
            }


            if (!Int32.TryParse(textBoxHeight.Text, out height) || !Int32.TryParse(textBoxAge.Text, out age))
            {
                MessageBox.Show($"Введенное значение в поле Рост или Возраст не распознано, как целое число. Повторите ввод.");
            }
            else
            {
                Int32.TryParse(textBoxAge.Text, out age);
                Int32.TryParse(textBoxHeight.Text, out height);
                if (height < 140 || height > 220)
                {
                    MessageBox.Show("Рост должен быть больше 140 см и меньше 220 см!");
                    ideal_weight.Text = "0";
                } else if (age<18) {
                    MessageBox.Show("Возраст должен быть старше 18!");
                    ideal_weight.Text = "0";
                } else {
                    result = height - 100 - ((height - 150) / sex_koeff);
                    ideal_weight.Text = Convert.ToString(result);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void weight_Click(object sender, EventArgs e)
        {

        }
    }
}
