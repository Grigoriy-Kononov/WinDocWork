using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDocWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helper = new WordHelper("blank-zayavleniya-o-priyome-na-rabotu.docx");

            var items = new Dictionary<string, string>
            {
                { "<ORG>", textBox3.Text },
                { "<FIO>", textBox4.Text },
                { "<PROF>", textBox5.Text },
                { "<DATE_FROM>", dateTimePicker3.Value.ToString("dd.MM.yyyy") },
                { "<MONTHS>", numericUpDown1.Value.ToString() },
                { "<SALARY>", textBox6.Text },
                { "<DATE>", dateTimePicker4.Value.ToString("dd.MM.yyyy") }
            };

            helper.Process(items);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var helper = new WordHelper("blank-zayavleniya-na-otpusk.docx");

            var items = new Dictionary<string, string>
            {
                { "<ORG>", textBox7.Text },
                { "<FIO>", textBox8.Text },
                { "<DATE_FROM>", dateTimePicker6.Value.ToString("dd.MM.yyyy") },
                { "<DAYS>", numericUpDown2.Value.ToString() },
                { "<DATE>", dateTimePicker5.Value.ToString("dd.MM.yyyy") }
            };

            helper.Process(items);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var helper = new WordHelper("blank_zayavleniya_ob_uvolnenii_po_sobstvennomu_gelaniyu.docx");

            var items = new Dictionary<string, string>
            {
                { "<ORG>", textBox1.Text },
                { "<FIO>", textBox2.Text },
                { "<DATE_FROM>", dateTimePicker1.Value.ToString("dd.MM.yyyy") },
                { "<DATE>", dateTimePicker2.Value.ToString("dd.MM.yyyy") }
            };

            helper.Process(items);
        }
    }
}
