using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirleyici geri_donuctipi metot_adi(parametrelistesi/arguman)
            //{ 
                //komutlar;
                //return ;
            //}

            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttırVeTopla(a, b);
            ornek.EkranaYazdır(Convert.ToString(sonuc2));
            ornek.EkranaYazdır(Convert.ToString(a+b));
        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(int deger1, int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
