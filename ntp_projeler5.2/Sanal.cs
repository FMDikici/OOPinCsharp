using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ntp_projeler5._2
{
    public class Sanal : KrediKarti
    {
        protected new int harcamaSayisi; // Sanal kartın harcama sayısını tutan değişken
        protected new string hangikart; // Sanal kartın ismini tutan değişken

        // Sanal kartın yapıcı metodu
        public Sanal(double limit, string hangikart) : base(limit, hangikart)
        {
            this.limit = limit;
            this.hangikart = hangikart;
            harcamaSayisi = 0; 
        }

        // Harcama yapma işlemini gerçekleştiren metot
        public override void HarcamaYap(double tutar)
        {
            double asimHakki = (limit < 800) ? limit : 800; // Sanal kartın aşım hakkı

            if (harcamaSayisi < 5)
            {
                // Harcama tutarı aşım hakkından küçükse veya limitten küçükse
                if (tutar <= asimHakki || tutar <= limit)
                {
                    base.HarcamaYap(tutar); // Temel sınıftaki HarcamaYap metodu çağrılır
                }
                else
                {
                    // Harcama yapılamıyorsa, kullanıcıya bilgi mesajı gösterilir
                    Console.WriteLine($"{hangikart} Sanal Kartında belirtilen tutarda harcama yapılamıyor. Limit ve aşım limiti aşıldı!");
                }
            }
            else
            {
                // Harcama limiti aşıldıysa, kullanıcıya bilgi mesajı gösterilir
                Console.WriteLine($" {hangikart} Sanal Kartında bir aylık harcama limiti aşıldı.");
            }
        }

        // Ekstreyi gösterme işlemini gerçekleştiren metot
        public override void EkstreyiGoster()
        {
            // Ekstre bilgisini formatlı bir şekilde ekrana yazdırma
            string format = String.Format("{0} kalan Limit: {1}\n", hangikart, limit);
            Console.WriteLine(format);
        }
    }

}
