using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Escritor
{
    public static  SqlString Escribir(string nombre, string directorio, string texto)
    {
        try
        {
            string fullName = directorio + @"\" + nombre;
            using (StreamWriter sw = new StreamWriter(fullName))
            {
                sw.Write(texto);
                return new SqlString("ok");
            }
            //return new SqlString( "ok");
        }
        catch (Exception ex)
        {

            return new SqlString( ex.Message);
        }

    }
}