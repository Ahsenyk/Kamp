using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel Müşteri
    class JuridicalCustomer:Customer   //miras olayıdır-Inheritance
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
