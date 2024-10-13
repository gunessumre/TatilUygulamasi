using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçin: Bodrum, Marmaris, Çeşme");
            string location = Console.ReadLine().ToLower(); 

            int locationfee = 0;
            string locationinfo = "";
            
            switch (location)
            {
                case "bodrum":
                    locationfee = 4000;
                    locationinfo = "Bodrum mandalinası dünyaca ünlüdür.";
                    break;
                case "marmaris":
                    locationfee = 3000;
                    locationinfo = "masmavi denizi, tertemiz havası, büyüleyici doğası, barlar sokağı, " +
                                   "plajları ve tertemiz sokakları ile meşhurdur.";
                    break;
                case "cesme":
                    locationfee = 5000;
                    locationinfo = "Çeşme, doğal güzellikleriyle de adından söz ettiren bir yer.";
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız. Lütfen Bodrum, Marmaris ya da Çeşme seçeneklerinden birini girin.");
                    continue;  
            }

            Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
            int peopleNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Lokasyon: {location.ToUpper()} - {locationinfo}");
            Console.WriteLine($"Kişi sayısı: {peopleNumber}");

            int transportationfee = 0;
            bool validtransaction = false;
            
            while (!validtransaction)
            {
                Console.WriteLine("Tatilinize nasıl gitmek istersiniz?\n1 - Kara yolu (Kişi başı ulaşım ücreti: 1500 TL)\n2 - Hava yolu (Kişi başı ulaşım ücreti: 4000 TL)");
                string transportationchoice = Console.ReadLine();

                if (transportationchoice == "1")
                {
                    transportationfee = 1500;
                    validtransaction = true;
                }
                else if (transportationchoice == "2")
                {
                    transportationfee = 4000;
                    validtransaction = true;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız. Lütfen 1 ya da 2 seçeneklerinden birini seçiniz.");
                }
            }
            
            int totalPrice = (locationfee + transportationfee) * peopleNumber;
            Console.WriteLine($"Toplam tatil maliyetiniz: {totalPrice} TL");
            
            bool Continue = true;
            Console.WriteLine("Yeni rezervasyon ister misiniz? (E/H)");
            string answer = Console.ReadLine().ToLower();

            if (answer != "e")
            {         
                Continue = false;
                Console.WriteLine("İyi günler!");
                break;

            }
        }
    }
}

