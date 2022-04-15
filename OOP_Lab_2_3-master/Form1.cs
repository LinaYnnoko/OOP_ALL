using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static Computer comp = new Computer();
        DataTable dataTable = new DataTable("Laboratory");


        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new FormCPU();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new FormGPU();
            form.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"^[a-zA-Z]+[@]$"))
            {
                comp.surnameNamePatronymic = textBox2.Text + " " + textBox1.Text + " " + textBox3.Text;
                textBox1.ForeColor = System.Drawing.Color.Green;
            }
            else
                textBox1.ForeColor = System.Drawing.Color.Red;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$"))
            {
                comp.surnameNamePatronymic = textBox2.Text + " " + textBox1.Text + " " + textBox3.Text;
                textBox2.ForeColor = System.Drawing.Color.Green;
            }
            else
                textBox2.ForeColor = System.Drawing.Color.Red;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox3.Text, @"^[a-zA-Z]+$"))
            {
                comp.surnameNamePatronymic = textBox2.Text + " " + textBox1.Text + " " + textBox3.Text;
                textBox3.ForeColor = System.Drawing.Color.Green;
            }
            else
                textBox3.ForeColor = System.Drawing.Color.Red;

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comp.typeRAM = listBox2.Items[listBox2.SelectedIndex].ToString();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comp.sizeRAM = listBox3.Items[listBox3.SelectedIndex].ToString();
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comp.typeHardDisk = listBox5.Items[listBox5.SelectedIndex].ToString();
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comp.sizeHardDisk = listBox4.Items[listBox4.SelectedIndex].ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //monthCalendar1.DateSelected;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Add(dataTable.NewRow());

            int rows = dataGridView1.Rows.Count;

            dataGridView1[0, rows - 2].Value = comp.surnameNamePatronymic;

            dataGridView1[1, rows - 2].Value = comp.typeRAM;
            dataGridView1[2, rows - 2].Value = comp.sizeRAM;
            dataGridView1[3, rows - 2].Value = comp.typeHardDisk;
            dataGridView1[4, rows - 2].Value = comp.sizeHardDisk ;

            dataGridView1[5, rows - 2].Value = comp.cpu.performance;
            dataGridView1[6, rows - 2].Value = comp.cpu.series;
            dataGridView1[7, rows - 2].Value = comp.cpu.model;
            dataGridView1[8, rows - 2].Value = comp.cpu.numberOfCores.ToString();
            dataGridView1[9, rows - 2].Value = comp.cpu.frequency;
            dataGridView1[10, rows - 2].Value = comp.cpu.maxFrequency;
            dataGridView1[11, rows - 2].Value = comp.cpu.archBitDepth;
            dataGridView1[12, rows - 2].Value = comp.cpu.cashSize;


            dataGridView1[13, rows - 2].Value =  comp.gpu.performance.ToString();
            dataGridView1[14, rows - 2].Value =  comp.gpu.series;
            dataGridView1[15, rows - 2].Value = comp.gpu.model;
            dataGridView1[16, rows - 2].Value = comp.gpu.frequency.ToString();
            dataGridView1[17, rows - 2].Value = comp.gpu.supportDirect;
            dataGridView1[18, rows - 2].Value =  comp.gpu.memory.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void размеруОЗУПаскудствоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа: IT лаборатория\nVersion: 1.0 \nLina_Ynnoko_PROD.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add(new DataColumn("ФИО"));
            dataTable.Columns.Add(new DataColumn("Тип ОЗУ"));
            dataTable.Columns.Add(new DataColumn("Размер ОЗУ"));
            dataTable.Columns.Add(new DataColumn("Тип жесткого диска"));
            dataTable.Columns.Add(new DataColumn("Размер жесткого диска"));
            dataTable.Columns.Add(new DataColumn("Производительность процессора"));
            dataTable.Columns.Add(new DataColumn("Серия процессора"));
            dataTable.Columns.Add(new DataColumn("Модель процессора"));
            dataTable.Columns.Add(new DataColumn("Кол-во ядер процессора"));
            dataTable.Columns.Add(new DataColumn("Частота процессора"));
            dataTable.Columns.Add(new DataColumn("Максимальная частота процессора"));
            dataTable.Columns.Add(new DataColumn("Разрядная архитектура процессора"));
            dataTable.Columns.Add(new DataColumn("Размер кэша процессора"));
            dataTable.Columns.Add(new DataColumn("Произволительность видеокарты"));
            dataTable.Columns.Add(new DataColumn("Серия видеокарты"));
            dataTable.Columns.Add(new DataColumn("Модель видеокарты"));
            dataTable.Columns.Add(new DataColumn("Частота видеокарты"));
            dataTable.Columns.Add(new DataColumn("Поддержка DirectX"));
            dataTable.Columns.Add(new DataColumn("Объем памяти видеокарты"));
            dataGridView1.DataSource = dataTable;

            // считать с файла
            string fileName = @"C:\Users\Lina Ynnoko\Desktop\data.xml";
            if (File.Exists(fileName))
            {
                dataTable.ReadXml(fileName);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // записать в файл     
            string fileName = @"C:\Users\Lina Ynnoko\Desktop\data.xml";
            dataTable = (DataTable)dataGridView1.DataSource;
            dataTable.WriteXml(fileName, XmlWriteMode.WriteSchema);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; ++j)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(toolStripTextBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        protected static bool needToReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }

        private void частотеРаботыПроцессораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[9].SortMode = DataGridViewColumnSortMode.Automatic;


            /*var temp;

            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    if (needToReOrder(dataGridView1.Rows[i].Cells[9].Value.ToString(),
                        dataGridView1.Rows[j + 1].Cells[9].Value.ToString()))
                    {
                        temp = dataGridView1.Rows[j];
                        dataGridView1.Rows[j] = dataGridView1.Rows[j + 1];
                        dataGridView1.Rows[j + 1] = temp;
                    }
                }
            }*/
        }
    }
}
