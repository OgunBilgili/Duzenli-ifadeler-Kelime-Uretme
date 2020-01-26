using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// non saprei descrivermi.

namespace Otomata_Odev_18
{
    public partial class Form1 : Form
    {
        private List<string> results;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Liste.Text = "";
            Kelime_Uretici test = new Kelime_Uretici(Alfabe.Text, Duzenli.Text);
            results = test.Kelime_Uret(Int32.Parse(comboBox1.Text.ToString()));
            //results.Sort();
            //Boolean sonuc = false;

            if (TumKelimeler.Checked)
            {
                foreach (var i in results)
                {
                    Liste.AppendText(i);
                    Liste.AppendText(Environment.NewLine);
                }

                if (Liste.Text == "")
                {
                    MessageBox.Show("Alfabeden düzenli ifade üretilemez", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int count = 1;
                if (Sayi.Text == "")
                {
                    MessageBox.Show("Listelenilecek Kelime Sayısını Giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var i in results)
                    {
                        Liste.AppendText(i);
                        Liste.AppendText(Environment.NewLine);
                        if (count == Int32.Parse(Sayi.Text))
                            break;
                        count++;
                    }
                }
            }
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            Boolean sonuc = false;
            if(results == null)
            {
                MessageBox.Show("Kelimeler Dahaca Oluşturulmadı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (string i in results)
                {
                    if (i.Contains(Arama.Text) && i.Length == Arama.Text.Length)
                    {
                        MessageBox.Show("Bu kelime L diline aittir.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                        sonuc = true;
                    }
                }
                if (sonuc == false)
                {
                    if(Arama.Text == "")
                        MessageBox.Show("Aranacak bir kelime giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Bu kelime L diline ait değildir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

/*
            string Alfabe = "a b c";
            string Expression = "(a+b)*(a)";
            SimplyRegex regex = new SimplyRegex(Alfabe,Expression);
            //regex.printStats();
            List<string> results = regex.Execute(3);
            
            foreach(var i in results)
            {
                Console.WriteLine(i);
            }
*/