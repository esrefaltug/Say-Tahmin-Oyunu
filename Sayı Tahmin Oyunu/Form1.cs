using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        int sayi = 0, tahmin_sayi = 0, puan = 1000;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int tahmin;
            tahmin_sayi++;
            if (tahmin_sayi<=10)
            {
                tahmin = int.Parse(textBox1.Text);
                label6.Text = tahmin_sayi.ToString();
                if (sayi<tahmin)
                {
                    label5.Text = "Tahmininizi azaltınız.";
                    puan = puan - 100;
                    label7.Text = puan.ToString();
                }
                else if (sayi>tahmin)
                {
                    label5.Text = "Tahmininizi arttırınız.";
                    puan = puan - 100;
                    label7.Text = puan.ToString();

                }
                else
                {
                    MessageBox.Show("Doğru Tahmin Tebriklerr" + label6.Text + ". denemede buldunuz." + label7.Text + "puanınız.");
                    button2.Enabled = true;
                    button1.Enabled = false;
                    tahmin_sayi = 0;
                    puan = 1000;
                }
                textBox1.Text = "";
                
            }
            else
            {
                textBox1.Enabled = false;
                MessageBox.Show("Hakkınız kalmadı kaybettiniz :( oyun kapatılacak");
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random rnd = new Random();
            sayi = rnd.Next(100);
            
            label5.Text = " ";
            label6.Text = "0";
            label7.Text = "1000";
            
            
            
        }
    }
}
