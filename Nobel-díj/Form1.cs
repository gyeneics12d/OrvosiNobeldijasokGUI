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

namespace Nobel_díj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            int num;
            bool isNum = int.TryParse(textBox1.Text.Trim(), out num);
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nem lehet üres egyik mező sem!");
            }
            else if (isNum==false)
            {
                MessageBox.Show("Hiba, az évszám nem megfelelő!");
            }
            else if (int.Parse(textBox1.Text) < 1989)
            {
                MessageBox.Show("Hiba, az évszám nem megfelelő!");
            }
            else if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nem lehet üres egyik mező sem!");
            }
            else if (textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nem lehet üres egyik mező sem!");
            }
            else if (textBox4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Nem lehet üres egyik mező sem!");
            }
            else
            {
                try
                {
                    StreamWriter sw = new StreamWriter("uj_dijazott.txt");
                    sw.WriteLine($"Év;Név;SzületésHalálozás;Országkód" +
                        $"\n{textBox1.Text};{textBox2.Text};{textBox3.Text};{textBox4.Text}");

                    MessageBox.Show("Sikeres mentés!");
                    sw.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show($"Hiba történt a mentés során. \n {error}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
