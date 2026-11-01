using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervazyon
{
    internal class Rezervasyon
    {
        private string _ad = "";
        private string oda = "";

        private int _gece;
        private decimal _fiyat;

        public string MusteriAdi
        {
            get { return _ad; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Müşteri adı boş olamaz!");
                        _ad = value;
            }


        }
        public string OdaTipi
        {
            get { return oda; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Oda Tipi Seçilmeli!");
                        oda = value;
            }

        }
        public int GeceSayisi
        {
            get { return _gece; }

            set
            {
                if (value < 1 || value > 30)
                    throw new ArgumentException("Gece Sayısı 1-30 arası olamlı!");
                _gece = value;
            }
        }
        public decimal GecelikFiyat
        {
            get { return _fiyat; }

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Gecelik fiyat 0dan büyük olmalı!");
                _fiyat = value;
            }
        }
        public decimal Tutar => GecelikFiyat * GeceSayisi;

        public decimal KahvaltiliTutar(bool kahvalti)
        {
            if (true)
                return (GecelikFiyat + 250m) * GeceSayisi;
            else

            return Tutar;
        }
    }
}
