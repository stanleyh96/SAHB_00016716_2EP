namespace parcial_2.SourceCode
{
    public class Business
    {
        public int idbusiness { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        
        public Business(){}
        
        public Business(int Bidbusiness , string Bname, string Pname)
        {
            idbusiness = Bidbusiness;
            name = Bname;
            name = Pname;
        }
    }
   
}