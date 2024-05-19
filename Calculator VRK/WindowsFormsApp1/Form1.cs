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



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int koef = 0;
        int height = 0;
        double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate() {
            if (rbfemale.Checked && radioButton3.Checked && radioButton6.Checked) {
                koef = 315;    
            } else if (rbfemale.Checked && radioButton3.Checked && radioButton7.Checked) {
                koef = 325;
            } else if (rbfemale.Checked && radioButton3.Checked && radioButton8.Checked) {
                koef = 335;
            } else if (rbfemale.Checked && radioButton4.Checked && radioButton6.Checked) {
                koef = 325;
            } else if (rbfemale.Checked && radioButton4.Checked && radioButton7.Checked) {
                koef = 345;
            } else if (rbfemale.Checked && radioButton4.Checked && radioButton8.Checked) {
                koef = 360;
            } else if (rbfemale.Checked && radioButton5.Checked && radioButton6.Checked) {
                koef = 355;
            } else if (rbfemale.Checked && radioButton5.Checked && radioButton7.Checked) {
                koef = 370;
            } else if (rbfemale.Checked && radioButton5.Checked && radioButton8.Checked) {
                koef = 380;
            } else {
                koef = 0;
                MessageBox.Show("Рассчет невозможен");
            }

            if (!Int32.TryParse(textBox1.Text, out height))
            {
                MessageBox.Show($"Введенное значение в поле Рост {textBox1.Text} не распознано, как целочисленное. Повторите ввод");
            }
            else
            {
                Int32.TryParse(textBox1.Text, out height);
                if (height < 100)
                {
                    MessageBox.Show("Рост должен быть больше 1 метра!");
                }
                else
                {
                    result = (height * koef) / 1000;
                    ideal_weight.Text = Convert.ToString(result);
                }
            }


        }

            private void radioButton1_CheckedChanged(object sender, EventArgs e) //rbmale
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) //rbfemale
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) //asten
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) //normosten
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) //hypersten
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) //15-18
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e) //19-25
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e) //26-40
        {

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Нормостенический тип — это пропорционально сложенный человек с хорошо развитой мускулатурой, с широкими плечами, выпуклой грудью, небольшим упругим животом и средней длиной конечностей с хорошо развитыми на них мышцами. " +
                "Люди нормостенического типа энергичны, уверены в своих силах. У них отмечается склонность к заболеваниям верхних дыхательных путей, двигательного аппарата, невралгиям, атеросклерозу коронарных сосудов. " +
                "\n\nАстенический тип в сравнении с нормостеническим характеризуется преимущественным развитием тела в длину, стройностью и легкостью его строения. " +
                "Характерны высокий рост, узкая, плоская грудная клетка, покатые плечи, длинная шея, тонкие и длинные конечности, продолговатое лицо, слабое развитие мускулатуры, бледная, тонкая кожа, внутренние органы (сердце, легкие, кишечник и др.) относительно малых размеров. Люди с астеническим типом отличаются повышенной возбудимостью нервной системы, склонностью к птозу (опущению) внутренних органов, неврозам, гипотензии, к туберкулезу, язвенной болезни." +
                "\n\nГиперстенический тип характеризуется большой развитостью в ширину. У таких людей относительно короткое, массивное, упитанное туловище и короткие конечности. Рост средний и ниже среднего. " +
                "Голова круглая, череп большой, шея короткая, плечи широкие, крутые, грудная клетка короткая, широкая, живот большой, выпячен. Размеры сердца сравнительно большие, величина легких относительно мала.\r\nИсточник: https://meduniver.com/Medical/pulmonologia/428.html MedUniver");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
