namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,World!");
            #region
            /*soru 2
                 /* 2 vize 1 final okutun. vizenin %30 finalin %70'ini alin.
                  * 
                  * Cikan sonuc 0-30 arasindaysa FF
                  * 30-50 araligindaysa DD
                  * 50-70 araligindaysa BB
                  * 70-100 arasindaysa AA
                  * olacak şekilde kullaniciyi bilgilendirin.
                  */
            byte vize1, vize2, final;
            float ortalama = 0;
            Console.Write("Birinci vizeyi giriniz.");
            vize1 = byte.Parse(Console.ReadLine());
            Console.Write("İkinci vizeyi giriniz.");
            vize2 = byte.Parse(Console.ReadLine());
            Console.Write("Finali giriniz.");
            final = byte.Parse(Console.ReadLine());
            ortalama = (vize1 + vize2) / 2 * 0.3f + final * 0.7f;
            if (ortalama > 0 && ortalama < 30)
            {
                Console.WriteLine("FF");

            }
            if (ortalama >= 30 && ortalama < 50)
            {
                Console.WriteLine("DD");
            }
            if (ortalama >= 50 && ortalama < 70)
            {
                Console.WriteLine("BB");
            }
            if (ortalama >= 70 && ortalama <= 100)
            {
                Console.WriteLine("AA");
            }
            #endregion

            #region Ternary IF
            /*
             * 
             * Eger tek satirda bir kontrol yapilacaksa ? operatoru kullanilabilir.
             * 
             * 
             */
            string temp1, temp2;
            temp2 = "";
            temp1 = temp2 == "" ? "Boş" : "Test";
            if (temp1 == "")
            {
                temp1 = "Boş";
            }
            else
            {
                temp2 = "Test";
            }
            #endregion
            Console.WriteLine();
            temp1 = temp2 == null ? "" : "";



            #region switch case
            /*
             * 
             * if-else mantigiyla benzerdir.Aradaki fark if-else buyukluk, kucukluk gibi durumlari kontrol ederken, switch case esitlik durumunda kullanilir.
             */
            string plakakodu;
            Console.WriteLine("Plaka kodun giriniz.");
            plakakodu = Console.ReadLine();
            if (plakakodu == "01")
            {
                Console.WriteLine("Adana");
            }
            else if (plakakodu == "02")
            {
                Console.WriteLine("Adıyaman");
            }
            else if (plakakodu == "03")
            {
                Console.WriteLine("Afyonkarahisar");
            }
            else if (plakakodu == "04")
            {
                Console.WriteLine("Ağrı");
            }
            else if (plakakodu == "05")
            {
                Console.WriteLine("Amasya");
            }
            switch (plakakodu)
            {
                case "01":
                    Console.WriteLine("Adana");
                    break;
                case "02":
                    Console.WriteLine("Adıyaman");
                    break;
                case "03":
                    Console.WriteLine("Afyonkarahisar");
                    break;
                case "04":
                    Console.WriteLine("Ağrı");
                    break;
                case "05":
                    Console.WriteLine("Amasya");
                    break;
                default:
                    break;

            }
            #endregion

            //Sorular
            //    Termary IF



            #region switch case ornekler
            string rol;
            Console.WriteLine("Rol giriniz.");
            rol = Console.ReadLine();
            switch (rol)
            {
                case "Moderator":
                case "CEO":
                case "Administrator":
                    Console.WriteLine("Admin sayfasına yönlendiriliyorsunuz.");
                    break;
                case "Uye":
                case "Member":
                case "Maraba":
                    Console.WriteLine("Üye sayfasına yönlendiriliyorsunuz.");
                    break;
                default:
                    Console.WriteLine("Yetkisiz kullanıcı. Giriş yapınız.");
                    break;


            }
            //Ekrandan ay okutun. 1 girildiyse ocak...12 girildiyse aralik yazdirin.
            #endregion

            #region

            string ay;
            Console.WriteLine("1-12 arasında bir sayı giriniz.");
            ay = Console.ReadLine();
            switch (ay)
            {

                case "1":
                    Console.WriteLine("Ocak");
                    break;
                case "2":
                    Console.WriteLine("Şubat");
                    break;
                case "3":
                    Console.WriteLine("Mart");
                    break;
                case "4":
                    Console.WriteLine("Nisan");
                    break;
                case "5":
                    Console.WriteLine("Mayıs");
                    break;
                case "6":
                    Console.WriteLine("Haziran");
                    break;
                case "7":
                    Console.WriteLine("Temmuz");
                    break;
                case "8":
                    Console.WriteLine("Ağustos");
                    break;
                case "9":
                    Console.WriteLine("Eylül");
                    break;
                case "10":
                    Console.WriteLine("Ekim");
                    break;
                case "11":
                    Console.WriteLine("Kasım");
                    break;
                case "12":
                    Console.WriteLine("Aralık");
                    break;
                default:
                    break;
            }




            #endregion













        }
    }
}