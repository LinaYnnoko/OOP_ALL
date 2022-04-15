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
    public partial class FormGPU : Form
    {
        public FormGPU()
        {
            InitializeComponent();
        }

        GPU gpu = new GPU();

        string strMess;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gpu.model = radioButton2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpu.performance = comboBox1.Items[comboBox1.SelectedIndex].ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpu.series = comboBox2.Items[comboBox2.SelectedIndex].ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpu.frequency = comboBox4.Items[comboBox4.SelectedIndex].ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpu.memory = comboBox3.Items[comboBox3.SelectedIndex].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.comp.gpu = gpu;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gpu.model = radioButton1.Text;
        }

        private void FormGPU_Load(object sender, EventArgs e)
        {
            foreach (RadioButton rb in this.Controls.OfType<RadioButton>()) //обходим радиобатоны
                rb.CheckedChanged += new EventHandler(rb_CheckedChanged); //подписываем обработчик
        }

        void rb_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked) //если батон чекнут
                strMess = (sender as RadioButton).Text; //запоминаем его текст

            gpu.supportDirect = strMess;
        }
    }
}
