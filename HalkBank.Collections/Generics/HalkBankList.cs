using System;
using System.Collections;
using System.Collections.Generic;

namespace HalkBank.Collections.Generics
{
    public class HalkBankList<T> : IBankList<T>, IEnumerable
    {
        protected T[] _dizi;

        public HalkBankList()
        {
            _dizi = new T[0];
        }

        public HalkBankList(int maxElemanSayisi) : this()
        {
            MaxElemanSayisi = maxElemanSayisi;
        }

        public int ElemanSayisi => _dizi.Length;
        public static int MaxElemanSayisi { get; set; } = 10;

        public T this[int index] //C# 7.0
        {
            get => _dizi[index];
            set => _dizi[index] = value;
        }

        public virtual void Ekle(T eleman)
        {
            if (ElemanSayisi >= MaxElemanSayisi)
                throw new System.Exception($"Maksimum eleman sayısına ulaştınız");

            var yedekDizi = _dizi;
            _dizi = new T[yedekDizi.Length + 1];

            //yedekDizi.CopyTo(_dizi, 0);

            for (int i = 0; i < yedekDizi.Length; i++)
            {
                _dizi[i] = yedekDizi[i];
            }

            _dizi[yedekDizi.Length] = eleman;
        }

        public void Sil(int index)
        {
            var yedekDizi = _dizi;
            _dizi = new T[yedekDizi.Length - 1];

            int sayac = 0;

            for (int i = 0; i < yedekDizi.Length; i++)
            {
                if (i == index)
                    continue;

                _dizi[sayac] = yedekDizi[i];
                sayac++;
            }
        }

        public void Temizle()
        {
            _dizi = new T[0];
        }

        //------------------------


        public IEnumerator GetEnumerator()
        {
            //return _dizi.GetEnumerator();
            return new HalkBankListEnumerator(_dizi);
        }

        public void Reverse()
        {
            var yedekDizi = _dizi;
            _dizi = new T[yedekDizi.Length];
            for (int i = 0; i < yedekDizi.Length; i++)
            {
                _dizi[i] = yedekDizi[yedekDizi.Length - 1 - i];
            }
        }

        public int IndexOf(T arananEleman)
        {
            for (int i = 0; i < _dizi.Length; i++)
            {
                if (_dizi[i].Equals(arananEleman))
                    return i;
            }
            return -1;
        }

        public int LastIndexOf(object arananEleman)
        {
            if (arananEleman == null)
                return -1;
            for (int i = _dizi.Length - 1; i >= 0; i--)
            {
                if (_dizi[i].Equals(arananEleman))
                    return i;
            }
            return -1;
        }

        public void RemoveAll(Predicate<T> predicate)
        {
            for (int i = 0; i < _dizi.Length; i++)
            {
                bool sartSaglandimi = predicate.Invoke(_dizi[i]);
                if (sartSaglandimi)
                    Sil(i);
            }
        }

        private class HalkBankListEnumerator : IEnumerator<T>
        {

            private T[] _dizi;
            int currentIndex = -1;
            public HalkBankListEnumerator(T[] dizi) => this._dizi = dizi;

            T IEnumerator<T>.Current => _dizi[currentIndex];

            object IEnumerator.Current => _dizi[currentIndex];
                        
            void IDisposable.Dispose()
            {
                //Console.WriteLine("İterasyon sonlandı.");
            }

            bool IEnumerator.MoveNext()
            {
                return ++currentIndex < _dizi.Length;
            }

            void IEnumerator.Reset()
            {
                currentIndex = 0;
            }
        }
    }
}
