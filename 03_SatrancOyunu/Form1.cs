using _03_Satranc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_SatrancOyunu
{
    public partial class Form1 : Form
    {
        Tahta satrancTahtam;
        public Form1()
        {
            InitializeComponent();
            satrancTahtam = new Tahta();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Size = new Size(Tahta._kareBoyut * 8, Tahta._kareBoyut * 8);
            cmbTasTipleri.DataSource = Enum.GetValues(typeof(TasTipleri));
            TahtayiEkranaCiz();
        }

        private void TahtayiEkranaCiz()
        {
            groupBox1.Controls.Clear();
            Panel pnl = null;
            Kare oAnkiKare = null;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    pnl = new Panel();
                    pnl.Name = "pnl" + i + j;
                    pnl.Width = Tahta._kareBoyut;
                    pnl.Height = Tahta._kareBoyut;
                    pnl.Left = i * Tahta._kareBoyut;
                    pnl.Top = j * Tahta._kareBoyut;
                    oAnkiKare = satrancTahtam.KareListesi[i, j];

                    if (oAnkiKare.UzerindeTasVarMi())
                    {
                        string resim = satrancTahtam.TasResminiGetir(oAnkiKare);
                        pnl.BackgroundImage = Image.FromFile(Application.StartupPath + "\\" + resim);
                        pnl.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        pnl.BackColor = oAnkiKare.Renk == Renkler.Siyah ? Color.Black : Color.White;
                    }
                    
                    groupBox1.Controls.Add(pnl);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TasTipleri secilenTas = (TasTipleri)cmbTasTipleri.SelectedItem;
            satrancTahtam.TasUret(secilenTas);
            TahtayiEkranaCiz();
        }

        private void btnTaslariHareketEttir_Click(object sender, EventArgs e)
        {
            //satrancTahtam.TaslariHareketEttir();
            //TahtayiEkranaCiz();
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            satrancTahtam.TaslariHareketEttir();
            TahtayiEkranaCiz();
        }
    }
}
