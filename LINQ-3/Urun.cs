using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_3
{
    internal class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public int KategoriId { get; set; }

        public override string ToString()
        {
            return $"{Id} {Ad} {Fiyat} {KategoriId}";
        }

        // navigation property ler iki şeye yarar;
        // join yazmak zorunda kalmayız.
        // 
    }
}
