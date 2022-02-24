using System;

namespace CinZodyagi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Çin Zodyağı nasıl hesaplanır?
            Çin zodyağı hesaplanırken kişinin doğum yılının 12 ile bölümünde kalana göre bulunur.
            Doğum Tarihi %12 = 0 ➜ Maymun
            Doğum Tarihi %12 = 1 ➜ Horoz
            Doğum Tarihi %12 = 2 ➜ Köpek
            Doğum Tarihi %12 = 3 ➜ Domuz
            Doğum Tarihi %12 = 4 ➜ Fare
            Doğum Tarihi %12 = 5 ➜ Öküz
            Doğum Tarihi %12 = 6 ➜ Kaplan
            Doğum Tarihi %12 = 7 ➜ Tavşan
            Doğum Tarihi %12 = 8 ➜ Ejderha
            Doğum Tarihi %12 = 9 ➜ Yılan
            Doğum Tarihi %12 = 10 ➜ At
            Doğum Tarihi %12 = 11 ➜ Koyun
            */

            Console.Write("Doğum tarihinizi giriniz : ");
            int dateBirth=Convert.ToInt16(Console.ReadLine());
            int number=dateBirth%12;
            string message="Çin zodyağı burcunuz : ";
            message=number switch{
                0=>message+="Maymun",
                1=>message+="Horoz",
                2=>message+="Köpek",
                3=>message+="Domuz ",
                4=>message+="Fare",
                5=>message+="Öküz",
                6=>message+="Kaplan",
                7=>message+="Tavşan",
                8=>message+="Ejderha",
                9=>message+="Yılan",
                10=>message+="At",
                11=>message+="Koyun"
            };
            Console.WriteLine(message);
        }
    }
}
