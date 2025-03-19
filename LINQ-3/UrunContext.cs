using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_3
{
    internal static class UrunContext // context sınıfına benzetmeye çalıştık.
    {
        public static List<Kategori> Kategoriler => new List<Kategori>() 
        { 
            new Kategori { Id = 1, KategoriAd = "Kırtasiye" },
            new Kategori { Id = 2, KategoriAd = "Hobi" },
            new Kategori { Id = 3, KategoriAd = "Hediyelik Eşya" },
            new Kategori { Id = 4, KategoriAd = "Elektronik" },
        };

        public static List<Urun> Urunler => new List<Urun>()
        {
            new Urun { Id = 11, Ad = "Defter", Fiyat = 45, KategoriId = 1 },
            new Urun { Id = 12, Ad = "Pergel", Fiyat = 55, KategoriId = 1 },
            new Urun { Id = 13, Ad = "Maket uçak", Fiyat = 250, KategoriId = 2 },
            new Urun { Id = 14, Ad = "Puzzle", Fiyat = 450, KategoriId = 2 },
            new Urun { Id = 15, Ad = "Vazo", Fiyat = 370, KategoriId = 3 },
            new Urun { Id = 16, Ad = "Magnet", Fiyat = 85, KategoriId = 3 },
            new Urun { Id = 17, Ad = "Ayıcık", Fiyat = 368, KategoriId = 3 },
            new Urun { Id = 18, Ad = "Oyun hamuru", Fiyat = 120, KategoriId = 2 },
            new Urun { Id = 19, Ad = "Hesap makinesi", Fiyat = 395, KategoriId = 4 },
            new Urun { Id = 110, Ad = "Anahtarlık", Fiyat = 75, KategoriId = 3 },
        };
    }
}
