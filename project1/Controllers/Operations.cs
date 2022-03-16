/*Uygulamada olması gereken özellikler aşağıdaki gibidir (5 temel işlev mevcut).

    Telefon Numarası Kaydet
    Telefon Numarası Sil
    Telefon Numarası Güncelle
    Rehber Listeleme (A-Z, Z-A seçimli)
    Rehberde Arama
*/
public static class Operations
{
    //Giriş Karşılaşmalarını yazdıran fonksiyon
    public static void Intro()
    {
        Console.Clear();
        Console.WriteLine("************************TELEFON REHBERI UYGULAMASINA HOŞGELDINIZ************************************");
        Console.WriteLine("Uygulamadan çıkmak için 1-5 dışında herhangi bir şey girmeniz yeterlidir!");
        Console.WriteLine("**********************************************");
        Console.WriteLine("(1) Yeni Bir Numara Kaydetmek");
        Console.WriteLine("(2) Mecvut Bir Numarayı Silmek");
        Console.WriteLine("(3) Mevcut Bir Numarayı GÜncelleme");
        Console.WriteLine("(4) Telefon Rehberini Listelemek");
        Console.WriteLine("(5) Telefon Rehberinde Arama Yapmak");
        Console.WriteLine("**********************************************");
        Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz (1-5) : ");
    }
    public static void ChooseOperation(int choice)
    {

        int choiceOperation = choice;
        while (Operations.ControlNumber(choiceOperation))
        {
            if (choiceOperation == 1)
            {
                Operations.SaveNumber();
                break;
            }
            else if (choiceOperation == 2)
            {
                Operations.DeleteNumber();
                break;
            }
            else if (choiceOperation == 3)
            {
                Operations.UpdateNumber();
                break;
            }
            else if (choiceOperation == 4)
            {
                Operations.PrintNumberList();
                break;
            }
            else if (choiceOperation == 5)
            {
                Operations.SearchNumber();
                break;
            }
            else
            {
                Console.WriteLine("1-5 Aralığı Dışında Bir Sayı Girildi!");
                Console.WriteLine("Program sonlandırılıyor...");
            }
        }

        if (choiceOperation != 4)
        {
            Console.WriteLine("Rehberin Son Hali : ");
            Operations.PrintNumberList();
        }
        Console.Write("Yeni bir işlem yapmak istiyor musunuz? (y/n) : ");
        char askingAgainChoice=Convert.ToChar(Console.ReadLine());

        if (askingAgainChoice == 'y' || askingAgainChoice == 'Y')
        {
            Console.Clear();
            Operations.Intro();
            choice = Convert.ToInt32(Console.ReadLine());
            ChooseOperation(choice);
        }
        else if (askingAgainChoice != 'y' || askingAgainChoice!='Y')
        {
            Console.WriteLine("Program Sona Erdi, Çıkış için herhangi bir tuşa basınız...");
            Console.ReadLine();
        }

    }
    //Girilen sayının 1-5 arasında (1,5 dahil) olup olmadığını kontrol eden fonksiyon
    public static bool ControlNumber(int number)
    {
        if (number >= 1 && number <= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Rehbere yeni bir kullanıcı kaydeden fonksiyon
    public static void SaveNumber()
    {
        Console.Write("Lütfen isim giriniz : ");
        string name = Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz : ");
        string surname = Console.ReadLine();
        Console.Write("Lütfen telefon numarası giriniz : ");
        string number = Console.ReadLine();
        PhoneListModel.PhoneNumberList.Add(new NumberModel(name, surname, number));
    }

    // Rehberde mevcut olan bir kullanıcıyı silen fonksiyon
    public static void DeleteNumber()
    {
        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz : ");
        int check = 0;
        string name = Console.ReadLine();
        foreach (var item in PhoneListModel.PhoneNumberList)
        {
            if (item.Name.ToLower() == name.ToLower() || item.Surname.ToLower() == name.ToLower())
            {
                Console.WriteLine("{0} isimli kişi rehberden silinmesini onaylıyor musunuz ? (y/n)", name);
                char control = char.Parse(Console.ReadLine());
                if (control == 'y' || control == 'Y')
                {
                    int deleteIndex = PhoneListModel.PhoneNumberList.IndexOf(item);
                    PhoneListModel.PhoneNumberList.RemoveAt(deleteIndex);
                    check++;
                    Console.WriteLine("Silme Onayı Başarılı!");
                    break;
                }
                else
                {
                    check++;
                    Console.WriteLine("Silme Onayı Başarısız!");
                    break;
                }
            }
        }
        if (check == 0)
        {
            Console.WriteLine("Aradığınız özellikte veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");
            int selection = int.Parse(Console.ReadLine());
            if (selection == 2)
            {
                while (selection == 2)
                {
                    Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz : ");
                    name = Console.ReadLine();
                    foreach (var item2 in PhoneListModel.PhoneNumberList)
                    {
                        if (item2.Name.ToLower() == name.ToLower() || item2.Surname.ToLower() == name.ToLower())
                        {
                            Console.WriteLine("{0} isimli kişi rehberden silinmesini onaylıyor musunuz ? (y/n)", name);
                            char control = char.Parse(Console.ReadLine());
                            if (control == 'y')
                            {
                                int deleteIndex = PhoneListModel.PhoneNumberList.IndexOf(item2);
                                PhoneListModel.PhoneNumberList.RemoveAt(deleteIndex);
                                check++;
                                selection = 3;
                                Console.WriteLine("Silme Onayı Başarılı!");
                                break;
                            }
                            else
                            {
                                check++;
                                selection = 3;
                                Console.WriteLine("Silme Onayı Başarısız!");
                                break;
                            }

                        }
                    }
                    if (check == 0)
                    {
                        Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine(" Silmeyi sonlandırmak için : (1)");
                        Console.WriteLine(" Yeniden denemek için : (2)");
                        selection = int.Parse(Console.ReadLine());

                    }
                }
            }
        }
    }

    //Belirtilen Özellikle Kişi varsa o kişinin numarasını güncelleyen fonksiyon
    public static void UpdateNumber()
    {
        Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz : ");
        string name = Console.ReadLine();
        int count = PhoneListModel.PhoneNumberList.Count;
        bool isFound = false;
        for (int i = 0; i < count; i++)
        {
            if (PhoneListModel.PhoneNumberList[i].Name.ToLower() == name.ToLower() || PhoneListModel.PhoneNumberList[i].Surname.ToLower() == name.ToLower())
            {
                isFound = true;
                Console.WriteLine("Kişi Bulundu ve Telefon Numarası : {0}", PhoneListModel.PhoneNumberList[i].Number);
                Console.WriteLine("Lütfen bu kişinin yeni telefon numarasını giriniz : ");
                string newNumber = Console.ReadLine();
                PhoneListModel.PhoneNumberList[i].Number = newNumber;
                Console.WriteLine("Telefon Numarası Güncellemesi Başarılı!");
                break;
            }
        }
        if (!isFound)
        {
            Console.WriteLine("Telefon Numarası Güncellemesi Başarısız!");
        }
    }

    // Rehberi listeleyen fonksiyon
    public static void PrintNumberList()
    {
        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine("**************************************************");
        for (int i = 0; i < PhoneListModel.PhoneNumberList.Count; i++)
        {
            Console.WriteLine("isim : {0}", PhoneListModel.PhoneNumberList[i].Name);
            Console.WriteLine("soyisim : {0}", PhoneListModel.PhoneNumberList[i].Surname);
            Console.WriteLine("Telefon Numarası : {0}", PhoneListModel.PhoneNumberList[i].Number);
            Console.WriteLine("-");
        }
    }

    //Belirtilen özellikle rehberde arama yapan fonksiyon
    public static void SearchNumber()
    {
        Console.WriteLine("Arama çeşidinizi belirleyiniz.");
        Console.WriteLine("************************************************");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için : (1)");
        Console.WriteLine("Telefon numarasına göre aramak yapmak için : (2)");
        int selection = int.Parse(Console.ReadLine());
        if (selection == 1)
        {
            Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını ya da soyadını giriniz : ");
            string name = Console.ReadLine();
            foreach (var item in PhoneListModel.PhoneNumberList)
            {
                if (item.Name.ToLower() == name.ToLower() || item.Surname.ToLower() == name.ToLower())
                {
                    Console.WriteLine("isim : {0}", item.Name);
                    Console.WriteLine("soyisim : {0}", item.Surname);
                    Console.WriteLine("telefon numarası : {0}", item.Number);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine("Arama işlemi bitti!");
        }
        else if (selection == 2)
        {
            Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin telefon numarasını giriniz : ");
            string no = Console.ReadLine();
            foreach (var item in PhoneListModel.PhoneNumberList)
            {
                if (item.Number == no)
                {
                    Console.WriteLine("isim : {0}", item.Name);
                    Console.WriteLine("soyisim : {0}", item.Surname);
                    Console.WriteLine("telefon numarası : {0}", item.Number);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine("Arama işlemi bitti!");
        }
        else
        {
            Console.WriteLine("Hatalı Seçim!");
        }
    }
}