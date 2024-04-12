namespace Authoritycheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba yetki kontrol protokolüne hoş geldiniz!");
            Console.ReadLine();
            Console.Clear();
            Console.Write("Lütfen kullanıcı adı oluşturunuz: ");
            string kadi = Console.ReadLine();
            Console.Clear();
            Console.Write("Lütfen şifre oluşturunuz: ");
            int sifre = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.Write("Kullanıcı adı giriniz: ");
            string x = Console.ReadLine();
            string mesaj = $"Hoş geldin {kadi},";
            string giris = $" sistem güvenli bir şekilde çalışmaktadır!";
            if (x == kadi)
            {
                Console.Write("şifre giriniz: ");
                int y = int.Parse(Console.ReadLine());
                Console.Clear() ;
                    if (y == sifre)
                {
                    mesaj = mesaj + giris;
                }
                    else
                {
                   mesaj = "Hata! lütfen tekrar deneyiniz!!!";
                }

            }
            else
            {
                mesaj = "Hata! Lütfen tekrar deneyiniz!!!";
            }
            Console.WriteLine(mesaj);
           
        }
    }
}
