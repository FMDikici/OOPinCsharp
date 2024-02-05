using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp_projeler5._2
{
    public class KrediKarti
    {
        protected double limit; // Kredi kartının limitini tutan değişken
        protected string hangikart; // Kredi kartının ismini tutan değişken
        protected int harcamaSayisi; // Kredi kartının harcama sayısını tutan değişken

        // Kredi kartının yapıcı metodu
        public KrediKarti(double limit, string hangikart)
        {
            this.limit = limit; // Kartın limitini başlangıç değeriyle ayarla
            this.hangikart = hangikart; // Kartın ismini başlangıç değeriyle ayarla
            this.harcamaSayisi = 0; // Harcama sayısını başlangıç değeriyle sıfırla
        }

        // Harcama yapma işlemini gerçekleştiren metot
        public virtual void HarcamaYap(double tutar)
        {
            // Limit aşılmamış ve harcama tutarı limitten küçükse
            if (limit > 0 && tutar <= limit)
            {
                string format = String.Format("{0} kartından {1} TL harcama yapıldı", hangikart, tutar);
                limit -= tutar; // Harcama yapıldığı için limitten düş
                harcamaSayisi++; // Harcama sayısını bir artır
                Console.WriteLine(format); // Kullanıcıya harcama bilgisi göster
            }
            else
            {
                // Harcama yapılamıyorsa, kullanıcıya bilgi mesajı göster
                Console.WriteLine("Harcama Yapılamıyor...Limit Aşımı Gerçekleşti..");
            }
        }

        // Ekstreyi gösterme işlemini gerçekleştiren metot
        public virtual void EkstreyiGoster()
        {
            // Ekstre bilgisini formatlı bir şekilde ekrana yazdırma
            Console.Write($"{hangikart} Kalan Limit: {limit} TL\n");
        }
    }

}
