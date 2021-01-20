using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet- kutunun altında olan noktacıklı şekil
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }


        //CRUID operasyonları classların görevlerinden biridir
    }
}
