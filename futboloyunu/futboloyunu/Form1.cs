using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futboloyunu
{
    public partial class Form1 : Form
    {
        private Kale kaleci = new Kale();
        private OrtaSaha ortaSaha = new OrtaSaha();
        private Defans defans = new Defans();
        private Kale2 kaleci2= new Kale2();
        private int skorA = 0;
        private int skorB = 0;


        public Form1()
        {
            InitializeComponent();
            GuncelleSkorLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Kaleci1_Click(object sender, EventArgs e)
        {
            string sonuc= kaleci2.GolDurumu();
            if (sonuc.Contains("Gol oldu"))
            {
                skorA++;
               
            }
            GuncelleSkorLabel();
            label1.Text = sonuc;
        
        }

        private void Kaleci2_Click(object sender, EventArgs e)
        {
            string sonuc = kaleci.GolDurumu();
            if (sonuc.Contains("Gol oldu"))
            {
                skorB++;
                
            }
            GuncelleSkorLabel();

            label1.Text = sonuc;
           
           
        }

        private void Orta1_Click(object sender, EventArgs e)
        {
            string sonuc =ortaSaha.PasVer();
            label1.Text = sonuc;
        }

        private void Orta2_Click(object sender, EventArgs e)
        {
            string sonuc=ortaSaha.SutDene();
            label1.Text = sonuc;
        }

        private void Defans2_Click(object sender, EventArgs e)
        {
            string sonuc = defans.PasVer();
            label1.Text = sonuc;
        }

        private void Defans1_Click(object sender, EventArgs e)
        {
            string sonuc = defans.GolAt();
            label1.Text = sonuc;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void GuncelleSkorLabel()
        {
            label2.Text = string.Format("A Takimi {0} - B Takimi {1}", skorA, skorB);
            
        }
        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = string.Format("B Takımı");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = string.Format("A Takımı");
        }

        
    }
}
