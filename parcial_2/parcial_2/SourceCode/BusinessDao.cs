using System;
using System.Collections.Generic;
using System.Data;

namespace parcial_2.SourceCode
{
    public class BusinessDao
    {
        public static List<Business> getLista()
        {
            string sql = "select * from BUSINESS";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Business> listab = new List<Business>();
            foreach (DataRow fila in dt.Rows)
            {
                Business b = new Business();
                
                b.name = fila[1].ToString();
               

                listab.Add(b);
            }
            return listab;
        }

        public static void actualizarContra(string usuario, string nuevaContra)
        {
            string sql = String.Format(
                "update APPUSER set password='{0}' where username='{1}';",
                nuevaContra, usuario);
            
            ConnectionBD.ExecuteNonQuery(sql);
        }
    }
}