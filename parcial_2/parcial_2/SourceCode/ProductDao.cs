using System;
using System.Collections.Generic;
using System.Data;

namespace parcial_2.SourceCode
{
    public class ProductDao
    {
        public static List<Product> getLista()
        {
            string sql = "select * from PRODUCT ";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Product> listaa = new List<Product>();
            foreach (DataRow fila in dt.Rows)
            {
                Product b = new Product();
                b.name = fila[2].ToString();
                
               

                listaa.Add(b);
            }
            return listaa;
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