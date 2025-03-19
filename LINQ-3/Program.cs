// LINQ to object (to sql, to xml diğer türler)

// linq sorguları iki şekilde yazılır -> like sql, expression tree

// like sql;

// sorgular
// id ile ilgili önemli bir şey anlatacak hoca!

// 1- tüm ürünler

using LINQ_3;
using System.Runtime.CompilerServices;

void Yazdir(IEnumerable<Urun> urunler)
{
    foreach (var u in urunler)
        Console.WriteLine(u.ToString());
}

// LIKE SQL

var result = from u in UrunContext.Urunler 
             select u;
var result2 = from u in UrunContext.Urunler
              where u.KategoriId == 3
              select u;
var result3 = from u in UrunContext.Urunler
              orderby u.Fiyat descending
              select u;
var result4 = (from u in UrunContext.Urunler
              join k in UrunContext.Kategoriler
              on u.KategoriId equals k.Id
              select new
              {
                  u.Id,
                  u.Ad,
                  u.Fiyat,
                  k.KategoriAd // aynı isimde property olmaması gerekiyor.
              }).Take(2); // bi like sql bi tree yapabiliriz.

//Yazdir(result.ToList());
//Yazdir(result2.ToList());
//Yazdir(result3.ToList());

//foreach (var item in result4)
//{
//    Console.WriteLine(item);
//}

// EXPRESSION TREE

var sonuc = UrunContext.Urunler.Select(x => x); // x geldi x çıktı (ürün geldi ürün çıktı, sadece x değişiklik yok) // Select(x => x.ToString())
var sonuc2 = UrunContext.Urunler.Where(x => x.KategoriId == 3).ToList();
var sonuc3 = UrunContext.Urunler.OrderByDescending(x => x.Fiyat).ToList();
var sonuc4 = UrunContext.Urunler.Join(UrunContext.Kategoriler, x => x.KategoriId, y => y.Id, (x, y) => new
{
    x.Id, x.Ad, x.Fiyat, y.KategoriAd
});

//Yazdir(sonuc.ToList());
//Yazdir(sonuc2.ToList());
//Yazdir(sonuc3.ToList());

//foreach (var item in sonuc4)
//{
//    Console.WriteLine(item);
//}

int id = 17;

var sorgu = from u in UrunContext.Urunler 
            where u.Id == id 
            select u;
var sorgu2 = (from u in UrunContext.Urunler
            where u.Id == id
            select u).ToList();

id = 14;
Yazdir(sorgu.ToList()); // gecikmeli mod - (deffered mode) linq sorguları, nşa da sorguyu yazdığımız yerde değil çağırdığımızda derlenir.
// immediate mode olarak çalıştıranlar tolist, toarray
Yazdir(sorgu2);
