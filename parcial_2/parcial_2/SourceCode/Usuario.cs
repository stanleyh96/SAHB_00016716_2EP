﻿namespace parcial_2.SourceCode
{
    public class Usuario
    {
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool userType { get; set; }
        
      
        
        public Usuario()
        {
            fullname = "";
            username = "";
            password = "";
            userType = true;
        }
    }
    
}