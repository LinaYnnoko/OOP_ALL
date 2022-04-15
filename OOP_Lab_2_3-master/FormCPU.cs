using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class FormCPU : Form
    {
        public FormCPU()
        {
            InitializeComponent();
        }

        CPU cpu = new CPU();
        string strMess;


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpu.performance = Convert.ToInt32(comboBox1.Items[comboBox1.SelectedIndex]);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpu.series = comboBox2.Items[comboBox2.SelectedIndex].ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpu.numberOfCores = Convert.ToInt32 (comboBox3.Items[comboBox3.SelectedIndex]);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpu.frequency = comboBox4.Items[comboBox4.SelectedIndex].ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpu.maxFrequency = comboBox5.Items[comboBox5.SelectedIndex].ToString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cpu.cashSize = comboBox6.Items[comboBox6.SelectedIndex].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.comp.cpu = cpu;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cpu.model = radioButton1.Text;
        }

        private void FormCPU_Load(object sender, EventArgs e)
        {
            foreach (RadioButton rb in this.Controls.OfType<RadioButton>()) //обходим радиобатоны
                rb.CheckedChanged += new EventHandler(rb_CheckedChanged); //подписываем обработчик
        }

        void rb_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked) //если батон чекнут
                strMess = (sender as RadioButton).Text; //запоминаем его текст

            cpu.archBitDepth = strMess; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cpu.model = radioButton2.Text;
        }
    }
}
