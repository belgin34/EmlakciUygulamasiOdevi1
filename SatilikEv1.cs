using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakciUygulamasiOdevi1
{
    public class SatilikEvler : Evler
    {
        private double satisfiyat;
        string dosyayolu = "C:\\Users\\belgi\\OneDrive\\Desktop\\EmlakciUygulamasi\\SatilikEvler.txt";
        public double Satisfiyat { get => satisfiyat; set => satisfiyat = value; }

        public override string EvBilgileriGetir()
        {
            StreamReader sr = File.OpenText(dosyayolu);
            return sr.ReadToEnd();
        }

        public void EvKayit(List<string> list)
        {

            using (StreamWriter sw = new StreamWriter(dosyayolu, true))
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                    sw.WriteLine("----------------------------------");
                }
            }

        }

        public virtual string EvBilgileri()
        {
            return $"{base.EvBilgileri()} \nFiyat : {satisfiyat}";
        }



    }
}
