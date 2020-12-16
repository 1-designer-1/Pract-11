using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Pract_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа № 11\n" +
                              "Серегин Денис \n" +
                              "ИСП-31\n" +
                              "Задание 1 \n" +
                              "Дана строка '23 2+3 2++3 2+++3 445 677'. Напишите регулярное выражение, которое найдет строки 23, 2+3, 2++3, 2+++3, не захватив остальные. \n" +
                              "Задание 2 \n" +
                              "Дана строка '*+ *q+ *qq+ *qqq+ *qqq qqq+'. Напишите регулярное выражение, которое найдет строки *+, *q+, *qq+, *qqq+, не захватив остальные. ", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void получитьОтветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regex regex1 = new Regex("2[+]*3"); 
            Regex regex2 = new Regex("[*][q]*[+]"); 
            MatchCollection matches1 = regex1.Matches(textBox1.Text);
            MatchCollection matches2 = regex2.Matches(textBox2.Text);
            for (int i = 0; i < matches1.Count; i++)
            {
                textBox3.Text += matches1[i].Value + " ";
            }
            for (int j = 0; j < matches2.Count; j++)
            {
                textBox4.Text += matches2[j].Value + " ";
            }

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();

        }
    }
}
