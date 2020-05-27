using System;

namespace parcial_2.SourceCode
{
    public class Product
    {
        public int idproduct { get; set; }
        public int idbusiness { get; set; }
        public string name { get; set; }
        
        
        public Product() {}

        public Product(int Pidproduct , int Pidbusiness, string Pname)
        {
            idproduct = Pidproduct;
            idbusiness = Pidbusiness;
            name = Pname;
        }
    }
}