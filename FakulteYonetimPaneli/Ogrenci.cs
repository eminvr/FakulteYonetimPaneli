using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakulteYonetimPaneli
{
    public class Ogrenci : IPerson
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Yas { get; set; }
        public string TCKN { get; set; }
        public string TelNo { get; set; }
        public string Durum { get; set; }
       
    }
}
