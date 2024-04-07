using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        /*kullanıcı adı


         şifre oluştur

         doğru ve yanlışlardaki mesajları ata

         kullanıcı adı doğru olmazsa tekrar girdir
        sifre yanlış olursa tekrar girdir

         şifreden sonra ne yapmak istediğini sor para yatır,çek
        ekranda bakiyeyi göster 
        para yatırırsa bakiyeye ekle
        para çekerse bakiyeden çıkar
        yetersiz bakiye sorununu yaz
         */



        string adsoyad = "yunus";

        var sifre = 5834;



        Console.WriteLine("kullanıcı adı giriniz");

        var kullanıcı_adı = Console.ReadLine();



        string dogru = "kullanıcı adınız dogru sifrenizi giriniz.";

        string yanlis = "kullanıcı adınız hatalı";

        string sifredogru = "giriş başarılı";







        if (adsoyad == kullanıcı_adı)

        {

            Console.WriteLine(dogru);


        }

        else
        {


            Console.WriteLine(yanlis);
        }



        string password = Console.ReadLine();


        int converted_password = Convert.ToInt32(password);


        string sdogru = "helal la sana";

        string syanlis = "sifreniz yanlıs";


        if (sifre == converted_password)

        {
            Console.WriteLine(sdogru);
        }

        else
        {
            Console.WriteLine(syanlis);

        }


        Console.Clear();

        string yatır_cek = "para yatırmak icin y tusuna cekmek icin c tusuna basınız";




        int bakiye = 1000;

        Console.WriteLine("hesap bakiyeniz: " + bakiye + "TL");


        Console.WriteLine(yatır_cek);


        var key = Console.ReadKey();

        if (key.Key == ConsoleKey.Y)
        {

            Console.WriteLine("yatırmak istediginiz tutarı girin");

            int yatır = Convert.ToInt32(Console.ReadLine());

            bakiye += yatır;

            Console.WriteLine(bakiye);

        }

        else if (key.Key == ConsoleKey.C)

        {

            Console.WriteLine("cekmek istediginiz tutarı girin");

            int cek = Convert.ToInt32(Console.ReadLine());

            if (cek < bakiye)
            {

                bakiye -= cek;

                Console.WriteLine(cek);

                Console.WriteLine(bakiye);

                Console.WriteLine("cekme isleminiz basarılı kalan bakiyeniz: " + bakiye);

            }

            Console.WriteLine("Cekmek istediginiz tutar bakiyenizden fazla bu işlemi yapamazsınız");

        }

        else
        {
            Console.WriteLine("lütfen gecerli bir tusa basınız");

        }

    }
}