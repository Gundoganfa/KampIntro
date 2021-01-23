using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Generic tip, class hangi tipte çalıştırılırsa o tipte çalışır.
    {
        T[] items;
        //constructor
        public MyList() // Class new dediğin anda burası çalışır
        { 
            items = new T[0]; //array oluştu ve sıfır elemanlı olarak hayata gözlerini açtı
        }
        public void Add(T item)
        {
            T[] tempArray = items; //items dizisinin referansını tempArray içinde tutuyorum
            items = new T[items.Length + 1]; //bir fazla elemanlı list oluşturdum
            for (int i = 0; i < tempArray.Length; i++) //eski arrayin bütün elemanlarını geri alacağım
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; // arrayin son elemanı olarak, ADD'a gelen item'i ekleyebiliriz artık
        }

        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }

    }
}
