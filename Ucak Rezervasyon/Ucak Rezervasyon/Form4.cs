using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ROTA: " + comboBox1.Text + " - " + comboBox2.Text + " - " + " Tarih: " + dateTimePicker1.Text + " - " + " Saat: " + maskedTextBox1.Text+ " YOLCU BİLGİLERİ ----> AD VE SOYAD: " + textBox1.Text+ " TCKN: "+ maskedTextBox2.Text+ " Telefon: "+ maskedTextBox3.Text);
            MessageBox.Show("YOLCU KAYDI OLDU");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;
        }
    }
}
