using System;
using System.Collections.Generic;
using System.Data;

namespace parcial_2.SourceCode
{
    public static class UserDao
    {
        public static List<Usuario> getLista()
        {
            string sql = "select * from APPUSER";

            DataTable dt = ConnectionBD.ExecuteQuery(sql);

            List<Usuario> lista = new List<Usuario>();
            foreach (DataRow fila in dt.Rows)
            {
                Usuario u = new Usuario();
                u.fullname = fila[1].ToString();
                u.username = fila[2].ToString();
                u.password = Convert.ToString(fila[3].ToString());
                u.userType = Convert.ToBoolean(fila[4].ToString());

                lista.Add(u);
            }
            return lista;
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