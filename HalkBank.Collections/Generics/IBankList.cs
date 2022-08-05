using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkBank.Collections
{
    public interface IBankList<T>
    {
        void Ekle(T eleman);

        void Sil(int index);

        void Temizle();

        int ElemanSayisi { get; }

        T this[int index]
        {
            get;
            set;
        }
    }
}
