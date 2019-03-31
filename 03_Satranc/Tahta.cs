using _03_SatrancTas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Satranc
{
    public class Tahta
    {
        public const int _kareBoyut = 50;
        private Kare[,] karelerim;

        public Tahta()
        {
            karelerim = new Kare[8, 8];
            KareleriOlustur();
        }

        public Kare[,] KareListesi
        {
            get { return karelerim; }
        }

        void KareleriOlustur()
        {
            Kare kare;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        kare = new Kare(Renkler.Siyah, new Konum(i, j));
                    }
                    else
                    {
                        kare = new Kare(Renkler.Beyaz, new Konum(i, j));
                    }
                    karelerim[i, j] = kare;
                }
            }
        }

        Kare RastgeleBosKareGetir()
        {
            Kare bosKare = null;
            Random rnd = new Random();

            if (BosKareVarMi())
            {
                do
                {
                    int x = rnd.Next(8);
                    int y = rnd.Next(8);
                    bosKare = karelerim[x, y];
                } while (bosKare.UzerindeTasVarMi());
            }

            return bosKare;
        }

        bool BosKareVarMi()
        {
            return Taslar.TaslarListesi.Count < 64;
        }

        public void TasUret(TasTipleri tasTipi)
        {
            Kare yerlestirilecekKare = RastgeleBosKareGetir();
            Tas eklenecekTas = null;

            switch (tasTipi)
            {
                case TasTipleri.At:
                    eklenecekTas = new At();
                    break;
                case TasTipleri.Fil:
                    eklenecekTas = new Fil();
                    break;
                case TasTipleri.Kale:
                    eklenecekTas = new Kale();
                    break;
            }

            eklenecekTas.Lokasyon = yerlestirilecekKare.Lokasyon;
            Taslar.TasEkle(eklenecekTas);
        }

        public string TasResminiGetir(Kare ustundeBulunduguKare)
        {
            Tas istenenTas = null;
            foreach (Tas item in Taslar.TaslarListesi)
            {
                if (item.Lokasyon.Equals(ustundeBulunduguKare.Lokasyon))
                {
                    istenenTas = item;
                    break;
                }
            }

            return istenenTas.Resim;
        }

        public void TaslariHareketEttir()
        {
            List<Konum> goturulebilecekYerler = new List<Konum>();
            bool sonuc = false;
            Random rnd = new Random();
            foreach (Tas item in Taslar.TaslarListesi)
            {
                sonuc = TasHareketEdebilirMi(item, ref goturulebilecekYerler);
                if (sonuc)
                {
                    Konum yenikonum = goturulebilecekYerler[rnd.Next(goturulebilecekYerler.Count)];
                    item.Lokasyon = yenikonum;
                    goturulebilecekYerler.Clear();
                }
            }
        }

        bool TasHareketEdebilirMi(Tas t, ref List<Konum> gidebilecegiYerler)
        {
            Kare kare = null;
            foreach (Konum item in t.GidebilecegiYerler)
            {
                if (item.X < 0 || item.Y < 0 || item.X > 7 || item.Y > 7)
                {
                    continue;
                }
                kare = KonumaGoreKareGetir(item);
                if (!kare.UzerindeTasVarMi())
                {
                    gidebilecegiYerler.Add(item);
                }
            }

            return gidebilecegiYerler.Count > 0;
        }

        Kare KonumaGoreKareGetir(Konum k)
        {
            return karelerim[k.X, k.Y];
        }
    }
}
