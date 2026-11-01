using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervazyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] tip = { "Standart", "Deluxe", "Suit" };

            foreach (string t in tip)
            {
                comboOda.Items.Add("Standart");
                comboOda.Items.Add("Deluxe");
                comboOda.Items.Add("Suit");

              
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal fiyat;

            if (!decimal.TryParse(textGeceFiyat.Text, out fiyat))
                return;

            try
            {
                Rezervasyon A = new Rezervasyon();
                A.MusteriAdi = textMusteri.Text;
                A.OdaTipi = comboOda.SelectedItem == null ? " " : comboOda.SelectedItem.ToString();
                A.GeceSayisi =(int ) nudGeceSayisi.Value;
                A.GecelikFiyat = fiyat;

                decimal odenecek;
                if (checkKahvalti.Checked)
                {
                    odenecek = A.KahvaltiliTutar(true);
                }
                else
                    odenecek = A.Tutar;
                lblSonuc.Text = "Müşteri Adı:" + A.MusteriAdi + "\n"+
                "Oda Tipi:"+A.OdaTipi + "\n"+
                "Gece Sayısı:"+ A.GeceSayisi + "\n"+
                "Gecelik Fiyat:"+A.GecelikFiyat + "\n";


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkKahvalti_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
