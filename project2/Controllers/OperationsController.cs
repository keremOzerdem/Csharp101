public static class OperationsController
{
    //Uygulama ilk başladığında kullanıcıya yapmak istediği işlemi soran fonksiyon
    public static void StartPrint()
    {
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz! : ");
        Console.WriteLine("*********************************************");
        Console.WriteLine("(1) Board Listelemek");
        Console.WriteLine("(2) Board'a Kart Eklemek");
        Console.WriteLine("(3) Board'dan Kart Silmek");
        Console.WriteLine("(4) Kart Taşımak");
    }

    // Board listeleme fonksiyonu
    public static void PrintBoard()
    {
        foreach (var item in BoardModel.BoardModelDict)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine("********************");
            int counter = item.Value.Count;
            if (counter == 0)
            {
                Console.WriteLine("-BOŞ-");
            }
            foreach (var item2 in item.Value)
            {
                counter--;
                Console.WriteLine("Başlık: {0}", item2.Title);
                Console.WriteLine("İçerik: {0}", item2.Content);
                Console.WriteLine("Atanan Kişi Numarası: {0} , Atanan Kişi Adı: {1}", item2.PeopleId, PeopleIdToName(item2.PeopleId));
                Console.WriteLine("Büyüklük: {0}", item2.Size);
                if (counter >= 1)
                {
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }

    // Kart ekleme fonksiyonu
    public static void AddCard()
    {
        Console.WriteLine("Başlık Giriniz: ");
        string title = Console.ReadLine();
        Console.WriteLine("İçerik Giriniz: ");
        string content = Console.ReadLine();
        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) : ");
        Console.WriteLine("Eğer 1-5 Aralığı Dışında değer girerseniz default olarak XL atanacaktır.");
        int sizeNumber = int.Parse(Console.ReadLine());
        string size = EnumToSize(sizeNumber);
        UserPrint();
        Console.WriteLine("Eklemek İstediğiniz Kişi Listede Mevcut mu?");
        Console.WriteLine("Mevcutsa y, Değilse n giriniz.");
        Console.WriteLine("y/n");
        string userControl = Console.ReadLine();
        if (userControl == "y")
        {
            Console.WriteLine("Lütfen Görev Eklemek İstediğiniz Kişi Id Numarasını Giriniz: ");
            int peopleId = int.Parse(Console.ReadLine());
            int control = 0;
            foreach (var item in TeamUserList.TeamList)
            {
                if (item.Id == peopleId)
                {
                    Console.WriteLine("Kişi mevcut, ekleme başarılı...");
                    ToDoLine.ToDoLineList.Add(new CardModel(title, content, peopleId, size));
                    control++;
                }
            }
            if (control == 0)
            {
                Console.WriteLine("Kişi bulunamadı, işlemden çıkılıyor...");
            }
        }
        else if (userControl == "n")
        {
            Console.WriteLine("Kişi Eklemek İster misiniz? (y/n)");
            string userAddControl = Console.ReadLine();
            if (userAddControl == "y")
            {
                UserPrint();
                Console.WriteLine("Kişi Adı Giriniz: ");
                string userAddUsername = Console.ReadLine();
                int userAddId = ((TeamUserList.TeamList.Count) + 1);
                TeamUserList.TeamList.Add(new TeamUserModel(userAddId, userAddUsername));
                Console.WriteLine("Kişi mevcut, ekleme başarılı...");
                ToDoLine.ToDoLineList.Add(new CardModel(title, content, userAddId, size));
            }
            else
            {
                Console.WriteLine("Çıkılıyor...");
            }
        }
        else
        {
            Console.WriteLine("Hatalı Karakter Girildi, Çıkılıyor...");
        }
    }

    // Kart silme fonksiyonu
    public static void DeleteCard()
    {
        int control = 0;
        int check = 0;
        string title = "";
        while (control == 0)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmelisiniz!");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            title = Console.ReadLine();
            foreach (var item in BoardModel.BoardModelDict)
            {
                foreach (var item2 in item.Value)
                {
                    if (item2.Title == title)
                    {
                        Console.WriteLine("Kart bulundu siliniyor...");
                        item.Value.Remove(item2);
                        control++;
                        break;
                    }
                }
            }
            if (control == 0)
            {
                Console.WriteLine("Aradığınız kriterlerde uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("-Silmeyi Sonlandırmak için: (1)");
                Console.WriteLine("-Yeniden denemek için: (2)");
                check = int.Parse(Console.ReadLine());
                if (check == 1)
                {
                    control++;
                }
            }
        }
    }

    //Kart taşıma fonksiyonu
    public static async void MoveCard()
    {
        int control = 0;
        int check = 0;
        int lineNumber;
        string title = "";
        while (control == 0)
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            title = Console.ReadLine();

            foreach (var item in BoardModel.BoardModelDict)
            {
                if (control == 0)
                {
                    foreach (var item2 in item.Value)
                    {
                        if (item2.Title == title)
                        {
                            Console.WriteLine("Bulunan Kart Bilgileri: ");
                            Console.WriteLine("*********************************************");
                            Console.WriteLine("Başlık: {0}", item2.Title);
                            Console.WriteLine("İçerik: {0}", item2.Content);
                            Console.WriteLine("Atanan Kişi: {0}", item2.PeopleId);
                            Console.WriteLine("Büyüklük: {0}", item2.Size);
                            Console.WriteLine("Line: {0}", item.Key);
                            Console.WriteLine("Lütfen taşımak istediğiniz line Numarasını giriniz:");
                            Console.WriteLine("(1) TODO");
                            Console.WriteLine("(2) ıN PROGRESS");
                            Console.WriteLine("(3) DONE");
                            lineNumber = int.Parse(Console.ReadLine());
                            if (lineNumber == 1)
                            {
                                ToDoLine.ToDoLineList.Add(new CardModel(item2.Title, item2.Content, item2.PeopleId, item2.Size));
                                item.Value.Remove(item2);
                                control++;
                                break;
                            }
                            else if (lineNumber == 2)
                            {
                                InProgressLine.InProgressLineList.Add(new CardModel(item2.Title, item2.Content, item2.PeopleId, item2.Size));
                                item.Value.Remove(item2);
                                control++;
                                break;
                            }
                            else if (lineNumber == 3)
                            {
                                DoneLine.DoneLineList.Add(new CardModel(item2.Title, item2.Content, item2.PeopleId, item2.Size));
                                item.Value.Remove(item2);
                                control++;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalu giriş, çıkılıyor...");
                                control++;
                                break;
                            }
                        }
                        if (control > 0)
                        {
                            break;
                        }
                    }
                }
            }
            if (control == 0)
            {
                Console.WriteLine("Aradığınız kritelere uygun kart, board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("-Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("-Yeniden denemek için : (2)");
                check = int.Parse(Console.ReadLine());
                if (check == 1)
                {
                    control++;
                }
            }
        }
    }

    //takım üyelerini atayan fonksiyon
    public static void AddUser(int id, string name)
    {
        TeamUserList.TeamList.Add(new TeamUserModel(id,name));
    }

    // id'e göre ilgili kişiyi getiren fonksiyonumuz
    public static string PeopleIdToName(int id)
    {
        foreach (var item in TeamUserList.TeamList)
        {
            if (item.Id == id)
            {
                return item.Username;
            }
        }
        return null;
    }

    // kişi listesini ekrana yazdıran fonksiyonumuz
    public static void UserPrint()
    {
        Console.WriteLine("***Kişi Listesi***");
        foreach (var item in TeamUserList.TeamList)
        {
            Console.WriteLine("Kişi Numarası: {0} , Kişi Adı: {1}", item.Id, item.Username);
        }
        Console.WriteLine("***Kişiler Listesinin Sonu***");
    }

    //kullanıcı seçimine göre hangi işlemin gerçekleştirilecekse
    //o fonksiyonu çağıran fonksiyon
    public static void CallFunction(int number)
    {
        if (number == 1)
        {
            PrintBoard();
        }
        else if (number == 2)
        {
            AddCard();
        }
        else if (number == 3)
        {
            DeleteCard();
        }
        else if (number == 4)
        {
            MoveCard();
        }
    }

    //kullanıcı tarafından girilen operasyon seçiminin doğru seçim aralığında 
    //olup olmadığını kontrol eden fonksiyon
    public static int ControlFunction(int number)
    {
        if (number >= 1 && number <= 4)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public static string EnumToSize(int number)
    {
        if (number == 1)
        {
            return CardSizeEnumModel.XS.ToString();
        }
        else if (number == 2)
        {
            return CardSizeEnumModel.S.ToString();
        }
        else if (number == 3)
        {
            return CardSizeEnumModel.M.ToString();
        }
        else if (number == 4)
        {
            return CardSizeEnumModel.L.ToString();
        }
        else
        {
            return CardSizeEnumModel.XL.ToString();
        }
    }

}