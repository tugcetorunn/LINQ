// LINQ-1 den devam

// 6- extension method (genişleten metod) (linq)

// var olan bir classın source koduna erişemiyorum. bu class a nasıl metod vs eklerim? kalıtım alabiliriz. ya sealed sa? extension metod.

// class ve metod static olmalı.
// extension metodu hangi yapıya bağlamak istiyorsak metodun ilk parametresinde this keywordü ile bağlamak istediğimiz yapıyı belirtiyoruz.

using LINQ_2;

int sayi = 24;
Console.WriteLine(sayi.KareAl());

// extension a bir örnek -> db bağlantısı için hangi provider ı yüklediysek onconfiguring metodunda o provider a ait metod yükleniyor.

// Enumerable; // ienumerable interface ini miras almış tüm sınıflarda bu metodları görürüz. tek bir yerde tüm ienumerable tipindeki nesneler için metodlar tanımlanmıştır.

// biz nasıl nerelerde kullanırız?

List<int> list = new List<int>();

list.Select(i => i);

// 7- expression tree ()

Console.WriteLine(sayi.KupAl().IkiyeBol().KareAl().SayiIleCarp(2)); // linq sorguları da bu şekilde yazılıyor.

// 8- lambda expression - delegelerde metod yazmada kullanılır.



