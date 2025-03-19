// c# 3.0 ile gelen yenilikler

// 1- var kullanımı - diğer tipler gibi bir tip değildir. daha doğrusu tip değildir. tipini bilmediğimiz değerler için kullanırız. runtime da veya daha sonra bu belirlenebilir. tip belli oluncaya kadar o tipin yerine kullanılaan ifadedir.

using LINQ_1;

var d1 = 123;
var d2 = "merhaba";
var d3 = 't';
var d4 = 124.99; // float64 -> double
var d5 = 33.55m;
var d6 = 44l;
var d7 = true;
var d8 = new List<string>();
var d9 = new int[5];

// d1 = "naber"; ilk değer geldikten sonra tipi değiştiremiyoruz.

// c# 4.0 ile gelen özellikler

dynamic d10 = "hello"; // var gibi bu da bir tip değildir.
d10 = 123; // object olarak değer tutuyor

// dynamic vs object
Object obj = new object();
obj = 12;
// int sayi = obj;
int sayi = (int)obj; // object kendinden alt sınıf olan tipe değer gönderemez. cast işlemi gerekir.

dynamic d11 = 12;
int sayi2 = d11; // içinde tipi de tuttuğu için 

// dynamic genelde mvc core da geçer. viewbag dynamic viewdata object tir.

// 2- auto property - public int Id { get; set; } backing field ların otomatik oluşturulduğu field lara auto property diyoruz. property ler değer tutmaz sadece içerisinde değer tutan metodlar içerir. ayrıca encapsulation uygulayarak class içerisindeki field ları dışarıya kapatmış oluyoruz.

// personel class ını ildasm uygulamasıyla oluşan field, backing field ve metodları görebiliriz.
// win aramaya developer command prompt a.ılıp ildasm komutu yazdığımızda açılır. açılan pencereye uygulamamızın dll dosyasını ekleyerek inceleriz.

// semi auto property çıkacak (yarı otomatik)

// 3- object initializer

Personel personel = new Personel() { Id = 1, Name = "tugce", Surname = "torun"};

// 4- collection initializer

List<Personel> personels = new List<Personel>() { personel, new Personel() { Id = 1, Name = "tugce", Surname = "torun" } };

// 5- anonymus object(type)

// delegate olmadan anonymus method yazamayız.

// linq teki join sorgusunda ve mvc de mvchelper larda kullanırız. (object olanı)

var d12 = new { Id = 11, Ad = "kemal", Adres = "kadıköy" };
