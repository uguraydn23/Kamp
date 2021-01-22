using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // T yazmamızın sebebi generic yapıyoruz . New ile ne istersen onu yaparsın
    // string yada int kullanabilirsin  bu şekilde
    class MyList<T>
    {
        T[] items;
        //ctor shortcut
     
        
        //constructor
        // class i new lersen otomatik çalışıyor
        public MyList()
        {
            items = new T[0];
        }


        public void Add(T item)
        {

            T[] tempArray = new items;

            // Elimizde 0 değerinde list var.
            // Listeni 1 arttır diyoruz
            // Mevcuttakini 1 arttırıyor
            items = new T[items.Length+1];


            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
        }
    }
}
