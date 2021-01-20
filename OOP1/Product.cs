using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //Snippet , prop otomatik olarak ekleme
    class Product
    {
        public int Id { get; set; }

        //Hangi kategoriye dahil
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }

        //StoktakiAdedi
        public int UnitInStock { get; set; }
    }
}
