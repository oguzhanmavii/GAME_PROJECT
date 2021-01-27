using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GameManager manager = new GameManager(new UserValidationManager());
            Gamer gamer = new Gamer();
            Console.WriteLine("--------------------------------OYUNCU BİLGİLERİNİZLE SİSTEME GİRİŞ YAPINIZ--------------------------------");
            int ID;
            string AD, SOYAD, TCNO;
            Console.Write("Oyuncu Id sini Giriniz:");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oyuncu Adını Giriniz:");
            AD = Convert.ToString(Console.ReadLine());
            Console.Write("Oyuncu Soyadını Giriniz:");
            SOYAD = Convert.ToString(Console.ReadLine());
            Console.Write("Kimlik Numaranızı Giriniz:");
            TCNO = Convert.ToString(Console.ReadLine());

            manager.Ekle(new Gamer { Id=ID, Ad=AD, Soyad=SOYAD, TcNo=TCNO });

        }
    }
}
